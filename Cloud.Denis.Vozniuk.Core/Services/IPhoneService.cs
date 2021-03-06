using Cloud.Denis.Vozniuk.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Denis.Vozniuk.Core.Services
{
    public interface IPhoneServices
    {
        List<Phone> GetPhones();
        Phone GetPhone(string id);
        Phone AddPhone(Phone phone);

        void DeletePhone(string id);
        Phone UpdatePhone(Phone phone);
    }
}
