using HotelChain.Models;
using HotelChain.Models.DatabaseModels;
using HotelChain.Services.Contracts;

namespace HotelChain.Services.Implementations
{
    public class RoomService : IRoomService
    {
        private readonly MobileContext _db;
        public RoomService(MobileContext db) => _db = db;
        public void Create(Room room)
        {
            _db.Rooms.Add(room);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Rooms.Remove(_db.Rooms.FirstOrDefault(r => r.Id == id));
            _db.SaveChanges();
        }

        public void Edit(Room room)
        {
            if (!_db.Rooms.Any(r => r.Id == room.Id))
            {
                return;
            }
            _db.Update(room);
            _db.SaveChanges();
        }

        public Room Get(int id)
        {
            return _db.Rooms.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Room> GetRooms()
        {
            return _db.Rooms.ToList();
        }
    }
}
