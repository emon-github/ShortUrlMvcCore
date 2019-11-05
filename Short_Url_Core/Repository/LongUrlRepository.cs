using Short_Url_Core.Models;
using Short_Url_Core.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Short_Url_Core.Repository
{
    public class LongUrlRepository : Repository<LongUrl>, ILongUrlRepository
    {
        private readonly ApplicationDbContext _db;

        public LongUrlRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(LongUrl longUrl)
        {
            var objFromDb = _db.LongUrls.FirstOrDefault(s => s.ID == longUrl.ID);

            objFromDb.LURL = longUrl.LURL;
            objFromDb.SURL = longUrl.SURL;
            objFromDb.CreatorIP = longUrl.CreatorIP;            
            objFromDb.CreatedOn = longUrl.CreatedOn;
            objFromDb.CreatedBy = longUrl.CreatedBy;
            _db.SaveChanges();
        }
    }
}
