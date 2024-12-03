
namespace MishnatYosef.Services
{
    public class DistributionStationService
    {
        public List<Entities.DistibutionStation> GetService()
        {
            return Data.DataContextManager.Lists._StationsList;
        }
        public Entities.DistibutionStation GetByIdService(int id)
        {
            Entities.DistibutionStation station;
            station = Data.DataContextManager.Lists._StationsList.Find(x => x.Station == id);
            return station;
        }
        public bool AddStation(Entities.DistibutionStation station)
        {
            Data.DataContextManager.Lists._StationsList.Add(station);
            if (Data.DataContextManager.Lists._StationsList.Find(x => x.Station == station.Station) != null)
                return true;
            return false;
        }
        public bool DeleteByIdService(int id)
        {
            if (Data.DataContextManager.Lists._StationsList == null) return false;
            Entities.DistibutionStation station = Data.DataContextManager.Lists._StationsList.Find(x => x.Station == id);
            if (station == null) return false;
            Data.DataContextManager.Lists._StationsList.Remove(station);
            return true;
        }
        public bool UpdateStation(int id, Entities.DistibutionStation s)
        {
            int station = Data.DataContextManager.Lists._StationsList.FindIndex(x => x.Station == id);
            if (station == -1) return false;
            Data.DataContextManager.Lists._StationsList[station]=s;
            return true;
        }
    }
}
