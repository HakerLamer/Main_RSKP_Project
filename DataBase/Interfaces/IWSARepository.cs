using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisend.Domain.Models;

namespace DataConnect.Interfaces
{
    public interface IWSARepository : IBaseRepository<AccountWS>
    {
        AccountWS GetAccountById(Guid accountId);
        //async public Task<List<AccountWS>> Select() 
        //{

        //    return await;
        //}
    }
}
