using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4.Models
{
    public class UserInfo
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Tel { get; set; }
        public DateTime LastLoginTime { get; set; }
    }
}