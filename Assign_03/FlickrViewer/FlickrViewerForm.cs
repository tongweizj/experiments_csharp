using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Security.Policy;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace FlickrViewer
{
    public partial class FlickrViewerForm : Form
    {
        // Use your Flickr API key here--you can get one at:
        // https://www.flickr.com/services/apps/create/apply
        private const string KEY = "2-o_TWR9XME92qAeGer0c0CURJ6QRmS5R-E1IH_xL_Q";

        // object used to invoke Flickr web service      
        private static HttpClient flickrClient = new HttpClient();

        Task<string> flickrTask = null; // Task<string> that queries Flickr

        public FlickrViewerForm()
        {
            InitializeComponent();
            Debug.WriteLine($"Main ThreadID: {Thread.CurrentThread.ManagedThreadId}");
        }

        // initiate asynchronous Flickr search query; 
        // display results when query completes
        private async void searchButton_Click(object sender, EventArgs e)
        {
            // if flickrTask already running, prompt user 
            if (flickrTask?.Status != TaskStatus.RanToCompletion && flickrTask != null)
            {
                var result = MessageBox.Show(
                   "Cancel the current Flickr search?",
                   "Are you sure?", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

                // determine whether user wants to cancel prior search
                if (result == DialogResult.No)
                {
                    return;
                }
                else
                {
                    flickrClient.CancelPendingRequests(); // cancel search
                }
            }
            
            imagesListBox.DataSource = null; // remove prior data source
            imagesListBox.Items.Clear(); // clear imagesListBox
            pictureBox.Image = null; // clear pictureBox
            imagesListBox.Items.Add("Loading..."); // display Loading...

            // new code, add SearchUnsplashImagesAsync()
            var flickrPhotos = await SearchUnsplashImagesAsync(inputTextBox.Text.Replace(" ", ","));
           
            imagesListBox.Items.Clear(); // clear imagesListBox

            // set ListBox properties only if results were found
            if (flickrPhotos.Any())
            {
                imagesListBox.DataSource = flickrPhotos.ToList();
                imagesListBox.DisplayMember = "Title";
            }
            else // no matches were found
            {
                imagesListBox.Items.Add("No matches");
            }
        }
        public static async Task<FlickrResult[]> SearchUnsplashImagesAsync(string query, int count = 25)
        {
            using HttpClient client = new HttpClient();
            string UNSPLASH_SEARCH_URL = "https://api.unsplash.com/search/photos";
            string API_KEY = "2-o_TWR9XME92qAeGer0c0CURJ6QRmS5R-E1IH_xL_Q";

            string url = $"{UNSPLASH_SEARCH_URL}?query={query}&per_page={count}&client_id={API_KEY}";

            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();
            JObject data = JObject.Parse(json);
            //select 

            FlickrResult[] imageUrls = data["results"]
                .Select(img => new FlickrResult
                {
                    Title = img["slug"].ToString(),
                    URL = img["urls"]["regular"].ToString()
                } )
                .ToArray();

            return imageUrls;
        }
        private void DownloadAndDisplayImage(string url)
        {
            Debug.WriteLine($"DownloadAndDisplayImage ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            using HttpClient client = new HttpClient();
            byte[] imageData = client.GetByteArrayAsync(url).Result;

            using MemoryStream ms = new MemoryStream(imageData);
            Image image = Image.FromStream(ms);

            if (pictureBox.InvokeRequired)
            {
                pictureBox.Invoke(new Action(() => pictureBox.Image = image));
            }
            else
            {
                pictureBox.Image = image;
            }   
        }
        public void GenerateThumbnail (byte[] imageBytes,string thumbnailfileName) {
            Debug.WriteLine($"GenerateThumbnail ThreadId: {Thread.CurrentThread.ManagedThreadId}");

            int imageHeight = 100;
            int imageWidth = 100;

            Image futtSizeImg = Image.FromStream(new MemoryStream(imageBytes)) ;
            Image.GetThumbnailImageAbort dummyCallBack = new Image.GetThumbnailImageAbort(ThumbnailCallback) ;
            Image thumbNailImage = futtSizeImg.GetThumbnailImage(imageWidth, imageHeight, dummyCallBack, IntPtr.Zero);
            thumbNailImage.Save(thumbnailfileName, ImageFormat.Jpeg) ;
            thumbNailImage.Dispose() ;
            futtSizeImg.Dispose() ;
        }
        public bool ThumbnailCallback()
        {
            return false;
        }

        // display selected image
        private async void imagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imagesListBox.SelectedItem != null)
            {
                FlickrResult image = ((FlickrResult)imagesListBox.SelectedItem);
                string selectedURL = image.URL;

                // use HttpClient to get selected image's bytes asynchronously
                byte[] imageBytes = await flickrClient.GetByteArrayAsync(selectedURL);
                Parallel.Invoke(
                    () => DownloadAndDisplayImage(selectedURL),
                    () => GenerateThumbnail(imageBytes, image.Title+ ".jpeg")
                );
                
                // display downloaded image in pictureBox                  
                //using (var memoryStream = new MemoryStream(imageBytes))
                //{
                //    pictureBox.Image = Image.FromStream(memoryStream);
                //}
            }
        }
    }
}
