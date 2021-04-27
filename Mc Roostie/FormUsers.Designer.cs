namespace Mc_Roostie
{
    partial class FormUsers
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
            this.GVAllUsers = new System.Windows.Forms.DataGridView();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.txbCompleteName = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxProfile = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // GVAllUsers
            // 
            this.GVAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVAllUsers.Location = new System.Drawing.Point(12, 12);
            this.GVAllUsers.Name = "GVAllUsers";
            this.GVAllUsers.Size = new System.Drawing.Size(815, 223);
            this.GVAllUsers.TabIndex = 0;
            this.GVAllUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVAllUsers_CellContentClick);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(732, 415);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(95, 23);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // txbCompleteName
            // 
            this.txbCompleteName.Location = new System.Drawing.Point(12, 305);
            this.txbCompleteName.Name = "txbCompleteName";
            this.txbCompleteName.Size = new System.Drawing.Size(226, 20);
            this.txbCompleteName.TabIndex = 2;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(558, 305);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(143, 20);
            this.tbxEmail.TabIndex = 3;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(408, 305);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(144, 20);
            this.txbPassword.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(244, 305);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre Completo";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(244, 286);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(98, 13);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Elige el Perfil";
            // 
            // cbxProfile
            // 
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cbxProfile.Location = new System.Drawing.Point(706, 305);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(121, 21);
            this.cbxProfile.TabIndex = 12;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(15, 415);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(181, 23);
            this.btnAddUser.TabIndex = 13;
            this.btnAddUser.Text = "Agregar";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(221, 415);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(181, 23);
            this.btnEditUser.TabIndex = 14;
            this.btnEditUser.Text = "Editar";
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.cbxProfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.txbCompleteName);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.GVAllUsers);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVAllUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVAllUsers;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.TextBox txbCompleteName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProfile;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
    }
}