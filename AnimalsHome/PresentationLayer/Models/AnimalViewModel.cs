using BL;

namespace PresentationLayer.Models
{
    public class AnimalViewModel
    {
        public AnimalViewModel() { }
        public int Id { get; set; }
        public string Name { get; set; }
        [MyIgnoreAttribute]
        public HomeViewModel Home { get; set; }
    }
}
