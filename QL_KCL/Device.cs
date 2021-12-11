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
        public string name { get => _name; set => _name = value; }
        public decimal quantity { get => _quantity; set => _quantity = value; }
        public string staff { get => _staff; set => _staff = value; }
        public string kcl { get => _kcl; set => _kcl = value; }
        public string date { get => _date; set => _date = value; }
    }
}
