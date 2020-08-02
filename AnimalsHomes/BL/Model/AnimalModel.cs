using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Model
{
    public class AnimalModel
    {
        public AnimalModel() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public HomeModel Homes { get; set; }
    }
}
