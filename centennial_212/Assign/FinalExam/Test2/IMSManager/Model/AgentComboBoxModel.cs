
namespace IMSManager.Model
{
    public class AgentComboBoxModel
    {
        public string Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public AgentComboBoxModel(string id, string fname, string lname)
        {

            Id = id;
            Fname = fname;
            Lname = lname;
            
        }
    }
}
