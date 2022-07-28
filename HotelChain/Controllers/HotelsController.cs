using Microsoft.AspNetCore.Mvc;
using HotelChain.Models.DatabaseModels;
using HotelChain.Services.Contracts;

namespace HotelChain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {

        readonly IHotelService _hotelService;
        public HotelsController(IHotelService hotelService) => _hotelService = hotelService;

        [HttpGet]
        public ActionResult<IEnumerable<Hotel>> GetHotels()
        {
            return Ok(_hotelService.GetHotels());
        }

        [HttpGet("{id}")] 
        public ActionResult Get(int id)
        {
            return Ok(_hotelService.Get(id));
        }

        [HttpPost]
        public ActionResult Create(Hotel hotel)
        {
           _hotelService.Create(hotel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _hotelService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Hotel hotel)
        {
            _hotelService.Edit(hotel);
            return Ok();
        }

    }
}
