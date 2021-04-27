namespace Mc_Roostie
{
    partial class VentasCarnitas
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
            this.btnAddItems = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbCash = new System.Windows.Forms.TextBox();
            this.txbWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKiloPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.Yellow;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(159, 240);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(230, 150);
            this.btnAddItems.TabIndex = 84;
            this.btnAddItems.Text = "ACEPTAR";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mc_Roostie.Properties.Resources.pig;
            this.pictureBox2.InitialImage = global::Mc_Roostie.Properties.Resources.pollo;
            this.pictureBox2.Location = new System.Drawing.Point(526, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // txbCash
            // 
            this.txbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCash.Location = new System.Drawing.Point(81, 144);
            this.txbCash.Name = "txbCash";
            this.txbCash.Size = new System.Drawing.Size(156, 38);
            this.txbCash.TabIndex = 85;
            this.txbCash.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbCash_KeyUp);
            // 
            // txbWeight
            // 
            this.txbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbWeight.Location = new System.Drawing.Point(308, 144);
            this.txbWeight.Name = "txbWeight";
            this.txbWeight.Size = new System.Drawing.Size(152, 38);
            this.txbWeight.TabIndex = 86;
            this.txbWeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbWeight_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 87;
            this.label1.Text = "Dinero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 88;
            this.label2.Text = "Kilos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 29);
            this.label3.TabIndex = 89;
            this.label3.Text = "Precio Carnitas por Kilo";
            // 
            // lblKiloPrice
            // 
            this.lblKiloPrice.AutoSize = true;
            this.lblKiloPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKiloPrice.Location = new System.Drawing.Point(301, 18);
            this.lblKiloPrice.Name = "lblKiloPrice";
            this.lblKiloPrice.Size = new System.Drawing.Size(0, 39);
            this.lblKiloPrice.TabIndex = 91;
            // 
            // VentasCarnitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 401);
            this.ControlBox = false;
            this.Controls.Add(this.lblKiloPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbWeight);
            this.Controls.Add(this.txbCash);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.pictureBox2);
            this.Name = "VentasCarnitas";
            this.Text = "VentasCarnitas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txbCash;
        private System.Windows.Forms.TextBox txbWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKiloPrice;
    }
}