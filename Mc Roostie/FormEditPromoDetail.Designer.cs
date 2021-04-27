namespace Mc_Roostie
{
    partial class FormEditPromoDetail
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
            this.GVAllPromoDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIdPromotionDetail = new System.Windows.Forms.Label();
            this.btnDeleteDetailPromo = new System.Windows.Forms.Button();
            this.btnAddItemPromo = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVAllPromoDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // GVAllPromoDetail
            // 
            this.GVAllPromoDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVAllPromoDetail.Location = new System.Drawing.Point(23, 32);
            this.GVAllPromoDetail.Name = "GVAllPromoDetail";
            this.GVAllPromoDetail.Size = new System.Drawing.Size(815, 223);
            this.GVAllPromoDetail.TabIndex = 34;
            this.GVAllPromoDetail.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVAllPromoDetail_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Descripcion del producto";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(163, 330);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 36;
            this.lblDescription.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Identificador";
            // 
            // lblIdPromotionDetail
            // 
            this.lblIdPromotionDetail.AutoSize = true;
            this.lblIdPromotionDetail.Location = new System.Drawing.Point(23, 330);
            this.lblIdPromotionDetail.Name = "lblIdPromotionDetail";
            this.lblIdPromotionDetail.Size = new System.Drawing.Size(13, 13);
            this.lblIdPromotionDetail.TabIndex = 38;
            this.lblIdPromotionDetail.Text = "0";
            // 
            // btnDeleteDetailPromo
            // 
            this.btnDeleteDetailPromo.Location = new System.Drawing.Point(311, 319);
            this.btnDeleteDetailPromo.Name = "btnDeleteDetailPromo";
            this.btnDeleteDetailPromo.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteDetailPromo.TabIndex = 39;
            this.btnDeleteDetailPromo.Text = "Eliminar de Promocion";
            this.btnDeleteDetailPromo.UseVisualStyleBackColor = true;
            this.btnDeleteDetailPromo.Click += new System.EventHandler(this.btnDeleteDetailPromo_Click);
            // 
            // btnAddItemPromo
            // 
            this.btnAddItemPromo.Location = new System.Drawing.Point(702, 310);
            this.btnAddItemPromo.Name = "btnAddItemPromo";
            this.btnAddItemPromo.Size = new System.Drawing.Size(136, 41);
            this.btnAddItemPromo.TabIndex = 40;
            this.btnAddItemPromo.Text = "Agregar Producto a Promocion";
            this.btnAddItemPromo.UseVisualStyleBackColor = true;
            this.btnAddItemPromo.Click += new System.EventHandler(this.btnAddItemPromo_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(763, 415);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarSesion.TabIndex = 41;
            this.btnCerrarSesion.Text = "Cerrar";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // FormEditPromoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnAddItemPromo);
            this.Controls.Add(this.btnDeleteDetailPromo);
            this.Controls.Add(this.lblIdPromotionDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GVAllPromoDetail);
            this.Name = "FormEditPromoDetail";
            this.Text = "FormEditPromoDetail";
            ((System.ComponentModel.ISupportInitialize)(this.GVAllPromoDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVAllPromoDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdPromotionDetail;
        private System.Windows.Forms.Button btnDeleteDetailPromo;
        private System.Windows.Forms.Button btnAddItemPromo;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}