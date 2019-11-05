using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Short_Url_Core.Models
{
    public class ShortUrlSetting
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Prefix { get; set; }
        public string Postfix { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
