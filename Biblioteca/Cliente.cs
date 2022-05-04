using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Cliente
    {
        //Declarar as variáveis
        private int codigo;
        private string nomeCompleto;
        private string telefone;
        private string endereco;

        public Cliente()
        {
            //Instanciando as variáveis 
            AcessarCodigo     = 0;
            AcessarNome       = "";
            AcessarTelefone   = "";
            AcessarEndereco   = "";
        }//fim do método construtor

        //Desenvolver os métodos gets e sets
        public int AcessarCodigo
        {
            get
            {
                return codigo;
            }
            set
            {
                this.codigo = value;
            }
        }//fim do método de acesso de código

        public string AcessarNome
        {
            get
            {
                return nomeCompleto;
            }
            set
            {
                this.nomeCompleto = value;
            }
        }//fim do acessarNome

        public string AcessarTelefone
        {
            get
            {
                return telefone;
            }
            set
            {
                this.telefone = value;
            }
        }//fim do acessarTelefone

        public string AcessarEndereco
        {
            get
            {
                return endereco;
            }
            set
            {
                this.endereco = value;
            }
        }//fim do acessarEndereco

        public void Cadastrar(int codigo, string nome, 
                              string telefone, string endereco)
        {
            AcessarCodigo = codigo;
            AcessarNome = nome;
            AcessarTelefone = telefone;
            AcessarEndereco = endereco;
        }//fim do método cadastrar

        public string Consultar(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                return "Código: " + AcessarCodigo +
                       "\nNome Completo: " + AcessarNome +
                       "\nTelefone: " + AcessarTelefone +
                       "\nEndereço: " + AcessarEndereco;
            }
            else
            {
                return "Código Informado Não é Valido!";
            }
        }//fim do método consultar

        public string AtualizarNome(int codigo, string nome)
        {
            if(AcessarCodigo == codigo)
            {
                AcessarNome = nome;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método atualizarNome

        public string AtualizarTelefone(int codigo, string telefone)
        {
            if(AcessarCodigo == codigo)
            {
                AcessarTelefone = telefone;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }
        }//fim do método atualizar telefone

        public string AtualizarEndereco(int codigo, string endereco)
        {
            if(AcessarCodigo == codigo)
            {
                AcessarEndereco = endereco;
                return "Endereço atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do método Atualizar Endereço

        public string Excluir(int codigo)
        {
            if(AcessarCodigo == codigo)
            {
                AcessarCodigo = 0;
                AcessarNome = "";
                AcessarTelefone = "";
                AcessarEndereco = "";
                return "Dados excluídos com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do excluir




    }//fim classe
}//fim do projeto
