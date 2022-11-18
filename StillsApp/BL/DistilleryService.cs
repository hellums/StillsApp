using Microsoft.EntityFrameworkCore;
using StillsApp.DL;

namespace StillsApp.BL
{
    public interface IDistilleryService
    {
        public IEnumerable<Distillery> GetAll();
        public Distillery GetById(int id);
        public String GetPhoto(int id);
        public void Update(int id, Distillery model);
        public void Delete(int id);
    }
    public class DistilleryService : IDistilleryService
    {
        private DataContext _context;
        public DistilleryService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Distillery> GetAll()
        {
            return _context.Distilleries;
        }

        public Distillery GetById(int id)
        {
            var distillery = _context.Distilleries
                    .Include(distilleries => distilleries.Addresses)
                    .Include(distilleries => distilleries.Experiences)
                    .Include(distilleries => distilleries.Photos)
                    .Include(distilleries => distilleries.Reviews)
                    .Include(distilleries => distilleries.Brands)
                    .SingleOrDefault(i => i.Id == id);
            //if (distillery == null) return NotFound();
            return distillery;
        }

        public String GetAddress(int id)
        {
            var address = _context.Distilleries.FirstOrDefault(i => i.Id == id);
            return address.Addresses.FirstOrDefault().ToString();
        }
        public String GetPhoto(int id)
        {
            var photo = _context.Photos.FirstOrDefault(i => i.Id == id);
            return photo.Base64Encoding.ToString();
        }

        public void Update(int id, Distillery model)
        {
            var distillery = _context.Distilleries.Find(id);
            _context.Distilleries.Update(distillery);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var distillery = _context.Distilleries.Find(id);
            _context.Distilleries.Remove(distillery);
            _context.SaveChanges();
        }
    }

}