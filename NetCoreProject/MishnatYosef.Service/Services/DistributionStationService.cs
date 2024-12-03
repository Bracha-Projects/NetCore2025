using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using MishnatYosef.Core.Services;

namespace MishnatYosef.Service.Services
{
    public class DistributionStationService:IDistributionStationService
    {
        readonly IStationRepository _stationRepository;
        public DistributionStationService(IStationRepository staion)
        {
            _stationRepository = staion;
        }
        public List<DistibutionStation> GetService()
        {
            return _stationRepository.GetAllStations();
        }
        public DistibutionStation GetByIdService(int id)
        {
            return _stationRepository.GetStationById(id);
        }
        public bool AddStation(DistibutionStation station)
        {
            return _stationRepository.AddStationToList(station);
        }
        public bool DeleteByIdService(int id)
        {
            return _stationRepository.RemoveStationById(id);
        }
        public bool UpdateStation(int id, DistibutionStation s)
        {
            return _stationRepository.UpdateStation(s, id);
        }
    }
}
