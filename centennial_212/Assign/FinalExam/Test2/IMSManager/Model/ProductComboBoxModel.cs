
namespace IMSManager.Model
{
    public class ProductComboBoxModel
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public ProductComboBoxModel(string code, string name)
        {

            Code = code;
            Name = name;

        }
    }
}
