using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{//encapsulation
    class Customer
    {
        //field : alan(degişken) tanımlamak
       // public string FirstName;
        
        //Property:özellik tanımlamak
        public int Id { get; set; }
        public string FirstName { get; set; }
        /*   //encapsulation
        private string _firstName;
        public string FirstName 
        {
            get { return "Mrs." + _firstName; }
            set { _firstName = value; }
        }
        */
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
