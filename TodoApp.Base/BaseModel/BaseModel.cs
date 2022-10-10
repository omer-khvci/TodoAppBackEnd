using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Base.BaseModel
{
    public abstract class BaseModel
    {
        public int id { get; set; }
        public string createdAt { get; set; }
        public DateTime createdTime { get; set; }
        public bool isActive { get; set; }
    }
}
