
Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtracao");
    Console.WriteLine("3 - Divisao");
    Console.WriteLine("4 - Multiplicacao");
    Console.WriteLine("5 - Cotacao");
    Console.WriteLine("6 - Sair");

    Console.WriteLine("-------------");
    Console.WriteLine("Selecione uma opcao: ");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: Cotacao(); break;
        case 6: System.Environment.Exit(0); break;
        default: Menu(); break;
    }

}

static void Soma()
{
    Console.Clear();

    Console.WriteLine("Primeiro Valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Insira o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 + v2;

    System.Console.WriteLine($"O resultado da soma e: {v1 + v2}");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine($"O resultado da subtracao: {v1 - v2}");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine($"O resultado da divisao: {v1 / v2}");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine($"O resultado da multiplicacao: {v1 * v2}");
    Console.ReadKey();
    Menu();
}

static void Cotacao()
{
    Console.Clear();
    Console.WriteLine("Digite o valor em reais para a conversao: ");
    double valorReais = double.Parse(Console.ReadLine());

    Console.WriteLine(@"Escolha em qual moeda voce quer a conversao: 
    1 - Dollar
    2 - Euro
    3 - Libra
    4 - Peso
    5 - Voltar menu");
    short res = short.Parse(Console.ReadLine());

    var euro = 5.60;
    var dollar = 5.20;
    var libra = 6.00;
    var peso = 100;


    switch (res)
    {
        case 1: Console.WriteLine($"Valor total em Dollar: {valorReais / dollar}"); break;
        case 2: Console.WriteLine($"Valor total em Euro: {valorReais / euro}"); break;
        case 3: Console.WriteLine($"Valor total em Libra: {valorReais / libra}"); break;
        case 4: Console.WriteLine($"Valor total em Peso: {valorReais / peso}"); break;
        case 5: Menu(); break;
        default: Cotacao(); break;
    }


}
