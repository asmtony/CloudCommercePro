using Newtonsoft.Json;


namespace CloudCommercePro.Models.DataModels
{
   
    public partial class DataContacts
    {       
        public string Name { get; set; }
        public DataAddress Address { get; set; }
    }
}
