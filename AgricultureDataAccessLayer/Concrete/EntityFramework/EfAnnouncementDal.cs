using AgricultureDataAccessLayer.Abstract;
using AgricultureDataAccessLayer.Concrete.Repository;
using AgricultureDataAccessLayer.Contexts;
using AgricultureEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureDataAccessLayer.Concrete.EntityFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public void AktifYap(int id)
        {
            using (var context = new AgricultureContext())
            {
                var entity = context.Announcements.Find(id);
                if (entity != null)
                {
                    entity.Status = true;
                    context.SaveChanges();
                }
            }
        }

        public void PasifYap(int id)
        {
            using (var context = new AgricultureContext())
            {
                var entity = context.Announcements.Find(id);
                if (entity != null)
                {
                    entity.Status = false;
                    context.SaveChanges();
                }
            }
        }
    }
}
