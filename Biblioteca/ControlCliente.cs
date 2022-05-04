using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class ControlCliente
    {
        Cliente cliente;//Conectando a model e a control
        private int opcao;
        public ControlCliente()
        {
            cliente = new Cliente();
        }//fim do construtor

        public int AcessarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }//fim do acessarOpcao
        public void Menu()
        {
            Console.Clear();//Limpar a tela do console
            Console.WriteLine("\n\nEscolha uma das opções abaixo:\n\n" +
                               "1. Cadastrar\n" +
                               "2. Consultar\n" + 
                               "3. Atualizar Nome\n" +
                               "4. Atualizar Telefone\n" +
                               "5. Atualizar Endereço\n" +
                               "6. Excluir\n"   +
                               "0. Sair");
            AcessarOpcao = Convert.ToInt32(Console.ReadLine());
        }//fim do método menu

        public void Executar()
        {
            do { 
            Menu();
                //Executar a ação
                switch (AcessarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        //Coletando o dado
                        Console.WriteLine("Informe um código: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe um telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe um endereço: ");
                        string endereco = Console.ReadLine();
                        //Passei o dado por parâmetro para o método
                        cliente.Cadastrar(codigo, nome, telefone, endereco);
                        //Mostro o dado em tela
                        Console.WriteLine("Cadastrado com Sucesso!");
                        break;
                    case 2:
                        //Pedir para o usuário digitar um código
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado da operação
                        Console.WriteLine(cliente.Consultar(codigo));
                        Console.ReadLine();//Manter o prompt aberto
                        break;
                    case 3:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um nome: ");
                        nome = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarNome(codigo, nome));
                        break;
                    case 4:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um telefone: ");
                        telefone = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarTelefone(codigo, telefone));
                        break;
                    case 5:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe um Endereço: ");
                        endereco = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarEndereco(codigo, endereco));
                        break;
                    case 6:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        //Utiliza o método
                        Console.WriteLine(cliente.Excluir(codigo));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida! Tente novamente!");
                        break;
                }//fim do switch
            } while (AcessarOpcao != 0);
        }//fim do executar
    }//fim da control
}//fim do projeto
