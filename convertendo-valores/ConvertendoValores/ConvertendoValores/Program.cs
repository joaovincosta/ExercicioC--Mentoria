// See https://aka.ms/new-console-template for more information

string nome = null;
int idade = 0;
double salario = 0;

// Solicitando o nome da pessoa
Console.WriteLine("Digite seu nome: ");

// Adicionando o nome da pessoa
nome = Console.ReadLine();

// Solicitando a idade da pessoa
Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

// Solicitando o salário da pessoa
Console.WriteLine("Digite seu salário: ");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("Seu nome é: " + nome);
Console.WriteLine("Sua idade é: " + idade);
Console.WriteLine("Seu salário é: " + salario);