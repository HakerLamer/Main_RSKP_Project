using DataConnect.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisend.Domain.DataSQL;
using Wisend.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataConnect.Repositories
{
    public class WSARepository : IWSARepository
    {
        private readonly Database _db;

        public WSARepository(Database db) 
        { 
            _db= db;
        }
        public bool Create(AccountWS entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(AccountWS entity)
        {
            throw new NotImplementedException();
        }

        public AccountWS Get(int id)
        {
            throw new NotImplementedException();
        }

        public AccountWS GetAccountById(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public Task<List<AccountWS>> Select()
        {
            return _db.AllAcc.ToListAsync();
        }

        IEnumerable<AccountWS> IBaseRepository<AccountWS>.Select()
        {
            throw new NotImplementedException();
        }
    }
}
