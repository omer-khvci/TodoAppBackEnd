using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Todo:EntityBase
    {
        public string TodoName { get; set; }
        public string TodoType { get; set; }
        public string TodoDescription { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
