using System;

namespace App
{
    class Program
    {
        private static object teclado;

        public int Id;
        public string Name;
        public double Price;


        struct Produto
        {
            //  método construtor em struct, sem ele os valores não poderão ser instanciados.
            public Product(int id, string name, double price, EProductType type)
            {
                Id = id;
                Name = name;
                Price = price;
                //Enum, toda vez que o pruduto for criado, ele irá receber o EProductType
                Type = type;
            }

            // Enum, virou um tipo de dado
            public EProductType Type;


            // Método
            public double PriceInDolar(double dolar)
            {
                return Price * dolar;
            }
        }

        //Enum tipo de dado, no caso quando for produto é 1, e quando for serviço é 2.
        enum EProductType
        {
            Product = 1,
            Service = 2,

        }
    }






    static void Main(string[] args)
    {

        //Instanciando
        var mouse = new Product(1, "Mouse gamer", 299.97, EProductType.Product); //parametros são passados aqui.
        var manutencao = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);


        Console.WriteLine(mouse.Id);
        Console.WriteLine(mouse.Name);
        Console.WriteLine(mouse.Price);
        //enum
        Console.WriteLine(mouse.Type);
        Console.WriteLine((int)mouse.Type); // conversão explicita, Aqui sairá o numero inteiro

    }
}
