using System.ComponentModel.DataAnnotations;

namespace PraticandoASPCORE.Models
{
    public class User
    {
        [Key]
        public string Ip { get; set; }
        public string Name { get; set; }    
        public string Password { get; set; }
    }
}
