namespace BL.Model
{
    public class AnimalModel
    {
        public AnimalModel() { }
        [MyIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public HomeModel Homes { get; set; }
    }
}
