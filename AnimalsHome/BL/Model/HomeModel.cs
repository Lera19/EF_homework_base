using System.Collections.Generic;

namespace BL.Model
{
    public class HomeModel
    {
        public HomeModel()
        {
            ListAnimal = new List<AnimalModel>();
        }
        [MyIgnore]
        public int Id { get; set; }
        public int NumberHome { get; set; }
        public List<AnimalModel> ListAnimal { get; set; }
    }
}