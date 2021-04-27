namespace Mc_Roostie
{
    partial class FormShowPromo
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.GVAllPromo = new System.Windows.Forms.DataGridView();
            this.btnEditPromotail = new System.Windows.Forms.Button();
            this.btnEditPromo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CkBxIsActive = new System.Windows.Forms.CheckBox();
            this.lblIdPromo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiaPromo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVAllPromo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrarSesion.Location = new System.Drawing.Point(732, 415);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(95, 23);
            this.btnCerrarSesion.TabIndex = 34;
            this.btnCerrarSesion.Text = "Cerrar";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // GVAllPromo
            // 
            this.GVAllPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVAllPromo.Location = new System.Drawing.Point(12, 12);
            this.GVAllPromo.Name = "GVAllPromo";
            this.GVAllPromo.Size = new System.Drawing.Size(815, 223);
            this.GVAllPromo.TabIndex = 33;
            this.GVAllPromo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVAllPromo_CellContentDoubleClick);
            // 
            // btnEditPromotail
            // 
            this.btnEditPromotail.BackColor = System.Drawing.Color.PaleGreen;
            this.btnEditPromotail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditPromotail.Location = new System.Drawing.Point(12, 278);
            this.btnEditPromotail.Name = "btnEditPromotail";
            this.btnEditPromotail.Size = new System.Drawing.Size(196, 23);
            this.btnEditPromotail.TabIndex = 35;
            this.btnEditPromotail.Text = "Editar productos de la Promocion";
            this.btnEditPromotail.UseVisualStyleBackColor = false;
            this.btnEditPromotail.Click += new System.EventHandler(this.btnEditPromotail_Click);
            // 
            // btnEditPromo
            // 
            this.btnEditPromo.Location = new System.Drawing.Point(12, 400);
            this.btnEditPromo.Name = "btnEditPromo";
            this.btnEditPromo.Size = new System.Drawing.Size(181, 23);
            this.btnEditPromo.TabIndex = 36;
            this.btnEditPromo.Text = "Actualizar  Promocion";
            this.btnEditPromo.UseVisualStyleBackColor = true;
            this.btnEditPromo.Click += new System.EventHandler(this.btnEditPromo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Precio";
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(329, 347);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(170, 20);
            this.txbPrice.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Dia de Promo";
            // 
            // CkBxIsActive
            // 
            this.CkBxIsActive.AutoSize = true;
            this.CkBxIsActive.Location = new System.Drawing.Point(542, 350);
            this.CkBxIsActive.Name = "CkBxIsActive";
            this.CkBxIsActive.Size = new System.Drawing.Size(115, 17);
            this.CkBxIsActive.TabIndex = 49;
            this.CkBxIsActive.Text = "Promocion Activa?";
            this.CkBxIsActive.UseVisualStyleBackColor = true;
            // 
            // lblIdPromo
            // 
            this.lblIdPromo.AutoSize = true;
            this.lblIdPromo.Location = new System.Drawing.Point(12, 350);
            this.lblIdPromo.Name = "lblIdPromo";
            this.lblIdPromo.Size = new System.Drawing.Size(13, 13);
            this.lblIdPromo.TabIndex = 50;
            this.lblIdPromo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Identificador Promo";
            // 
            // lblDiaPromo
            // 
            this.lblDiaPromo.AutoSize = true;
            this.lblDiaPromo.Location = new System.Drawing.Point(157, 350);
            this.lblDiaPromo.Name = "lblDiaPromo";
            this.lblDiaPromo.Size = new System.Drawing.Size(13, 13);
            this.lblDiaPromo.TabIndex = 52;
            this.lblDiaPromo.Text = "0";
            // 
            // FormShowPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblDiaPromo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIdPromo);
            this.Controls.Add(this.CkBxIsActive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditPromo);
            this.Controls.Add(this.btnEditPromotail);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.GVAllPromo);
            this.Name = "FormShowPromo";
            this.Text = "FormShowPromo";
            ((System.ComponentModel.ISupportInitialize)(this.GVAllPromo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.DataGridView GVAllPromo;
        private System.Windows.Forms.Button btnEditPromotail;
        private System.Windows.Forms.Button btnEditPromo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CkBxIsActive;
        private System.Windows.Forms.Label lblIdPromo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDiaPromo;
    }
}