namespace Seguimiento_y_Control.Reportes
{
    partial class Frm_ReporteMovimientos
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
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txbArticulo = new System.Windows.Forms.TextBox();
            this.gridReporte = new DevExpress.XtraGrid.GridControl();
            this.reporteMovimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvReporte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalEntradas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProduccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSalidasInternas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSalidasVendedores = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSalidasSucursales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSalidas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteMovimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.btnBuscarArticulo);
            this.pnlDatos.Controls.Add(this.btnReporte);
            this.pnlDatos.Controls.Add(this.label4);
            this.pnlDatos.Controls.Add(this.dtpFinal);
            this.pnlDatos.Controls.Add(this.label3);
            this.pnlDatos.Controls.Add(this.dtpInicial);
            this.pnlDatos.Controls.Add(this.label1);
            this.pnlDatos.Controls.Add(this.txbArticulo);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(734, 109);
            this.pnlDatos.TabIndex = 0;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(638, 8);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(28, 26);
            this.btnBuscarArticulo.TabIndex = 8;
            this.btnBuscarArticulo.Text = "...";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReporte.Enabled = false;
            this.btnReporte.Location = new System.Drawing.Point(330, 73);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 26);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha inicial:";
            // 
            // dtpFinal
            // 
            this.dtpFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFinal.CustomFormat = "dddd dd/MMM/yyyy";
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(432, 41);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 26);
            this.dtpFinal.TabIndex = 5;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.dtpFinal_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha inicial:";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpInicial.CustomFormat = "dddd dd/MMM/yyyy";
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(132, 41);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(200, 26);
            this.dtpInicial.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artículo:";
            // 
            // txbArticulo
            // 
            this.txbArticulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbArticulo.BackColor = System.Drawing.Color.White;
            this.txbArticulo.Location = new System.Drawing.Point(132, 9);
            this.txbArticulo.MaxLength = 6;
            this.txbArticulo.Name = "txbArticulo";
            this.txbArticulo.ReadOnly = true;
            this.txbArticulo.Size = new System.Drawing.Size(500, 26);
            this.txbArticulo.TabIndex = 0;
            // 
            // gridReporte
            // 
            this.gridReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReporte.DataSource = this.reporteMovimientosBindingSource;
            this.gridReporte.Location = new System.Drawing.Point(12, 116);
            this.gridReporte.MainView = this.gvReporte;
            this.gridReporte.Name = "gridReporte";
            this.gridReporte.Size = new System.Drawing.Size(710, 332);
            this.gridReporte.TabIndex = 1;
            this.gridReporte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReporte});
            // 
            // reporteMovimientosBindingSource
            // 
            this.reporteMovimientosBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Reportes.ReporteMovimientos);
            // 
            // gvReporte
            // 
            this.gvReporte.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvReporte.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvReporte.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvReporte.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvReporte.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvReporte.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvReporte.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvReporte.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvReporte.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvReporte.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvReporte.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.Empty.Options.UseBackColor = true;
            this.gvReporte.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvReporte.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvReporte.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvReporte.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvReporte.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvReporte.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvReporte.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvReporte.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvReporte.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvReporte.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvReporte.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvReporte.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvReporte.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvReporte.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvReporte.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporte.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporte.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvReporte.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvReporte.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporte.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporte.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvReporte.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvReporte.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvReporte.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporte.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvReporte.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvReporte.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvReporte.Appearance.GroupRow.Options.UseFont = true;
            this.gvReporte.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvReporte.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvReporte.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvReporte.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvReporte.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvReporte.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvReporte.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvReporte.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.OddRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.OddRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvReporte.Appearance.Preview.Options.UseBackColor = true;
            this.gvReporte.Appearance.Preview.Options.UseForeColor = true;
            this.gvReporte.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.Row.Options.UseBackColor = true;
            this.gvReporte.Appearance.Row.Options.UseForeColor = true;
            this.gvReporte.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvReporte.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvReporte.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvReporte.Appearance.VertLine.Options.UseBackColor = true;
            this.gvReporte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfecha,
            this.colTotalEntradas,
            this.colTotalProduccion,
            this.colTotalSalidasInternas,
            this.colTotalSalidasVendedores,
            this.colTotalSalidasSucursales,
            this.colTotalSalidas,
            this.colUnidad});
            this.gvReporte.GridControl = this.gridReporte;
            this.gvReporte.Name = "gvReporte";
            this.gvReporte.OptionsBehavior.Editable = false;
            this.gvReporte.OptionsView.EnableAppearanceEvenRow = true;
            this.gvReporte.OptionsView.EnableAppearanceOddRow = true;
            this.gvReporte.OptionsView.ShowGroupPanel = false;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha";
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 0;
            // 
            // colTotalEntradas
            // 
            this.colTotalEntradas.Caption = "Entrada";
            this.colTotalEntradas.FieldName = "TotalEntradas";
            this.colTotalEntradas.Name = "colTotalEntradas";
            this.colTotalEntradas.Visible = true;
            this.colTotalEntradas.VisibleIndex = 2;
            // 
            // colTotalProduccion
            // 
            this.colTotalProduccion.Caption = "Produccion";
            this.colTotalProduccion.FieldName = "TotalProduccion";
            this.colTotalProduccion.Name = "colTotalProduccion";
            this.colTotalProduccion.Visible = true;
            this.colTotalProduccion.VisibleIndex = 3;
            // 
            // colTotalSalidasInternas
            // 
            this.colTotalSalidasInternas.Caption = "Salidas a Producción";
            this.colTotalSalidasInternas.FieldName = "TotalSalidasInternas";
            this.colTotalSalidasInternas.Name = "colTotalSalidasInternas";
            this.colTotalSalidasInternas.Visible = true;
            this.colTotalSalidasInternas.VisibleIndex = 4;
            // 
            // colTotalSalidasVendedores
            // 
            this.colTotalSalidasVendedores.Caption = "Salida a Vendedores";
            this.colTotalSalidasVendedores.FieldName = "TotalSalidasVendedores";
            this.colTotalSalidasVendedores.Name = "colTotalSalidasVendedores";
            this.colTotalSalidasVendedores.Visible = true;
            this.colTotalSalidasVendedores.VisibleIndex = 5;
            // 
            // colTotalSalidasSucursales
            // 
            this.colTotalSalidasSucursales.Caption = "Salida a Sucursales";
            this.colTotalSalidasSucursales.FieldName = "TotalSalidasSucursales";
            this.colTotalSalidasSucursales.Name = "colTotalSalidasSucursales";
            this.colTotalSalidasSucursales.Visible = true;
            this.colTotalSalidasSucursales.VisibleIndex = 6;
            // 
            // colTotalSalidas
            // 
            this.colTotalSalidas.Caption = "Total Salidas";
            this.colTotalSalidas.FieldName = "TotalSalidas";
            this.colTotalSalidas.Name = "colTotalSalidas";
            this.colTotalSalidas.Visible = true;
            this.colTotalSalidas.VisibleIndex = 7;
            // 
            // colUnidad
            // 
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(330, 454);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 26);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Frm_ReporteMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 492);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gridReporte);
            this.Controls.Add(this.pnlDatos);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 530);
            this.Name = "Frm_ReporteMovimientos";
            this.ShowIcon = false;
            this.Text = "Reporte de Movimientos";
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteMovimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbArticulo;
        private DevExpress.XtraGrid.GridControl gridReporte;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReporte;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.BindingSource reporteMovimientosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalEntradas;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProduccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSalidasInternas;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSalidasVendedores;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSalidasSucursales;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSalidas;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
    }
}