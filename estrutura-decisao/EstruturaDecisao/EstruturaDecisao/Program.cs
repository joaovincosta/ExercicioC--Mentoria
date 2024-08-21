// See https://aka.ms/new-console-template for more information

// Criando um sistema para aprovação ou reprovação de aluno

string nome;
double nota1, nota2, nota3, media;

Console.WriteLine("Digite o nome do aluno: ");
nome = Console.ReadLine();

Console.WriteLine("Digite a nota1 do aluno: ");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota2 do aluno: ");
nota2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a nota3 do aluno: ");
nota3 = double.Parse(Console.ReadLine());

media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("Olá, " + nome);
Console.WriteLine("Sua média final foi de " + media);

if(media > 5)
{
    Console.WriteLine("Parabéns, você foi aprovado!");
}
else if (media == 5)
{
    Console.WriteLine("Você foi aprovado (mas foi por pouco, e precisa melhorar)");
}
else
{
    Console.WriteLine("Você foi reprovado!");
}