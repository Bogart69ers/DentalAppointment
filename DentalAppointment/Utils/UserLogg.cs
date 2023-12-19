using DentalAppointment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalAppointment.Utils
{
    internal class UserLogg
    {
        private static UserLogg instance;

        public UserAccount UserAccount { get; set; }

        public static UserLogg GetInstance()
        {
            if (instance == null)
                instance = new UserLogg();
            return instance;
        }
        private UserLogg()
        {

        }
    }
}
