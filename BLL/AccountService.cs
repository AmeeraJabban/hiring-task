using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
 public   class AccountService
    {

        public Context db;
        public AccountService(Context _db) {
            db =_db ;
        }
            public List<Account> getAll()
            {
                return db.Account.ToList();
            }
            public Account getByID(long ID)
            {
                return db.Account.Find(ID);
            }
            public void Add(Account account)
            {
                db.Account.Add(account);
                db.SaveChanges();
            }
            public void Edit(Account account)
            {
            Account _account = new Account();
             _account = getByID(account.ID);
            _account.Account_number = account.Account_number;
            _account.Balance = account.Balance;
            _account.Currency = account.Currency;
            _account.Avalible_Balance = account.Avalible_Balance;
            _account.Status = account.Status;
            

            db.SaveChanges();

            }
            public void Delete(long ID)
            {
                Account account = db.Account.Find(ID);
                db.Account.Remove(account);
                db.SaveChanges();
            }
           
        }
    }


