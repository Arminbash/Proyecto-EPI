using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using DataConnection;
namespace Controller
{
    public class UserController
    {
        private readonly UserServiceConnection _userService = new UserServiceConnection();
        public async Task<bool> tryLogin(Entities.User user)
        {try
            {
                string request = await _userService.GetHttp("trylogin/" + user.UserName + "/" + user.Password);
                if (request == "Ok")
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
