using Cloud.Denis.Vozniuk.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.Denis.Vozniuk.Core.Services
{
    public interface ITabletService
    {
        List<Tablet> GetTablets();
        Tablet GetTablet(string id);
        Tablet AddTablet(Tablet book);

        void DeleteTablet(string id);
        Tablet UpdateTablet(Tablet book);
    }
}
