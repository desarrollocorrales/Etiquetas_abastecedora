namespace Seguimiento_y_Control.Produccion
{
    partial class Frm_RequisicionesInternas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gridArticulos = new DevExpress.XtraGrid.GridControl();
            this.articuloRequerirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvArticulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colarticulo_a_requerir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarticulo_a_requerir1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_a_requrir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbUnidad = new System.Windows.Forms.ComboBox();
            this.cbClave = new System.Windows.Forms.ComboBox();
            this.cbDescripcion = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbExpiracion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloRequerirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(799, 55);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Requerir Materia Prima";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::Seguimiento_y_Control.Properties.Resources.save_icon30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(600, 619);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 35);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gridArticulos
            // 
            this.gridArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridArticulos.DataSource = this.articuloRequerirBindingSource;
            this.gridArticulos.Location = new System.Drawing.Point(12, 139);
            this.gridArticulos.MainView = this.gvArticulos;
            this.gridArticulos.Name = "gridArticulos";
            this.gridArticulos.Size = new System.Drawing.Size(775, 473);
            this.gridArticulos.TabIndex = 14;
            this.gridArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArticulos});
            // 
            // articuloRequerirBindingSource
            // 
            this.articuloRequerirBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Produccion.ArticuloRequerir);
            // 
            // gvArticulos
            // 
            this.gvArticulos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvArticulos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvArticulos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvArticulos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvArticulos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.Empty.Options.UseBackColor = true;
            this.gvArticulos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvArticulos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvArticulos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvArticulos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvArticulos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvArticulos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvArticulos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvArticulos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvArticulos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvArticulos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvArticulos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvArticulos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.GroupRow.Options.UseFont = true;
            this.gvArticulos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvArticulos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvArticulos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvArticulos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvArticulos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvArticulos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvArticulos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvArticulos.Appearance.Preview.Options.UseBackColor = true;
            this.gvArticulos.Appearance.Preview.Options.UseForeColor = true;
            this.gvArticulos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.Row.Options.UseBackColor = true;
            this.gvArticulos.Appearance.Row.Options.UseForeColor = true;
            this.gvArticulos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvArticulos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvArticulos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvArticulos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvArticulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colarticulo_a_requerir,
            this.colarticulo_a_requerir1,
            this.colcantidad_a_requrir,
            this.colunidad});
            this.gvArticulos.GridControl = this.gridArticulos;
            this.gvArticulos.Name = "gvArticulos";
            this.gvArticulos.OptionsBehavior.Editable = false;
            this.gvArticulos.OptionsCustomization.AllowFilter = false;
            this.gvArticulos.OptionsCustomization.AllowGroup = false;
            this.gvArticulos.OptionsCustomization.AllowSort = false;
            this.gvArticulos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvArticulos.OptionsView.EnableAppearanceOddRow = true;
            this.gvArticulos.OptionsView.ShowGroupPanel = false;
            // 
            // colarticulo_a_requerir
            // 
            this.colarticulo_a_requerir.AppearanceHeader.Options.UseTextOptions = true;
            this.colarticulo_a_requerir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colarticulo_a_requerir.Caption = "Clave";
            this.colarticulo_a_requerir.FieldName = "articulo_a_requerir.clave";
            this.colarticulo_a_requerir.Name = "colarticulo_a_requerir";
            this.colarticulo_a_requerir.Visible = true;
            this.colarticulo_a_requerir.VisibleIndex = 0;
            // 
            // colarticulo_a_requerir1
            // 
            this.colarticulo_a_requerir1.AppearanceHeader.Options.UseTextOptions = true;
            this.colarticulo_a_requerir1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colarticulo_a_requerir1.Caption = "Descripción";
            this.colarticulo_a_requerir1.FieldName = "articulo_a_requerir.articulo";
            this.colarticulo_a_requerir1.Name = "colarticulo_a_requerir1";
            this.colarticulo_a_requerir1.Visible = true;
            this.colarticulo_a_requerir1.VisibleIndex = 1;
            // 
            // colcantidad_a_requrir
            // 
            this.colcantidad_a_requrir.AppearanceHeader.Options.UseTextOptions = true;
            this.colcantidad_a_requrir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcantidad_a_requrir.Caption = "Cantidad";
            this.colcantidad_a_requrir.FieldName = "cantidad_a_requrir";
            this.colcantidad_a_requrir.Name = "colcantidad_a_requrir";
            this.colcantidad_a_requrir.Visible = true;
            this.colcantidad_a_requrir.VisibleIndex = 2;
            // 
            // colunidad
            // 
            this.colunidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colunidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colunidad.Caption = "Unidad";
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // txbCantidad
            // 
            this.txbCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCantidad.Location = new System.Drawing.Point(513, 75);
            this.txbCantidad.MaxLength = 9;
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(75, 26);
            this.txbCantidad.TabIndex = 8;
            this.txbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCantidad_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Location = new System.Drawing.Point(721, 74);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(30, 26);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "+";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(757, 74);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(30, 26);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(591, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unidad:";
            // 
            // cbUnidad
            // 
            this.cbUnidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidad.FormattingEnabled = true;
            this.cbUnidad.Location = new System.Drawing.Point(594, 75);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(121, 26);
            this.cbUnidad.TabIndex = 9;
            // 
            // cbClave
            // 
            this.cbClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbClave.FormattingEnabled = true;
            this.cbClave.Location = new System.Drawing.Point(12, 75);
            this.cbClave.MaxLength = 6;
            this.cbClave.Name = "cbClave";
            this.cbClave.Size = new System.Drawing.Size(60, 26);
            this.cbClave.TabIndex = 6;
            this.cbClave.SelectedIndexChanged += new System.EventHandler(this.cbClave_SelectedIndexChanged);
            // 
            // cbDescripcion
            // 
            this.cbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbDescripcion.FormattingEnabled = true;
            this.cbDescripcion.Location = new System.Drawing.Point(78, 75);
            this.cbDescripcion.MaxLength = 50;
            this.cbDescripcion.Name = "cbDescripcion";
            this.cbDescripcion.Size = new System.Drawing.Size(429, 26);
            this.cbDescripcion.TabIndex = 7;
            this.cbDescripcion.SelectedIndexChanged += new System.EventHandler(this.cbDescripcion_SelectedIndexChanged);
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
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dias de vigencia del pedido:";
            // 
            // txbExpiracion
            // 
            this.txbExpiracion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbExpiracion.Location = new System.Drawing.Point(474, 107);
            this.txbExpiracion.Name = "txbExpiracion";
            this.txbExpiracion.Size = new System.Drawing.Size(38, 26);
            this.txbExpiracion.TabIndex = 13;
            this.txbExpiracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbExpiracion_KeyPress);
            // 
            // Frm_RequisicionesInternas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 667);
            this.Controls.Add(this.txbExpiracion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cbDescripcion);
            this.Controls.Add(this.cbClave);
            this.Controls.Add(this.cbUnidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gridArticulos);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(815, 705);
            this.Name = "Frm_RequisicionesInternas";
            this.Text = "Requerir Materia Prima";
            this.Load += new System.EventHandler(this.Frm_RequisicionesInternas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloRequerirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGuardar;
        private DevExpress.XtraGrid.GridControl gridArticulos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArticulos;
        private System.Windows.Forms.BindingSource articuloRequerirBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colarticulo_a_requerir;
        private DevExpress.XtraGrid.Columns.GridColumn colarticulo_a_requerir1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_a_requrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbUnidad;
        private System.Windows.Forms.ComboBox cbClave;
        private System.Windows.Forms.ComboBox cbDescripcion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbExpiracion;
    }
}