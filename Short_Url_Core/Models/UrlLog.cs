using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Short_Url_Core.Models
{
    public class UrlLog
    {
        public int ID { get; set; }
        public int LongUrlID { get; set; }
        public string BrowserIP { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
