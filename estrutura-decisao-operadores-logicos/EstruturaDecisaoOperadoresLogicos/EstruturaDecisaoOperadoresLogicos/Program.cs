// See https://aka.ms/new-console-template for more information

string nome;
int idade;

Console.WriteLine("Digite um nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite uma idade: ");
idade = int.Parse(Console.ReadLine());

// Verificando se todas as condições são verdadeiras usando && (equivalente ao "and" no phyton)
if (nome == "João" && idade == 15)
{
    Console.WriteLine("Seu nome é João e você tem 15 anos");
}

// Verificando se pelo menos uma condição é verdadeira usando || (equivalente ao "ou" no phyton)
if (nome == "João" || idade == 15)
{
    Console.WriteLine("Seu nome pode ser João ou você pode ter 15 anos");
}

bool v = false;
bool f = true;

if (!v) 
{
    Console.WriteLine("A primeira condição é verdadeira!");
}

if (!f)
{
    Console.WriteLine("A segunda condição é verdadeira!");
}

Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
Console.WriteLine("Finalizado nosso sistema!");