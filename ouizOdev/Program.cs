using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Product product1 = new Product();
        product1.UrUnAdi = "krampon";
        product1.marka = "nike";
        product1.fiyat = 195.0;
        product1.beden = 43.0;

        Product product2 = new Product();
        product2.UrUnAdi = "bot";
        product2.marka = "caterpiller";
        product2.fiyat = 350.0;
        product2.beden = 42.0;

        Product product3 = new Product();
        product3.UrUnAdi = "terlik";
        product3.marka = "polaris";
        product3.fiyat = 49.99;
        product3.beden = 42.5;

        Product[] products = new Product[] { product1, product2, product3 };

        Console.WriteLine("+++Foreach Döngüsü Başlar+++");

        foreach (var product in products)
        {
            Console.WriteLine(product.UrUnAdi + " " + product.marka + " " + product.fiyat + " " + product.beden);
        }
        Console.WriteLine("***for döngüsü başlar***");

        for (int i = 0; i < 3 ; i++)
        {
            Console.WriteLine(products[i].UrUnAdi +" "+products[i].marka +" "+ products[i].fiyat +" "+ products[i].beden );
        }
        Console.WriteLine("--- While döngüsü başlar ---");
  
        int j = 0;
        while (j< 3)
        {
            Console.WriteLine(products[j].UrUnAdi + " " + products[j].marka + " " + products[j].fiyat + " " + products[j].beden);
            j++;
        }

        Console.WriteLine("TEŞEKKÜRLER");
  


  }
}
class Product
{
    public string UrUnAdi { get; set; }

    public string marka { get; set; }

    public double fiyat { get; set; }

    public double beden { get; set; }


}