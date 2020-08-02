using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
