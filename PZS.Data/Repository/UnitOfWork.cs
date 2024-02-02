using PZS.Data.Interfaces;
using PZS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZS.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PizzaStoreContext _context;
        private readonly IAccountRepository accountRepository;

        public UnitOfWork(PizzaStoreContext context, IAccountRepository accountRepository)
        {
            _context = context;
            this.accountRepository = accountRepository;
        }

        public IAccountRepository AccountRepository {
            get { 
                return accountRepository; 
            }
        
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }

       
    
}
