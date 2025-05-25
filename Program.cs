Console.Clear();

Console.WriteLine("======== Contorno Retângulo ========");

int altura, largura;

while (true)
{
    Console.Write("\nDigite um valor de largura: ");
    string entradaLargura = Console.ReadLine()!;
    Console.Write("Digite um valor de altura: ");
    string entradaAltura = Console.ReadLine()!;

    bool alturaValida = int.TryParse(entradaAltura, out altura);
    bool larguraValida = int.TryParse(entradaLargura, out largura);

    if (alturaValida && larguraValida && altura <= 10 && largura <= 10 && altura > 0 && largura > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("\nEntrada inválida! Por favor, digite apenas valores válidos.");
    }
}

string[] desenhoRet = desenhaRet(altura, largura);

Console.WriteLine("\nTamanho do retângulo:");
Console.WriteLine($"Largura..: {largura}");
Console.WriteLine($"Altura...: {altura}\n");

foreach (string linha in desenhoRet)
{
    Console.WriteLine(linha);
}

static string[] desenhaRet(int altura, int largura)
{
    string[] desenho = new string[altura];
    for (int linha = 0; linha < altura; linha++)
    {
        if (linha == 0 || linha == altura - 1)
        {
            desenho[linha] = new string('*', largura);
        }
        else
        {
            string meio = new string(' ', largura - 2);
            desenho[linha] = "*" + meio + "*"; 
        }
    }
    return desenho;
}