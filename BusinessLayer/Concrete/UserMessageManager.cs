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
    public class UserMessageManager : IUserMessageService
    {
        private IUserMessageDal _user;

        public UserMessageManager(IUserMessageDal _user)
        {
            this._user = _user;
        }
        public void TAdd(UserMessage t)
        {
            _user.Insert(t);
        }

        public void TDelete(UserMessage t)
        {
            _user.Delete(t);
        }

        public void TUpdate(UserMessage t)
        {
            _user.Update(t);
        }

        public List<UserMessage> TGetList()
        {
            return _user.GetList();
        }

        public UserMessage TGetByID(int id)
        {
            return _user.GetByID(id);
        }

        public List<UserMessage> GetUserMessagesWithUserService()
        {
            return _user.GetUserMessagesWithUser();
        }
    }
}
