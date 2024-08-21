// See https://aka.ms/new-console-template for more information

int numero;

Console.WriteLine("Digite um número: ");
numero = int.Parse(Console.ReadLine());

switch (numero)
{
    case 1: // case = caso -> caso isso aconteça, caso aquilo aconteça etc.
    case 2:
    case 3:
        {
            Console.WriteLine("A variável tem o valor entre 1 e 3");
            break; // quebra, sai do switch
        }
    case 4:
    case 5:
    case 6:
        {
            Console.WriteLine("A variável tem o valor entre 4 e 6");
            break;
        }
    default:
        {
            Console.WriteLine("A variável tem o valor maior que 6");
            break;
        }
}