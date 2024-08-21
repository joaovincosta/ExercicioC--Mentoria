// See https://aka.ms/new-console-template for more information

double numero;
int quantidade;

Console.WriteLine("Digite um número da tabuada: ");

numero = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade: ");

quantidade = int.Parse(Console.ReadLine());

for (int i = 0; i <= quantidade; i++)
{
    double total = numero * i;
    Console.WriteLine(numero + "X" + i + " = " + total);
}

Console.WriteLine("Criando uma tabuada simples no C#!");