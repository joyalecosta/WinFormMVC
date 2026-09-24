using System;
using System.ComponentModel;
using System.Windows.Forms;
using MVC_Controller;
using MVC_Model;

namespace MVC_View
{
    public partial class FuncionariosView : Form, IUsersView
    {
        private FuncionariosController _controller;

        public FuncionariosView()
        {
            InitializeComponent();
        }

        #region Eventos

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _controller.AddNewUser();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _controller.RemoveFuncionario();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            _controller.Salvar();
        }

        private void grdUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (grdFuncionarios.SelectedItems.Count > 0)
            {
                string selectedId =
                    grdFuncionarios.SelectedItems[0].Text;

                _controller.SelectedUserChanged(selectedId);
            }
        }

        #endregion

        #region IUsersView

        public void SetController(FuncionariosController controller)
        {
            _controller = controller;
        }

        public void ClearGrid()
        {
            grdFuncionarios.Items.Clear();
        }

        public void AddUserToGrid(Funcionario usr)
        {
            ListViewItem parent;

            parent = grdFuncionarios.Items.Add(usr.ID);

            parent.SubItems.Add(usr.Nome);
            parent.SubItems.Add(usr.Sobrenome);
            parent.SubItems.Add(usr.Departamento);

            parent.SubItems.Add(
                Enum.GetName(
                    typeof(Funcionario.SexoPessoa),
                    usr.Sexo
                )
            );
        }

        public void UpdateGridWithChangedUser(Funcionario usr)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in grdFuncionarios.Items)
            {
                if (row.Text == usr.ID)
                {
                    rowToUpdate = row;
                    break;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = usr.ID;
                rowToUpdate.SubItems[1].Text = usr.Nome;
                rowToUpdate.SubItems[2].Text = usr.Sobrenome;
                rowToUpdate.SubItems[3].Text = usr.Departamento;

                rowToUpdate.SubItems[4].Text =
                    Enum.GetName(
                        typeof(Funcionario.SexoPessoa),
                        usr.Sexo
                    );
            }
        }

        public void RemoveUserFromGrid(Funcionario usr)
        {
            ListViewItem rowToRemove = null;

            foreach (ListViewItem row in grdFuncionarios.Items)
            {
                if (row.Text == usr.ID)
                {
                    rowToRemove = row;
                    break;
                }
            }

            if (rowToRemove != null)
            {
                grdFuncionarios.Items.Remove(rowToRemove);
                grdFuncionarios.Focus();
            }
        }

        public string GetIdOfSelectedUserInGrid()
        {
            if (grdFuncionarios.SelectedItems.Count > 0)
            {
                return grdFuncionarios.SelectedItems[0].Text;
            }

            return "";
        }

        public void SetSelectedUserInGrid(Funcionario usr)
        {
            foreach (ListViewItem row in grdFuncionarios.Items)
            {
                if (row.Text == usr.ID)
                {
                    if (!row.Selected)
                    {
                        row.Selected = true;
                    }

                    row.Focused = true;
                    row.EnsureVisible();
                    break;
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Nome
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Sobrenome
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FuncionarioID
        {
            get { return txtID.Text; }
            set { txtID.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Departamento
        {
            get { return txtDepartamento.Text; }
            set { txtDepartamento.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Funcionario.SexoPessoa Sexo
        {
            get
            {
                if (rdMale.Checked)
                    return Funcionario.SexoPessoa.M;

                return Funcionario.SexoPessoa.F;
            }

            set
            {
                if (value == Funcionario.SexoPessoa.M)
                    rdMale.Checked = true;
                else
                    rdFemale.Checked = true;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool CanModifyID
        {
            set { txtID.Enabled = value; }
        }

        #endregion
    }
}