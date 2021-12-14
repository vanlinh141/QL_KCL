using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KCL
{
    class Device
    {
        private string _id;
        private string _name;
        private decimal _quantity;
        private string _staff;
        private string _kcl;
        private string _date;
   
        public Device()
        {

        }

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

    class Victim
    {
        private string _id;
        private string _firstname;
        private string _name;
        private string _gender;
        private string _birthday;
        private string _address;
        private string _cmnd;
        private string _phone;
        private string _bed;
        private string _kcl;
        private string _datein;
        private string _dateout;

        public Victim()
        {

        }

        public Victim(string ID, string firstname, string name, string gender, string birthday, string address, string cmnd, string phone, string kcl, string bed, string datein, string dateout)
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
}
