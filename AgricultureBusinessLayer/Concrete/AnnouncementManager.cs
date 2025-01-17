﻿using AgricultureBusinessLayer.Abstract;
using AgricultureDataAccessLayer.Abstract;
using AgricultureEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureBusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void AktifYap(int id)
        {
            _announcementDal.AktifYap(id);
        }

        public void Delete(Announcement t)
        {
            _announcementDal.Delete(t);
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> GetListAll()
        {
            return _announcementDal.GetListAll();
        }

        public void Insert(Announcement t)
        {
            _announcementDal.Insert(t);
        }

        public void PasifYap(int id)
        {
            _announcementDal.PasifYap(id);
        }

        public void Update(Announcement t)
        {
            _announcementDal.Update(t);
        }
    }
}
