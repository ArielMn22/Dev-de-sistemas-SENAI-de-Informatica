using System;
using Senai.FolhaDePagamento.Classes;

namespace Senai.FolhaDePagamento {
    class Program {
        static Funcionario[] func = new Funcionario[1000]; //Declarando Array
        static int i = 0; //Contador // Conta quantos usuários foram cadastrados
        static void Main (string[] args) {
            do {
                Menu ();

                switch (opcao) {
                    case "1":
                        {
                            CadastrarUsuario ();
                            break;
                        }
                    case "2":
                        {
                            ExibirFolhaPagamento ();
                            break;
                        }
                    case "3":
                        {
                            ExibirTotalBruto ();
                            break;
                        }

                    case "4":
                        {
                            AumentarSalario ();
                            break;
                        }

                    case "5":
                        {
                            ExibirTotalLiquido ();
                            break;
                        }

                    case "0":
                        {
                            Console.Clear ();
                            System.Console.WriteLine ("Até a próxima!");
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine ("Insira uma opção válida!");
                            break;
                        }
                }
                Pausa ();
            }
            while (opcao != "0");
        }

        static string opcao;
        static void Menu () {
            Console.Clear ();

            System.Console.WriteLine ("===================================================");
            System.Console.WriteLine ("               Folha de pagamento");
            System.Console.WriteLine ("===================================================");
            System.Console.WriteLine ("1 - Cadastrar um novo usuário.");
            System.Console.WriteLine ("2 - Exibir folha de pagamento.");
            System.Console.WriteLine ("3 - Exibir custo total dos salários brutos.");
            System.Console.WriteLine ("4 - Aumentar um salário.");
            System.Console.WriteLine ("5 - Exibir custo total dos salários líquidos.");
            System.Console.WriteLine ("0 - Sair do programa");

            System.Console.Write ("Informe uma opção: ");
            opcao = Console.ReadLine ();
        }
        static void CadastrarUsuario () {
            if (i < 1000) {
                func[i] = new Funcionario ();

                System.Console.WriteLine ("\nInsira o nome do usuário:");
                func[i].Nome = Console.ReadLine ();

                System.Console.WriteLine ("\nInsira o salário do funcionário:");
                func[i].Salario = double.Parse (Console.ReadLine ());
                i++;
                System.Console.WriteLine ("\nUsuário cadastrado com sucesso!");
            } else {
                System.Console.WriteLine ("Número limite de usuários cadastrados atingido!");
            }
        }
        static void ExibirFolhaPagamento () {
            Console.Clear ();

            System.Console.WriteLine ("===================================================");
            System.Console.WriteLine ("                   Funcionários");
            System.Console.WriteLine ("===================================================");

            if (i == 0) {
                System.Console.WriteLine ("\nNão há funcionários cadastrados!");
            } else {
                int j;
                for (j = 0; j < i; j++) {
                    System.Console.WriteLine ($"Funcionário: {func[j].Nome} - Índice: {j}\n");
                }

                System.Console.WriteLine ("Insira o índice do funcionário que deseja ver as informações do salário:");
                int indice = int.Parse (Console.ReadLine ());
                Console.Clear ();

                if (indice < 0 || func[indice] == null) {
                    System.Console.WriteLine ("Índice Inválido!");
                    Pausa ();
                    ExibirFolhaPagamento ();
                } else {
                    System.Console.WriteLine ("===================================================");
                    System.Console.WriteLine ($"                 {func[indice].Nome}");
                    System.Console.WriteLine ("===================================================");
                    System.Console.WriteLine ($"Salário Bruto: {func[indice].Salario.ToString("C")}");
                    System.Console.WriteLine ($"Desconto do INSS: {func[indice].INSS().ToString("C")}");
                    System.Console.WriteLine ($"Desconto do IRFF: {func[indice].IRFF().ToString("C")}");
                    System.Console.WriteLine ($"Desconto do vale transporte: {func[indice].ValeTransporte().ToString("C")}");
                    System.Console.WriteLine ($"Total de descontos: {(func[indice].INSS() + func[indice].IRFF() + func[indice].ValeTransporte()).ToString("C")}");
                    System.Console.WriteLine ($"Salário Líquido: {func[indice].SalarioDescontado().ToString("C")}");
                }
            }

        }
        static void ExibirTotalBruto () {
            double soma = 0;

            for (int j = 0; j < i; j++) {
                soma += func[j].Salario;
            }

            System.Console.WriteLine ($"\nSalário Total Bruto: {soma.ToString("C")}");
        }
        static void ExibirTotalLiquido () {
            double soma = 0;

            for (int j = 0; j < i; j++) {
                soma += func[j].SalarioDescontado ();
            }

            System.Console.WriteLine ($"\nSalário Total Líquido: {soma.ToString("C")}");
        }
        static void AumentarSalario () {

            if (i == 0) {
                System.Console.WriteLine ("\nNão há funcionários cadastrados!");
            } else {
                int j;
                for (j = 0; j < i; j++) {
                    System.Console.WriteLine ($"\nFuncionário: {func[j].Nome} - Índice: {j}\n");
                }

                System.Console.WriteLine ("Insira o índice do funcionário que deseja aumentar o salário:");
                int indice = int.Parse (Console.ReadLine ());

                if (indice < 0 || func[indice] == null) {
                    System.Console.WriteLine ("Índice inválido!");
                    Pausa ();
                    AumentarSalario ();
                } else {

                    double salarioAntes = func[indice].Salario;

                    func[indice].AumentarSalario ();

                    System.Console.WriteLine ("\nSalário aumentado com sucesso!\n");
                    System.Console.WriteLine ($"Funcionário: {func[indice].Nome}\nSalário: Antes - {salarioAntes.ToString("C")}. Depois - {func[indice].Salario.ToString("C")}");
                }
            }
        }
        static void Pausa () {
            System.Console.WriteLine ("\nAperte [QUALQUER] tecla para continuar...");
            Console.ReadKey ();
        }
    }
}