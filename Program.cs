using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //id = new Guid("090086d4-d5a1-48ae-a245-d152428451b1");
            //id = new Guid();
            var price = 10.2 + 9;
            //var texto ="O preço o produto é " +  price + " apenas na promoção";
            //var texto = string.Format("O preço o produto é {1} apenas na promoção {0}", price, true);
            //var texto = $"O preço o produto é {price} apenas na promoção";
            //var texto = $@"O preço do produto 
            //é {price} apenas na promoção";
            var texto = $"O preço o produto é \n {price} apenas na promoção";
            Console.WriteLine(texto);



        }
    }
}
