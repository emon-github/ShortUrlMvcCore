using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Short_Url_Core.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ILongUrlRepository LongUrl { get; }

        void Save();

    }
}
