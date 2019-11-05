using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Short_Url_Core.Models
{
    public class LongUrl
    {
        public int ID { get; set; }
        public string LURL { get; set; }
        public string SURL { get; set; } // prefix + LongUrl ID + Postfix
        public string CreatorIP { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
