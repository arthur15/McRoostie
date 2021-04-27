namespace Mc_Roostie
{
    partial class VentasExtras
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
            this.gvDetalle = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLessTaco = new System.Windows.Forms.Button();
            this.btnMoreTaco = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTaco = new System.Windows.Forms.Label();
            this.lblTacoPo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLessTacoPo = new System.Windows.Forms.Button();
            this.btnMoreTacoPo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.Yellow;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(586, 385);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(230, 150);
            this.btnAddItems.TabIndex = 97;
            this.btnAddItems.Text = "ACEPTAR";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btn_Click);
            // 
            // gvDetalle
            // 
            this.gvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetalle.Location = new System.Drawing.Point(35, 385);
            this.gvDetalle.Name = "gvDetalle";
            this.gvDetalle.Size = new System.Drawing.Size(502, 150);
            this.gvDetalle.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 29);
            this.label6.TabIndex = 89;
            this.label6.Text = "Taco de Carnitas";
            // 
            // btnLessTaco
            // 
            this.btnLessTaco.BackColor = System.Drawing.Color.Red;
            this.btnLessTaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessTaco.Location = new System.Drawing.Point(230, 36);
            this.btnLessTaco.Name = "btnLessTaco";
            this.btnLessTaco.Size = new System.Drawing.Size(93, 85);
            this.btnLessTaco.TabIndex = 87;
            this.btnLessTaco.Text = "-";
            this.btnLessTaco.UseVisualStyleBackColor = false;
            this.btnLessTaco.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMoreTaco
            // 
            this.btnMoreTaco.BackColor = System.Drawing.Color.Lime;
            this.btnMoreTaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreTaco.Location = new System.Drawing.Point(413, 36);
            this.btnMoreTaco.Name = "btnMoreTaco";
            this.btnMoreTaco.Size = new System.Drawing.Size(93, 85);
            this.btnMoreTaco.TabIndex = 86;
            this.btnMoreTaco.Text = "+";
            this.btnMoreTaco.UseVisualStyleBackColor = false;
            this.btnMoreTaco.Click += new System.EventHandler(this.btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mc_Roostie.Properties.Resources.taco;
            this.pictureBox2.InitialImage = global::Mc_Roostie.Properties.Resources.pollo;
            this.pictureBox2.Location = new System.Drawing.Point(586, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // lblTaco
            // 
            this.lblTaco.AutoSize = true;
            this.lblTaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaco.Location = new System.Drawing.Point(356, 62);
            this.lblTaco.Name = "lblTaco";
            this.lblTaco.Size = new System.Drawing.Size(26, 29);
            this.lblTaco.TabIndex = 98;
            this.lblTaco.Text = "0";
            // 
            // lblTacoPo
            // 
            this.lblTacoPo.AutoSize = true;
            this.lblTacoPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacoPo.Location = new System.Drawing.Point(356, 179);
            this.lblTacoPo.Name = "lblTacoPo";
            this.lblTacoPo.Size = new System.Drawing.Size(26, 29);
            this.lblTacoPo.TabIndex = 102;
            this.lblTacoPo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 101;
            this.label2.Text = "Taco de Pollo";
            // 
            // btnLessTacoPo
            // 
            this.btnLessTacoPo.BackColor = System.Drawing.Color.Red;
            this.btnLessTacoPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLessTacoPo.Location = new System.Drawing.Point(230, 153);
            this.btnLessTacoPo.Name = "btnLessTacoPo";
            this.btnLessTacoPo.Size = new System.Drawing.Size(93, 85);
            this.btnLessTacoPo.TabIndex = 100;
            this.btnLessTacoPo.Text = "-";
            this.btnLessTacoPo.UseVisualStyleBackColor = false;
            this.btnLessTacoPo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMoreTacoPo
            // 
            this.btnMoreTacoPo.BackColor = System.Drawing.Color.Lime;
            this.btnMoreTacoPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreTacoPo.Location = new System.Drawing.Point(413, 153);
            this.btnMoreTacoPo.Name = "btnMoreTacoPo";
            this.btnMoreTacoPo.Size = new System.Drawing.Size(93, 85);
            this.btnMoreTacoPo.TabIndex = 99;
            this.btnMoreTacoPo.Text = "+";
            this.btnMoreTacoPo.UseVisualStyleBackColor = false;
            this.btnMoreTacoPo.Click += new System.EventHandler(this.btn_Click);
            // 
            // VentasExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 551);
            this.ControlBox = false;
            this.Controls.Add(this.lblTacoPo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLessTacoPo);
            this.Controls.Add(this.btnMoreTacoPo);
            this.Controls.Add(this.lblTaco);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.gvDetalle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLessTaco);
            this.Controls.Add(this.btnMoreTaco);
            this.Name = "VentasExtras";
            this.Text = "VentasExtras";
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.DataGridView gvDetalle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLessTaco;
        private System.Windows.Forms.Button btnMoreTaco;
        private System.Windows.Forms.Label lblTaco;
        private System.Windows.Forms.Label lblTacoPo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLessTacoPo;
        private System.Windows.Forms.Button btnMoreTacoPo;
    }
}