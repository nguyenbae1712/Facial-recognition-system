using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlySieuthi.DTO
{
    class CreateDB : CreateDatabaseIfNotExists<Model1>
    {
        protected override void Seed(Model1 context)
        {   
            //base.Seed(context);
            Category cat1 = new Category() { CatName = "My pham" };
            Category cat2 = new Category() { CatName = "Thoi trang" };
            Category cat3 = new Category() { CatName = "Dien tu" };
            Category cat4 = new Category() { CatName = "Thuc an" };
            context.Categories.Add(cat1);
            context.Categories.Add(cat2);
            context.Categories.Add(cat3);
            context.Categories.Add(cat4);
            context.SaveChanges();
            base.Seed(context);
            Product prod1 = new Product() { ProdID = 01,CatId = cat1.CatId, ProdName = "Son", NSX = "Maybelline", DateIn = new DateTime(2020, 02, 03), State = true };
            Product prod2 = new Product() { ProdID = 02, CatId = cat1.CatId, ProdName = "Chi ke may", NSX = "The Face Shop", DateIn = new DateTime(2020, 05, 10), State = true };
            Product prod3 = new Product() { ProdID = 03, CatId = cat1.CatId, ProdName = "Kem nen", NSX = "Innisfree", DateIn = new DateTime(2020, 11, 13), State = true };
            Product prod4 = new Product() { ProdID = 04, CatId = cat1.CatId, ProdName = "Phan ma hong", NSX = "Nars", DateIn = new DateTime(2020, 02, 23), State = false };
            Product prod5 = new Product() { ProdID = 05, CatId = cat2.CatId, ProdName = "Ao so mi", NSX = "H & M", DateIn = new DateTime(2020, 07, 03), State = true };
            Product prod6 = new Product() { ProdID = 06, CatId = cat2.CatId, ProdName = "Giay", NSX = "Adidas", DateIn = new DateTime(2020, 08, 11), State = true };
            Product prod7 = new Product() { ProdID = 07, CatId = cat2.CatId, ProdName = "Ao T-Shirt", NSX = "Zara", DateIn = new DateTime(2020, 06, 22), State = false };
            Product prod8 = new Product() { ProdID = 08, CatId = cat2.CatId, ProdName = "Quan tay", NSX = "LV", DateIn = new DateTime(2020, 12, 28), State = true };
            Product prod9 = new Product() { ProdID = 09, CatId = cat3.CatId, ProdName = "TV", NSX = "Sony", DateIn = new DateTime(2020, 10,30), State = true };
            Product prod10 = new Product() { ProdID = 10, CatId = cat3.CatId, ProdName = "Laptop", NSX = "Asus", DateIn = new DateTime(2020, 06, 08), State = false };
            Product prod11 = new Product() { ProdID = 11, CatId = cat3.CatId, ProdName = "May giat", NSX = "LG", DateIn = new DateTime(2020, 02, 05), State = true };
            Product prod12 = new Product() { ProdID = 12, CatId = cat3.CatId, ProdName = "Tu lanh", NSX = "Hitachi", DateIn = new DateTime(2020,03, 01), State = true };
            Product prod13 = new Product() { ProdID = 13, CatId = cat4.CatId, ProdName = "Sua", NSX = "Vinamilk", DateIn = new DateTime(2020,07, 31), State = false };
            Product prod14 = new Product() { ProdID = 14, CatId = cat4.CatId, ProdName = "Ga ran", NSX = "Bae", DateIn = new DateTime(2020,03, 21), State = true };
            Product prod15 = new Product() { ProdID = 15, CatId = cat4.CatId, ProdName = "Pizza", NSX = "Bae", DateIn = new DateTime(2020,12, 11), State = true };
            Product prod16 = new Product() { ProdID = 16, CatId = cat4.CatId, ProdName = "Banh ngot", NSX = "Bae", DateIn = new DateTime(2020,04, 22), State = false };
            context.Products.Add(prod1);
            context.Products.Add(prod2);
            context.Products.Add(prod3);
            context.Products.Add(prod4);
            context.Products.Add(prod5);
            context.Products.Add(prod6);
            context.Products.Add(prod7);
            context.Products.Add(prod8);
            context.Products.Add(prod9);
            context.Products.Add(prod10);
            context.Products.Add(prod11);
            context.Products.Add(prod12);
            context.Products.Add(prod13);
            context.Products.Add(prod14);
            context.Products.Add(prod15);
            context.Products.Add(prod16);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
