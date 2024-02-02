using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZS.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IAccountRepository AccountRepository { get; }

        void Save();
    }
}
