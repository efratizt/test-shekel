using ENV;
using ENV.Data;
using Firefly.Box;
using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Northwind.TestProduct
{
    public class Test : UIControllerBase
    {
        public readonly Models.Products products = new Models.Products();
        public Test()
        {
            From = products;
            Where.Add(products.ProductName.StartsWith("C"));
        }

        public void Run()
        {
            Execute();
        }

        protected override void OnLoad()
        {
            View = () => new Views.TestView(this);
        }
    }
}