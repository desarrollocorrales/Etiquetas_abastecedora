namespace Seguimiento_y_Control.Topos.EntregaExterna
{
    partial class Frm_EntregaExternaSucursales
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridMateriaPrima = new DevExpress.XtraGrid.GridControl();
            this.gridEntregaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvMateriaPrima = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRequisicion = new DevExpress.XtraGrid.GridControl();
            this.articuloRequerirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvRequisicion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colarticulo_a_requerir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txbIdRequisicion = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ofdBuscaArchivo = new System.Windows.Forms.OpenFileDialog();
            this.btnCambiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntregaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRequisicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloRequerirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequisicion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = global::Seguimiento_y_Control.Properties.Resources.close_icon30;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(702, 619);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 35);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Image = global::Seguimiento_y_Control.Properties.Resources.save_icon30;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(600, 619);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 35);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 249);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Datos de Entrega:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Datos Requisición:";
            // 
            // gridMateriaPrima
            // 
            this.gridMateriaPrima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMateriaPrima.DataSource = this.gridEntregaBindingSource;
            this.gridMateriaPrima.Location = new System.Drawing.Point(16, 270);
            this.gridMateriaPrima.MainView = this.gvMateriaPrima;
            this.gridMateriaPrima.Name = "gridMateriaPrima";
            this.gridMateriaPrima.Size = new System.Drawing.Size(770, 341);
            this.gridMateriaPrima.TabIndex = 26;
            this.gridMateriaPrima.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMateriaPrima});
            // 
            // gridEntregaBindingSource
            // 
            this.gridEntregaBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Topos.GridEntrega);
            // 
            // gvMateriaPrima
            // 
            this.gvMateriaPrima.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvMateriaPrima.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvMateriaPrima.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.Empty.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvMateriaPrima.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvMateriaPrima.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvMateriaPrima.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvMateriaPrima.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvMateriaPrima.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvMateriaPrima.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvMateriaPrima.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMateriaPrima.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMateriaPrima.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMateriaPrima.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMateriaPrima.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvMateriaPrima.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMateriaPrima.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvMateriaPrima.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvMateriaPrima.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.GroupRow.Options.UseFont = true;
            this.gvMateriaPrima.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvMateriaPrima.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvMateriaPrima.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvMateriaPrima.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvMateriaPrima.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvMateriaPrima.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvMateriaPrima.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvMateriaPrima.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.OddRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.OddRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvMateriaPrima.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvMateriaPrima.Appearance.Preview.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.Preview.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvMateriaPrima.Appearance.Row.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.Row.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvMateriaPrima.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvMateriaPrima.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvMateriaPrima.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvMateriaPrima.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvMateriaPrima.Appearance.VertLine.Options.UseBackColor = true;
            this.gvMateriaPrima.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroEtiqueta,
            this.colArticulo,
            this.colCantidad,
            this.colUnidad1,
            this.colDescripcionEstado});
            this.gvMateriaPrima.GridControl = this.gridMateriaPrima;
            this.gvMateriaPrima.GroupCount = 1;
            this.gvMateriaPrima.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Articulo", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", this.colCantidad, "")});
            this.gvMateriaPrima.Name = "gvMateriaPrima";
            this.gvMateriaPrima.OptionsBehavior.Editable = false;
            this.gvMateriaPrima.OptionsView.EnableAppearanceEvenRow = true;
            this.gvMateriaPrima.OptionsView.EnableAppearanceOddRow = true;
            this.gvMateriaPrima.OptionsView.ShowGroupPanel = false;
            this.gvMateriaPrima.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colArticulo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvMateriaPrima.EndGrouping += new System.EventHandler(this.gvMateriaPrima_EndGrouping);
            // 
            // colNumeroEtiqueta
            // 
            this.colNumeroEtiqueta.FieldName = "NumeroEtiqueta";
            this.colNumeroEtiqueta.Name = "colNumeroEtiqueta";
            this.colNumeroEtiqueta.Visible = true;
            this.colNumeroEtiqueta.VisibleIndex = 0;
            // 
            // colArticulo
            // 
            this.colArticulo.Caption = "Articulo";
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 1;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 1;
            // 
            // colUnidad1
            // 
            this.colUnidad1.Caption = "Unidad";
            this.colUnidad1.FieldName = "Unidad";
            this.colUnidad1.Name = "colUnidad1";
            this.colUnidad1.Visible = true;
            this.colUnidad1.VisibleIndex = 2;
            // 
            // colDescripcionEstado
            // 
            this.colDescripcionEstado.Caption = "Estado";
            this.colDescripcionEstado.FieldName = "DescripcionEstado";
            this.colDescripcionEstado.Name = "colDescripcionEstado";
            this.colDescripcionEstado.OptionsColumn.ReadOnly = true;
            this.colDescripcionEstado.Visible = true;
            this.colDescripcionEstado.VisibleIndex = 3;
            // 
            // gridRequisicion
            // 
            this.gridRequisicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRequisicion.DataSource = this.articuloRequerirBindingSource;
            this.gridRequisicion.Location = new System.Drawing.Point(16, 107);
            this.gridRequisicion.MainView = this.gvRequisicion;
            this.gridRequisicion.Name = "gridRequisicion";
            this.gridRequisicion.Size = new System.Drawing.Size(770, 139);
            this.gridRequisicion.TabIndex = 25;
            this.gridRequisicion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRequisicion});
            // 
            // articuloRequerirBindingSource
            // 
            this.articuloRequerirBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Produccion.ArticuloRequerir);
            // 
            // gvRequisicion
            // 
            this.gvRequisicion.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRequisicion.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvRequisicion.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRequisicion.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvRequisicion.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRequisicion.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvRequisicion.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvRequisicion.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gvRequisicion.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvRequisicion.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvRequisicion.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRequisicion.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvRequisicion.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvRequisicion.Appearance.Empty.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRequisicion.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvRequisicion.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRequisicion.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvRequisicion.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRequisicion.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRequisicion.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvRequisicion.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvRequisicion.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvRequisicion.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gvRequisicion.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gvRequisicion.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvRequisicion.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRequisicion.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvRequisicion.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRequisicion.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRequisicion.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvRequisicion.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRequisicion.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRequisicion.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvRequisicion.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvRequisicion.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRequisicion.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRequisicion.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvRequisicion.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvRequisicion.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvRequisicion.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRequisicion.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRequisicion.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvRequisicion.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvRequisicion.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvRequisicion.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvRequisicion.Appearance.GroupRow.Options.UseFont = true;
            this.gvRequisicion.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRequisicion.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvRequisicion.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvRequisicion.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvRequisicion.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvRequisicion.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvRequisicion.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gvRequisicion.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvRequisicion.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvRequisicion.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvRequisicion.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvRequisicion.Appearance.OddRow.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.OddRow.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gvRequisicion.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gvRequisicion.Appearance.Preview.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.Preview.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvRequisicion.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvRequisicion.Appearance.Row.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.Row.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvRequisicion.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gvRequisicion.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvRequisicion.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvRequisicion.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvRequisicion.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvRequisicion.Appearance.VertLine.Options.UseBackColor = true;
            this.gvRequisicion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colarticulo_a_requerir,
            this.colunidad});
            this.gvRequisicion.GridControl = this.gridRequisicion;
            this.gvRequisicion.GroupCount = 2;
            this.gvRequisicion.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cantidad_a_requrir", null, "")});
            this.gvRequisicion.Name = "gvRequisicion";
            this.gvRequisicion.OptionsBehavior.Editable = false;
            this.gvRequisicion.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRequisicion.OptionsView.EnableAppearanceOddRow = true;
            this.gvRequisicion.OptionsView.ShowGroupPanel = false;
            this.gvRequisicion.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colarticulo_a_requerir, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colunidad, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colarticulo_a_requerir
            // 
            this.colarticulo_a_requerir.Caption = "Articulo";
            this.colarticulo_a_requerir.FieldName = "articulo_a_requerir.articulo";
            this.colarticulo_a_requerir.Name = "colarticulo_a_requerir";
            // 
            // colunidad
            // 
            this.colunidad.Caption = "Unidad";
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            // 
            // txbIdRequisicion
            // 
            this.txbIdRequisicion.BackColor = System.Drawing.Color.White;
            this.txbIdRequisicion.Enabled = false;
            this.txbIdRequisicion.Location = new System.Drawing.Point(119, 57);
            this.txbIdRequisicion.Name = "txbIdRequisicion";
            this.txbIdRequisicion.Size = new System.Drawing.Size(277, 26);
            this.txbIdRequisicion.TabIndex = 24;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(407, 56);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(30, 26);
            this.btnAbrir.TabIndex = 23;
            this.btnAbrir.Text = "...";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID Requisición:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(799, 35);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Entrega a requisiciones de sucursales";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdBuscaArchivo
            // 
            this.ofdBuscaArchivo.FileName = "*.txt";
            this.ofdBuscaArchivo.Filter = "Archivos de Texto | *.txt";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCambiar.AutoSize = true;
            this.btnCambiar.Location = new System.Drawing.Point(717, 73);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(69, 28);
            this.btnCambiar.TabIndex = 31;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Visible = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // Frm_EntregaExternaSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 667);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridMateriaPrima);
            this.Controls.Add(this.gridRequisicion);
            this.Controls.Add(this.txbIdRequisicion);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_EntregaExternaSucursales";
            this.Text = "Entrega a Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.gridMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntregaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriaPrima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRequisicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloRequerirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRequisicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridMateriaPrima;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMateriaPrima;
        private DevExpress.XtraGrid.GridControl gridRequisicion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRequisicion;
        private System.Windows.Forms.TextBox txbIdRequisicion;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.OpenFileDialog ofdBuscaArchivo;
        private System.Windows.Forms.BindingSource gridEntregaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionEstado;
        private System.Windows.Forms.BindingSource articuloRequerirBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colarticulo_a_requerir;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private System.Windows.Forms.Button btnCambiar;
    }
}