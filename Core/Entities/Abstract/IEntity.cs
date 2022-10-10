using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Abstract
{
    public interface IEntity
    {
        public long Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }

        public long? UpdateBy { get; set; }

        public DateTime? DeleteDate { get; set; }
        public long? DeleteBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
