using Short_Url_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Short_Url_Core.Repository.IRepository
{
    public interface ILongUrlRepository
    {
        void Update(LongUrl longUrl);
    }
}
