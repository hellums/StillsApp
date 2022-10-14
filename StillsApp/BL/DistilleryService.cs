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

        /*public Distillery GetPhoto(int id)
        {
            var distillery = _context.Distilleries
                    .Include(distilleries => distilleries.Photos[0])
                    .SingleOrDefault(i => i.Id == id);
            //if (distillery == null) return NotFound();
            return distillery;
        }*/
        public String GetPhoto(int id)
        {
            /*var distillery = _context.Distilleries
                    .Include(distilleries => distilleries.Photos[0])
                    .SingleOrDefault(i => i.Id == id);
            //if (distillery == null) return NotFound();
            var photo = distillery.Photos.FirstOrDefault().Base64Encoding;
            return photo;*/
            var photo = _context.Photos.FirstOrDefault(i => i.Id == id);
            return photo.Base64Encoding.ToString();
        }

        public void Update(int id, Distillery model)
        {
            var distillery = _context.Distilleries.Find(id);

            // validate
            /*if (model.Username != user.Username && _context.Users.Any(x => x.Username == model.Username))
                throw new AppException("Username '" + model.Username + "' is already taken");*/

            // hash password if it was entered
            /*if (!string.IsNullOrEmpty(model.Password))
                user.PasswordHash = BCrypt.HashPassword(model.Password);*/

            // copy model to user and save
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