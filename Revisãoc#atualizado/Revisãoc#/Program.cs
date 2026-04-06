

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

        string[] nomes = { "Ana", "Bruno", "Carla", "Diego", "Elena" };
        Console.WriteLine("\n--- Mensagens de Boas-Vindas ---");
        foreach (string nome in nomes)
        {
            Console.WriteLine($"Bem-vindo, {nome}");
        }

        int[] numerosInteiros = { 10, 20, 30, 40, 50 };
        int somaTotalArray = 0;
        foreach (int n in numerosInteiros)
        {
            somaTotalArray += n;
        }
        Console.WriteLine($"\nSoma do array de inteiros: {somaTotalArray}");

       
        double[] valoresDecimais = { 12.5, 45.8, 8.2, 99.1, 34.6 };
        double maiorValor = valoresDecimais[0];
        foreach (double v in valoresDecimais)
        {
            if (v > maiorValor) maiorValor = v;
        }
        Console.WriteLine($"O maior valor no array é: {maiorValor}");

       
        Console.Write("\nDigite uma frase para contar a letra 'a': ");
        string frase = Console.ReadLine();
        int contadorA = 0;
        foreach (char letra in frase.ToLower()) // ToLower facilita a busca
        {
            if (letra == 'a') contadorA++;
        }
        Console.WriteLine($"A letra 'a' aparece {contadorA} vezes.");

        
        List<int> listaMista = new List<int> { -5, 10, -2, 15, 0, 8 };
        Console.Write("Números positivos da lista: ");
        foreach (int numPositivo in listaMista)
        {
            if (numPositivo > 0) Console.Write(numPositivo + " ");
        }
        Console.WriteLine();

       
        Console.Write("\nDigite uma palavra para inverter: ");
        string palavra = Console.ReadLine();
        string palavraInvertida = "";
        foreach (char c in palavra)
        {
            palavraInvertida = c + palavraInvertida; // Adiciona o caractere no início
        }
        Console.WriteLine($"Palavra invertida: {palavraInvertida}");

      
        double[] precos = { 100.0, 250.0, 50.0, 10.0 };
        Console.WriteLine("\nNovos preços (Aumento de 10%):");
        foreach (double preco in precos)
        {
            double novoPreco = preco * 1.10;
            Console.WriteLine($"R$ {novoPreco:F2}");
        }

      
        List<string> frutas = new List<string> { "Maçã", "Banana", "Morango", "Uva" };
        Console.Write("\nQual fruta deseja buscar? ");
        string buscaFruta = Console.ReadLine();
        bool encontrou = false;
        foreach (string fruta in frutas)
        {
            if (fruta.Equals(buscaFruta, StringComparison.OrdinalIgnoreCase))
            {
                encontrou = true;
                break;
            }
        }
        Console.WriteLine(encontrou ? "A fruta está na lista!" : "Fruta não encontrada.");

    
        int[] dezNumeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("\nClassificação de Pares e Ímpares:");
        foreach (int item in dezNumeros)
        {
            string tipo = (item % 2 == 0) ? "Par" : "Ímpar";
            Console.WriteLine($"{item} é {tipo}");
        }

    }
    
}