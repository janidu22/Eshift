using Eshift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshift.services
{
    public static class SessionManager
    {
        public static Customer? CurrentCustomer { get; set; }
        public static Admin? CurrentAdmin { get; set; }


        public static bool IsLoggedIn => CurrentCustomer != null;
        public static bool IsAdminLoggedIn => CurrentAdmin != null;

        public static void Login(Customer customer,Admin admin)
        {
            CurrentCustomer = customer;
            CurrentAdmin = admin;
        }

        public static void Logout()
        {
            CurrentCustomer = null;
            CurrentAdmin = null;
        }
    }
}
