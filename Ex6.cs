using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salário fixo:");
            double fixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor total das vendas do vendedor:");
            double vendas = double.Parse(Console.ReadLine());
            double sal = 0;
            if(vendas <= 1500)
            {
                sal = fixo + (vendas * 0.05);
            }
            else
            {
                double primeiro = 1500 * 0.05;
                double segundo = (vendas - 1500) * 0.03;
                sal = fixo + primeiro + segundo;
                
            }
            
            Console.WriteLine("O salário total do vendedor é de:" + sal);
            Console.ReadKey();
        }
    }
}
