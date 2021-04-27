namespace Mc_Roostie
{
    partial class FormItems
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
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.txbField1 = new System.Windows.Forms.TextBox();
            this.txbField2 = new System.Windows.Forms.TextBox();
            this.txbItemCode = new System.Windows.Forms.TextBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.GVAllItems = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txbField3 = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GVAllItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(232, 415);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(181, 23);
            this.btnEditItem.TabIndex = 28;
            this.btnEditItem.Text = "Editar";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(26, 415);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(181, 23);
            this.btnAddItem.TabIndex = 27;
            this.btnAddItem.Text = "Agregar";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Extra 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Extra1";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(163, 286);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 22;
            this.lblUserName.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Codigo de Producto";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(166, 305);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(247, 20);
            this.txbDescription.TabIndex = 20;
            // 
            // txbField1
            // 
            this.txbField1.Location = new System.Drawing.Point(419, 305);
            this.txbField1.Name = "txbField1";
            this.txbField1.Size = new System.Drawing.Size(77, 20);
            this.txbField1.TabIndex = 19;
            // 
            // txbField2
            // 
            this.txbField2.Location = new System.Drawing.Point(502, 305);
            this.txbField2.Name = "txbField2";
            this.txbField2.Size = new System.Drawing.Size(77, 20);
            this.txbField2.TabIndex = 18;
            // 
            // txbItemCode
            // 
            this.txbItemCode.Location = new System.Drawing.Point(23, 305);
            this.txbItemCode.Name = "txbItemCode";
            this.txbItemCode.Size = new System.Drawing.Size(134, 20);
            this.txbItemCode.TabIndex = 17;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrarSesion.Location = new System.Drawing.Point(743, 415);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(95, 23);
            this.btnCerrarSesion.TabIndex = 16;
            this.btnCerrarSesion.Text = "Cerrar";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // GVAllItems
            // 
            this.GVAllItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVAllItems.Location = new System.Drawing.Point(23, 12);
            this.GVAllItems.Name = "GVAllItems";
            this.GVAllItems.Size = new System.Drawing.Size(815, 223);
            this.GVAllItems.TabIndex = 15;
            this.GVAllItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVAllItems_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Extra 3";
            // 
            // txbField3
            // 
            this.txbField3.Location = new System.Drawing.Point(585, 305);
            this.txbField3.Name = "txbField3";
            this.txbField3.Size = new System.Drawing.Size(77, 20);
            this.txbField3.TabIndex = 29;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(668, 305);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(170, 20);
            this.txbPrice.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Precio";
            // 
            // FormItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrarSesion;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbField3);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbField1);
            this.Controls.Add(this.txbField2);
            this.Controls.Add(this.txbItemCode);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.GVAllItems);
            this.Name = "FormItems";
            this.Text = "FormItems";
            ((System.ComponentModel.ISupportInitialize)(this.GVAllItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.TextBox txbField1;
        private System.Windows.Forms.TextBox txbField2;
        private System.Windows.Forms.TextBox txbItemCode;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.DataGridView GVAllItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbField3;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label5;
    }
}