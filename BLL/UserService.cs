using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Service
    {
        public class UserService
        {
        public Context db;
        public UserService(Context _db)
        {
            db = _db;
        }
        public List<User> getAll()
            {
                return db.User.ToList();
            }
            public User getByID(long ID)
            {
                return db.User.Find(ID);
            }
            public void Add(User User)
            {
                db.User.Add(User);
                db.SaveChanges();
            }
            public void Edit(User User)
            {
                 User _User = new User();
                 _User = getByID(User.ID);
                _User.First_Name = User.First_Name;
               _User.Last_Name = User.Last_Name;
               _User.Status = User.Status;
               _User.Update_DateTime_UTC =DateTime.Now;
            if (User.imagepath != string.Empty) {
                _User.imagepath = User.imagepath;

            }
            db.SaveChanges();
            }
            public void Delete(long ID)
            {
                User User = db.User.Find(ID);
                db.User.Remove(User);
                db.SaveChanges();
            }

        }
    }