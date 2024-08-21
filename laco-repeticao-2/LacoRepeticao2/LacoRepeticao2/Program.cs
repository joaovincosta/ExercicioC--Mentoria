// See https://aka.ms/new-console-template for more information

string[] nomePessoas = new string[10];

nomePessoas[0] = "Elvis Presley";
nomePessoas[1] = "Joan Jett";
nomePessoas[2] = "Harry Styles";
nomePessoas[3] = "Michael Jackson";
nomePessoas[4] = "Taylor Swift";
nomePessoas[5] = "Bruno Mars";
nomePessoas[6] = "Dua Lipa";
nomePessoas[7] = "Jay Z";
nomePessoas[8] = "Billie Eilish";
nomePessoas[9] = "João Vinícius";

int i = 0;

while (i < nomePessoas.Length)
{
    Console.WriteLine("Repetindo a variável nome, índice: " + i);
    Console.WriteLine(nomePessoas[i]);

    i++;
}

foreach (var nome in nomePessoas) // laço de repeticao foreach (para cada)
{
    Console.WriteLine(nome);
}

    Console.WriteLine("Aprendendo Laço de Repetição - 2!");