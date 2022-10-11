using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category:EntityBase
    {
        public string CategoryName { get; set; }
        public string CategoryType { get; set; }
        public string CategoryDescription { get; set; }
        public ICollection<Todo> Todos { get; set; }
    }
}
