namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Multiplicação");

            Console.WriteLine("-------");
            Console.WriteLine("Selecione uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float vUm = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float vDois = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = vUm + vDois;
            // Console.WriteLine("O resultado da soma é " + resultado);
            Console.WriteLine($"O resultado da soma é {resultado}");
            // Console.WriteLine($"O resultado da soma é {vUm + vDois}");
            // Console.WriteLine("O resultado da soma é " + (vUm + vDois));
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float vUm = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float vDois = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = vUm - vDois;
            Console.WriteLine($"O resultado da subtração  é {resultado}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float vUm = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float vDois = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = vUm / vDois;

            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float vUm = float.Parse(Console.ReadLine());

            Console.WriteLine("segundo valor: ");
            float vDois = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = vUm * vDois;

            Console.WriteLine("O resultado da multiplicação é " + (vUm * vDois));
            Console.ReadKey();
            Menu();


        }
    }
}