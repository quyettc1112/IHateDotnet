using PZS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZS.Data.Interfaces
{
    public interface IAccountRepository
    {
        IList<Account> GetAllAccounts();   
        Account GetAccount(int id);

        void addAccount(Account account);

        void updateAccount(Account account);

        void removeAccount(Guid id);
    }
}
