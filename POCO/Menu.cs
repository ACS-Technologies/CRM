using System;
using System.Collections.Generic;

namespace POCO
{
    public class Menu
    {
        public int MenuId { get; set; }
        public Int64 ParentId { get; set; }
        public string PrimaryName { get; set; }
        public string SecondarName { get; set; }
        public string Icon { get; set; }
        public string ControllerName { get; set; }
        public string MethodName { get; set; }
        public string Parameter { get; set; }
        public int Seq { get; set; }

        public int UserId { get; set; }
        public List<Menu> MenuList { get; set; }
    }
}
