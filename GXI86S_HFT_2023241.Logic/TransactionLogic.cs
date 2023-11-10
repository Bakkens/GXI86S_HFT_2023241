﻿using GXI86S_HFT_2023241.Logic.InterfaceLogic;
using GXI86S_HFT_2023241.Models;
using GXI86S_HFT_2023241.Repository;
using System;
using System.Linq;

namespace GXI86S_HFT_2023241.Logic
{
    public class TransactionLogic : ITransactionLogic
    {
        IRepository<Transaction> repo;

        public TransactionLogic(IRepository<Transaction> repo)
        {
            this.repo = repo;
        }

        public void Create(Transaction item)
        {
            try
            {
                Update(item);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("The ID what you give not exist");
            }

            this.repo.Create(item);
        }

        public void Delete(int id)
        {
            this.repo.Delete(id);
        }

        public Transaction Read(int id)
        {
            var custumer = this.repo.Read(id);
            if (custumer == null)
            {
                throw new ArgumentException("Account is not exist...");
            }
            return this.repo.Read(id);
        }

        public IQueryable<Transaction> ReadAll()
        {
            return this.repo.ReadAll();
        }

        public void Update(Transaction item)
        {
            this.repo.Update(item);
        }

    }
}
