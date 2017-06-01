using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Homework
{
     

    public class TestTarget
    {
        /// <summary>
        /// 取得分組加總
        /// </summary>
        /// <param name="size">每幾筆加總</param>
        /// <returns></returns>
        public List<int> Sum(int size, Field field)
        {
            List<Product> listProduct = CreateProducts().ToList();
            List<int> listSum = new List<int>();

            int startIndex = 0;
            // 分組加總
            while (startIndex < listProduct.Count)
            {
                switch (field)
                {
                    case Field.Id:
                        listSum.Add(listProduct.Skip(startIndex).Take(size).Sum(x => x.Id));
                        break;
                    case Field.Cost:
                        listSum.Add(listProduct.Skip(startIndex).Take(size).Sum(x => x.Cost));
                        break;
                    case Field.Revenue:
                        listSum.Add(listProduct.Skip(startIndex).Take(size).Sum(x => x.Revenue));
                        break;
                    case Field.SellPrice:
                        listSum.Add(listProduct.Skip(startIndex).Take(size).Sum(x => x.SellPrice));
                        break;
                }
              
                startIndex += size;
            }

            return listSum;
        }

       

        /// <summary>
        /// 建立資料
        /// </summary>
        /// <returns></returns>
        private List<Product> CreateProducts()
        {
            List<Product> listProduct = new List<Product>()
            {
                new Product() { Id = 1 ,Cost = 1 ,Revenue = 11 ,SellPrice = 21 },
                new Product() { Id = 2 ,Cost = 2 ,Revenue = 12 ,SellPrice = 22 },
                new Product() { Id = 3 ,Cost = 3 ,Revenue = 13 ,SellPrice = 23 },
                new Product() { Id = 4 ,Cost = 4 ,Revenue = 14 ,SellPrice = 24 },
                new Product() { Id = 5 ,Cost = 5 ,Revenue = 15 ,SellPrice = 25 },
                new Product() { Id = 6 ,Cost = 6 ,Revenue = 16 ,SellPrice = 26 },
                new Product() { Id = 7 ,Cost = 7 ,Revenue = 17 ,SellPrice = 27 },
                new Product() { Id = 8 ,Cost = 8 ,Revenue = 18 ,SellPrice = 28 },
                new Product() { Id = 9 ,Cost = 9 ,Revenue = 19 ,SellPrice = 29 },
                new Product() { Id = 10,Cost = 10,Revenue = 20 ,SellPrice = 30 },
                new Product() { Id = 11,Cost = 11,Revenue = 21 ,SellPrice = 31 }
            };

            return listProduct;
        }


    }


    public enum Field
    {
        Id,
        Cost,
        Revenue,
        SellPrice
    }

    public class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }

}
