// See https://aka.ms/new-console-template for more information

// Este é um tipo de comentário em linha

/*    
 
 Este é um tipo de comentário em bloco

 */

// Adicionando uma variável nome pessoa
string nomePessoa = "João";

/* 
 Adicionando uma variável salário pessoa
 Adicionando uma variável idade pessoa
 */
double salario = 229.90;
int idade = 15;

// Mostrando mensagem no console para escrever o nome
Console.WriteLine("Digite o nome da pessoa: ");

// ReadLine
nomePessoa = Console.ReadLine();

// WriteLine exibe mesagens na tela
Console.WriteLine("Nome: " + nomePessoa);
Console.WriteLine("Idade: " + idade);
Console.WriteLine("Salario: " + salario);