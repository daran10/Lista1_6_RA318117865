using System;

namespace Lista1_6
{
    class Program
    {


        static bool PAR(int num) 
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }


        public static void Main(string[] args)
        {
            //Questão 1

            int[] vet = new int[4]; 

            int Digitos = 0;
            int Troca1 = 0;
            int Troca2 = 0;
            int Digito1 = 0;
            int Digito2 = 0;
            int Digito3 = 0;
            int Digito4 = 0;

            Console.WriteLine("Favor digitar um número de 4 digitos");
            Digitos = Convert.ToInt32(Console.ReadLine());

            Digito1 = Digitos / 1000;
            Digito2 = Digitos / 100 % 10;
            Digito3 = Digitos / 10 % 10;
            Digito4 = Digitos % 10;

            Digito1 = (Digito1 + 7) / 10;
            Digito2 = (Digito2 + 7) / 10;
            Digito3 = (Digito3 + 7) / 10;
            Digito4 = (Digito4 + 7) / 10;

            vet[0] = Digito1;
            vet[1] = Digito2;
            vet[2] = Digito3;
            vet[3] = Digito4;

            Troca1 = vet[0];
            vet[0] = vet[2];
            vet[2] = Troca1;

            Troca2 = vet[1];
            vet[1] = vet[3];
            vet[3] = Troca2;

            for (int j = 0; j < vet.Length; j++)

            {
                Console.Write(vet[j] + " ");

            }

            Console.WriteLine(" /n Novo Numero");

            Console.ReadLine();
            Console.Clear();


            //Questão 2

            int saldo = 0;

            Console.WriteLine("Informe o saldo: \n");
            saldo = Convert.ToInt32(Console.ReadLine());

            Cliente cliente = new Cliente(saldo, 2000, 100, 800, 5000);
            Console.WriteLine("Novo saldo: \n");
            Console.WriteLine(cliente.NovoSaldo());

            cliente.AtualizaSaldo();

            if (cliente.Limiteestourado())
                Console.WriteLine("Limite excedido !");
            else
                Console.WriteLine("Crédito disponivel.");

            Console.ReadKey();
            Console.Clear();

            //Questão 3


            int num = 0;
            Console.WriteLine("\t\t\t\t PAR (TRUE) ------  IMPAR (FALSE) \n"); 
            while (num <= 10)
            {
                Console.WriteLine("Número : " + num + " " + PAR(num)); 
                num = num + 1;
            }

            Console.ReadKey();
            Console.Clear();




            //Questão 4

            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;

            Console.WriteLine("Qual o primeiro valor do triângulo? :");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o Segundo valor do triângulo? :");
            valor2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual o Terceiro valor do triângulo :");
            valor3 = Convert.ToInt32(Console.ReadLine());

            if (valor1 == valor2 && valor2 == valor3)
                Console.WriteLine("Triangulo Equilátero = 3 lados iguais : lado 1 = " + valor1 + " lado 2 = " + valor2 + " lado 3 = " + valor3);

            else if (valor1 != valor2 && valor1 != valor3 && valor2 != valor3)
                Console.WriteLine("Triangulo Escaleno = 3 lados diferentes : lado 1 = " + valor1 + " lado 2 = " + valor2 + " lado 3 = " + valor3);
            else
                Console.WriteLine("Triangulo Isoceles = 2 lados iguais : lado 1 = " + valor1 + " lado 2 = " + valor2 + " lado 3 = " + valor3);

            Console.ReadKey();
            Console.Clear();


            // Questão 5


            string VogalA = "a";
            string VogalE = "e";
            string VogalI = "i";
            string VogalO = "o";
            string VogalU = "u";


            string letra;


            Console.WriteLine("Digite uma letra");
            letra = Convert.ToString(Console.ReadLine());

            if (letra.Length > VogalA.Length || letra.Length > VogalE.Length || letra.Length > VogalI.Length || letra.Length > VogalO.Length || letra.Length > VogalU.Length)

                Console.WriteLine("Favor digitar somente 1 caracter");


            else if (letra == VogalA || letra == VogalE || letra == VogalI || letra == VogalO || letra == VogalU)
                Console.WriteLine(" A letra é uma Vogal");

            else
                Console.WriteLine(" A letra é uma Consoante");
            Console.ReadKey();
            Console.Clear();


            //Questão 6

            int numero;
            int i;
            int soma = 0;
            Console.WriteLine(" Digite um número inteiro:  ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= numero; i++) 
                
            {
                int aux = 0;


                aux = numero % i; 
                if (aux == 0)
                {
                    soma = soma + 1;
                }
            }

            if (soma == 2)
                Console.WriteLine("O número é primo");
            else
                Console.WriteLine("O número não é primo");

            Console.ReadKey();
            Console.Clear();

        }
    }
}
