using MishnatYosef.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Core.Repositories
{
    public interface IStationRepository
    {
        public List<DistibutionStation> GetAllStations();
        public DistibutionStation GetStationById(int id);
        public bool AddStationToList(DistibutionStation station);
        public bool RemoveStationById(int id);
        public bool UpdateStation(DistibutionStation station,int id);
    }
}
