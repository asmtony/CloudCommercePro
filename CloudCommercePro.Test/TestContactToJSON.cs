using CloudCommercePro.Data.JSONData;
using CloudCommercePro.Test.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data;

namespace CloudCommercePro.Test
{
    [TestClass]
    public class TestContactToJSON
    {
        [TestMethod]
        public void CreateContactDataTableFromJSON()
        {
            // Arrange
            string jsonContact = JsonData.JsonDataContactsShort();
            var contact = CloudCommercePro.Data.JSONData.Contacts.FromJson(jsonContact);
            List<Contacts> lstContacts = new List<Contacts>();
            lstContacts.Add(contact);
            
            // Act
            DataTable dtContacts = lstContacts.ToDataTable();

            // Assert
            Assert.AreEqual(1, dtContacts.Rows.Count);
        }

        public void ConvertDataTableToCSV_TestFileCreated()
        {
            // Arrange
            string jsonContact = JsonData.JsonDataContactsShort();
            var contact = CloudCommercePro.Data.JSONData.Contacts.FromJson(jsonContact);
            List<Contacts> lstContacts = new List<Contacts>();
            lstContacts.Add(contact);

            // Act
            DataTable dtContacts = lstContacts.ToDataTable();

            // Assert
            Assert.AreEqual(1, dtContacts.Rows.Count);
        }
        
    }    
}
