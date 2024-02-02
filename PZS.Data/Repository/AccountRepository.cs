using PZS.Data.Interfaces;
using PZS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZS.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public readonly IRepository<Account> _repository;

        public AccountRepository(IRepository<Account> repository)
        {
            _repository = repository;
        }  

        public void addAccount(Account account)
        {
            this._repository.Insert(account);  
        }

        public Account GetAccount(int id)
        {
            return this._repository.Get(id);    
        }

        public IList<Account> GetAllAccounts()
        {
             return this._repository.GetAll_V2();
        }

        public void removeAccount(Guid id)
        {
            var account = _repository.Get(id);
            if (account != null) { 
                _repository.Delete(account);
            }
         
        }

        public void updateAccount(Account account)
        {
            _repository.Update(account);
        }
    }
}
