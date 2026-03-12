using System;

namespace Hands_on
{
    class ProductApp
    {

        private int _productId;
        private string _productName;
        private double _unitPrice;
        private int _quantity;

        public ProductApp(int productId)
        {
            this._productId = productId;
        }


        public int ProductId
        {
            get { return _productId; }
        }


        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }


        public double UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }


        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }


        public void ShowDetails()
        {
            double total = _unitPrice * _quantity;

            Console.WriteLine("Product Id: " + _productId);
            Console.WriteLine("Product Name: " + _productName);
            Console.WriteLine("Unit Price: " + _unitPrice);
            Console.WriteLine("Quantity: " + _quantity);
            Console.WriteLine("Total Amount: " + total);
        }
    }

    internal class Product
    {
        static void Main(string[] args)
        {
            ProductApp p = new ProductApp(101);

            p.ProductName = "Laptop";
            p.UnitPrice = 50000;
            p.Quantity = 2;

            p.ShowDetails();
        }
    }
}

   

