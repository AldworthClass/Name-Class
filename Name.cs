using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Class
{
    public class Name
    {
        private string _firstName;
        private string _lastName;
        private string _title;

        public Name(string firstName, string lastName, string title)
        {
            _firstName = firstName;
            _lastName = lastName;
            _title = title;
        }

        public Name(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _title = "";
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            set { _lastName = value; }
            get { return _lastName; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Initials
        {
            get
            {
                return _firstName.Substring(0, 1) + _lastName.Substring(0, 1);
            }
        }

        public override string ToString()
        {
            return (_title + " " + _firstName + " " + _lastName).Trim();
        }

    }
}
