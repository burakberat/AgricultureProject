using AgricultureEntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureBusinessLayer.Abstract
{
    public interface IAnnouncementService : IGenericService<Announcement>
    {
        void AktifYap(int id);
        void PasifYap(int id);
    }
}
