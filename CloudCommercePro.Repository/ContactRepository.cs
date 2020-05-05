using CloudCommercePro.Interfaces;
using CloudCommercePro.Models.DataModels;
using CloudCommercePro.Models.ViewModels;
using System;
using System.Collections.Generic;

namespace CloudCommercePro.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly IContactData ContactData;

        public ContactRepository(IContactData contactData)
        {
            this.ContactData = contactData;
        }
        public List<DataContacts> Get()
        {
            List<DataContacts> dataContacts = ContactData.Get();
            return dataContacts;
        }
    }
}
