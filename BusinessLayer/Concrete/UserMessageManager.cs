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
    public class UserMessageManager : IUserMessageService
    {
        IUserMessageDal _userMessageDal;
        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            this._userMessageDal = userMessageDal;
        }

        public List<UserMessage> GetList()
        {
            return _userMessageDal.GetList();
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
            return _userMessageDal.GetUserMessagesWithUsers();
        }

        public void TAdd(UserMessage entity)
        {
            _userMessageDal.Insert(entity);
        }

        public void TDelete(UserMessage entity)
        {
            _userMessageDal.Delete(entity);
        }

        public UserMessage TGetByID(int id)
        {
            return _userMessageDal.GetByID(id);
        }

        public void TUpdate(UserMessage entity)
        {
            _userMessageDal.Update(entity);
        }
    }
}
