using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Models
{
    public class AnimalViewModel
    {
        public AnimalViewModel() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public HomeViewModel Home { get; set; }
    }
}
