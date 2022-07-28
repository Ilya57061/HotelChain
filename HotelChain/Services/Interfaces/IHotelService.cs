using HotelChain.Models.DatabaseModels;

namespace HotelChain.Services.Contracts
{
    public interface IHotelService
    {
        IEnumerable<Hotel> GetHotels();
        Hotel Get(int id);
        void Delete(int id);
        void Create(Hotel hotel);
        void Edit(Hotel hotel);
    }
}
