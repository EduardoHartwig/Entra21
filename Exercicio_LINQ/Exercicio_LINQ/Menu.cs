using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_LINQ
{
    class Menu
    {
        enum MenuPrincipal
        {
            Sair,
            Cadastrar,
            Atualizar,
            Remover,
        }
        enum Cadastrar
        {
            Sair,
            CadastrarCaminhao,
            CadastrarMotoristra,
            CadastrarViagem,
        }
        enum Atualizar
        {
            Sair,
            AtualizarMotorista,
            AtualizarCaminhao,
            AtualizarViagem,
        }
        enum Remover
        {

        }

        public static void MostrarMenu()
        {

        }
    }
}
