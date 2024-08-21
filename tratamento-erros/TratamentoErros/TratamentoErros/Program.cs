// See https://aka.ms/new-console-template for more information

int idade;

try
{
    Console.WriteLine("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Sua idade é: " + idade);
}
catch (Exception erro)
{

    Console.WriteLine("Houve umerro, por favor informe uma idade válida, erro: " + erro.Message);
}

Console.WriteLine("Tratamento de erros!");