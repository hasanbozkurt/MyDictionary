using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> productList = new MyDictionary<string>();
            productList.Add("Laptop");
            productList.Add("Yazıcı");
            productList.Add("Monitör");
            productList.Add("Klavye");
            productList.Add("Mouse");
            productList.Add("Kamera");
            productList.Add("Hoparlör");
            productList.Add("Kulaklık");
            productList.Add("Gaming Masa");
            productList.Add("Gaming Koltuk");
            

            Console.WriteLine("Ürün Sayısı: "+productList.Length);


            Console.WriteLine("-----------Ürün Listesi-----------");
            foreach (var products in productList.Items)
            {
                Console.WriteLine(products);
            }
        }
    }
}
