using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models
{
    public class CurrentUser
    {
        private static CurrentUser currentUser = null;
        private CurrentUser() { }
        public Users User { get; set; }

        public static CurrentUser GetCurrentUser()
        {
            if (currentUser == null)
                currentUser = new CurrentUser();
            return currentUser;
        }


    }
}
