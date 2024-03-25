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
    public class ToDoListManager : IToDoListService
    {
        private IToDoListDal _dal;
        public ToDoListManager(IToDoListDal _dal)
        {
            this._dal = _dal;
        }
        public void TAdd(ToDoList t)
        {
            _dal.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            _dal.Delete(t);
        }

        public void TUpdate(ToDoList t)
        {
            _dal.Update(t);
        }

        public List<ToDoList> TGetList()
        {
            return _dal.GetList();
        }

        public ToDoList TGetByID(int id)
        {
            return _dal.GetByID(id);
        }
    }
}
