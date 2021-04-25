using System; 

class minhaClasse {

    static void Main(string[] args) { 

            double salario, reajuste, novoSalario, percentual;
           
            salario = Convert.ToDouble(Console.ReadLine());

         if (salario <0 ) {
           salario = 0;
           percentual = 0;
         }

            if( salario <= 400.00)
            {
                reajuste = salario * 0.15; 
                novoSalario = salario + reajuste;
                percentual = 0.15*100;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                percentual = 0.12*100;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                percentual = 0.10*100;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual:  {0:0} %", percentual);
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                percentual = 0.07*100;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0}", reajuste);
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
            else
            {
              reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                percentual =0.04*100;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0:0} %", percentual);
            }
    }

}