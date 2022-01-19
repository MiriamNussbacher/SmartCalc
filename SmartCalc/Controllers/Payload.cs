using System.ComponentModel.DataAnnotations;

namespace SmartCalc.Controllers
{
    public class Payload
    {
        [Required]
        public string Operator { get; set; }
        [Required]
        public int Left { get; set; }
        [Required]
        public int Right { get; set; }


    }
}