

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro para ver a tabuada: ");
        int numeroEscolhido = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabuada do {numeroEscolhido}:");
        Console.WriteLine("------------------");

     
        for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
        {
         
            int resultadoMultiplicacao = numeroEscolhido * multiplicador;

         
            Console.WriteLine($"{numeroEscolhido} x {multiplicador} = {resultadoMultiplicacao}");
        }
        Console.WriteLine();
        int num = 10;

        Console.WriteLine($"São os numeros pares entre 0 e 50:");
        for (int i = 0; i < 51; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i );
            }
        }
        Console.WriteLine($"Contagem regressiva:");
        for (int i = num; i >=0; i--)
        {
          
                Console.WriteLine(i);
           
        }
        int soma = 0;
        for (int i = 1; i <= 10; i++)
        {
            soma += i;
        }
        Console.WriteLine($"A soma total é: {soma}");

        int fatorial = 1;
        int numerofatoriando = 5;
        for (int i = numerofatoriando; i > 0; i--)
        {
            fatorial *= i;
        }
        Console.WriteLine();



        Console.Write("Quantas notas você deseja digitar? ");
            int totalDeNotas = int.Parse(Console.ReadLine());

            double acumuladorNotas = 0;

           
            for (int contador = 1; contador <= totalDeNotas; contador++)
            {
                Console.Write($"Digite a nota {contador}: ");
                double notaAtual = double.Parse(Console.ReadLine());
                acumuladorNotas += notaAtual;
            }
            double resultadoMedia = acumuladorNotas / totalDeNotas;
            Console.WriteLine("\n--- Relatório Final ---");
            Console.WriteLine($"Total somado: {acumuladorNotas:F2}");
            Console.WriteLine($"Média final: {resultadoMedia:F2}");
        Console.WriteLine();

        Console.Write("Digite o valor da base: ");
        int valorBase = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor do expoente (inteiro positivo): ");
        int valorExpoente = int.Parse(Console.ReadLine());

        int resultadoPotencia = 1;

        for (int contador = 1; contador <= valorExpoente; contador++)
        {
            resultadoPotencia *= valorBase;
        }


        Console.WriteLine($"\nO resultado de {valorBase} elevado a {valorExpoente} é: {resultadoPotencia}");

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(new string('*', i));
        }

        Console.Write("\nDigite um número para verificar se é primo: ");
        int numeroVerificar = int.Parse(Console.ReadLine());
        bool ehPrimo = true;

        if (numeroVerificar < 2) ehPrimo = false;

        for (int divisor = 2; divisor < numeroVerificar; divisor++)
        {
            if (numeroVerificar % divisor == 0)
            {
                ehPrimo = false;
                break; // Se achou um divisor, não precisa continuar testando
            }
        }

        if (ehPrimo) Console.WriteLine($"{numeroVerificar} é um número primo.");
        else Console.WriteLine($"{numeroVerificar} não é um número primo.");


        Console.WriteLine("\nOs 15 primeiros números da sequência de Fibonacci:");
        int primeiroTermo = 0;
        int segundoTermo = 1;

        for (int i = 1; i <= 15; i++)
        {
            Console.Write(primeiroTermo + " ");

            int proximoTermo = primeiroTermo + segundoTermo;
            primeiroTermo = segundoTermo;
            segundoTermo = proximoTermo;
        }
        Console.WriteLine();


        Console.WriteLine("\nMúltiplos de 3 e 5 entre 1 e 100:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
    
}