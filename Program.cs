using System;

namespace Final_Project{
    internal class Program{
        static void Main(string[] args){
            Clientes clientes = new Clientes();
           
            if (clientes.Inicializa())
                Console.WriteLine(" > Coleção de clientes inicializada! ");
            else
            {
                Console.WriteLine(" > Erro ao inicializar a coleção de clientes");
                //return -1;
            }

            string OpcaoMenu;

            do
            {
                OpcaoMenu = Menu();

                switch (OpcaoMenu)
                {
                    case "00":{
                        Console.WriteLine("O programa vai encerrar... Adeus!");
                        break;
                    }

                    case "01":
                        {
                            int contagem = clientes.Contagem();

                            if (clientes.Contagem() == 0)
                            {
                                Console.WriteLine("Não existem clientes na coleção!");
                                break;
                            }

                            else{
                                if(clientes.Estado_Cliente()){
                                    
                                    for (int i = 0; i < clientes.Contagem(); i++)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------");
                                        Console.WriteLine($" > Número do cliente ............... {clientes.Numero_Cliente(i)}");
                                        Console.WriteLine($" > Nome ................ {clientes.Nome(i)}");
                                        Console.WriteLine($" > Número de Contribuinte ............... {clientes.Contribuinte(i)}");
                                        Console.WriteLine($" > Saldo Disponível ..... {clientes.Saldo_Disponivel(i)}");
                                    }

                                } 
                            }

                            break;
                        }

                    case "02":
                        {
                            /* 
                            ex 7.1
                            if (viaturas.Contagem() == 0)
                            {
                                Console.WriteLine("Não existem viaturas na coleção!");
                                break;
                            }

                            bool passed;
                            int tentativas = 1;
                            int iIndice;

                            do
                            {
                                Console.Write("Insira o índice da viatura na coleção: ");
                                string sIndice = Console.ReadLine();

                                passed = int.TryParse(sIndice, out iIndice);

                                if (!passed)
                                {
                                    if (++tentativas > 3)
                                    {
                                        Console.WriteLine("Índice com formato errado! Número de tentativas excedido...");
                                        break;
                                    }

                                    Console.WriteLine("Índice com formato errado! Insira novamente...");
                                }
                            }
                            while (!passed);

                            if (passed)
                            {
                                if (viaturas.Elimina(iIndice))
                                    Console.WriteLine("A viatura foi removida da coleção com sucesso!");
                                else
                                    Console.WriteLine("A viatura não foi encontrada! Verifique o índice na coleção!");
                            } */

                            //trabalho final começa aqui
                            int contagem = clientes.Contagem();

                            if (clientes.Contagem() == 0)
                            {
                                Console.WriteLine("Não existem clientes na coleção!");
                                break;
                            }

                            clientes.ClienteAtivoSaldo();


                            break;
                        }

                    case "03":
                        {
                            /* 
                            ex 7.1
                            Console.Write(" > Introduza a marca da viatura: ");
                            string sMarca = Console.ReadLine();

                            Console.Write(" > Introduza o modelo da viatura: ");
                            string sModelo = Console.ReadLine();

                            bool passed;
                            int tentativas = 1;
                            int iAno;

                            do
                            {
                                Console.Write(" > Introduza o ano da matrícula: ");
                                string sAno = Console.ReadLine();

                                passed = int.TryParse(sAno, out iAno);

                                if (!passed)
                                {
                                    if (++tentativas > 3)
                                    {
                                        Console.WriteLine("Formato do Ano errado! Número de tentativas excedido...");
                                        break;
                                    }

                                    Console.WriteLine("Formato do Ano errado! Insira novamente...");
                                }
                            }
                            while (!passed);

                            if (passed)
                            {
                                viaturas.Adiciona(sMarca, sModelo, iAno);

                                Console.WriteLine($"Viatura {sMarca} {sModelo} (de {iAno}) inserida na coleção com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Impossível adicionar a viatura. Operação cancelada.");
                            }
 */

                            //trabalho final começa aqui
                            int contagem = clientes.Contagem();

                            if (clientes.Contagem() == 0)
                            {
                                Console.WriteLine("Não existem clientes na coleção!");
                                break;
                            }

                            clientes.ClienteAtivoSaldoExp();

                            break;
                        }

                    case "04":
                        {
                            /* 
                            isso é do exercicio 7.1
                            if (viaturas.Grava())
                                Console.WriteLine(" > Coleção de viaturas gravada! ");
                            else
                                Console.WriteLine(" > Erro ao gravar a coleção de viaturas! ");
                            */
                            
                            
                            //trabalho final começa aqui
                            int contagem = clientes.Contagem();

                            if (clientes.Contagem() == 0)
                            {
                                Console.WriteLine("Não existem clientes na coleção!");
                                break;
                            }

                            Console.WriteLine("Qual o número do cliente que deseja obter todos os dados?");
                            int indice = int.Parse(Console.ReadLine());
                            clientes.MostrarUmCliente(indice);
                        
                            break;
                        }

                    case "05":
                        {
                            Console.Write(" > Introduza o nome do cliente: ");
                            string Snome = Console.ReadLine();

                            Console.Write(" > Introduza a morada do cliente: ");
                            string Smorada = Console.ReadLine();

                            Console.Write(" > Introduza o código postal do cliente: ");
                            string Scodigo_postal = Console.ReadLine();

                            Console.Write(" > Introduza a localidade do cliente: ");
                            string Slocalidade = Console.ReadLine();

                            Console.Write(" > Introduza o telefone do cliente: ");
                            string Stelefone = Console.ReadLine();

                            Console.Write(" > Introduza o email do cliente: ");
                            string Semail = Console.ReadLine();

                            Console.Write(" > Introduza o contribuinte do cliente: ");
                            string Scontribuinte = Console.ReadLine();

                            bool passed;
                            int Itelefone;

                            do
                            {
                                passed = int.TryParse(Stelefone, out Itelefone);
                                
                                if (!passed)
                                {
                                    Console.WriteLine("Formato do telefone errado! Insira novamente...");
                                }
                            }
                            while (!passed);

                            if (passed)
                            {
                                clientes.Adiciona(Snome, Smorada, Scodigo_postal, Slocalidade, Itelefone, Semail, Scontribuinte);

                                Console.WriteLine($"Cliente inserido na coleção com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Impossível adicionar o cliente. Operação cancelada.");
                            }
                            break;
                        }

                    case "06":
                        {
                            //trabalho final começa aqui
                            int contagem = clientes.Contagem();

                            if (clientes.Contagem() == 0)
                            {
                                Console.WriteLine("Não existem clientes na coleção!");
                                break;
                            }

                            Console.WriteLine("Qual o número do cliente que deseja eliminar?");
                            int indice = int.Parse(Console.ReadLine());

                            clientes.Elimina(indice);

                            break;
                        }

                    case "07":
                        {
                            break;
                        }

                    case "08":
                        {
                            break;
                        }

                    case "09":
                        {
                            break;
                        }

                    case "10":
                        {
                            break;
                        }

                    case "11":
                        {
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
            while (!OpcaoMenu.Equals("11"));

            //return 0;
        }

        private static string Menu(){
            Console.WriteLine("------------------------------------------- Opções --------------------------------------------");
            Console.WriteLine("00 - Sair do programa");
            Console.WriteLine("01 - Listar todos os Clientes Ativos, indicando: Número de Cliente, Nome, Número de Contribuinte e Saldo Disponível");
            Console.WriteLine("02 - Listar os Clientes Ativos com saldo disponível, indicando: Número de Cliente, Nome, o valor do Saldo Disponível e Data/Hora deValidade do Saldo Disponível");
            Console.WriteLine("03 - Listar os Clientes Ativos com data de validade expirada, indicando: Número de Cliente, Nome, o valor do Saldo Disponível e há quanto tempo o saldo expirou");
            Console.WriteLine("04 - Listar todos os dados de um único cliente, indicando: Número de Cliente, Nome, Morada, Código Postal, Localidade,Telefone, E-mail, Número de Contribuinte, Saldo Disponível e a Data/Hora deValidade do Saldo Disponível");
            Console.WriteLine("05 - Adicionar um novo Cliente");
            Console.WriteLine("06 - Eliminar um Cliente (torná-lo inativo)");
            Console.WriteLine("07 - Modificar os dados de um Cliente (preferencialmente, especificar que dado se pretende modificar)");
            Console.WriteLine("08 - Listar os carregamentos de um Cliente, indicando: Número de Cliente, Nome, Data/Hora do Movimento eValor do Movimento");
            Console.WriteLine("09 - Listar os consumos de um Cliente, indicando: Número de Cliente, Nome, Data/Hora do Movimento eValor do Movimento");
            Console.WriteLine("10 - Adicionar um consumo (viagem) de um cliente, indicando o valor gasto e a Data/Hora do Movimento");
            Console.WriteLine("11 - Adicionar um carregamento de um cliente, indicando o valor e a Data/Hora do Movimento");
            Console.Write("\nInsira a sua opção: ");

            string Opcao = Console.ReadLine();

            return Opcao;
        }
    }

}
