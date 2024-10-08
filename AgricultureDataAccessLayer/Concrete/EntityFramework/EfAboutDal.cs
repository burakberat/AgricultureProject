using AgricultureDataAccessLayer.Abstract;
using AgricultureDataAccessLayer.Concrete.Repository;
using AgricultureEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureDataAccessLayer.Concrete.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}
