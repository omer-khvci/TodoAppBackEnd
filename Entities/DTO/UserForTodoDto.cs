using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class UserForTodoDto
    {
        public string TodoName { get; set; }
        public string TodoType { get; set; }
        public string TodoDescription { get; set; }
        public ICollection<UserForCategoryDto> UserForCategories { get; set; }
    }
}
