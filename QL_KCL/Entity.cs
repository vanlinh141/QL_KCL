using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KCL
{
    abstract class Person
    {
        protected string _id;
        protected string _firstname;
        protected string _name;
        protected string _gender;
        protected string _birthday;
        protected string _address;
        protected string _cmnd;
        protected string _phone;
        protected string _kcl;
        protected string _datein;
    }

    class Device
    {
        private string _id;
        private string _name;
        private decimal _quantity;
        private string _staff;
        private string _kcl;
        private string _date;

        public Device(string ID, string name, decimal quantity, string staff, string kcl, string date) 
        {
            _id = ID;
            _name = name;
            _quantity = quantity;
            _staff = staff;
            _kcl = kcl;
            _date = date;
        }

        public string ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal Quantity { get => _quantity; set => _quantity = value; }
        public string Staff { get => _staff; set => _staff = value; }
        public string Kcl { get => _kcl; set => _kcl = value; }
        public string Date { get => _date; set => _date = value; }
    }

    class Victim : Person
    {
        private string _bed;
        private string _dateout;

        public Victim(string ID, string firstname, string name, string gender, 
                    string birthday, string address, string cmnd, string phone, 
                    string kcl, string bed, string datein, string dateout)
        {
            _id = ID;
            _firstname = firstname;
            _name = name;
            _gender = gender;
            _birthday = birthday;
            _cmnd = cmnd;
            _phone = phone;
            _address = address;
            _bed = bed;
            _kcl = kcl;
            _datein = datein;
            _dateout = dateout;
        }

        public string ID { get => _id; set => _id = value; }

        public string Firstname { get => _firstname; set => _firstname = value; }

        public string Name { get => _name; set => _name = value; }

        public string Gender { get => _gender; set => _gender = value; }

        public string Birthday { get => _birthday; set => _birthday = value; }

        public string Address { get => _address; set => _address = value; }

        public string Bed { get => _bed; set => _bed = value; }

        public string Kcl { get => _kcl; set => _kcl = value; }

        public string Phone { get => _phone; set => _phone = value; }

        public string Cmnd { get => _cmnd; set => _cmnd = value; }

        public string Datein { get => _datein; set => _datein = value; }

        public string Dateout { get => _dateout; set => _dateout = value; }
    }

    class Staff : Person
    {
        private string _role;
        private string _partial;

        public Staff(string ID, string firstname, string name, string gender, 
                    string birthday, string address, string cmnd, string phone, 
                    string kcl, string datein, string role, string partial)
        {
            _id = ID;
            _firstname = firstname;
            _name = name;
            _gender = gender;
            _birthday = birthday;
            _cmnd = cmnd;
            _phone = phone;
            _address = address;
            _kcl = kcl;
            _datein = datein;
            _role = role;
            _partial = partial;
        }
        public string ID { get => _id; set => _id = value; }

        public string Firstname { get => _firstname; set => _firstname = value; }

        public string Name { get => _name; set => _name = value; }

        public string Gender { get => _gender; set => _gender = value; }

        public string Birthday { get => _birthday; set => _birthday = value; }

        public string Address { get => _address; set => _address = value; }

        public string Kcl { get => _kcl; set => _kcl = value; }

        public string Phone { get => _phone; set => _phone = value; }

        public string Cmnd { get => _cmnd; set => _cmnd = value; }

        public string Datein { get => _datein; set => _datein = value; }

        public string Role { get => _role; set => _role = value; }

        public string Partial { get => _partial; set => _partial = value; }
    }

    class Test
    {
        private string _ID;
        private string _victimID;
        private string _staffID;
        private string _typeTest;
        private string _dateTest;
        private string _dateResult;
        private string _indexCT;
        private string _dateNextTest;
        private string _result;

        public Test(string ID, string victimID, string staffID, string typeTest, string dateTest,
            string dateResult, string indexCT, string dateNextTest, string result)
        {
            _ID = ID;
            _victimID = victimID;
            _staffID = staffID; 
            _typeTest = typeTest;
            _dateTest = dateTest;
            _dateResult = dateResult;
            _indexCT = indexCT;
            _dateNextTest = dateNextTest;
            _result = result;
        }

        public string ID { get => _ID; set => _ID = value; }
        public string VictimID { get => _victimID; set => _victimID = value; }
        public string StaffID { get => _staffID; set => _staffID = value; }
        public string TypeTest { get => _typeTest; set => _staffID = value; }
        public string DateTest { get => _dateTest; set => _dateTest = value; }
        public string DateResult { get => _dateResult; set => _dateResult = value; }
        public string IndexCT { get => _indexCT; set => _indexCT = value; } 
        public string DateNextTest { get => _dateNextTest; set => _dateNextTest = value; }
        public string Result { get => _result; set => _result = value; }
    }
}
