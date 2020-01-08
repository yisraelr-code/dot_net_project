using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GuestRequest
    {
        private int GuestRequestKey { set; get; }
        private string PrivateName { set; get; }
        private string LastName { set; get; }
        private string MailAddress { set; get; }
        private string Status { set; get; }
        private DateTime RegistrationDate;
        private DateTime ReleaseDate;
        private Area area;
        private string SubArea { set; get; }
        private Type type; 
        private int Adults { set; get; }
        private int Children { set; get; }
        private Pool pool;
        private ChildrenAtraction ChildrenAtraction;
        private Garden Garden;
        private Jacuzzi jacuzzi;
        public string ToString(GuestRequest guestRequest)
        {
            return null;
        }
        
    }
}
