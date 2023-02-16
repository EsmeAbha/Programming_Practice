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
        public string getMonth()
        {
            return this.month;  
        }
        private string setMonth(string month)
        {
            return this.month;
        }
        private int setDay(int day)
        {
            return this.day;
        }
        public int getDay()
        {
            return this.day;
        }
        private int setYear(int year)
        {
            return this.year;
        }

        public int getYear()
        {
            return this.year;
        }
       
    }
     class Product
    {
        private float price;
        private string name;
        private int id;
        private UserDate UserDate;

        public Product(float price, string name, int id, UserDate UserDate)
        {
            this.price = price;
            this.name = name;
            this.id = id;
            this.UserDate = UserDate;
        }
        public void setPrice(float price) 
        {
            this.price = price;
        }
        public float getPrice() 
        {
            return this.price;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }

        public void setProductManufacturingDate(UserDate UserDate)
        {
            this.UserDate= UserDate;
        }
        public UserDate getProductManufacturingDate()
        {
            return this.UserDate;
        }
        


        public void ShowProductDetails()
        {
            Console.WriteLine("Product Price: {0}", this.getPrice());
            Console.WriteLine("Product Name : {0}", this.getName());
            Console.WriteLine("Product ID : {0}", this.getId());
            Console.WriteLine("Manufacturing Date :{0}/{1}/{2}",this.getProductManufacturingDate().getDay(), this.getProductManufacturingDate().getMonth(), this.getProductManufacturingDate().getYear());
                }
        static void Main(string[] args)
        {
            Product p1 = new Product(1000,"Phone Case",21,new UserDate("FEB", 14, 2023));
            //Product p2 = new Product();
            p1.ShowProductDetails();    

        }
    }
}
