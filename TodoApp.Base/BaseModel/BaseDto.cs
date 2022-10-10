using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TodoApp.Base.BaseModel
{
    public abstract class BaseDto
    {
        public int id { get; set; }
        public DateTime createdAt { get; set; }
        public string createdBy { get; set; }

        public bool isActive { get; set; }
    }
}
