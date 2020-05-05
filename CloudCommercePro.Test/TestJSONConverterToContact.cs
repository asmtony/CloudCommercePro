using CloudCommercePro.Test.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CloudCommercePro.Test
{
    [TestClass]
    public class TestJSONConverterToContact
    {
        [TestMethod]
        public void JSONContact_ConvertToContactObject_TestName()
        {
            // Arrange
            string jsonContact = JsonData.JsonDataContacts();

            // Act
            var contact = CloudCommercePro.Data.JSONData.Contacts.FromJson(jsonContact);

            // Assert
            Assert.AreEqual("Dave", contact.Name);       
        }

        [TestMethod]
        public void JSONContact_ConvertToContactObject_TestAddressLineOne()
        {
            // Arrange
            string jsonContact = JsonData.JsonDataContacts();

            // Act
            var contact = CloudCommercePro.Data.JSONData.Contacts.FromJson(jsonContact);

            // Assert
            Assert.AreEqual("Street", contact.Address.Line1);
        }
    }    
}
