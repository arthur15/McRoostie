namespace Mc_Roostie
{
    partial class Ventas
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
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvDetalle = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGetTicket = new System.Windows.Forms.Button();
            this.txbxNumTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChangeLocation = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnVtaComple = new System.Windows.Forms.Button();
            this.btnVtaTortas = new System.Windows.Forms.Button();
            this.btnVtaTostadas = new System.Windows.Forms.Button();
            this.btnVtaCarnitas = new System.Windows.Forms.Button();
            this.btnVtaPromo = new System.Windows.Forms.Button();
            this.btnVtaExtras = new System.Windows.Forms.Button();
            this.btnVtaAgua = new System.Windows.Forms.Button();
            this.btnVtaPollo = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(1284, 752);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(6);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(186, 44);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.Color.Chartreuse;
            this.txbTotal.Enabled = false;
            this.txbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(1022, 535);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(240, 68);
            this.txbTotal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1033, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOTAL A PAGAR";
            // 
            // gvDetalle
            // 
            this.gvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetalle.Location = new System.Drawing.Point(579, 15);
            this.gvDetalle.Name = "gvDetalle";
            this.gvDetalle.Size = new System.Drawing.Size(668, 359);
            this.gvDetalle.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Promocion del dia";
            // 
            // btnGetTicket
            // 
            this.btnGetTicket.BackColor = System.Drawing.Color.Yellow;
            this.btnGetTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTicket.Location = new System.Drawing.Point(579, 489);
            this.btnGetTicket.Name = "btnGetTicket";
            this.btnGetTicket.Size = new System.Drawing.Size(280, 158);
            this.btnGetTicket.TabIndex = 38;
            this.btnGetTicket.Text = "COBRAR";
            this.btnGetTicket.UseVisualStyleBackColor = false;
            this.btnGetTicket.Click += new System.EventHandler(this.btn_Click);
            // 
            // txbxNumTicket
            // 
            this.txbxNumTicket.Enabled = false;
            this.txbxNumTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxNumTicket.Location = new System.Drawing.Point(904, 471);
            this.txbxNumTicket.Name = "txbxNumTicket";
            this.txbxNumTicket.Size = new System.Drawing.Size(117, 45);
            this.txbxNumTicket.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(908, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Num Ticket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Seleccionar Pollo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Seleccionar Tacos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Seleccionar Bebidas";
            // 
            // btnChangeLocation
            // 
            this.btnChangeLocation.BackColor = System.Drawing.Color.Aquamarine;
            this.btnChangeLocation.Location = new System.Drawing.Point(596, 380);
            this.btnChangeLocation.Name = "btnChangeLocation";
            this.btnChangeLocation.Size = new System.Drawing.Size(242, 89);
            this.btnChangeLocation.TabIndex = 47;
            this.btnChangeLocation.Text = "Cambiar Lugar de Atencion";
            this.btnChangeLocation.UseVisualStyleBackColor = false;
            this.btnChangeLocation.Click += new System.EventHandler(this.btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "Seleccionar Carnitas";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.Location = new System.Drawing.Point(1068, 393);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(179, 63);
            this.btnDeleteOrder.TabIndex = 52;
            this.btnDeleteOrder.Text = "Eliminar Pedido";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 54;
            this.label8.Text = "Seleccionar Tostadas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 25);
            this.label10.TabIndex = 56;
            this.label10.Text = "Seleccionar Tortas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(301, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 25);
            this.label11.TabIndex = 58;
            this.label11.Text = "Complementos";
            // 
            // btnVtaComple
            // 
            this.btnVtaComple.BackgroundImage = global::Mc_Roostie.Properties.Resources.complementos;
            this.btnVtaComple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVtaComple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVtaComple.Location = new System.Drawing.Point(273, 541);
            this.btnVtaComple.Name = "btnVtaComple";
            this.btnVtaComple.Size = new System.Drawing.Size(195, 120);
            this.btnVtaComple.TabIndex = 57;
            this.btnVtaComple.UseVisualStyleBackColor = true;
            this.btnVtaComple.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnVtaTortas
            // 
            this.btnVtaTortas.BackgroundImage = global::Mc_Roostie.Properties.Resources.lonche;
            this.btnVtaTortas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVtaTortas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVtaTortas.Location = new System.Drawing.Point(273, 377);
            this.btnVtaTortas.Name = "btnVtaTortas";
            this.btnVtaTortas.Size = new System.Drawing.Size(195, 120);
            this.btnVtaTortas.TabIndex = 55;
            this.btnVtaTortas.UseVisualStyleBackColor = true;
            this.btnVtaTortas.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnVtaTostadas
            // 
            this.btnVtaTostadas.BackgroundImage = global::Mc_Roostie.Properties.Resources.tortilla;
            this.btnVtaTostadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVtaTostadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVtaTostadas.Location = new System.Drawing.Point(276, 207);
            this.btnVtaTostadas.Name = "btnVtaTostadas";
            this.btnVtaTostadas.Size = new System.Drawing.Size(195, 120);
            this.btnVtaTostadas.TabIndex = 53;
            this.btnVtaTostadas.UseVisualStyleBackColor = true;
            this.btnVtaTostadas.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnVtaCarnitas
            // 
            this.btnVtaCarnitas.BackgroundImage = global::Mc_Roostie.Properties.Resources.pig;
            this.btnVtaCarnitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVtaCarnitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVtaCarnitas.Location = new System.Drawing.Point(275, 36);
            this.btnVtaCarnitas.Name = "btnVtaCarnitas";
            this.btnVtaCarnitas.Size = new System.Drawing.Size(195, 120);
            this.btnVtaCarnitas.TabIndex = 50;
            this.btnVtaCarnitas.UseVisualStyleBackColor = true;
            this.btnVtaCarnitas.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnVtaPromo
            // 
            this.btnVtaPromo.BackgroundImage = global::Mc_Roostie.Properties.Resources.promo;
            this.btnVtaPromo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVtaPromo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVtaPromo.Location = new System.Drawing.Point(11, 541);
            this.btnVtaPromo.Name = "btnVtaPromo";
            this.btnVtaPromo.Size = new System.Drawing.Size(195, 120);
            this.btnVtaPromo.TabIndex = 49;
            this.btnVtaPromo.UseVisualStyleBackColor = true;
            this.btnVtaPromo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnVtaExtras
            // 
            this.btnVtaExtras.BackgroundImage = global::Mc_Roostie.Properties.Resources.taco;
            this.btnVtaExtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVtaExtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVtaExtras.Location = new System.Drawing.Point(12, 207);
            this.btnVtaExtras.Name = "btnVtaExtras";
            this.btnVtaExtras.Size = new System.Drawing.Size(195, 120);
            this.btnVtaExtras.TabIndex = 44;
            this.btnVtaExtras.UseVisualStyleBackColor = true;
            this.btnVtaExtras.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnVtaAgua
            // 
            this.btnVtaAgua.BackgroundImage = global::Mc_Roostie.Properties.Resources.agua;
            this.btnVtaAgua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVtaAgua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVtaAgua.Location = new System.Drawing.Point(11, 377);
            this.btnVtaAgua.Name = "btnVtaAgua";
            this.btnVtaAgua.Size = new System.Drawing.Size(195, 120);
            this.btnVtaAgua.TabIndex = 43;
            this.btnVtaAgua.UseVisualStyleBackColor = true;
            this.btnVtaAgua.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnVtaPollo
            // 
            this.btnVtaPollo.BackgroundImage = global::Mc_Roostie.Properties.Resources.pollo;
            this.btnVtaPollo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVtaPollo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVtaPollo.Location = new System.Drawing.Point(13, 36);
            this.btnVtaPollo.Name = "btnVtaPollo";
            this.btnVtaPollo.Size = new System.Drawing.Size(195, 120);
            this.btnVtaPollo.TabIndex = 41;
            this.btnVtaPollo.UseVisualStyleBackColor = true;
            this.btnVtaPollo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1151, 634);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 48);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1313, 694);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnVtaComple);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnVtaTortas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVtaTostadas);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVtaCarnitas);
            this.Controls.Add(this.btnVtaPromo);
            this.Controls.Add(this.btnChangeLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVtaExtras);
            this.Controls.Add(this.btnVtaAgua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVtaPollo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbxNumTicket);
            this.Controls.Add(this.btnGetTicket);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gvDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.btnCerrarSesion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvDetalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGetTicket;
        private System.Windows.Forms.TextBox txbxNumTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVtaPollo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVtaAgua;
        private System.Windows.Forms.Button btnVtaExtras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChangeLocation;
        private System.Windows.Forms.Button btnVtaPromo;
        private System.Windows.Forms.Button btnVtaCarnitas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVtaTostadas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnVtaTortas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVtaComple;
        private System.Windows.Forms.Button btnClose;
    }
}