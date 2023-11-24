Console.WriteLine("Média Decimal");

Console.WriteLine("Digite a quantidade de números desejados:");
int quantidade = Convert.ToInt32(Console.ReadLine());

decimal numerodigitado;
int auxiliar = 0;

decimal soma = 0;
decimal maiornumero= 999999.99M;
decimal menornumero= 999999.99M;

while (auxiliar < quantidade)
{
    auxiliar += 1;
    Console.Write($"Número #{auxiliar}: ");
    numerodigitado = Convert.ToDecimal(Console.ReadLine());
    soma = soma + numerodigitado;

    if (auxiliar == 1)
    {
        maiornumero = numerodigitado;
        menornumero = numerodigitado;
    }


    if (numerodigitado > maiornumero)
    {
        maiornumero = numerodigitado;
    }

    if (numerodigitado < menornumero)
    {
        menornumero = numerodigitado;
    }

}

if (auxiliar > 0)
{
    decimal media = soma / quantidade;

    Console.WriteLine($"Soma: {soma:N2}");
    Console.WriteLine($"Média: {media:N2}");
    Console.WriteLine($"Menor: {menornumero:N2}");
    Console.WriteLine($"Maior: {maiornumero:N2}");
}