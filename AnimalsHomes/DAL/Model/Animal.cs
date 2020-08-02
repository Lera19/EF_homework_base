using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Animal
    {
        public Animal() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public Home Homes { get; set; }
    }
}
