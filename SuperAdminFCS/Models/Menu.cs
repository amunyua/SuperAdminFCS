using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperAdminFCS.Models
{
    public class Menu
    {
        public Int64 id { get; set; }
        public Int64 Parent_id { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Icon { get; set; }
        public int Sequence { get; set; }
        public string Menu_name  { get; set; }
        public Boolean Status { get; set; }
      
    }
}