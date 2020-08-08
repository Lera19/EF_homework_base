using System.Collections.Generic;

namespace DAL.Model
{
    public class Home
    {
        public Home()
        {
            ListAnimal = new List<Animal>();
        }
        public int Id { get; set; }
        public int NumberHome { get; set; }
        public List<Animal> ListAnimal { get; set; }
    }
}
