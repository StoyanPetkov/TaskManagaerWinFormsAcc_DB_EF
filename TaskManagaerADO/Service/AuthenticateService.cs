using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMLib.Entities;
using TMLib.Repository;

namespace TaskManager.Service
{
    public static class AuthenticateService
    {
        public static User LoggedUser { get; set; }

        public static User AuthenticateUser(string username, string password)
        {
            UserRepository userRepo = new UserRepository();
            AuthenticateService.LoggedUser = userRepo.getByUserNameAndPassword(username, password);
            return LoggedUser;
        }
    }
}
