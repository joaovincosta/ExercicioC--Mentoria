// See https://aka.ms/new-console-template for more information

double valor1, valor2; // Isto é uma simplificação. Determina direto que ambos são variáveis double, ao invés de fazer isso separadamente

valor1 = 10;
valor2 = 5;

double soma = valor1 + valor2;
double multiplicacao = valor1 * valor2;
double divisao = valor1 / valor2;
double subtracao = valor1 - valor2;
double media = soma / 2;

Console.WriteLine("A soma de " + valor1 + " e " + valor2 + " = " + soma);
Console.WriteLine("A multiplicação de " + valor1 + " e " + valor2 + " = " + multiplicacao);
Console.WriteLine("A divisão de " + valor1 + " e " + valor2 + " = " + divisao);
Console.WriteLine("A subtração de " + valor1 + " e " + valor2 + " = " + subtracao);
Console.WriteLine("A média de " + valor1 + " e " + valor2 + " = " + media);