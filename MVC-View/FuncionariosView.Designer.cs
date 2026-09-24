namespace MVC_View
{
    partial class FuncionariosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtID = new TextBox();
            txtDepartamento = new TextBox();
            groupBox2 = new GroupBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            btnAdd = new Button();
            btnRemove = new Button();
            btnRegister = new Button();
            grdFuncionarios = new ListView();
            colID = new ColumnHeader();
            colNome = new ColumnHeader();
            colSobrenome = new ColumnHeader();
            colDepartamento = new ColumnHeader();
            colSexo = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtDepartamento);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Controls.Add(txtFirstName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(664, 271);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registrar Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 44);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 109);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 44);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 103);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 3;
            label4.Text = "Departamento:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(129, 38);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(157, 31);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(129, 100);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(157, 31);
            txtLastName.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(476, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(155, 31);
            txtID.TabIndex = 6;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(476, 97);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(155, 31);
            txtDepartamento.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdFemale);
            groupBox2.Controls.Add(rdMale);
            groupBox2.Location = new Point(38, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 88);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sexo";
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Checked = true;
            rdMale.Location = new Point(59, 38);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(53, 29);
            rdMale.TabIndex = 0;
            rdMale.TabStop = true;
            rdMale.Text = "M";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(172, 38);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(46, 29);
            rdFemale.TabIndex = 1;
            rdFemale.Text = "F";
            rdFemale.UseVisualStyleBackColor = true;            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(692, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(165, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Novo Usuário";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(692, 95);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(165, 34);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remover Usuário";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(692, 231);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(165, 34);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Registrar Usuário";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // grdFuncionarios
            // 
            grdFuncionarios.Columns.AddRange(new ColumnHeader[]
                { colID,
                  colNome,
                  colSobrenome,
                  colDepartamento,
                  colSexo
                });
            grdFuncionarios.FullRowSelect = true;
            grdFuncionarios.GridLines = true;
            grdFuncionarios.Location = new Point(12, 289);
            grdFuncionarios.MultiSelect = false;
            grdFuncionarios.Name = "grdFuncionarios";
            grdFuncionarios.Size = new Size(890, 272);
            grdFuncionarios.TabIndex = 4;
            grdFuncionarios.UseCompatibleStateImageBehavior = false;
            grdFuncionarios.View = View.Details;
            grdFuncionarios.SelectedIndexChanged += grdUsers_SelectedIndexChanged;
            // 
            // ID
            // 
            colID.Text = "ID";
            colID.Width = 100;
            // 
            // Nome
            // 
            colNome.Text = "Nome";
            colNome.Width = 150;
            // 
            // Sobrenome
            // 
            colSobrenome.Text = "Sobrenome";
            colSobrenome.Width = 150;
            // 
            // Departamento
            // 
            colDepartamento.Text = "Departamento";
            colDepartamento.Width = 170;
            // 
            // Sexo
            // 
            colSexo.Text = "Sexo";
            colSexo.Width = 80;
            // 
            // FuncionariosView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 559);
            Controls.Add(grdFuncionarios);
            Controls.Add(btnRegister);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Name = "FuncionariosView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionários";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDepartamento;
        private TextBox txtID;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnRegister;
        private ListView grdFuncionarios;
        private ColumnHeader colID;
        private ColumnHeader colNome;
        private ColumnHeader colSobrenome;
        private ColumnHeader colDepartamento;
        private ColumnHeader colSexo;
    }
}