namespace Seguimiento_y_Control.Topos.Reimpresion
{
    partial class Frm_ReimprirSalida
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbCodigoSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimirInterna = new System.Windows.Forms.Button();
            this.panelSalidaInterna = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimirSucursal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSalidaSucursal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImprimirVendedor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSalidaVendedor = new System.Windows.Forms.TextBox();
            this.rbInternas = new System.Windows.Forms.RadioButton();
            this.rbSucursales = new System.Windows.Forms.RadioButton();
            this.rbVendedores = new System.Windows.Forms.RadioButton();
            this.panelSalidaInterna.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Salida:";
            // 
            // txbCodigoSalida
            // 
            this.txbCodigoSalida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCodigoSalida.Location = new System.Drawing.Point(183, 48);
            this.txbCodigoSalida.MaxLength = 20;
            this.txbCodigoSalida.Name = "txbCodigoSalida";
            this.txbCodigoSalida.Size = new System.Drawing.Size(267, 26);
            this.txbCodigoSalida.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reimprimir Salida Interna";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImprimirInterna
            // 
            this.btnImprimirInterna.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImprimirInterna.Location = new System.Drawing.Point(219, 80);
            this.btnImprimirInterna.Name = "btnImprimirInterna";
            this.btnImprimirInterna.Size = new System.Drawing.Size(75, 26);
            this.btnImprimirInterna.TabIndex = 11;
            this.btnImprimirInterna.Text = "Imprimir";
            this.btnImprimirInterna.UseVisualStyleBackColor = true;
            this.btnImprimirInterna.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panelSalidaInterna
            // 
            this.panelSalidaInterna.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelSalidaInterna.Controls.Add(this.btnImprimirInterna);
            this.panelSalidaInterna.Controls.Add(this.label2);
            this.panelSalidaInterna.Controls.Add(this.label1);
            this.panelSalidaInterna.Controls.Add(this.txbCodigoSalida);
            this.panelSalidaInterna.Location = new System.Drawing.Point(42, 12);
            this.panelSalidaInterna.Name = "panelSalidaInterna";
            this.panelSalidaInterna.Size = new System.Drawing.Size(512, 117);
            this.panelSalidaInterna.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnImprimirSucursal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbSalidaSucursal);
            this.panel1.Location = new System.Drawing.Point(42, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 117);
            this.panel1.TabIndex = 13;
            // 
            // btnImprimirSucursal
            // 
            this.btnImprimirSucursal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImprimirSucursal.Enabled = false;
            this.btnImprimirSucursal.Location = new System.Drawing.Point(219, 80);
            this.btnImprimirSucursal.Name = "btnImprimirSucursal";
            this.btnImprimirSucursal.Size = new System.Drawing.Size(75, 26);
            this.btnImprimirSucursal.TabIndex = 11;
            this.btnImprimirSucursal.Text = "Imprimir";
            this.btnImprimirSucursal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(512, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Reimprimir Salida a Pedido de Sucursal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo de Salida:";
            // 
            // txbSalidaSucursal
            // 
            this.txbSalidaSucursal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbSalidaSucursal.Enabled = false;
            this.txbSalidaSucursal.Location = new System.Drawing.Point(183, 48);
            this.txbSalidaSucursal.MaxLength = 20;
            this.txbSalidaSucursal.Name = "txbSalidaSucursal";
            this.txbSalidaSucursal.Size = new System.Drawing.Size(267, 26);
            this.txbSalidaSucursal.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btnImprimirVendedor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txbSalidaVendedor);
            this.panel2.Location = new System.Drawing.Point(42, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 117);
            this.panel2.TabIndex = 13;
            // 
            // btnImprimirVendedor
            // 
            this.btnImprimirVendedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImprimirVendedor.Enabled = false;
            this.btnImprimirVendedor.Location = new System.Drawing.Point(219, 80);
            this.btnImprimirVendedor.Name = "btnImprimirVendedor";
            this.btnImprimirVendedor.Size = new System.Drawing.Size(75, 26);
            this.btnImprimirVendedor.TabIndex = 11;
            this.btnImprimirVendedor.Text = "Imprimir";
            this.btnImprimirVendedor.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(512, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reimprimir Salida a Pedido de Vendedor";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo de Salida:";
            // 
            // txbSalidaVendedor
            // 
            this.txbSalidaVendedor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbSalidaVendedor.Enabled = false;
            this.txbSalidaVendedor.Location = new System.Drawing.Point(183, 48);
            this.txbSalidaVendedor.MaxLength = 20;
            this.txbSalidaVendedor.Name = "txbSalidaVendedor";
            this.txbSalidaVendedor.Size = new System.Drawing.Size(267, 26);
            this.txbSalidaVendedor.TabIndex = 1;
            // 
            // rbInternas
            // 
            this.rbInternas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbInternas.AutoSize = true;
            this.rbInternas.Checked = true;
            this.rbInternas.Location = new System.Drawing.Point(12, 73);
            this.rbInternas.Name = "rbInternas";
            this.rbInternas.Size = new System.Drawing.Size(14, 13);
            this.rbInternas.TabIndex = 14;
            this.rbInternas.TabStop = true;
            this.rbInternas.UseVisualStyleBackColor = true;
            this.rbInternas.CheckedChanged += new System.EventHandler(this.rbInternas_CheckedChanged);
            // 
            // rbSucursales
            // 
            this.rbSucursales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbSucursales.AutoSize = true;
            this.rbSucursales.Location = new System.Drawing.Point(12, 196);
            this.rbSucursales.Name = "rbSucursales";
            this.rbSucursales.Size = new System.Drawing.Size(14, 13);
            this.rbSucursales.TabIndex = 15;
            this.rbSucursales.UseVisualStyleBackColor = true;
            this.rbSucursales.CheckedChanged += new System.EventHandler(this.rbSucursales_CheckedChanged);
            // 
            // rbVendedores
            // 
            this.rbVendedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbVendedores.AutoSize = true;
            this.rbVendedores.Location = new System.Drawing.Point(12, 319);
            this.rbVendedores.Name = "rbVendedores";
            this.rbVendedores.Size = new System.Drawing.Size(14, 13);
            this.rbVendedores.TabIndex = 16;
            this.rbVendedores.UseVisualStyleBackColor = true;
            this.rbVendedores.CheckedChanged += new System.EventHandler(this.rbVendedores_CheckedChanged);
            // 
            // Frm_ReimprirSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 415);
            this.Controls.Add(this.rbVendedores);
            this.Controls.Add(this.rbSucursales);
            this.Controls.Add(this.rbInternas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSalidaInterna);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ReimprirSalida";
            this.Text = "Reimprir Salida";
            this.panelSalidaInterna.ResumeLayout(false);
            this.panelSalidaInterna.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCodigoSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimirInterna;
        private System.Windows.Forms.Panel panelSalidaInterna;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImprimirSucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSalidaSucursal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImprimirVendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSalidaVendedor;
        private System.Windows.Forms.RadioButton rbInternas;
        private System.Windows.Forms.RadioButton rbSucursales;
        private System.Windows.Forms.RadioButton rbVendedores;
    }
}