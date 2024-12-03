
using MishnatYosef.Core.Entities;
using MishnatYosef.Core.Repositories;
using MishnatYosef.Core.Services;

namespace MishnatYosef.Service.Services
{
    public class SellService:ISellService
    {
        readonly ISellRepository _sellRepository;
        public SellService(ISellRepository sellRepository)
        {
            _sellRepository = sellRepository;
        }
        public List<Sell> GetService()
        {
            return _sellRepository.GetAllSells();
        }
        public Sell GetByIdService(int id)
        {
            return _sellRepository.GetSellById(id);
        }
        public bool AddSell(Sell sell)
        {
           return _sellRepository.AddSellToList(sell); 
        }
        public bool DeleteByIdService(int id)
        {
            return _sellRepository.RemoveSellById(id);
        }
        public bool UpdateCustomer(int id, Sell s)
        {
            return _sellRepository.UpdateSell(s,id);
        }
    }
}
