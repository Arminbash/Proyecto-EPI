using Api_Services_TEAMCELL.DataConnection;
using Api_Services_TEAMCELL.Methods;
using Api_Services_TEAMCELL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Services_TEAMCELL.Services
{
    public class UserService
    {
        private readonly ApiDBContext _dbContext;
        public UserService(ApiDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<User> getUsersActive()
        {
            try
            {
                var listUser = _dbContext.User.Include(x => x.Employee).Where(x => x.Status == true).ToList();
                return listUser;
            }
            catch (Exception ex)
            {
                return new List<User>();
            }
        }

        public bool addUser(User user)
        {
            try
            {
                _dbContext.User.Add(user);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool editUser(User user)
        {
            try
            {
                var userEdit = _dbContext.User.FirstOrDefault(x => x.IdUser == user.IdUser);
                userEdit.UserName = user.UserName;
                userEdit.Password = user.Password;
                userEdit.IdEmployee = user.IdEmployee;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deleteUser(int idUser)
        {
            try
            {
                var delUser = _dbContext.User.FirstOrDefault(x => x.IdUser == idUser);
                delUser.Status = false;
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public User getUserXId(int idUser)
        {
            try
            {
                var user = _dbContext.User.Include(x => x.Employee).FirstOrDefault(x => x.IdUser == idUser);
                return user;
            }
            catch (Exception)
            {
                return new User();
            }
        }

        public bool tryLogin(string userName,string password )
        {
            try
            {
                var user = _dbContext.User.FirstOrDefault(x => x.UserName == userName);
                if (user != null)
                {
                    byte[] hashedPassword = Cryptographic.HashPasswordWithSalt(Encoding.UTF8.GetBytes(password), user.Salt);

                    if (hashedPassword.SequenceEqual(user.Password))
                        return true;
                    else
                        return false;
                }
                return false;         
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
   
    }

