namespace Seguimiento_y_Control.Reportes
{
    partial class Frm_ReporteRecepcion
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridEtiquetas = new DevExpress.XtraGrid.GridControl();
            this.reporteRecepcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEtiquetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.txbArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTotalEtiquetas = new System.Windows.Forms.Label();
            this.lblTotalCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteRecepcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(734, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reporte de Recepción";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Image = global::Seguimiento_y_Control.Properties.Resources.lupa25;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(285, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 26);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.reporteRecepcionBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(11, 108);
            this.gridEtiquetas.MainView = this.gvEtiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(712, 354);
            this.gridEtiquetas.TabIndex = 19;
            this.gridEtiquetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiquetas});
            // 
            // reporteRecepcionBindingSource
            // 
            this.reporteRecepcionBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Topos.ReporteRecepcion);
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
            this.colEstado,
            this.colSalida});
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
            this.colNumeroEtiqueta.FieldName = "NumeroEtiqueta";
            this.colNumeroEtiqueta.Name = "colNumeroEtiqueta";
            this.colNumeroEtiqueta.Visible = true;
            this.colNumeroEtiqueta.VisibleIndex = 1;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceCell.Options.UseTextOptions = true;
            this.colCantidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
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
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            // 
            // colSalida
            // 
            this.colSalida.FieldName = "Salida";
            this.colSalida.Name = "colSalida";
            this.colSalida.Visible = true;
            this.colSalida.VisibleIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha:";
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(687, 44);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(36, 26);
            this.btnBuscarArticulo.TabIndex = 14;
            this.btnBuscarArticulo.Text = "...";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // txbArticulo
            // 
            this.txbArticulo.Enabled = false;
            this.txbArticulo.Location = new System.Drawing.Point(79, 44);
            this.txbArticulo.Name = "txbArticulo";
            this.txbArticulo.Size = new System.Drawing.Size(602, 26);
            this.txbArticulo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Articulo:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = global::Seguimiento_y_Control.Properties.Resources.Printer30;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(319, 468);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 32);
            this.btnImprimir.TabIndex = 21;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dddd dd/MMM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(79, 76);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 22;
            // 
            // lblTotalEtiquetas
            // 
            this.lblTotalEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalEtiquetas.Location = new System.Drawing.Point(12, 465);
            this.lblTotalEtiquetas.Name = "lblTotalEtiquetas";
            this.lblTotalEtiquetas.Size = new System.Drawing.Size(301, 18);
            this.lblTotalEtiquetas.TabIndex = 23;
            this.lblTotalEtiquetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalCantidad
            // 
            this.lblTotalCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCantidad.Location = new System.Drawing.Point(422, 465);
            this.lblTotalCantidad.Name = "lblTotalCantidad";
            this.lblTotalCantidad.Size = new System.Drawing.Size(301, 18);
            this.lblTotalCantidad.TabIndex = 24;
            this.lblTotalCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Frm_ReporteRecepcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.lblTotalCantidad);
            this.Controls.Add(this.lblTotalEtiquetas);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gridEtiquetas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.txbArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Frm_ReporteRecepcion";
            this.Text = "Reporte Recepción";
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteRecepcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.GridControl gridEtiquetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtiquetas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.TextBox txbArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.BindingSource reporteRecepcionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colContador;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colSalida;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTotalEtiquetas;
        private System.Windows.Forms.Label lblTotalCantidad;
    }
}