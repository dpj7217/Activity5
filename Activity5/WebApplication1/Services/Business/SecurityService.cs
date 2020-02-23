using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity2Part3.Services.Business
{
    public class SecurityService
    {
        public bool Authenticate(Activity2Part3.Models.UserModel user)
        {
            Data.SecurityDAO DAO = new Data.SecurityDAO();

            return DAO.FindByUser(user);
        }
    }
}