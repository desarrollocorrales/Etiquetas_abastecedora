namespace Seguimiento_y_Control.Topos.RecepcionProveedores
{
    partial class Frm_PrevioImprimir
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblRazon = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblNumeroEtiqueta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbxPiezas = new System.Windows.Forms.CheckBox();
            this.numUpDnPiezas = new System.Windows.Forms.NumericUpDown();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.dtpEmpacado = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txbCaducidad = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnImprimirPesoVariado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPiezas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECIBIDO POR:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Seguimiento_y_Control.Properties.Resources.logoEtq;
            this.pbLogo.Location = new System.Drawing.Point(18, 34);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(275, 99);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblRazon
            // 
            this.lblRazon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazon.Location = new System.Drawing.Point(18, 130);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(275, 22);
            this.lblRazon.TabIndex = 2;
            this.lblRazon.Text = "LOS CORRALES SA DE SV";
            this.lblRazon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Location = new System.Drawing.Point(49, 160);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(244, 59);
            this.lblProveedor.TabIndex = 4;
            this.lblProveedor.Text = "DISTRIBUIDORA Y COMERCIALIZADORA INTERNACIONAL DEL NORTE, S.A. DE C.V.";
            // 
            // lblLote
            // 
            this.lblLote.Location = new System.Drawing.Point(15, 219);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(278, 22);
            this.lblLote.TabIndex = 5;
            this.lblLote.Text = "LOTE: ";
            // 
            // lblNumeroEtiqueta
            // 
            this.lblNumeroEtiqueta.Font = new System.Drawing.Font("EAN-13", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEtiqueta.Location = new System.Drawing.Point(12, 259);
            this.lblNumeroEtiqueta.Name = "lblNumeroEtiqueta";
            this.lblNumeroEtiqueta.Size = new System.Drawing.Size(281, 116);
            this.lblNumeroEtiqueta.TabIndex = 13;
            this.lblNumeroEtiqueta.Text = "0000000000000";
            this.lblNumeroEtiqueta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Empacado el:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Caducidad:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chbxPiezas);
            this.panel1.Controls.Add(this.numUpDnPiezas);
            this.panel1.Controls.Add(this.txbCantidad);
            this.panel1.Controls.Add(this.lblUnidad);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(323, 259);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 116);
            this.panel1.TabIndex = 8;
            // 
            // chbxPiezas
            // 
            this.chbxPiezas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxPiezas.Location = new System.Drawing.Point(275, 8);
            this.chbxPiezas.Name = "chbxPiezas";
            this.chbxPiezas.Size = new System.Drawing.Size(82, 26);
            this.chbxPiezas.TabIndex = 18;
            this.chbxPiezas.Text = "Piezas:";
            this.chbxPiezas.UseVisualStyleBackColor = true;
            this.chbxPiezas.CheckedChanged += new System.EventHandler(this.chbxPiezas_CheckedChanged);
            // 
            // numUpDnPiezas
            // 
            this.numUpDnPiezas.Enabled = false;
            this.numUpDnPiezas.Location = new System.Drawing.Point(363, 8);
            this.numUpDnPiezas.Name = "numUpDnPiezas";
            this.numUpDnPiezas.Size = new System.Drawing.Size(59, 26);
            this.numUpDnPiezas.TabIndex = 16;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Enabled = false;
            this.txbCantidad.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(66, 44);
            this.txbCantidad.MaxLength = 9;
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(258, 66);
            this.txbCantidad.TabIndex = 14;
            this.txbCantidad.Text = "0000.0000";
            this.txbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCantidad_KeyPress);
            // 
            // lblUnidad
            // 
            this.lblUnidad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(330, 81);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(92, 29);
            this.lblUnidad.TabIndex = 15;
            this.lblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cantidad:";
            // 
            // lblClave
            // 
            this.lblClave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(323, 203);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(430, 26);
            this.lblClave.TabIndex = 10;
            this.lblClave.Text = "000000";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArticulo
            // 
            this.lblArticulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(193, 229);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(560, 26);
            this.lblArticulo.TabIndex = 11;
            this.lblArticulo.Text = "Articulo";
            this.lblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpEmpacado
            // 
            this.dtpEmpacado.CustomFormat = "dd/MMM/yyyy";
            this.dtpEmpacado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmpacado.Location = new System.Drawing.Point(416, 132);
            this.dtpEmpacado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEmpacado.Name = "dtpEmpacado";
            this.dtpEmpacado.Size = new System.Drawing.Size(116, 26);
            this.dtpEmpacado.TabIndex = 7;
            this.dtpEmpacado.ValueChanged += new System.EventHandler(this.dtpEmpacado_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "DE:";
            // 
            // txbCaducidad
            // 
            this.txbCaducidad.BackColor = System.Drawing.Color.White;
            this.txbCaducidad.Enabled = false;
            this.txbCaducidad.Location = new System.Drawing.Point(637, 132);
            this.txbCaducidad.Name = "txbCaducidad";
            this.txbCaducidad.Size = new System.Drawing.Size(116, 26);
            this.txbCaducidad.TabIndex = 9;
            this.txbCaducidad.Text = "28/jun/2014";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Seguimiento_y_Control.Properties.Resources.Printer30;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(332, 385);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 35);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(320, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(433, 56);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImprimirPesoVariado
            // 
            this.btnImprimirPesoVariado.Image = global::Seguimiento_y_Control.Properties.Resources.Printer30;
            this.btnImprimirPesoVariado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirPesoVariado.Location = new System.Drawing.Point(438, 385);
            this.btnImprimirPesoVariado.Name = "btnImprimirPesoVariado";
            this.btnImprimirPesoVariado.Size = new System.Drawing.Size(100, 35);
            this.btnImprimirPesoVariado.TabIndex = 17;
            this.btnImprimirPesoVariado.Text = "Imprimir";
            this.btnImprimirPesoVariado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirPesoVariado.UseVisualStyleBackColor = true;
            this.btnImprimirPesoVariado.Visible = false;
            this.btnImprimirPesoVariado.Click += new System.EventHandler(this.btnImprimirPesoVariado_Click);
            // 
            // Frm_PrevioImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 432);
            this.Controls.Add(this.btnImprimirPesoVariado);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txbCaducidad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpEmpacado);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNumeroEtiqueta);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRazon);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 470);
            this.Name = "Frm_PrevioImprimir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vista Previa";
            this.Load += new System.EventHandler(this.Frm_PrevioImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPiezas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblNumeroEtiqueta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.DateTimePicker dtpEmpacado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.TextBox txbCaducidad;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnImprimirPesoVariado;
        private System.Windows.Forms.NumericUpDown numUpDnPiezas;
        private System.Windows.Forms.CheckBox chbxPiezas;
    }
}