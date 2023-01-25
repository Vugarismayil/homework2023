using System;
using System.Collections.Generic;
using System.Text;

namespace applicationtest
{
    internal class Notebook
    {
        public string Brand;
        public string Model;
        public double Price;

        public Notebook(string brand, string model, double price = 0)
        {
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
        }



        public string GetNotebookInfo()
        {
            return $"Brand: {Brand} Model: {Model} Price: {Price}";
        }
    }
}
