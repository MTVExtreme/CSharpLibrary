using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object_Creation
{
    public class Car
    {   //Stores ID of last Car
        private static int currentID;

        //Properties
        public int ID { get; set; }
        public double maxSpeed { get; set; }
        public string carName { get; set; }
        public short manufactureYear { get; set; }

        public Car()
        {
            ID = 0;
            maxSpeed = 120;
            carName = "Default Car";
            manufactureYear = 1908;
        }

        public Car(double speed, string name, short year)
        {
            this.ID = GetNextID();
            this.maxSpeed = speed;
            this.carName = name;
            this.manufactureYear = year;
        }

        static Car()
        {
            currentID = 0;
        }

        protected int GetNextID()
        {
            //added to the ID count
            return ++currentID;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", this.ID, this.carName);
        }






    }

    public class SportsCar : Car
    {
        //protected int originalItemID { get; set; }

        public string carColor { get; set; }

        public byte seatCount { get; set; }

        public double wheelSize { get; set; }

        public SportsCar() { }


        public SportsCar(double speed, string name, short year, string color, byte count, double wheels) : base(speed, name, year)
        {
            //this.ID = GetNextID();
            //Frome base
            this.maxSpeed = speed;
            this.carName = name;
            this.manufactureYear = year;

            this.carColor = color;
            this.seatCount = count;
            this.wheelSize = wheels;

        }
    }


}
