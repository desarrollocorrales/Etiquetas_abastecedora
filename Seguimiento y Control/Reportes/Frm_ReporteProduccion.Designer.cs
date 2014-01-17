namespace Seguimiento_y_Control.Reportes
{
    partial class Frm_ReporteProduccion
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
            this.txbArticulo = new System.Windows.Forms.TextBox();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNumPedido = new System.Windows.Forms.TextBox();
            this.gridEtiquetas = new DevExpress.XtraGrid.GridControl();
            this.reporteProduccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEtiquetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSumaEtiquetas = new System.Windows.Forms.Label();
            this.lblSumaCantidades = new System.Windows.Forms.Label();
            this.btnImprimirTarima = new System.Windows.Forms.Button();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProduccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articulo:";
            // 
            // txbArticulo
            // 
            this.txbArticulo.Enabled = false;
            this.txbArticulo.Location = new System.Drawing.Point(80, 38);
            this.txbArticulo.Name = "txbArticulo";
            this.txbArticulo.Size = new System.Drawing.Size(602, 26);
            this.txbArticulo.TabIndex = 1;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(688, 38);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(36, 26);
            this.btnBuscarArticulo.TabIndex = 2;
            this.btnBuscarArticulo.Text = "...";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(734, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reporte de Producción";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dddd dd/MMM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(435, 70);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.Value = new System.DateTime(2013, 10, 5, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pedido:";
            // 
            // txbNumPedido
            // 
            this.txbNumPedido.BackColor = System.Drawing.Color.White;
            this.txbNumPedido.Location = new System.Drawing.Point(80, 70);
            this.txbNumPedido.MaxLength = 15;
            this.txbNumPedido.Name = "txbNumPedido";
            this.txbNumPedido.Size = new System.Drawing.Size(253, 26);
            this.txbNumPedido.TabIndex = 7;
            this.txbNumPedido.TextChanged += new System.EventHandler(this.txbNumPedido_TextChanged);
            // 
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.reporteProduccionBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(12, 102);
            this.gridEtiquetas.MainView = this.gvEtiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(712, 360);
            this.gridEtiquetas.TabIndex = 9;
            this.gridEtiquetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiquetas});
            // 
            // reporteProduccionBindingSource
            // 
            this.reporteProduccionBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Produccion.ReporteProduccion);
            // 
            // gvEtiquetas
            // 
            this.gvEtiquetas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.Empty.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvEtiquetas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvEtiquetas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvEtiquetas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEtiquetas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvEtiquetas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvEtiquetas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseFont = true;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEtiquetas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvEtiquetas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvEtiquetas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvEtiquetas.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvEtiquetas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvEtiquetas.Appearance.Preview.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.Preview.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.Row.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.Row.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvEtiquetas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvEtiquetas.Appearance.VertLine.Options.UseBackColor = true;
            this.gvEtiquetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContador,
            this.colNumeroEtiqueta,
            this.colCantidad,
            this.colUnidad,
            this.colBodega,
            this.colNumeroPedido,
            this.colEstado});
            this.gvEtiquetas.GridControl = this.gridEtiquetas;
            this.gvEtiquetas.Name = "gvEtiquetas";
            this.gvEtiquetas.OptionsBehavior.Editable = false;
            this.gvEtiquetas.OptionsCustomization.AllowFilter = false;
            this.gvEtiquetas.OptionsCustomization.AllowGroup = false;
            this.gvEtiquetas.OptionsCustomization.AllowSort = false;
            this.gvEtiquetas.OptionsMenu.EnableColumnMenu = false;
            this.gvEtiquetas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEtiquetas.OptionsView.EnableAppearanceOddRow = true;
            this.gvEtiquetas.OptionsView.ShowGroupPanel = false;
            // 
            // colContador
            // 
            this.colContador.Caption = " ";
            this.colContador.DisplayFormat.FormatString = "#,#";
            this.colContador.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colContador.FieldName = "Contador";
            this.colContador.Name = "colContador";
            this.colContador.Visible = true;
            this.colContador.VisibleIndex = 0;
            // 
            // colNumeroEtiqueta
            // 
            this.colNumeroEtiqueta.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroEtiqueta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroEtiqueta.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroEtiqueta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroEtiqueta.Caption = "Numero de Etiqueta";
            this.colNumeroEtiqueta.FieldName = "NumeroEtiqueta";
            this.colNumeroEtiqueta.Name = "colNumeroEtiqueta";
            this.colNumeroEtiqueta.Visible = true;
            this.colNumeroEtiqueta.VisibleIndex = 1;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            // 
            // colUnidad
            // 
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 3;
            // 
            // colBodega
            // 
            this.colBodega.AppearanceCell.Options.UseTextOptions = true;
            this.colBodega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBodega.AppearanceHeader.Options.UseTextOptions = true;
            this.colBodega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBodega.FieldName = "Bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.Visible = true;
            this.colBodega.VisibleIndex = 4;
            // 
            // colNumeroPedido
            // 
            this.colNumeroPedido.AppearanceCell.Options.UseTextOptions = true;
            this.colNumeroPedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroPedido.AppearanceHeader.Options.UseTextOptions = true;
            this.colNumeroPedido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNumeroPedido.Caption = "Numero de Pedido";
            this.colNumeroPedido.FieldName = "NumeroPedido";
            this.colNumeroPedido.Name = "colNumeroPedido";
            this.colNumeroPedido.Visible = true;
            this.colNumeroPedido.VisibleIndex = 5;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = global::Seguimiento_y_Control.Properties.Resources.Printer30;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(252, 468);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 32);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Image = global::Seguimiento_y_Control.Properties.Resources.lupa25;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(641, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 26);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblSumaEtiquetas
            // 
            this.lblSumaEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSumaEtiquetas.Location = new System.Drawing.Point(12, 465);
            this.lblSumaEtiquetas.Name = "lblSumaEtiquetas";
            this.lblSumaEtiquetas.Size = new System.Drawing.Size(227, 18);
            this.lblSumaEtiquetas.TabIndex = 12;
            this.lblSumaEtiquetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSumaCantidades
            // 
            this.lblSumaCantidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumaCantidades.Location = new System.Drawing.Point(496, 465);
            this.lblSumaCantidades.Name = "lblSumaCantidades";
            this.lblSumaCantidades.Size = new System.Drawing.Size(228, 18);
            this.lblSumaCantidades.TabIndex = 13;
            this.lblSumaCantidades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnImprimirTarima
            // 
            this.btnImprimirTarima.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimirTarima.Enabled = false;
            this.btnImprimirTarima.Image = global::Seguimiento_y_Control.Properties.Resources.Printer30;
            this.btnImprimirTarima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirTarima.Location = new System.Drawing.Point(355, 468);
            this.btnImprimirTarima.Name = "btnImprimirTarima";
            this.btnImprimirTarima.Size = new System.Drawing.Size(128, 32);
            this.btnImprimirTarima.TabIndex = 14;
            this.btnImprimirTarima.Text = "Imprimir Grid";
            this.btnImprimirTarima.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirTarima.UseVisualStyleBackColor = true;
            this.btnImprimirTarima.Click += new System.EventHandler(this.btnImprimirTarima_Click);
            // 
            // colEstado
            // 
            this.colEstado.AppearanceCell.Options.UseTextOptions = true;
            this.colEstado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstado.AppearanceHeader.Options.UseTextOptions = true;
            this.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 6;
            // 
            // Frm_ReporteProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.btnImprimirTarima);
            this.Controls.Add(this.lblSumaCantidades);
            this.Controls.Add(this.lblSumaEtiquetas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gridEtiquetas);
            this.Controls.Add(this.txbNumPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.txbArticulo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Frm_ReporteProduccion";
            this.Text = "Reporte de producción";
            this.Load += new System.EventHandler(this.Frm_ReporteProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteProduccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbArticulo;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNumPedido;
        private DevExpress.XtraGrid.GridControl gridEtiquetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtiquetas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroPedido;
        private System.Windows.Forms.Label lblSumaEtiquetas;
        private System.Windows.Forms.Label lblSumaCantidades;
        private System.Windows.Forms.BindingSource reporteProduccionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colContador;
        private System.Windows.Forms.Button btnImprimirTarima;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}