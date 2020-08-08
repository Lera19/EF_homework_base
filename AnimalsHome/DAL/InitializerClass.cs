using DAL.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    public class InitializerClass : CreateDatabaseIfNotExists<AnimalsContext>
    {
        protected override void Seed(AnimalsContext animalsContext)
        {

            var home1 = new Home() { NumberHome = 1, Id = 1 };
            var home2 = new Home() { NumberHome = 2, Id = 2 };


            var dataAnimal =
                new List<Animal>()
                {
                    new Animal() {Name = "Cat", Homes= home1, Id=1},
                    new Animal() {Name = "Dog", Homes = home1, Id=2},
                    new Animal() {Name = "Rabbit", Homes = home2, Id=3}
                };


            animalsContext.Homes.Add(home2);
            animalsContext.Homes.Add(home1);
            animalsContext.Animals.AddRange(dataAnimal);

            animalsContext.SaveChanges();

        }
    }
}
