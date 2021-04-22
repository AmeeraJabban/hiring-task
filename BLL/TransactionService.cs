using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
   public class TransactionService
    {
        public Context db;
        public TransactionService(Context _db)
        {
            db = _db;
        }
        public List<Transaction> getAll()
        {
            return db.Transaction.ToList();
        }
        public Transaction getByID(long ID)
        {
            return db.Transaction.Find(ID);
        }
        public void Add(Transaction transaction)
        {
            db.Transaction.Add(transaction);
            db.SaveChanges();
        }
        public void Edit(Transaction transaction)
        {
            Transaction _transaction = new Transaction();
             _transaction = getByID(transaction.ID);
            _transaction.Acount_ID = transaction.Acount_ID;
            _transaction.Amount = transaction.Amount;
            _transaction.Currency = transaction.Currency;
            _transaction.IS_Credit = transaction.IS_Credit;
            db.SaveChanges();
        }
        public void Delete(long ID)
        {
            Transaction transaction = db.Transaction.Find(ID);
            db.Transaction.Remove(transaction);
            db.SaveChanges();
        }

    }
}