namespace Seguimiento_y_Control.Topos.RecepcionProveedores
{
    partial class Frm_RecepcionProveedores
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
            this.lblProveedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEtiquetasPesoVariado = new System.Windows.Forms.TextBox();
            this.cbProveedores = new System.Windows.Forms.ComboBox();
            this.cbBodegas = new System.Windows.Forms.ComboBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbArticulos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gvPesosFijos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSeleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtiquetas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridPesosFijos = new DevExpress.XtraGrid.GridControl();
            this.pesoFijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEtiquetasCantidadFija = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvPesosFijos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesosFijos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoFijoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(799, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Recepción de Proveedores";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(137, 104);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(77, 18);
            this.lblProveedor.TabIndex = 5;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clave del articulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bodega:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Etiquetas a imprimir:";
            // 
            // txbEtiquetasPesoVariado
            // 
            this.txbEtiquetasPesoVariado.Enabled = false;
            this.txbEtiquetasPesoVariado.Location = new System.Drawing.Point(220, 197);
            this.txbEtiquetasPesoVariado.MaxLength = 4;
            this.txbEtiquetasPesoVariado.Name = "txbEtiquetasPesoVariado";
            this.txbEtiquetasPesoVariado.Size = new System.Drawing.Size(50, 26);
            this.txbEtiquetasPesoVariado.TabIndex = 11;
            this.txbEtiquetasPesoVariado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbEtiquetasPesoVariado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEtiquetasPesoVariado_KeyPress);
            // 
            // cbProveedores
            // 
            this.cbProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProveedores.Enabled = false;
            this.cbProveedores.FormattingEnabled = true;
            this.cbProveedores.Location = new System.Drawing.Point(220, 101);
            this.cbProveedores.Name = "cbProveedores";
            this.cbProveedores.Size = new System.Drawing.Size(500, 26);
            this.cbProveedores.TabIndex = 6;
            this.cbProveedores.SelectedIndexChanged += new System.EventHandler(this.cbProveedores_SelectedIndexChanged);
            this.cbProveedores.TextChanged += new System.EventHandler(this.cbProveedores_TextChanged);
            // 
            // cbBodegas
            // 
            this.cbBodegas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBodegas.Enabled = false;
            this.cbBodegas.FormattingEnabled = true;
            this.cbBodegas.Location = new System.Drawing.Point(220, 133);
            this.cbBodegas.Name = "cbBodegas";
            this.cbBodegas.Size = new System.Drawing.Size(200, 26);
            this.cbBodegas.TabIndex = 8;
            // 
            // lblClave
            // 
            this.lblClave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(220, 40);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(121, 26);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "-";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClave.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Image = global::Seguimiento_y_Control.Properties.Resources.Printer30;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(591, 515);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 35);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(697, 515);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 35);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbArticulos
            // 
            this.cbArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbArticulos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbArticulos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbArticulos.FormattingEnabled = true;
            this.cbArticulos.Location = new System.Drawing.Point(220, 69);
            this.cbArticulos.Name = "cbArticulos";
            this.cbArticulos.Size = new System.Drawing.Size(500, 26);
            this.cbArticulos.TabIndex = 4;
            this.cbArticulos.SelectedIndexChanged += new System.EventHandler(this.cbArticulos_SelectedIndexChanged);
            this.cbArticulos.TextChanged += new System.EventHandler(this.cbArticulos_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(96, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Articulo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gvPesosFijos
            // 
            this.gvPesosFijos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvPesosFijos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPesosFijos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvPesosFijos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvPesosFijos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPesosFijos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvPesosFijos.Appearance.Empty.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvPesosFijos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvPesosFijos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvPesosFijos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvPesosFijos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPesosFijos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.gvPesosFijos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvPesosFijos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPesosFijos.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvPesosFijos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvPesosFijos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvPesosFijos.Appearance.FocusedCell.Options.UseFont = true;
            this.gvPesosFijos.Appearance.FocusedRow.BackColor = System.Drawing.Color.Black;
            this.gvPesosFijos.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gvPesosFijos.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvPesosFijos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.FocusedRow.Options.UseFont = true;
            this.gvPesosFijos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.FooterPanel.BackColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvPesosFijos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPesosFijos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPesosFijos.Appearance.FooterPanel.Options.UseFont = true;
            this.gvPesosFijos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.GroupButton.BackColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.GroupButton.BorderColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvPesosFijos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPesosFijos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.GroupFooter.BackColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvPesosFijos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPesosFijos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPesosFijos.Appearance.GroupFooter.Options.UseFont = true;
            this.gvPesosFijos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.GroupPanel.BackColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvPesosFijos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPesosFijos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.GroupPanel.Options.UseFont = true;
            this.gvPesosFijos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvPesosFijos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvPesosFijos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPesosFijos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.GroupRow.Options.UseFont = true;
            this.gvPesosFijos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvPesosFijos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPesosFijos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPesosFijos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPesosFijos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvPesosFijos.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvPesosFijos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvPesosFijos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvPesosFijos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.HorzLine.BackColor = System.Drawing.Color.Gray;
            this.gvPesosFijos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gvPesosFijos.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gvPesosFijos.Appearance.Preview.ForeColor = System.Drawing.Color.Black;
            this.gvPesosFijos.Appearance.Preview.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.Preview.Options.UseFont = true;
            this.gvPesosFijos.Appearance.Preview.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvPesosFijos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvPesosFijos.Appearance.Row.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.Row.Options.UseFont = true;
            this.gvPesosFijos.Appearance.Row.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvPesosFijos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gvPesosFijos.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvPesosFijos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPesosFijos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPesosFijos.Appearance.SelectedRow.Options.UseFont = true;
            this.gvPesosFijos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPesosFijos.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gvPesosFijos.Appearance.TopNewRow.Options.UseFont = true;
            this.gvPesosFijos.Appearance.VertLine.BackColor = System.Drawing.Color.Gray;
            this.gvPesosFijos.Appearance.VertLine.Options.UseBackColor = true;
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
            this.colSeleccion.AppearanceHeader.Options.UseTextOptions = true;
            this.colSeleccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSeleccion.FieldName = "Seleccion";
            this.colSeleccion.Name = "colSeleccion";
            this.colSeleccion.Visible = true;
            this.colSeleccion.VisibleIndex = 0;
            // 
            // colPeso
            // 
            this.colPeso.AppearanceHeader.Options.UseTextOptions = true;
            this.colPeso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPeso.Caption = "Peso fijo";
            this.colPeso.FieldName = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.OptionsColumn.AllowEdit = false;
            this.colPeso.Visible = true;
            this.colPeso.VisibleIndex = 1;
            // 
            // colEtiquetas
            // 
            this.colEtiquetas.AppearanceHeader.Options.UseTextOptions = true;
            this.colEtiquetas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEtiquetas.Caption = "Cantidad de etiquetas";
            this.colEtiquetas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colEtiquetas.FieldName = "Etiquetas";
            this.colEtiquetas.Name = "colEtiquetas";
            this.colEtiquetas.Visible = true;
            this.colEtiquetas.VisibleIndex = 2;
            // 
            // gridPesosFijos
            // 
            this.gridPesosFijos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPesosFijos.DataSource = this.pesoFijoBindingSource;
            this.gridPesosFijos.Enabled = false;
            this.gridPesosFijos.Location = new System.Drawing.Point(189, 293);
            this.gridPesosFijos.MainView = this.gvPesosFijos;
            this.gridPesosFijos.Name = "gridPesosFijos";
            this.gridPesosFijos.Size = new System.Drawing.Size(420, 216);
            this.gridPesosFijos.TabIndex = 15;
            this.gridPesosFijos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPesosFijos});
            // 
            // pesoFijoBindingSource
            // 
            this.pesoFijoBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Topos.PesoFijo);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Peso Variado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Peso Fijo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad Fija:";
            // 
            // txbEtiquetasCantidadFija
            // 
            this.txbEtiquetasCantidadFija.Enabled = false;
            this.txbEtiquetasCantidadFija.Location = new System.Drawing.Point(220, 229);
            this.txbEtiquetasCantidadFija.MaxLength = 4;
            this.txbEtiquetasCantidadFija.Name = "txbEtiquetasCantidadFija";
            this.txbEtiquetasCantidadFija.Size = new System.Drawing.Size(50, 26);
            this.txbEtiquetasCantidadFija.TabIndex = 13;
            this.txbEtiquetasCantidadFija.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbEtiquetasCantidadFija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEtiquetasCantidadFija_KeyPress);
            // 
            // Frm_RecepcionProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbEtiquetasCantidadFija);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbArticulos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.cbBodegas);
            this.Controls.Add(this.cbProveedores);
            this.Controls.Add(this.txbEtiquetasPesoVariado);
            this.Controls.Add(this.gridPesosFijos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(815, 600);
            this.Name = "Frm_RecepcionProveedores";
            this.Text = "Recepción de proveedores";
            this.Load += new System.EventHandler(this.Frm_RecepcionProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPesosFijos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesosFijos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoFijoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEtiquetasPesoVariado;
        private System.Windows.Forms.ComboBox cbProveedores;
        private System.Windows.Forms.ComboBox cbBodegas;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cbArticulos;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPesosFijos;
        private DevExpress.XtraGrid.GridControl gridPesosFijos;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccion;
        private DevExpress.XtraGrid.Columns.GridColumn colPeso;
        private DevExpress.XtraGrid.Columns.GridColumn colEtiquetas;
        private System.Windows.Forms.BindingSource pesoFijoBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEtiquetasCantidadFija;
    }
}