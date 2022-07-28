using System.ComponentModel.DataAnnotations.Schema;

namespace HotelChain.Models.DatabaseModels
{
   
        [Table("Rooms")]
        public class Room
        {
            public int Id { get; set; }
            public string Number { get; set; } = string.Empty;
            public ushort Price { get; set; }
            public bool Accessed { get; set; }
            public int HotelId { get; set; }
            public Hotel? Hotel { get; set; }

        
    }
}
