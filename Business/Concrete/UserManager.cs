using Business.Abstract;
using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IGenericRepository<User> _userDal;

        public UserManager(IGenericRepository<User> userDal)
        {
            _userDal = userDal;
        }

        public bool Add(UserForRegisterDto user, long userId)
        {
            return _userDal.Add(new User()
            {
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Surname = user.Surname 
            },userId);
        }

        public bool Delete(long id)
        {
            var userToDelete = _userDal.Get(p => p.Id == id);
            if(userToDelete == null)
                return false;
            return _userDal.Delete(userToDelete,id);
        }

        public User Get(long id)
        {
            return _userDal.Get(p => p.Id ==id);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll(p=> p.IsDeleted!=true);
        }

        public List<User> GetByUsername(string userName)
        {
            return _userDal.GetAll(s => s.Name.Contains(userName));
        }

        public bool Update(long id, UserForLoginDto model)
        {
            var user = _userDal.Get(p => p.Id == id);
            if(user == null)
            {
                return false;
            }
            user.Email = model.Email;
            user.Password = model.Password;

            return _userDal.Update(user,id);
        }
    }
}
