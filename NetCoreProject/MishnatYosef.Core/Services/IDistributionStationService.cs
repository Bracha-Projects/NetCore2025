using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Services
{
    public interface IDistributionStationService
    {
        public List<DistibutionStation> GetService();
        public DistibutionStation GetByIdService(int id);
        public bool AddStation(DistibutionStation station);
        public bool DeleteByIdService(int id);
        public bool UpdateStation(int id, DistibutionStation s);
    }
}
