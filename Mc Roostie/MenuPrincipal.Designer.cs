namespace Mc_Roostie
{
    partial class MenuPrincipal
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnMenuAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(163, 254);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCerrar.Size = new System.Drawing.Size(166, 43);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Location = new System.Drawing.Point(246, 35);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(237, 181);
            this.btnVenta.TabIndex = 1;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.UseWaitCursor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnMenuAdmin
            // 
            this.btnMenuAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAdmin.Location = new System.Drawing.Point(12, 35);
            this.btnMenuAdmin.Name = "btnMenuAdmin";
            this.btnMenuAdmin.Size = new System.Drawing.Size(228, 181);
            this.btnMenuAdmin.TabIndex = 2;
            this.btnMenuAdmin.Text = "Menu Administrador";
            this.btnMenuAdmin.UseVisualStyleBackColor = true;
            this.btnMenuAdmin.Click += new System.EventHandler(this.btnMenuAdmin_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 319);
            this.ControlBox = false;
            this.Controls.Add(this.btnMenuAdmin);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnCerrar);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnMenuAdmin;
    }
}