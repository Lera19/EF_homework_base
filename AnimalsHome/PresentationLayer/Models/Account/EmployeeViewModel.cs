using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Models
{
    public class Employee 
    {

        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}
