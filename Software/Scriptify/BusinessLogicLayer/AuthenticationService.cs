﻿using DataAccessLayer.Repositories;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class AuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            using (var repo = new UserRepository())
            {
                User user = repo.GetUserByUsernameAndPasssword(username, password);
                return user != null;
            }
        }

        public bool CreateUser(User user)
        {
            bool isSuccessful = false;
            using (var repo = new UserRepository())
            {
                int affectedRow = repo.CreateNewUser(user);
                isSuccessful = affectedRow > 0;
            }
            return isSuccessful;
        }
    }
}