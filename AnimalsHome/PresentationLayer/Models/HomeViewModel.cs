using BL;
using System.Collections.Generic;

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
        [MyIgnoreAttribute]
        public List<AnimalViewModel> ListAnimal { get; set; }
    }
}
