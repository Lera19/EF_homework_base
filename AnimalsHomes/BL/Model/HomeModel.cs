using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Model
{
    public class HomeModel
    {
        public HomeModel()
        {
            ListAnimal = new List<AnimalModel>();
        }
        public int Id { get; set; }
        public int NumberHome { get; set; }
        public List<AnimalModel> ListAnimal { get; set; }
    }
}
