// See https://aka.ms/new-console-template for more information

// Robô de atendimento

int opcao;

Console.WriteLine("                 Digite a opção desejada: "                  );
Console.WriteLine("                 ============================"               );
Console.WriteLine("                 1 - Desbloqueio de cartão"                  );
Console.WriteLine("                 ============================"               );
Console.WriteLine("                 2 - Bloqueio de cartão"                     );
Console.WriteLine("                 ============================"               );
Console.WriteLine("                 3 - Falar com atendente"                    );
Console.WriteLine("                 ============================"               );
Console.WriteLine("                 4 - Sair do sistema"                        );
Console.WriteLine("                 ============================"               );

opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        {
            Console.WriteLine("Cartão desbloqueado com sucesso!");
            break;
        }
    case 2:
        {
            Console.WriteLine("Cartão bloqueado com sucesso!");
            break;
        }
    case 3:
        {
            Console.WriteLine("Olá, em que posso ajudar?");
            break;
        }
    case 4:
        {
            Console.Clear();

            Console.WriteLine("              ==================="               );
            Console.WriteLine("                 Volte sempre!"                  );
            Console.WriteLine("              ===================");
            break;
        }
    default:
        {
            Console.WriteLine("Opção informada não existe");
            break;
        }
}