using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class DistributionStationRepository : IStationRepository
    {
        readonly DataContext _dataContext;
        public DistributionStationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<DistibutionStation> GetAllStations()
        {
            return _dataContext.DistributionStations.ToList();
        }
        public DistibutionStation GetStationById(int id)
        {
            var result = _dataContext.DistributionStations.ToList().Find(c => c.Station == id);
            return result;
        }
        public bool AddStationToList(DistibutionStation station)
        {
            _dataContext.DistributionStations.Add(station);
            return true;
        }
        public bool RemoveStationById(int id)
        {
            var result = _dataContext.DistributionStations.FirstOrDefault(c => c.Station == id);
            if (result == null)
            {
                return false;
            }
            _dataContext.DistributionStations.Remove(result);
            return true;
        }

        public bool UpdateStation(DistibutionStation station, int id)
        {
            var result = _dataContext.Customers.ToList().FindIndex(c => c.Id == id);
            if (result == -1)
            {
                return false;
            }
            List<DistibutionStation> lst = _dataContext.DistributionStations.ToList();

            if (station.Address != null) 
                lst[result].Address = station.Address;
            if (station.StationUsherPhone != null)
                lst[result].StationUsherPhone = station.StationUsherPhone;
            if (station.City != null)
                lst[result].City = station.City;
            if (station.StationManagerName != null)
                lst[result].StationManagerName = station.StationManagerName;
            if (station.StationManagerPhone != null)
                lst[result].StationManagerPhone = station.StationManagerPhone;
            if (station.StationName != null)
                lst[result].StationName = station.StationName;
            return true;
        }
    }
}
