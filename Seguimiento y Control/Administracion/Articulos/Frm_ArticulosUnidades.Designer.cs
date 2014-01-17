namespace Seguimiento_y_Control.Administracion.Articulos
{
    partial class Frm_ArticulosUnidades
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
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.gridArticulo = new DevExpress.XtraGrid.GridControl();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvArticulo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colclave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gridUnidades = new DevExpress.XtraGrid.GridControl();
            this.unidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvUnidades = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAsignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(265, 55);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(60, 26);
            this.btnBuscarArticulo.TabIndex = 0;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asignar unidades a un producto en el portal de logística";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(118, 18);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Clave del artículo:";
            // 
            // txbClave
            // 
            this.txbClave.Location = new System.Drawing.Point(139, 56);
            this.txbClave.MaxLength = 6;
            this.txbClave.Name = "txbClave";
            this.txbClave.Size = new System.Drawing.Size(120, 26);
            this.txbClave.TabIndex = 3;
            // 
            // gridArticulo
            // 
            this.gridArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridArticulo.DataSource = this.articulosBindingSource;
            this.gridArticulo.Location = new System.Drawing.Point(15, 88);
            this.gridArticulo.MainView = this.gvArticulo;
            this.gridArticulo.Name = "gridArticulo";
            this.gridArticulo.Size = new System.Drawing.Size(594, 142);
            this.gridArticulo.TabIndex = 4;
            this.gridArticulo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArticulo});
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataSource = typeof(Seguimiento_y_Control.Entity.Internet.articulos);
            // 
            // gvArticulo
            // 
            this.gvArticulo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulo.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvArticulo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulo.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvArticulo.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvArticulo.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvArticulo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvArticulo.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvArticulo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvArticulo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvArticulo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvArticulo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvArticulo.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvArticulo.Appearance.Empty.Options.UseBackColor = true;
            this.gvArticulo.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvArticulo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvArticulo.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvArticulo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulo.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvArticulo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulo.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulo.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvArticulo.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvArticulo.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvArticulo.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvArticulo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvArticulo.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvArticulo.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvArticulo.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvArticulo.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvArticulo.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvArticulo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvArticulo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvArticulo.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvArticulo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvArticulo.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvArticulo.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvArticulo.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulo.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvArticulo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulo.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvArticulo.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvArticulo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvArticulo.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulo.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulo.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvArticulo.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvArticulo.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvArticulo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvArticulo.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvArticulo.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvArticulo.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvArticulo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulo.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvArticulo.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvArticulo.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulo.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvArticulo.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvArticulo.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvArticulo.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvArticulo.Appearance.GroupRow.Options.UseFont = true;
            this.gvArticulo.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvArticulo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulo.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvArticulo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvArticulo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvArticulo.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvArticulo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvArticulo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvArticulo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvArticulo.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvArticulo.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvArticulo.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvArticulo.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvArticulo.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvArticulo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.OddRow.Options.UseBackColor = true;
            this.gvArticulo.Appearance.OddRow.Options.UseForeColor = true;
            this.gvArticulo.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvArticulo.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvArticulo.Appearance.Preview.Options.UseBackColor = true;
            this.gvArticulo.Appearance.Preview.Options.UseForeColor = true;
            this.gvArticulo.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvArticulo.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvArticulo.Appearance.Row.Options.UseBackColor = true;
            this.gvArticulo.Appearance.Row.Options.UseForeColor = true;
            this.gvArticulo.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvArticulo.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvArticulo.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvArticulo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvArticulo.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvArticulo.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvArticulo.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvArticulo.Appearance.VertLine.Options.UseBackColor = true;
            this.gvArticulo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colclave,
            this.colnombre});
            this.gvArticulo.GridControl = this.gridArticulo;
            this.gvArticulo.Name = "gvArticulo";
            this.gvArticulo.OptionsBehavior.Editable = false;
            this.gvArticulo.OptionsView.EnableAppearanceEvenRow = true;
            this.gvArticulo.OptionsView.EnableAppearanceOddRow = true;
            this.gvArticulo.OptionsView.ShowGroupPanel = false;
            // 
            // colclave
            // 
            this.colclave.AppearanceCell.Options.UseTextOptions = true;
            this.colclave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colclave.AppearanceHeader.Options.UseTextOptions = true;
            this.colclave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colclave.Caption = "Clave";
            this.colclave.FieldName = "clave";
            this.colclave.MaxWidth = 100;
            this.colclave.Name = "colclave";
            this.colclave.Visible = true;
            this.colclave.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Artículo";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unidades disponibles:";
            // 
            // gridUnidades
            // 
            this.gridUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUnidades.DataSource = this.unidadesBindingSource;
            this.gridUnidades.Location = new System.Drawing.Point(18, 254);
            this.gridUnidades.MainView = this.gvUnidades;
            this.gridUnidades.Name = "gridUnidades";
            this.gridUnidades.Size = new System.Drawing.Size(591, 142);
            this.gridUnidades.TabIndex = 6;
            this.gridUnidades.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUnidades});
            // 
            // unidadesBindingSource
            // 
            this.unidadesBindingSource.DataSource = typeof(Seguimiento_y_Control.Entity.Internet.unidades);
            // 
            // gvUnidades
            // 
            this.gvUnidades.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvUnidades.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvUnidades.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvUnidades.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvUnidades.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvUnidades.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvUnidades.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvUnidades.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvUnidades.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvUnidades.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gvUnidades.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvUnidades.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvUnidades.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvUnidades.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvUnidades.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvUnidades.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvUnidades.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvUnidades.Appearance.Empty.Options.UseBackColor = true;
            this.gvUnidades.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvUnidades.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvUnidades.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvUnidades.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvUnidades.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvUnidades.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvUnidades.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvUnidades.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvUnidades.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvUnidades.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvUnidades.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvUnidades.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvUnidades.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvUnidades.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvUnidades.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gvUnidades.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvUnidades.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gvUnidades.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvUnidades.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvUnidades.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvUnidades.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvUnidades.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvUnidades.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvUnidades.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvUnidades.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvUnidades.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvUnidades.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvUnidades.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvUnidades.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvUnidades.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvUnidades.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvUnidades.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvUnidades.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvUnidades.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvUnidades.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvUnidades.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvUnidades.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvUnidades.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvUnidades.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvUnidades.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvUnidades.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvUnidades.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvUnidades.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvUnidades.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvUnidades.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvUnidades.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvUnidades.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvUnidades.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvUnidades.Appearance.GroupRow.Options.UseFont = true;
            this.gvUnidades.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvUnidades.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvUnidades.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvUnidades.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvUnidades.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvUnidades.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvUnidades.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvUnidades.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvUnidades.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvUnidades.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gvUnidades.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvUnidades.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvUnidades.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvUnidades.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvUnidades.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvUnidades.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvUnidades.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvUnidades.Appearance.OddRow.Options.UseBackColor = true;
            this.gvUnidades.Appearance.OddRow.Options.UseForeColor = true;
            this.gvUnidades.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gvUnidades.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gvUnidades.Appearance.Preview.Options.UseBackColor = true;
            this.gvUnidades.Appearance.Preview.Options.UseForeColor = true;
            this.gvUnidades.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvUnidades.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvUnidades.Appearance.Row.Options.UseBackColor = true;
            this.gvUnidades.Appearance.Row.Options.UseForeColor = true;
            this.gvUnidades.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvUnidades.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvUnidades.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gvUnidades.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvUnidades.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvUnidades.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvUnidades.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvUnidades.Appearance.VertLine.Options.UseBackColor = true;
            this.gvUnidades.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_unidad,
            this.colunidad});
            this.gvUnidades.GridControl = this.gridUnidades;
            this.gvUnidades.Name = "gvUnidades";
            this.gvUnidades.OptionsBehavior.Editable = false;
            this.gvUnidades.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUnidades.OptionsView.EnableAppearanceOddRow = true;
            this.gvUnidades.OptionsView.ShowGroupPanel = false;
            // 
            // colid_unidad
            // 
            this.colid_unidad.AppearanceCell.Options.UseTextOptions = true;
            this.colid_unidad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid_unidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colid_unidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid_unidad.Caption = "ID";
            this.colid_unidad.FieldName = "id_unidad";
            this.colid_unidad.MaxWidth = 100;
            this.colid_unidad.Name = "colid_unidad";
            this.colid_unidad.Visible = true;
            this.colid_unidad.VisibleIndex = 0;
            this.colid_unidad.Width = 20;
            // 
            // colunidad
            // 
            this.colunidad.Caption = "Unidad";
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 1;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAsignar.AutoSize = true;
            this.btnAsignar.Location = new System.Drawing.Point(280, 402);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(64, 28);
            this.btnAsignar.TabIndex = 7;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // Frm_ArticulosUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.gridUnidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridArticulo);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Frm_ArticulosUnidades";
            this.ShowIcon = false;
            this.Tag = "";
            this.Text = "Asignar Unidades";
            this.Load += new System.EventHandler(this.Frm_ArticulosUnidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txbClave;
        private DevExpress.XtraGrid.GridControl gridArticulo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArticulo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridUnidades;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUnidades;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colclave;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private System.Windows.Forms.BindingSource unidadesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_unidad;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
    }
}