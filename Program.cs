using static System.Console;

double valor1 = 0.0;
double valorB = 0.0;
double valorFinal = 0;


WriteLine("Escreva o valor 1: ");
valor1 = Convert.ToInt32(ReadLine());

WriteLine("Escreva o valor 2: ");
valorB = Convert.ToInt32(ReadLine());

if (valor1 <= 0 || valorB <= 0 )
{
    WriteLine("Valores = 0 não se dividem");
}
else
{
    valorFinal = valor1 / valorB;
}

WriteLine($"O resultado da divisão é: {valorFinal}");

