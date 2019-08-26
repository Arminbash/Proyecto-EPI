using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using Model;

namespace Controller
{
    public class UserController
    {
        #region CreateUsers

        public bool CreateUsers(Users users)

           
        {
            try
            {
                using (BDPracticaEntities1 bdContext = new BDPracticaEntities1())
                {
                    Users Ousers =new Users();
                    Ousers.Username = users.Username;
                    Ousers.Password = users.Password ;
                    Ousers.IdEmployee = users.IdEmployee;
                    Ousers.Activo = true;
                    bdContext.Users.Add(Ousers);
                    bdContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
                throw;
            }
        }
        #endregion

        public bool Login(string username, string password)
        {
            try
            {
                using (BDPracticaEntities1 bdContext = new BDPracticaEntities1())
                {
                    var Ouser = (from n in bdContext.Users
                        where n.Username == username && n.Password == password && n.Activo==true
                        select n).FirstOrDefault();

                    if (Ouser != null)
                    {
                        return true;

                    }
                    return false;

                }

            }
            catch (Exception e)
            {
               
                throw;
            }
        }
        
        public  List<Users> GetUsers()
        {
            try
            {
                using (BDPracticaEntities1 dbContext = new BDPracticaEntities1())
                {


                    var result = (from n in dbContext.Users
                                  where n.Activo == true
                                  select n).ToList();
                    return result;
                }
               

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Existe(string username)
        {
            using (BDPracticaEntities1 bdContext = new BDPracticaEntities1())
            {
                var result = (from n in bdContext.Users where n.Username == username select n).Count();
                if (result == 0)
                    return false;
                else
                    return true;
            }
        }
    }
}
