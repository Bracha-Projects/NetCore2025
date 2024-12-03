using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishnatYosef.Data.Repositories
{
    public class DistributionStationRepository:IStationRepository
    {
        readonly DataContext _dataContext;
        public DistributionStationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<DistibutionStation> GetAllStations()
        {
            return _dataContext.DistributionStations;
        }
        public DistibutionStation GetStationById(int id)
        {
            var result = _dataContext.DistributionStations.Find(c => c.Station == id);
            return result;
        }
        public bool AddStationToList(DistibutionStation station)
        {
            try
            {
                _dataContext.DistributionStations.Add(station);
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool RemoveStationById(int id)
        {
            try
            {
                var result = _dataContext.DistributionStations.FirstOrDefault(c => c.Station == id);
                if (result == null)
                {
                    return false;
                }
                _dataContext.DistributionStations.Remove(result);
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateStation(DistibutionStation station, int id)
        {
            try
            {
                var result = _dataContext.Customers.FindIndex(c => c.Id == id);
                if (result == -1)
                {
                    return false;
                }
                _dataContext.DistributionStations[result] = station;
                _dataContext.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
