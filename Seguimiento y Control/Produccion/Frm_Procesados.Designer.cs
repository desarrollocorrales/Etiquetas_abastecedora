namespace Seguimiento_y_Control.Produccion
{
    partial class Frm_Procesados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCamara = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaEmpaque = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.gridPesosFijos = new DevExpress.XtraGrid.GridControl();
            this.pesoFijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPesosFijos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSeleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtiquetas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rbPesoVariado = new System.Windows.Forms.RadioButton();
            this.rbPesoFijo = new System.Windows.Forms.RadioButton();
            this.txbCantidadFija = new System.Windows.Forms.TextBox();
            this.rbCantidadFija = new System.Windows.Forms.RadioButton();
            this.panelPreview = new System.Windows.Forms.Panel();
            this.lblPara = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblEmpaque = new System.Windows.Forms.Label();
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblNumeroEtiqueta = new System.Windows.Forms.Label();
            this.txbNumPedido = new System.Windows.Forms.TextBox();
            this.btnBuscarPedidos = new System.Windows.Forms.Button();
            this.btnBuscarArticulos = new System.Windows.Forms.Button();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.txbArticulo = new System.Windows.Forms.TextBox();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesosFijos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoFijoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPesosFijos)).BeginInit();
            this.panelPreview.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPiezas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEtiqueta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Pedido:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave del articulo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(799, 55);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Procesados";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Articulo:";
            // 
            // cbCamara
            // 
            this.cbCamara.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamara.Enabled = false;
            this.cbCamara.FormattingEnabled = true;
            this.cbCamara.Location = new System.Drawing.Point(267, 155);
            this.cbCamara.Name = "cbCamara";
            this.cbCamara.Size = new System.Drawing.Size(212, 26);
            this.cbCamara.TabIndex = 7;
            this.cbCamara.SelectedIndexChanged += new System.EventHandler(this.cbCamara_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Camara:";
            // 
            // dtpFechaEmpaque
            // 
            this.dtpFechaEmpaque.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaEmpaque.CustomFormat = "dd/MMM/yyyy";
            this.dtpFechaEmpaque.Enabled = false;
            this.dtpFechaEmpaque.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEmpaque.Location = new System.Drawing.Point(267, 187);
            this.dtpFechaEmpaque.Name = "dtpFechaEmpaque";
            this.dtpFechaEmpaque.Size = new System.Drawing.Size(150, 26);
            this.dtpFechaEmpaque.TabIndex = 9;
            this.dtpFechaEmpaque.ValueChanged += new System.EventHandler(this.dtpFechaEmpaque_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de empaque:";
            // 
            // panelOpciones
            // 
            this.panelOpciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpciones.Controls.Add(this.gridPesosFijos);
            this.panelOpciones.Controls.Add(this.rbPesoVariado);
            this.panelOpciones.Controls.Add(this.rbPesoFijo);
            this.panelOpciones.Controls.Add(this.txbCantidadFija);
            this.panelOpciones.Controls.Add(this.rbCantidadFija);
            this.panelOpciones.Enabled = false;
            this.panelOpciones.Location = new System.Drawing.Point(12, 219);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(775, 100);
            this.panelOpciones.TabIndex = 11;
            // 
            // gridPesosFijos
            // 
            this.gridPesosFijos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridPesosFijos.DataSource = this.pesoFijoBindingSource;
            this.gridPesosFijos.Location = new System.Drawing.Point(154, 3);
            this.gridPesosFijos.MainView = this.gvPesosFijos;
            this.gridPesosFijos.Name = "gridPesosFijos";
            this.gridPesosFijos.Size = new System.Drawing.Size(284, 92);
            this.gridPesosFijos.TabIndex = 5;
            this.gridPesosFijos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPesosFijos});
            // 
            // pesoFijoBindingSource
            // 
            this.pesoFijoBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Topos.PesoFijo);
            // 
            // gvPesosFijos
            // 
            this.gvPesosFijos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSeleccion,
            this.colPeso,
            this.colEtiquetas});
            this.gvPesosFijos.GridControl = this.gridPesosFijos;
            this.gvPesosFijos.Name = "gvPesosFijos";
            this.gvPesosFijos.OptionsCustomization.AllowFilter = false;
            this.gvPesosFijos.OptionsCustomization.AllowGroup = false;
            this.gvPesosFijos.OptionsCustomization.AllowSort = false;
            this.gvPesosFijos.OptionsView.ShowGroupPanel = false;
            // 
            // colSeleccion
            // 
            this.colSeleccion.FieldName = "Seleccion";
            this.colSeleccion.Name = "colSeleccion";
            this.colSeleccion.OptionsColumn.AllowMove = false;
            this.colSeleccion.Visible = true;
            this.colSeleccion.VisibleIndex = 0;
            // 
            // colPeso
            // 
            this.colPeso.Caption = "Peso";
            this.colPeso.FieldName = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.OptionsColumn.AllowEdit = false;
            this.colPeso.OptionsColumn.AllowMove = false;
            this.colPeso.Visible = true;
            this.colPeso.VisibleIndex = 1;
            // 
            // colEtiquetas
            // 
            this.colEtiquetas.Caption = "Etiquetas";
            this.colEtiquetas.FieldName = "Etiquetas";
            this.colEtiquetas.Name = "colEtiquetas";
            this.colEtiquetas.OptionsColumn.AllowMove = false;
            this.colEtiquetas.Visible = true;
            this.colEtiquetas.VisibleIndex = 2;
            // 
            // rbPesoVariado
            // 
            this.rbPesoVariado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbPesoVariado.AutoSize = true;
            this.rbPesoVariado.Location = new System.Drawing.Point(605, 4);
            this.rbPesoVariado.Name = "rbPesoVariado";
            this.rbPesoVariado.Size = new System.Drawing.Size(106, 22);
            this.rbPesoVariado.TabIndex = 4;
            this.rbPesoVariado.TabStop = true;
            this.rbPesoVariado.Text = "Peso Variado";
            this.rbPesoVariado.UseVisualStyleBackColor = true;
            this.rbPesoVariado.CheckedChanged += new System.EventHandler(this.rbPesoVariado_CheckedChanged);
            // 
            // rbPesoFijo
            // 
            this.rbPesoFijo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbPesoFijo.AutoSize = true;
            this.rbPesoFijo.Location = new System.Drawing.Point(62, 4);
            this.rbPesoFijo.Name = "rbPesoFijo";
            this.rbPesoFijo.Size = new System.Drawing.Size(86, 22);
            this.rbPesoFijo.TabIndex = 2;
            this.rbPesoFijo.TabStop = true;
            this.rbPesoFijo.Text = "Peso Fijo:";
            this.rbPesoFijo.UseVisualStyleBackColor = true;
            this.rbPesoFijo.CheckedChanged += new System.EventHandler(this.rbPesoFijo_CheckedChanged);
            // 
            // txbCantidadFija
            // 
            this.txbCantidadFija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCantidadFija.Location = new System.Drawing.Point(559, 3);
            this.txbCantidadFija.MaxLength = 4;
            this.txbCantidadFija.Name = "txbCantidadFija";
            this.txbCantidadFija.Size = new System.Drawing.Size(40, 26);
            this.txbCantidadFija.TabIndex = 1;
            this.txbCantidadFija.Text = "0";
            // 
            // rbCantidadFija
            // 
            this.rbCantidadFija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCantidadFija.AutoSize = true;
            this.rbCantidadFija.Location = new System.Drawing.Point(444, 4);
            this.rbCantidadFija.Name = "rbCantidadFija";
            this.rbCantidadFija.Size = new System.Drawing.Size(109, 22);
            this.rbCantidadFija.TabIndex = 0;
            this.rbCantidadFija.TabStop = true;
            this.rbCantidadFija.Text = "Cantidad Fija:";
            this.rbCantidadFija.UseVisualStyleBackColor = true;
            this.rbCantidadFija.CheckedChanged += new System.EventHandler(this.rbCantidadFija_CheckedChanged);
            // 
            // panelPreview
            // 
            this.panelPreview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPreview.BackColor = System.Drawing.Color.White;
            this.panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreview.Controls.Add(this.lblPara);
            this.panelPreview.Controls.Add(this.label8);
            this.panelPreview.Controls.Add(this.lblLote);
            this.panelPreview.Controls.Add(this.lblLeyenda);
            this.panelPreview.Controls.Add(this.lblCaducidad);
            this.panelPreview.Controls.Add(this.label13);
            this.panelPreview.Controls.Add(this.lblEmpaque);
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
            this.panelPreview.Controls.Add(this.btnImprimir);
            this.panelPreview.Controls.Add(this.lblNumeroEtiqueta);
            this.panelPreview.Enabled = false;
            this.panelPreview.Location = new System.Drawing.Point(12, 325);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(775, 330);
            this.panelPreview.TabIndex = 12;
            // 
            // lblPara
            // 
            this.lblPara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPara.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara.Location = new System.Drawing.Point(130, 130);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(532, 20);
            this.lblPara.TabIndex = 38;
            this.lblPara.Text = "-----";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Location = new System.Drawing.Point(69, 130);
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
            this.lblLote.Location = new System.Drawing.Point(130, 150);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(80, 20);
            this.lblLote.TabIndex = 36;
            this.lblLote.Text = "9999999";
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLeyenda.Location = new System.Drawing.Point(303, 110);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(359, 20);
            this.lblLeyenda.TabIndex = 34;
            this.lblLeyenda.Text = "MANTENGASE EN CONGELACION";
            this.lblLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaducidad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaducidad.Location = new System.Drawing.Point(586, 90);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(80, 20);
            this.lblCaducidad.TabIndex = 33;
            this.lblCaducidad.Text = "01/01/0001";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Location = new System.Drawing.Point(505, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Caducidad:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEmpaque
            // 
            this.lblEmpaque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpaque.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpaque.Location = new System.Drawing.Point(393, 90);
            this.lblEmpaque.Name = "lblEmpaque";
            this.lblEmpaque.Size = new System.Drawing.Size(120, 20);
            this.lblEmpaque.TabIndex = 31;
            this.lblEmpaque.Text = "01/01/0001 99:99";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Location = new System.Drawing.Point(300, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Empacado el:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDomicilio.Location = new System.Drawing.Point(303, 34);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(359, 50);
            this.lblDomicilio.TabIndex = 29;
            this.lblDomicilio.Text = "Segunda de Selenio y Estaño s/n Cd. Industrial cp 34208 Durango, Dgo. Tel: 01 618" +
    " 8 14 15 15";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(303, 2);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(359, 42);
            this.lblNombreEmpresa.TabIndex = 28;
            this.lblNombreEmpresa.Text = "ABASTECEDORA DE CARNES LOS CORRALES S.A. DE C.V.";
            this.lblNombreEmpresa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblArticulo
            // 
            this.lblArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArticulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(72, 174);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(590, 26);
            this.lblArticulo.TabIndex = 27;
            this.lblArticulo.Text = "Articulo";
            this.lblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(303, 148);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(359, 26);
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
            this.panel2.Location = new System.Drawing.Point(303, 204);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 116);
            this.panel2.TabIndex = 25;
            // 
            // numUpDnPiezas
            // 
            this.numUpDnPiezas.Enabled = false;
            this.numUpDnPiezas.Location = new System.Drawing.Point(314, 3);
            this.numUpDnPiezas.Name = "numUpDnPiezas";
            this.numUpDnPiezas.Size = new System.Drawing.Size(40, 26);
            this.numUpDnPiezas.TabIndex = 40;
            // 
            // lblPiezas
            // 
            this.lblPiezas.AutoSize = true;
            this.lblPiezas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiezas.Location = new System.Drawing.Point(257, 5);
            this.lblPiezas.Name = "lblPiezas";
            this.lblPiezas.Size = new System.Drawing.Size(51, 18);
            this.lblPiezas.TabIndex = 16;
            this.lblPiezas.Text = "Piezas:";
            this.lblPiezas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(13, 34);
            this.txbCantidad.MaxLength = 9;
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(243, 66);
            this.txbCantidad.TabIndex = 14;
            this.txbCantidad.Text = "0000.0000";
            this.txbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUnidad
            // 
            this.lblUnidad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(262, 71);
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
            this.lblCantidadPeso.Location = new System.Drawing.Point(9, 8);
            this.lblCantidadPeso.Name = "lblCantidadPeso";
            this.lblCantidadPeso.Size = new System.Drawing.Size(84, 23);
            this.lblCantidadPeso.TabIndex = 12;
            this.lblCantidadPeso.Text = "Cantidad:";
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl.Location = new System.Drawing.Point(69, 148);
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
            this.pbLogoEtiqueta.Location = new System.Drawing.Point(69, 24);
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
            this.label6.Location = new System.Drawing.Point(69, 2);
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
            this.lblRazon.Location = new System.Drawing.Point(69, 98);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(170, 22);
            this.lblRazon.TabIndex = 21;
            this.lblRazon.Text = "LOS CORRALES SA DE SV";
            this.lblRazon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImprimir.Image = global::Seguimiento_y_Control.Properties.Resources.Printer30;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(669, 285);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 35);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblNumeroEtiqueta
            // 
            this.lblNumeroEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroEtiqueta.Font = new System.Drawing.Font("EAN-13", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEtiqueta.Location = new System.Drawing.Point(69, 204);
            this.lblNumeroEtiqueta.Name = "lblNumeroEtiqueta";
            this.lblNumeroEtiqueta.Size = new System.Drawing.Size(192, 116);
            this.lblNumeroEtiqueta.TabIndex = 35;
            this.lblNumeroEtiqueta.Text = "000000000000";
            this.lblNumeroEtiqueta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txbNumPedido
            // 
            this.txbNumPedido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNumPedido.BackColor = System.Drawing.Color.White;
            this.txbNumPedido.Enabled = false;
            this.txbNumPedido.Location = new System.Drawing.Point(267, 58);
            this.txbNumPedido.MaxLength = 12;
            this.txbNumPedido.Name = "txbNumPedido";
            this.txbNumPedido.Size = new System.Drawing.Size(122, 26);
            this.txbNumPedido.TabIndex = 13;
            // 
            // btnBuscarPedidos
            // 
            this.btnBuscarPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarPedidos.Image = global::Seguimiento_y_Control.Properties.Resources.lupa25;
            this.btnBuscarPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarPedidos.Location = new System.Drawing.Point(395, 58);
            this.btnBuscarPedidos.Name = "btnBuscarPedidos";
            this.btnBuscarPedidos.Size = new System.Drawing.Size(137, 26);
            this.btnBuscarPedidos.TabIndex = 14;
            this.btnBuscarPedidos.Text = "Buscar Pedido";
            this.btnBuscarPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarPedidos.UseVisualStyleBackColor = true;
            this.btnBuscarPedidos.Click += new System.EventHandler(this.btnBuscarPedidos_Click);
            // 
            // btnBuscarArticulos
            // 
            this.btnBuscarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarArticulos.Enabled = false;
            this.btnBuscarArticulos.Image = global::Seguimiento_y_Control.Properties.Resources.lupa25;
            this.btnBuscarArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarArticulos.Location = new System.Drawing.Point(395, 90);
            this.btnBuscarArticulos.Name = "btnBuscarArticulos";
            this.btnBuscarArticulos.Size = new System.Drawing.Size(136, 26);
            this.btnBuscarArticulos.TabIndex = 15;
            this.btnBuscarArticulos.Text = "Buscar Artículo";
            this.btnBuscarArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarArticulos.UseVisualStyleBackColor = true;
            this.btnBuscarArticulos.Click += new System.EventHandler(this.btnBuscarArticulos_Click);
            // 
            // txbClave
            // 
            this.txbClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbClave.BackColor = System.Drawing.Color.White;
            this.txbClave.Enabled = false;
            this.txbClave.Location = new System.Drawing.Point(268, 90);
            this.txbClave.MaxLength = 12;
            this.txbClave.Name = "txbClave";
            this.txbClave.Size = new System.Drawing.Size(121, 26);
            this.txbClave.TabIndex = 16;
            // 
            // txbArticulo
            // 
            this.txbArticulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbArticulo.BackColor = System.Drawing.Color.White;
            this.txbArticulo.Enabled = false;
            this.txbArticulo.Location = new System.Drawing.Point(267, 122);
            this.txbArticulo.MaxLength = 12;
            this.txbArticulo.Name = "txbArticulo";
            this.txbArticulo.Size = new System.Drawing.Size(399, 26);
            this.txbArticulo.TabIndex = 17;
            // 
            // Frm_Procesados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 667);
            this.Controls.Add(this.txbArticulo);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.btnBuscarArticulos);
            this.Controls.Add(this.btnBuscarPedidos);
            this.Controls.Add(this.txbNumPedido);
            this.Controls.Add(this.panelPreview);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaEmpaque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCamara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(815, 705);
            this.Name = "Frm_Procesados";
            this.Text = "Procesados";
            this.Load += new System.EventHandler(this.Frm_Procesados_Load);
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesosFijos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoFijoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPesosFijos)).EndInit();
            this.panelPreview.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPiezas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEtiqueta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCamara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaEmpaque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.TextBox txbCantidadFija;
        private System.Windows.Forms.RadioButton rbCantidadFija;
        private System.Windows.Forms.RadioButton rbPesoVariado;
        private System.Windows.Forms.RadioButton rbPesoFijo;
        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pbLogoEtiqueta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Label lblCaducidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEmpaque;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblCantidadPeso;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblNumeroEtiqueta;
        private DevExpress.XtraGrid.GridControl gridPesosFijos;
        private System.Windows.Forms.BindingSource pesoFijoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPesosFijos;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccion;
        private DevExpress.XtraGrid.Columns.GridColumn colPeso;
        private DevExpress.XtraGrid.Columns.GridColumn colEtiquetas;
        private System.Windows.Forms.TextBox txbNumPedido;
        private System.Windows.Forms.Button btnBuscarPedidos;
        private System.Windows.Forms.Button btnBuscarArticulos;
        private System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.TextBox txbArticulo;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numUpDnPiezas;
        private System.Windows.Forms.Label lblPiezas;
        public System.Windows.Forms.Label lblTitulo;
    }
}