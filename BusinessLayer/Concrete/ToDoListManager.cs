using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoListDal;
        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }
        public List<ToDoList> GetList()
        {
            return _toDoListDal.GetList();
        }

        public void TAdd(ToDoList entity)
        {
            _toDoListDal.Insert(entity);
        }

        public void TDelete(ToDoList entity)
        {
            _toDoListDal.Delete(entity);
        }

        public ToDoList TGetByID(int id)
        {
           return _toDoListDal.GetByID(id);
        }

        public void TUpdate(ToDoList entity)
        {
            _toDoListDal.Update(entity);
        }
    }
}
