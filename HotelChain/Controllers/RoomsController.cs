using Microsoft.AspNetCore.Mvc;
using HotelChain.Models.DatabaseModels;
using HotelChain.Services.Contracts;

namespace HotelChain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        readonly IRoomService _roomService;
        public RoomsController(IRoomService roomService) => _roomService = roomService;

        [HttpGet]
        public ActionResult<IEnumerable<Room>> GetRooms()
        {
            return Ok(_roomService.GetRooms());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_roomService.Get(id));
        }

        [HttpPost]
        public ActionResult Create(Room room)
        {
            _roomService.Create(room);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _roomService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Room room)
        {
            _roomService.Edit(room);
            return Ok();
        }
    }
}
