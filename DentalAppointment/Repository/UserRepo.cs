using DentalAppointment.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DentalAppointment.Repository
{
    public class UserRepo
    {
        public AppointmentSysEnt db;

        public UserRepo() 
        {
             db = new AppointmentSysEnt();       
        }

        public ErrorCode NewUser(UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.UserAccounts.Add(aUserAccount);
                db.SaveChanges();

                outMessage = "Account Created";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }



        public ErrorCode UpdateUser(int? userId, UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                // Find the user with id
                UserAccount user = db.UserAccounts.Where(m => m.UserID == userId).FirstOrDefault();

                if (user != null)
                {
                    // Update the value of the retrieved user
                    user.Username = aUserAccount.Username;
                    user.Password = aUserAccount.Password;
                    user.ContactInfo = aUserAccount.ContactInfo;
                    user.FirstName = aUserAccount.FirstName;
                    user.LastName = aUserAccount.LastName;
                    user.RoleID = aUserAccount.RoleID;

                    db.SaveChanges(); // Execute the update

                    outMessage = "Updated";
                    retValue = ErrorCode.Success;
                }
                else
                {
                    outMessage = "User not found";
                }
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }


        public ErrorCode RemoveUser(int? userId, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                UserAccount user = db.UserAccounts.Where(m => m.UserID == userId).FirstOrDefault();
                // Remove the user
                db.UserAccounts.Remove(user);
                db.SaveChanges();       // Execute the update

                outMessage = "Deleted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Error;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public UserAccount GetUserByUsername(String username)
        {
            // re-initialize db object because sometimes data in the list not updated
            db = new AppointmentSysEnt();
            // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
            return db.UserAccounts.Where(s => s.Username == username).FirstOrDefault();
        }
        public List<UserAccount> UserAccounts()
        {
            db = new AppointmentSysEnt();

            return db.UserAccounts.ToList();
        }

        /*public List<DentistAppointmentsView> AllUserRole()
        {
            db = new AppointmentSysEntities();

            return db.DentistAppointmentsViews.ToList();
        }*/
    }
}
