using static System.Console;

double valorA = 0.0;
double valorB = 0.0;
double valorFinal = 0;


WriteLine("Escreva o valor 1: ");
valorA = Convert.ToInt32(ReadLine());

WriteLine("Escreva o valor 2: ");
valorB = Convert.ToInt32(ReadLine());

if (valorA <= 0 || valorB <= 0 )
{
    WriteLine("Valores = 0 não se dividem");
}
else
{
    valorFinal = valorA / valorB;
}

WriteLine($"O resultado da divisão é: {valorFinal}");

WriteLine($"O resultado da divisão");
WriteLine($"O resultado");
