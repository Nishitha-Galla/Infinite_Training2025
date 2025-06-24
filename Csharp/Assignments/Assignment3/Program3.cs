using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.Create a class called Saledetails which has data members like Salesno, Productno, Price, dateofsale, Qty, TotalAmount
//- Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as  Qty *Price
//- Pass the other information like SalesNo, Productno, Price, Qty and Dateof sale through constructor
//- call the show data method to display the values without an object.

namespace Assignment3
{
    class Program3
    {
        static int Sales_no;
        static int Product_no;
        static double Price;
        static int Qty;
        static string DateOfSale;
        static double TotalAmount;

        public static void Details(int sales_no, int product_no, double price, int qty, string dateOfSale)
        {
            Sales_no = sales_no;
            Product_no = product_no;
            Price = price;
            Qty = qty;
            DateOfSale = dateOfSale;
            Sales();
        }

        static void Sales()
        {
            TotalAmount = Qty * Price;
        }

        public static void ShowData()
        {
            Console.WriteLine("============SALE DETAILS==========");
            Console.WriteLine("Sales no: " + Sales_no);
            Console.WriteLine("Product no: ", + Product_no);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Date of sale: " + DateOfSale);
            Console.WriteLine("Total amount: " + TotalAmount);

        }
        static void Main()
        {
            Program3.Details(26, 22, 110.4, 2, "2021-11-04");
            Program3.ShowData();

            Console.Read();
        }
        
    }
}
