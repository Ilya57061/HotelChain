using HotelChain.Models.DatabaseModels;

namespace HotelChain.Services.Contracts
{
    public interface IRoomService
    {
        IEnumerable<Room> GetRooms();
        Room Get(int id);
        void Delete(int id);
        void Create(Room room);
        void Edit(Room room);

    }
}
