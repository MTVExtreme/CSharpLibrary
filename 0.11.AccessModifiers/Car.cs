using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11.AccessModifiers
{
    class Car
    {
        protected string Make { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }

        protected string CarDetails()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}";
        }
    }


    class Acura : Car
    {
        private int price;

        public Acura(string model, int year, int price)
        {
            this.Make = "Acura";
            this.Model = model;
            this.Year = year;
            this.price = price;
        }
        public string AcuraDetails()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nPrice: {price}";
        }
    }
}
