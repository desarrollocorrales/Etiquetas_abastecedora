namespace Seguimiento_y_Control.Produccion
{
    partial class Frm_ImpPesoVariado
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
            this.components = new System.ComponentModel.Container();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.dtpEmpaque = new System.Windows.Forms.DateTimePicker();
            this.lblPara = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numUpDnPiezas = new System.Windows.Forms.NumericUpDown();
            this.lblPiezas = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblCantidadPeso = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pbLogoEtiqueta = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRazon = new System.Windows.Forms.Label();
            this.lblNumeroEtiqueta = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.objBascula = new System.IO.Ports.SerialPort(this.components);
            this.panelPreview.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPiezas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEtiqueta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.Color.White;
            this.panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreview.Controls.Add(this.dtpEmpaque);
            this.panelPreview.Controls.Add(this.lblPara);
            this.panelPreview.Controls.Add(this.label8);
            this.panelPreview.Controls.Add(this.lblLote);
            this.panelPreview.Controls.Add(this.lblLeyenda);
            this.panelPreview.Controls.Add(this.lblCaducidad);
            this.panelPreview.Controls.Add(this.label13);
            this.panelPreview.Controls.Add(this.label11);
            this.panelPreview.Controls.Add(this.lblDomicilio);
            this.panelPreview.Controls.Add(this.lblNombreEmpresa);
            this.panelPreview.Controls.Add(this.lblArticulo);
            this.panelPreview.Controls.Add(this.lblClave);
            this.panelPreview.Controls.Add(this.panel2);
            this.panelPreview.Controls.Add(this.lbl);
            this.panelPreview.Controls.Add(this.pbLogoEtiqueta);
            this.panelPreview.Controls.Add(this.label6);
            this.panelPreview.Controls.Add(this.lblRazon);
            this.panelPreview.Controls.Add(this.lblNumeroEtiqueta);
            this.panelPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPreview.Enabled = false;
            this.panelPreview.Location = new System.Drawing.Point(0, 0);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(664, 346);
            this.panelPreview.TabIndex = 13;
            // 
            // dtpEmpaque
            // 
            this.dtpEmpaque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEmpaque.CustomFormat = "dd/MM/yyyy";
            this.dtpEmpaque.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmpaque.Location = new System.Drawing.Point(365, 91);
            this.dtpEmpaque.Name = "dtpEmpaque";
            this.dtpEmpaque.Size = new System.Drawing.Size(92, 26);
            this.dtpEmpaque.TabIndex = 39;
            // 
            // lblPara
            // 
            this.lblPara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPara.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara.Location = new System.Drawing.Point(90, 138);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(532, 20);
            this.lblPara.TabIndex = 38;
            this.lblPara.Text = "-----";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Location = new System.Drawing.Point(29, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "PARA:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLote
            // 
            this.lblLote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLote.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(90, 158);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(80, 20);
            this.lblLote.TabIndex = 36;
            this.lblLote.Text = "9999999";
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLeyenda.Location = new System.Drawing.Point(263, 118);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(371, 20);
            this.lblLeyenda.TabIndex = 34;
            this.lblLeyenda.Text = "MANTENGASE EN CONGELACION";
            this.lblLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaducidad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaducidad.Location = new System.Drawing.Point(554, 98);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(80, 20);
            this.lblCaducidad.TabIndex = 33;
            this.lblCaducidad.Text = "01/01/0001";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Location = new System.Drawing.Point(464, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Caducidad:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Location = new System.Drawing.Point(263, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Empacado el:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDomicilio.Location = new System.Drawing.Point(263, 52);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(371, 36);
            this.lblDomicilio.TabIndex = 29;
            this.lblDomicilio.Text = "Segunda de Selenio y Estaño s/n Cd. Industrial cp 34208 Durango, Dgo. Tel: 01 618" +
                " 8 14 15 15";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(263, 10);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(371, 39);
            this.lblNombreEmpresa.TabIndex = 28;
            this.lblNombreEmpresa.Text = "ABASTECEDORA DE CARNES LOS CORRALES S.A. DE C.V.";
            this.lblNombreEmpresa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblArticulo
            // 
            this.lblArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArticulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(32, 182);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(602, 26);
            this.lblArticulo.TabIndex = 27;
            this.lblArticulo.Text = "Articulo";
            this.lblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(263, 156);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(371, 26);
            this.lblClave.TabIndex = 26;
            this.lblClave.Text = "000000";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.numUpDnPiezas);
            this.panel2.Controls.Add(this.lblPiezas);
            this.panel2.Controls.Add(this.txbCantidad);
            this.panel2.Controls.Add(this.lblUnidad);
            this.panel2.Controls.Add(this.lblCantidadPeso);
            this.panel2.Location = new System.Drawing.Point(263, 212);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 116);
            this.panel2.TabIndex = 25;
            // 
            // numUpDnPiezas
            // 
            this.numUpDnPiezas.Enabled = false;
            this.numUpDnPiezas.Location = new System.Drawing.Point(304, 9);
            this.numUpDnPiezas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDnPiezas.Name = "numUpDnPiezas";
            this.numUpDnPiezas.Size = new System.Drawing.Size(53, 26);
            this.numUpDnPiezas.TabIndex = 40;
            // 
            // lblPiezas
            // 
            this.lblPiezas.AutoSize = true;
            this.lblPiezas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiezas.Location = new System.Drawing.Point(247, 11);
            this.lblPiezas.Name = "lblPiezas";
            this.lblPiezas.Size = new System.Drawing.Size(51, 18);
            this.lblPiezas.TabIndex = 16;
            this.lblPiezas.Text = "Piezas:";
            this.lblPiezas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(16, 40);
            this.txbCantidad.MaxLength = 9;
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(243, 66);
            this.txbCantidad.TabIndex = 14;
            this.txbCantidad.Text = "0000.0000";
            this.txbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCantidad_KeyPress);
            // 
            // lblUnidad
            // 
            this.lblUnidad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(265, 77);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(92, 29);
            this.lblUnidad.TabIndex = 15;
            this.lblUnidad.Text = "unidad";
            this.lblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidadPeso
            // 
            this.lblCantidadPeso.AutoSize = true;
            this.lblCantidadPeso.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPeso.Location = new System.Drawing.Point(12, 14);
            this.lblCantidadPeso.Name = "lblCantidadPeso";
            this.lblCantidadPeso.Size = new System.Drawing.Size(93, 23);
            this.lblCantidadPeso.TabIndex = 12;
            this.lblCantidadPeso.Text = "Peso Neto:";
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl.Location = new System.Drawing.Point(29, 156);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(55, 22);
            this.lbl.TabIndex = 24;
            this.lbl.Text = "LOTE: ";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbLogoEtiqueta
            // 
            this.pbLogoEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogoEtiqueta.Image = global::Seguimiento_y_Control.Properties.Resources.logoEtq;
            this.pbLogoEtiqueta.Location = new System.Drawing.Point(29, 32);
            this.pbLogoEtiqueta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLogoEtiqueta.Name = "pbLogoEtiqueta";
            this.pbLogoEtiqueta.Size = new System.Drawing.Size(170, 70);
            this.pbLogoEtiqueta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoEtiqueta.TabIndex = 20;
            this.pbLogoEtiqueta.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "ELABORADO POR:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRazon
            // 
            this.lblRazon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRazon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazon.Location = new System.Drawing.Point(29, 106);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(170, 22);
            this.lblRazon.TabIndex = 21;
            this.lblRazon.Text = "LOS CORRALES SA DE SV";
            this.lblRazon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumeroEtiqueta
            // 
            this.lblNumeroEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEtiqueta.Location = new System.Drawing.Point(32, 212);
            this.lblNumeroEtiqueta.Name = "lblNumeroEtiqueta";
            this.lblNumeroEtiqueta.Size = new System.Drawing.Size(225, 116);
            this.lblNumeroEtiqueta.TabIndex = 35;
            this.lblNumeroEtiqueta.Text = "0000000000000";
            this.lblNumeroEtiqueta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Image = global::Seguimiento_y_Control.Properties.Resources.Printer30;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(442, 343);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 33);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTerminar.Image = global::Seguimiento_y_Control.Properties.Resources.close_icon30;
            this.btnTerminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminar.Location = new System.Drawing.Point(550, 343);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(102, 33);
            this.btnTerminar.TabIndex = 19;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // objBascula
            // 
            this.objBascula.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.objBascula_DataReceived);
            // 
            // Frm_ImpPesoVariado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panelPreview);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 450);
            this.Name = "Frm_ImpPesoVariado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Imprimir Peso Variado";
            this.Load += new System.EventHandler(this.Frm_ImpPesoVariado_Load);
            this.panelPreview.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPiezas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEtiqueta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Label lblCaducidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numUpDnPiezas;
        private System.Windows.Forms.Label lblPiezas;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblCantidadPeso;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pbLogoEtiqueta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.Label lblNumeroEtiqueta;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.DateTimePicker dtpEmpaque;
        public System.IO.Ports.SerialPort objBascula;
    }
}