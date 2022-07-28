using HotelChain.Models;
using HotelChain.Models.DatabaseModels;
using HotelChain.Services.Contracts;

namespace HotelChain.Services.Implementations
{
    public class HotelService : IHotelService
    {
        readonly MobileContext _db;
        public HotelService(MobileContext db) => _db = db;

        public void Create(Hotel hotel)
        {
            _db.Hotels.Add(hotel);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Hotels.Remove(_db.Hotels.FirstOrDefault(h => h.Id == id));
            _db.SaveChanges();
        }

        public void Edit(Hotel hotel)
        {
            if (!_db.Hotels.Any(h => h.Id == hotel.Id))
            {
                return;
            }
            _db.Update(hotel);
            _db.SaveChanges();
        }

        public Hotel Get(int id)
        {
            return _db.Hotels.FirstOrDefault(h => h.Id == id);
        }

        public IEnumerable<Hotel> GetHotels()
        {
            return _db.Hotels.ToList();
        }
    }
}
