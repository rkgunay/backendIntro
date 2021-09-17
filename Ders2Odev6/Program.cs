using System;

namespace Ders2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            String productID = "Ürün Kodu ";
            String brandName = "Marka ";
            String productName = "Ürün Adı ";
            String noTaxPrice = "Fiyat ";
            String taxPrice = "KDV Dahil Fiyat ";

            String taxKDV = "KDV";
            String plus = " + ";
            String komma = " : ";
            String newLine = "\n";
            String tl = " TL ";
            double taxPercentage = 1.18;


            Product product1 = new Product();
            product1.productID = 19448;
            product1.brandName = "ST";
            product1.productName = "STM32 İşlemci Kiti NUCLEO-G031K8";
            product1.productPrice = 142.05;    
            
            Product product2 = new Product();
            product2.productID = 12396;
            product2.brandName = "Robotistan";
            product2.productName = "8x8 Kırmızı Dot Matrix Board8";
            product2.productPrice = 16.66; ;
                        
            Product product3 = new Product();
            product3.productID = 11854;
            product3.brandName = "Freescale";
            product3.productName = "FRDM-KL25Z Geliştirme Kartı";
            product3.productPrice = 212.32;

            Product[] products = new Product[] { product1, product2, product3};

            for(int i=0; i<products.Length; i++)
            {
                Console.WriteLine(
                    productID + komma + products[i].productID + newLine +
                    brandName + komma + products[i].brandName + newLine +
                    productName + komma + products[i].productName + newLine +
                    noTaxPrice + komma + products[i].productPrice + tl + plus + taxKDV + newLine +
                    taxPrice + komma + products[i].productPrice*taxPercentage + tl + newLine 

                    );
            }

            foreach (var product in products)
            {
                Console.WriteLine(
                   productID + komma + product.productID + newLine +
                   brandName + komma + product.brandName + newLine +
                   productName + komma + product.productName + newLine +
                   noTaxPrice + komma + product.productPrice + tl + plus + taxKDV + newLine +
                   taxPrice + komma + product.productPrice * taxPercentage + tl + newLine

                   );
            }

            int w = 0; 
            while(w< products.Length)
            {
                Console.WriteLine(
                   productID + komma + products[w].productID + newLine +
                   brandName + komma + products[w].brandName + newLine +
                   productName + komma + products[w].productName + newLine +
                   noTaxPrice + komma + products[w].productPrice + tl + plus + taxKDV + newLine +
                   taxPrice + komma + products[w].productPrice * taxPercentage + tl + newLine

                   );

                w++;
            }


        }
    }

    class Product
    {
        public int productID { get; set; }
        public string brandName { get; set; }

        public string productName { get; set; }
        public double productPrice { get; set; }
        
    }
}
