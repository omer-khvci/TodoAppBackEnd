using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User Get(long id);
        bool Add(UserForRegisterDto user, long userId);
        bool Update(long id, UserForLoginDto user);

        bool Delete(long id);

        List<User> GetByUsername(string userName);
    }
}
