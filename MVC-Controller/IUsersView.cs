using System;
using MVC_Model;

namespace MVC_Controller
{
    public interface IUsersView
    {
        void SetController(FuncionariosController controller);
        void ClearGrid();
        void AddUserToGrid(Funcionario user);
        void UpdateGridWithChangedUser(Funcionario user);
        void RemoveUserFromGrid(Funcionario user);
        string GetIdOfSelectedUserInGrid();
        void SetSelectedUserInGrid(Funcionario user);

        string Nome { get; set; }
        string Sobrenome { get; set; }
        string FuncionarioID { get; set; }
        string Departamento { get; set; }
        Funcionario.SexoPessoa Sexo { get; set; }
        bool CanModifyID { set; }
    }
}