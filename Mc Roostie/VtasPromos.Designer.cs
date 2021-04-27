namespace Mc_Roostie
{
    partial class VtasPromos
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
            this.gvDetailPromocion = new System.Windows.Forms.DataGridView();
            this.LblNombrePromocion = new System.Windows.Forms.Label();
            this.lblCostoPromo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbQtyPromo = new System.Windows.Forms.TextBox();
            this.btnLessPromo = new System.Windows.Forms.Button();
            this.btnMorePromo = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetailPromocion)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDetailPromocion
            // 
            this.gvDetailPromocion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetailPromocion.Location = new System.Drawing.Point(22, 164);
            this.gvDetailPromocion.Name = "gvDetailPromocion";
            this.gvDetailPromocion.Size = new System.Drawing.Size(678, 211);
            this.gvDetailPromocion.TabIndex = 2;
            // 
            // LblNombrePromocion
            // 
            this.LblNombrePromocion.AutoSize = true;
            this.LblNombrePromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombrePromocion.Location = new System.Drawing.Point(36, 51);
            this.LblNombrePromocion.Name = "LblNombrePromocion";
            this.LblNombrePromocion.Size = new System.Drawing.Size(310, 39);
            this.LblNombrePromocion.TabIndex = 3;
            this.LblNombrePromocion.Text = "Nombre Promocion";
            // 
            // lblCostoPromo
            // 
            this.lblCostoPromo.AutoSize = true;
            this.lblCostoPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoPromo.Location = new System.Drawing.Point(313, 51);
            this.lblCostoPromo.Name = "lblCostoPromo";
            this.lblCostoPromo.Size = new System.Drawing.Size(278, 39);
            this.lblCostoPromo.TabIndex = 4;
            this.lblCostoPromo.Text = "Costo Promocion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Detalle Promocion";
            // 
            // txbQtyPromo
            // 
            this.txbQtyPromo.Enabled = false;
            this.txbQtyPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQtyPromo.Location = new System.Drawing.Point(181, 478);
            this.txbQtyPromo.Name = "txbQtyPromo";
            this.txbQtyPromo.Size = new System.Drawing.Size(100, 38);
            this.txbQtyPromo.TabIndex = 71;
            // 
            // btnLessPromo
            // 
            this.btnLessPromo.BackColor = System.Drawing.Color.Red;
            this.btnLessPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessPromo.Location = new System.Drawing.Point(67, 448);
            this.btnLessPromo.Name = "btnLessPromo";
            this.btnLessPromo.Size = new System.Drawing.Size(93, 85);
            this.btnLessPromo.TabIndex = 70;
            this.btnLessPromo.Text = "-";
            this.btnLessPromo.UseVisualStyleBackColor = false;
            this.btnLessPromo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMorePromo
            // 
            this.btnMorePromo.BackColor = System.Drawing.Color.Lime;
            this.btnMorePromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMorePromo.Location = new System.Drawing.Point(304, 448);
            this.btnMorePromo.Name = "btnMorePromo";
            this.btnMorePromo.Size = new System.Drawing.Size(93, 85);
            this.btnMorePromo.TabIndex = 69;
            this.btnMorePromo.Text = "+";
            this.btnMorePromo.UseVisualStyleBackColor = false;
            this.btnMorePromo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.Yellow;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(470, 405);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(230, 150);
            this.btnAddItems.TabIndex = 83;
            this.btnAddItems.Text = "ACEPTAR";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btn_Click);
            // 
            // VtasPromos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 567);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.txbQtyPromo);
            this.Controls.Add(this.btnLessPromo);
            this.Controls.Add(this.btnMorePromo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCostoPromo);
            this.Controls.Add(this.LblNombrePromocion);
            this.Controls.Add(this.gvDetailPromocion);
            this.Name = "VtasPromos";
            this.Text = "VtasPromos";
            ((System.ComponentModel.ISupportInitialize)(this.gvDetailPromocion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvDetailPromocion;
        private System.Windows.Forms.Label LblNombrePromocion;
        private System.Windows.Forms.Label lblCostoPromo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbQtyPromo;
        private System.Windows.Forms.Button btnLessPromo;
        private System.Windows.Forms.Button btnMorePromo;
        private System.Windows.Forms.Button btnAddItems;
    }
}