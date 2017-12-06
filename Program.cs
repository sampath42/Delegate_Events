using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Demo
{
    delegate int delegateTest(int x);
    public delegate bool IsProductEligible(Product p);
    class Program
    {
        static void Main2(string[] args)
        {
            IsProductEligible isProductEligible = ApplyDiscount;
            Product tShirt=new Product(){Name="Buffalo Brand Red T-Shirt", Amount=2000.00,Category="DiscountCategory"};
            Product formalShoes=new Product(){Name="XYZ Brand Black Formal Shoes size 8", Amount=1200.00,Category="ShoesCategory"};
            Product jeans=new Product(){Name="Buffalo Brand Blue Jeans XL", Amount=2500.00,Category="DiscountCategory"};
            List<Product> products = new List<Product>(){tShirt,jeans,formalShoes};
            //products.Select or products.Where or products.Find
            ShoppingCart.ApplyDiscount(products, isProductEligible);
        }

        static bool ApplyDiscount(Product product)
        {
            return product.Category.Equals("DiscountCategory");
        }

        static int CopyTest(int x) => 10;
        static public void Copy(string srcPath, string dstPath, IProgressIndicator progressIndicator)
        {
            int bufferSize = 100000;
            var fi = new FileInfo(srcPath);
            var srcFile = new FileStream(srcPath, FileMode.Open);
            var dstFile = new FileStream(dstPath, FileMode.CreateNew);
            byte[] buffer = new byte[bufferSize];
            int readedSize;
            int step = 0;
            progressIndicator.Progress("Start copy", 0);
            do 
            {
                readedSize = srcFile.Read(buffer, 0, bufferSize);
                dstFile.Write(buffer, 0, bufferSize);
                step++;
                progressIndicator.Progress("Progress copy", (int) fi.Length / (step * readedSize));
            } while (readedSize != 0);
            progressIndicator.Progress("Finish copy", 100);
        }
    }       
}
