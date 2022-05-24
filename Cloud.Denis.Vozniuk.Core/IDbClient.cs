using Cloud.Denis.Vozniuk.Core.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Denis.Vozniuk.Core
{
    public interface IDbClient
    {
        IMongoCollection<Phone> GetPhoneCollection();
        IMongoCollection<Tablet> GetTabletCollection();
        IMongoCollection<Computer> GetComputerCollection();
    }
}
