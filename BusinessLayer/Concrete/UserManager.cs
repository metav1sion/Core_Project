using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _user;

        public UserManager(IUserDal _user)
        {
            this._user = _user;
        }
        public void TAdd(User t)
        {
            _user.Insert(t);
        }

        public void TDelete(User t)
        {
            _user.Delete(t);
        }

        public void TUpdate(User t)
        {
            _user.Update(t);
        }

        public List<User> TGetList()
        {
            return _user.GetList();
        }

        public User TGetByID(int id)
        {
            return _user.GetByID(id);
        }
    }
}
