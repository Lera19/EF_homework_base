using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            ListAnimal = new List<AnimalViewModel>();
        }

        public int Id { get; set; }
        public int NumberHome { get; set; }
        public List<AnimalViewModel> ListAnimal { get; set; }
    }
}
