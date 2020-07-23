using DAL.Models;

namespace DAL
{
    public class DiscRepository
    {
        public void SaveCalculate(DataForDiscrim data)
        {
            using (var context = new DiscContext())
            {
                context.Discriminants.Add(data);
                context.SaveChanges();
            }
        }
        }
    }
