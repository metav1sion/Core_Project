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
    public class MessageManager : IMessageService
    {
        private IMessageDal dal;

        public MessageManager(IMessageDal dal)
        {
            this.dal = dal;
        }
        public void TAdd(Message t)
        {
            dal.Insert(t);
        }

        public void TDelete(Message t)
        {
            dal.Delete(t);
        }

        public void TUpdate(Message t)
        {
            dal.Update(t);
        }

        public List<Message> TGetList()
        {
            return dal.GetList();
        }

        public Message TGetByID(int id)
        {
            return dal.GetByID(id);
        }
    }
}
