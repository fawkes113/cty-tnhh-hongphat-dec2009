using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtyHongPhat.Controller
{
    public class UserController
    {
        public static bool CheckUserPassword(string user, string password)
        {
            password = password.Trim().ToUpper();
            if (password.Length < 10)
                password = password.PadRight(10, ' ');

            password = new EncodeHVT.EncryptHVClass().MD8PWD(ref password);
            user = user.ToUpper();

            //get userinfo and check password
            /*UsersInfo ui = GetByColumnsTop1(conn,
               ColumnsName.NAME, user,
               ColumnsName.PASSWORD, password);

            if (ui != null && ui.NAME == user && ui.PASSWORD == password && ui.DELETED == 0)
                return true;*/
             
            //return false;
            return true;
        }

        public static bool ChangePassword(string user, string passwordOld, string passwordNew)
        {
            passwordOld = passwordOld.ToUpper();
            if (passwordOld.Length < 10)
                passwordOld = passwordOld.PadRight(10, ' ');
            passwordOld = new EncodeHVT.EncryptHVClass().MD8PWD(ref passwordOld);

            passwordNew = passwordNew.ToUpper();
            if (passwordNew.Length < 10)
                passwordNew = passwordNew.PadRight(10, ' ');
            passwordNew = new EncodeHVT.EncryptHVClass().MD8PWD(ref passwordNew);

            user = user.ToUpper();

            //get userinfo, check password and update password 
            /*
            UsersInfo ui = GetByColumnsTop1(conn,
               ColumnsName.NAME, user,
               ColumnsName.PASSWORD, passwordOld);

            if (ui != null && ui.NAME == user && ui.PASSWORD == passwordOld && ui.DELETED == 0)
            {
                string sqlCmd = string.Format("UPDATE USERS SET PASSWORD = '{0}' WHERE USER_ID = {1}", passwordNew, ui.USER_ID);
                SQLHelper.ExecCmdNonQuery(sqlCmd, conn);

                return true;
            }
            */

            return false;
        }
    }
}
