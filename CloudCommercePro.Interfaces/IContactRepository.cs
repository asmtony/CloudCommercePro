using CloudCommercePro.Models.DataModels;
using System.Collections.Generic;

namespace CloudCommercePro.Interfaces
{
    public interface IContactRepository
    {
        List<DataContacts> Get(); 
    }
}
