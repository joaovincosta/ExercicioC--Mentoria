// See https://aka.ms/new-console-template for more information

Console.WriteLine("Aprendendo a usar o Array!");
Console.WriteLine("---------------------------------------------");
// Usado para armazenar, dentro de uma única variável tipo Array, várias informações

string[] linguagens = new string[4];
int[] anoLinguagens = new int[4];

linguagens[0] = "C#";
linguagens[1] = "JavaScript";
linguagens[2] = "Java";
linguagens[3] = "PHP";

anoLinguagens[0] = 1990;
anoLinguagens[1] = 1992;
anoLinguagens[2] = 1994;
anoLinguagens[3] = 1996;

Console.WriteLine("Linguagem de Programação 01: " + linguagens[0]);
Console.WriteLine("Ano da Linguagem de Programação 01: " + anoLinguagens[0]);
Console.WriteLine("=============================================");
Console.WriteLine("Linguagem de Programação 02: " + linguagens[1]);
Console.WriteLine("Ano da Linguagem de Programação 02: " + anoLinguagens[1]);
Console.WriteLine("=============================================");
Console.WriteLine("Linguagem de Programação 03: " + linguagens[2]);
Console.WriteLine("Ano da Linguagem de Programação 03: " + anoLinguagens[2]);
Console.WriteLine("=============================================");
Console.WriteLine("Linguagem de Programação 04: " + linguagens[3]);
Console.WriteLine("Ano da Linguagem de Programação 04: " + anoLinguagens[3]);