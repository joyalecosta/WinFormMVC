using System;
using System.Collections;
using MVC_Model;

namespace MVC_Controller
{
    public class FuncionariosController
    {
        IUsersView _view;
        IList _funcionarios;
        Funcionario _funcionarioSelecionado;

        public FuncionariosController(IUsersView view, IList funcionarios)
        {
            _view = view;
            _funcionarios = funcionarios;

            view.SetController(this);
        }

        public IList Users
        {
            get
            {
                return ArrayList.ReadOnly(_funcionarios);
            }
        }

        private void updateViewDetailValues(Funcionario usr)
        {
            _view.Nome = usr.Nome;
            _view.Sobrenome = usr.Sobrenome;
            _view.FuncionarioID = usr.ID;
            _view.Departamento = usr.Departamento;
            _view.Sexo = usr.Sexo;
        }

        private void updateUserWithViewValues(Funcionario usr)
        {
            usr.Nome = _view.Nome;
            usr.Sobrenome = _view.Sobrenome;
            usr.ID = _view.FuncionarioID;
            usr.Departamento = _view.Departamento;
            usr.Sexo = _view.Sexo;
        }

        public void LoadView()
        {
            _view.ClearGrid();

            foreach (Funcionario usr in _funcionarios)
            {
                _view.AddUserToGrid(usr);
            }

            _view.SetSelectedUserInGrid(
                (Funcionario)_funcionarios[0]
            );
        }

        public void SelectedUserChanged(string selectedUserId)
        {
            foreach (Funcionario usr in this._funcionarios)
            {
                if (usr.ID == selectedUserId)
                {
                    _funcionarioSelecionado = usr;

                    updateViewDetailValues(usr);

                    _view.SetSelectedUserInGrid(usr);
                    this._view.CanModifyID = false;

                    break;
                }
            }
        }

        public void AddNewUser()
        {
            _funcionarioSelecionado = new Funcionario(
                "" /*firstname*/,
                "" /*lastname*/,
                "" /*id*/,
                "" /*department*/,
                Funcionario.SexoPessoa.M /*sex*/
            );

            this.updateViewDetailValues(
                _funcionarioSelecionado
            );

            this._view.CanModifyID = true;
        }

        public void RemoveFuncionario()
        {
            string id =
                this._view.GetIdOfSelectedUserInGrid();

            Funcionario userToRemove = null;

            if (id != "")
            {
                foreach (Funcionario usr in this._funcionarios)
                {
                    if (usr.ID == id)
                    {
                        userToRemove = usr;
                        break;
                    }
                }

                if (userToRemove != null)
                {
                    int newSelectedIndex =
                        this._funcionarios.IndexOf(userToRemove);

                    this._funcionarios.Remove(userToRemove);

                    this._view.RemoveUserFromGrid(userToRemove);

                    if (newSelectedIndex > -1 &&
                        newSelectedIndex < _funcionarios.Count)
                    {
                        this._view.SetSelectedUserInGrid(
                            (Funcionario)_funcionarios[newSelectedIndex]
                        );
                    }
                }
            }
        }

        public void Salvar()
        {
            updateUserWithViewValues(
                _funcionarioSelecionado
            );

            if (!this._funcionarios.Contains(
                    _funcionarioSelecionado))
            {
                // Add new user
                this._funcionarios.Add(
                    _funcionarioSelecionado
                );

                this._view.AddUserToGrid(
                    _funcionarioSelecionado
                );
            }
            else
            {
                // Update existing
                this._view.UpdateGridWithChangedUser(
                    _funcionarioSelecionado
                );
            }

            _view.SetSelectedUserInGrid(
                _funcionarioSelecionado
            );

            this._view.CanModifyID = false;
        }
    }
}