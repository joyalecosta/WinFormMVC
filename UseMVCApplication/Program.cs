using System;
using System.Collections;
using System.Windows.Forms;
using MVC_Model;
using MVC_Controller;
using MVC_View;

namespace UseMVCApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Cria a lista de funcionários
            IList funcionarios = new ArrayList();

            // Funcionários iniciais para teste
            funcionarios.Add(
                new Funcionario(
                    "João",
                    "Silva",
                    "001",
                    "TI",
                    Funcionario.SexoPessoa.M
                )
            );

            funcionarios.Add(
                new Funcionario(
                    "Maria",
                    "Santos",
                    "002",
                    "Recursos Humanos",
                    Funcionario.SexoPessoa.F
                )
            );

            funcionarios.Add(
                new Funcionario(
                    "Carlos",
                    "Oliveira",
                    "003",
                    "Financeiro",
                    Funcionario.SexoPessoa.M
                )
            );

            // Cria a View
            FuncionariosView view = new FuncionariosView();

            // Cria o Controller e conecta Model + View
            FuncionariosController controller =
                new FuncionariosController(view, funcionarios);

            // Carrega os funcionários na tela
            controller.LoadView();

            // Inicia o Windows Forms
            Application.Run(view);
        }
    }
}