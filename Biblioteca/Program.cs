using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlCliente control = new ControlCliente();//Conectando a classe control cliente
            control.Executar();//Estou usando o método executar
            Console.ReadLine();//Manter o prompt aberto
        }//fim do método main
    }//fim da classe
}//fim do projeto
