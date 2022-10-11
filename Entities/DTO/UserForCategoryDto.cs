using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class UserForCategoryDto
    {
        public string CategoryName { get; set; }
        public string CategoryType { get; set; }
        public string CategoryDescription { get; set; }
        public ICollection<UserForTodoDto> UserForTodos { get; set; }
    }
}
