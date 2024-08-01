namespace SistemaEscolar
{
    class Program
    {
        private static double notaMinima = -1;
        private static List<Aluno> alunos = new List<Aluno>();
        private static bool notaMinimaDefinida = false;

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Olá, professor! Escolha uma opção: ");
                Console.WriteLine("1 - Cadastrar nota mínima para aprovação");
                Console.WriteLine("2 - Cadastrar um aluno");
                Console.WriteLine("3 - Selecionar o aluno pelo nome");
                Console.WriteLine("4 - Listar todos os alunos");
                Console.WriteLine("5 - Sair");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarNotaMinima();
                        break;
                    case "2":
                        CadastrarAluno();
                        break;
                    case "3":
                        ConsultarAluno();
                        break;
                    case "4":
                        ListarAlunos();
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private static void CadastrarNotaMinima()
        {
            if (notaMinimaDefinida)
            {
                Console.Write("A nota mínima já foi cadastra. Ao altera-la, todos os cadastros serão removidos. Deseja mesmo continuar? Se sim, digite 's', se não, digite 'n': ");
                if (Console.ReadLine().ToLower() != "s")
                {
                    return;
                }

                alunos.Clear(); 
                notaMinimaDefinida = false; 
            }

            Console.Write("Digite a nova nota mínima para aprovação: ");
            if (double.TryParse(Console.ReadLine(), out double novaNotaMinima))
            {
                notaMinima = novaNotaMinima;
                notaMinimaDefinida = true;
                Console.WriteLine("Nota mínima cadastrada com sucesso.");
            }
            else
            {
                Console.WriteLine("Nota inválida. Tente novamente.");
            }

            Console.ReadKey();
        }
        private static void CadastrarAluno()
        {
            if (!notaMinimaDefinida)
            {
                Console.WriteLine("O cadastro dos alunos não pode ser feito até que a nota mínima para aprovação seja cadastrada. Vá para a função 1 e cadastre a nota mínima.");
                Console.ReadKey();
                return;
            }

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            List<double> notas = new List<double>();
            while (true)
            {
                Console.Write("Digite a nota do aluno (ou 'media' para finalizar): ");
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "media")
                {
                    break;
                }

                if (double.TryParse(entrada, out double nota))
                {
                    notas.Add(nota);
                }
                else
                {
                    Console.WriteLine("Nota inválida. Tente novamente.");
                }
            }

            double media = 0;
            foreach (var n in notas)
            {
                media += n;
            }
            media /= notas.Count;

            bool aprovado = media >= notaMinima;

            alunos.Add(new Aluno { Nome = nome, Media = media, Aprovado = aprovado });

            Console.WriteLine($"Aluno cadastrado com sucesso. Média: {media:F2}, Status: {(aprovado ? "Aprovado" : "Reprovado")}");
            Console.ReadKey();
        }

        private static void ConsultarAluno()
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Aluno aluno = alunos.Find(a => a.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (aluno != null)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}, Média: {aluno.Media:F2}, Status: {(aluno.Aprovado ? "Aprovado" : "Reprovado")}");
            }
            else
            {
                Console.WriteLine("Nenhum aluno cadastrado. Vá para a sessão 2 para cadastrar um aluno.");
            }

            Console.ReadKey();
        }

        private static void ListarAlunos()
        {
            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado. Vá para a sessão 2 para cadastrar um aluno.");
            }
            else
            {
                foreach (var aluno in alunos)
                {
                    Console.WriteLine($"Aluno: {aluno.Nome}, Média: {aluno.Media:F2}, Status: {(aluno.Aprovado ? "Aprovado" : "Reprovado")}");
                }
            }

            Console.ReadKey();
        }
        class Aluno
        {
            public string Nome { get; set; }
            public double Media { get; set; }
            public bool Aprovado { get; set; }
        }
    }
}