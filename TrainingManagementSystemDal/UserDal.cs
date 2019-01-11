using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagementSystemDal
{
  
  public  class UserDal
    {

        SwatiTmsEntities db = new SwatiTmsEntities();

        public List<User> GetUser()
        {
            return db.usp_Users_getUser().ToList();

        }

        public int CreateUser(User user)
        {

            db.usp_User_InsertUser(user.UserCode, user.UserName, user.UserEmail, user.UserPassword, user.Role, user.JoinDate, user.UserManager, user.CreatedBy);

            return 1;
        }

        public int UpdateUser( User user)
        {
            db.usp_User_UpdateUser(user.UserId, user.UserName, user.UserEmail, user.UserPassword, user.Role, user.JoinDate, user.UserManager, user.ModifiedBy,user.ModifiedOn);
            return 1;
        }
        public int DeleteUser(int UserId)
        {
            db.usp_User_DeleteUser(UserId);
            return 1;


        }



    }
}
