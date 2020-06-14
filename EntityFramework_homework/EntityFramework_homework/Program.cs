using BusinessLayer;
using System;

namespace EntityFramework_homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var manager = new Manager();
            var insertAll = manager.Insert();
            var students = manager.GetInfoAboutStud();
            foreach (var s in students)
            {
                Console.WriteLine(s);
                foreach(var i in insertAll)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("------------");

            var deleteStud = manager.DeleteStudentsById(5);
            foreach (var d in deleteStud)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}