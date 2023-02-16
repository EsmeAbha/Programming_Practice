using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{

    struct UserDate
    {
        private string month;
        private int day;
        private int year;

        public UserDate(string month, int day, int year)
        {
            this.month = month;
            this.day = day;
            this.year = year;
        }
        
        public string Month
        {
            get { return this.month; }
            set { this.month = value; }
        }
        public int Day
        {
            get { return this.day; }
            set { this.day = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }

        }
    }
    class Vehicle
    {
        private float price;
        private string color;
        private UserDate regDate;

        public Vehicle(float price, string color, UserDate regDate)
        {
            this.Price = price;
            this.Color = color;
            this.RegDate = regDate;
        }
        public Vehicle()
        {
            
        }

        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public UserDate RegDate
        {
            get { return this.regDate; }
            set {this.regDate = value; }
        }



        public void ShowVehicleDetails()
        {
            Console.WriteLine("Vehicle Price: {0}", this.Price);
            Console.WriteLine("Vehicle Color : {0}", this.Color);
            Console.WriteLine("Registration Date :{0}/{1}/{2}", this.RegDate.Day, this.RegDate.Month, this.RegDate.Year);
        }
        static void Main(string[] args)
        {
            UserDate d1 = new UserDate();
            UserDate d2 = new UserDate( "feb", 12, 2023);
            Vehicle v1 = new Vehicle(250000.0f, "Red", d1);
            v1.ShowVehicleDetails();
            Vehicle v2 = new Vehicle();
            v2.Price = 13124243.2f;
            v2.RegDate = d2;
            v2.Color = "black";
            v2.ShowVehicleDetails();
        }
    }
}
