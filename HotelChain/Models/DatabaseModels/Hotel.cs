using System.ComponentModel.DataAnnotations.Schema;

namespace HotelChain.Models.DatabaseModels
{
    [Table("Hotels")]
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<Room>? Rooms { get; set; }
    }
}
