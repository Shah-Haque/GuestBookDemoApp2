using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary.Models
{
    public class GuestModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MessageToHost { get; set; }

        //Full Property which gets the Firstname, LastName and MessageToHost and returns those values
        //as one property
        public string GuestInfo
        {
            get
            {
                return $"{FirstName} {LastName}: {MessageToHost}";
            }
        }
    }
}
