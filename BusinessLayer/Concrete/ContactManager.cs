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
    public class ContactManager : IContactService
    {
        private IContactDal dal;

        public ContactManager(IContactDal dal)
        {
            this.dal = dal;
        }
        public void TAdd(Contact t)
        {
            dal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            dal.Delete(t);
        }

        public void TUpdate(Contact t)
        {
            dal.Update(t);
        }

        public List<Contact> TGetList()
        {
            return dal.GetList();
        }

        public Contact TGetByID(int id)
        {
            return dal.GetByID(id);
        }
    }
}
