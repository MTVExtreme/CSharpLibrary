using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_GettersandSetters
{
    class Employees
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("The Employee name is not valid");
                _name = value; }
        }

        private int _id;

        public int ID
        {
            get { return _id; }
            set
            {
                if (ID <= 0)
                    throw new Exception("The Employee ID is not valid");
                _id = value;
            }
        }


    }
}
