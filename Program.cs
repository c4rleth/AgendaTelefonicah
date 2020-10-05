using System;

namespace ListaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLista lista = new CircularLista();
            int opcao = 0;

            do
            {
                Console.WriteLine("\n|-----------------------------------------------|");
                Console.WriteLine("|             LISTA CIRCULAR SIMPLES            |");
                Console.WriteLine("|-------------------|---------------------------|");
                Console.WriteLine("| 1. Inserir        |  6. Ordenar por Nome      |");
                Console.WriteLine("| 2. Atualizar      |  7. Ordenar por Email     |");
                Console.WriteLine("| 3. Procurar       |  8. Salvar em Arquivo     |");
                Console.WriteLine("| 4. Remover        |  9. Finalizar Programa    |");
                Console.WriteLine("| 5. Mostrar Agenda |  10. Navegar pela Agenda  |");
                Console.WriteLine("|-------------------|---------------------------|");
                Console.Write("Escolha uma opcao acima: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("INSERIR CONTATO NA AGENDA");
                        lista.Add();
                        break;
                    case 2: 
                        Console.WriteLine("ATUALIZAR CONTATO NA AGENDA");
                        lista.Update();
                        break;
                    case 3:
                        Console.WriteLine("PROCURAR CONTATO NA AGENDA");
                        lista.Find();
                        break;
                    case 4:
                        Console.WriteLine("REMOVER CONTATO NA AGENDA");
                        lista.Remove();
                        break;
                    case 5:
                        Console.WriteLine("MOSTRANDO AGENDA");
                        lista.PrintList();
                        break;
                    case 6: 
                        Console.WriteLine("ORDENANDO LISTA POR NOME");
                        lista.OrdenarPorNome();
                        lista.PrintList();
                        break;
                    case 7: 
                        Console.WriteLine("ORDENANDO LISTA POR EMAIL");
                        lista.OrdenarPorEmail();
                        lista.PrintList();
                        break;
                    case 8:
                       Console.WriteLine("SALVANDO AGENDA EM UM ARQUIVO"); 
                        lista.SalvarAgenda();
                       break;
                    case 9:
                       Console.WriteLine("FINALIZANDO PROGRAMA..."); 
                       break; 
                    case 10:
                        Console.WriteLine("NAVEGAR PELOS CONTATOS");
                        lista.Navigation();
                        break;

                    default:
                        Console.WriteLine("OPÇÃO NÃO VÁLIDA, TENTE NOVAMNETE."); 
                        break;
                }
               
            }while(opcao != 9);
            
        }
    }
}
