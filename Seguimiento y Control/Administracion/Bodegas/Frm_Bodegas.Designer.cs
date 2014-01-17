namespace Seguimiento_y_Control.Administracion.Bodegas
{
    partial class Frm_Bodegas
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
            this.tabBodegas = new System.Windows.Forms.TabControl();
            this.tpAgregar = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txbBodega = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridBodegas = new DevExpress.XtraGrid.GridControl();
            this.bodegasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvBodegas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpMidificar = new System.Windows.Forms.TabPage();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txbBodegaModificar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridModificar = new DevExpress.XtraGrid.GridControl();
            this.gvModificar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tpEliminar = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gridbodegasEliminar = new DevExpress.XtraGrid.GridControl();
            this.gvBodegasEliminar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbodega1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tabBodegas.SuspendLayout();
            this.tpAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBodegas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBodegas)).BeginInit();
            this.tpMidificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModificar)).BeginInit();
            this.tpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridbodegasEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBodegasEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBodegas
            // 
            this.tabBodegas.Controls.Add(this.tpAgregar);
            this.tabBodegas.Controls.Add(this.tpMidificar);
            this.tabBodegas.Controls.Add(this.tpEliminar);
            this.tabBodegas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBodegas.Location = new System.Drawing.Point(0, 35);
            this.tabBodegas.Margin = new System.Windows.Forms.Padding(4);
            this.tabBodegas.Name = "tabBodegas";
            this.tabBodegas.SelectedIndex = 0;
            this.tabBodegas.Size = new System.Drawing.Size(604, 427);
            this.tabBodegas.TabIndex = 0;
            // 
            // tpAgregar
            // 
            this.tpAgregar.Controls.Add(this.btnAgregar);
            this.tpAgregar.Controls.Add(this.txbBodega);
            this.tpAgregar.Controls.Add(this.label1);
            this.tpAgregar.Controls.Add(this.gridBodegas);
            this.tpAgregar.Location = new System.Drawing.Point(4, 27);
            this.tpAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.tpAgregar.Name = "tpAgregar";
            this.tpAgregar.Padding = new System.Windows.Forms.Padding(4);
            this.tpAgregar.Size = new System.Drawing.Size(596, 396);
            this.tpAgregar.TabIndex = 0;
            this.tpAgregar.Text = "Agregar";
            this.tpAgregar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Image = global::Seguimiento_y_Control.Properties.Resources.Ok_icon30;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(247, 53);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 38);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txbBodega
            // 
            this.txbBodega.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBodega.Location = new System.Drawing.Point(159, 21);
            this.txbBodega.Name = "txbBodega";
            this.txbBodega.Size = new System.Drawing.Size(429, 26);
            this.txbBodega.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de la bodega:";
            // 
            // gridBodegas
            // 
            this.gridBodegas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBodegas.DataSource = this.bodegasBindingSource;
            this.gridBodegas.Location = new System.Drawing.Point(8, 97);
            this.gridBodegas.MainView = this.gvBodegas;
            this.gridBodegas.Name = "gridBodegas";
            this.gridBodegas.Size = new System.Drawing.Size(580, 291);
            this.gridBodegas.TabIndex = 0;
            this.gridBodegas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBodegas});
            // 
            // bodegasBindingSource
            // 
            this.bodegasBindingSource.DataSource = typeof(Seguimiento_y_Control.Entity.bodegas);
            // 
            // gvBodegas
            // 
            this.gvBodegas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegas.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvBodegas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvBodegas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvBodegas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvBodegas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvBodegas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvBodegas.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvBodegas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvBodegas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvBodegas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvBodegas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvBodegas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvBodegas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvBodegas.Appearance.Empty.Options.UseBackColor = true;
            this.gvBodegas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvBodegas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvBodegas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvBodegas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegas.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvBodegas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvBodegas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvBodegas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvBodegas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvBodegas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvBodegas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvBodegas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvBodegas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvBodegas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvBodegas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvBodegas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvBodegas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvBodegas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvBodegas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvBodegas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvBodegas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvBodegas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvBodegas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegas.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvBodegas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvBodegas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvBodegas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvBodegas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvBodegas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegas.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvBodegas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvBodegas.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvBodegas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvBodegas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvBodegas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvBodegas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvBodegas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvBodegas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvBodegas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegas.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvBodegas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvBodegas.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvBodegas.Appearance.GroupRow.Options.UseFont = true;
            this.gvBodegas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvBodegas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegas.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvBodegas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvBodegas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvBodegas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvBodegas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvBodegas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvBodegas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvBodegas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvBodegas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvBodegas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvBodegas.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvBodegas.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvBodegas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvBodegas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvBodegas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvBodegas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvBodegas.Appearance.Preview.Options.UseBackColor = true;
            this.gvBodegas.Appearance.Preview.Options.UseForeColor = true;
            this.gvBodegas.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvBodegas.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvBodegas.Appearance.Row.Options.UseBackColor = true;
            this.gvBodegas.Appearance.Row.Options.UseForeColor = true;
            this.gvBodegas.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvBodegas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvBodegas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvBodegas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvBodegas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvBodegas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvBodegas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvBodegas.Appearance.VertLine.Options.UseBackColor = true;
            this.gvBodegas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colbodega});
            this.gvBodegas.GridControl = this.gridBodegas;
            this.gvBodegas.Name = "gvBodegas";
            this.gvBodegas.OptionsBehavior.Editable = false;
            this.gvBodegas.OptionsCustomization.AllowFilter = false;
            this.gvBodegas.OptionsCustomization.AllowGroup = false;
            this.gvBodegas.OptionsCustomization.AllowSort = false;
            this.gvBodegas.OptionsMenu.EnableColumnMenu = false;
            this.gvBodegas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvBodegas.OptionsView.EnableAppearanceOddRow = true;
            this.gvBodegas.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.MaxWidth = 20;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 20;
            // 
            // colbodega
            // 
            this.colbodega.AppearanceCell.Options.UseTextOptions = true;
            this.colbodega.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbodega.AppearanceHeader.Options.UseTextOptions = true;
            this.colbodega.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbodega.Caption = "Bodegas";
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            this.colbodega.Visible = true;
            this.colbodega.VisibleIndex = 1;
            // 
            // tpMidificar
            // 
            this.tpMidificar.Controls.Add(this.btnModificar);
            this.tpMidificar.Controls.Add(this.txbBodegaModificar);
            this.tpMidificar.Controls.Add(this.label2);
            this.tpMidificar.Controls.Add(this.gridModificar);
            this.tpMidificar.Location = new System.Drawing.Point(4, 27);
            this.tpMidificar.Margin = new System.Windows.Forms.Padding(4);
            this.tpMidificar.Name = "tpMidificar";
            this.tpMidificar.Padding = new System.Windows.Forms.Padding(4);
            this.tpMidificar.Size = new System.Drawing.Size(596, 396);
            this.tpMidificar.TabIndex = 1;
            this.tpMidificar.Text = "Modificar";
            this.tpMidificar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.Image = global::Seguimiento_y_Control.Properties.Resources.save_icon30;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(247, 53);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 38);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txbBodegaModificar
            // 
            this.txbBodegaModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBodegaModificar.Location = new System.Drawing.Point(159, 21);
            this.txbBodegaModificar.Name = "txbBodegaModificar";
            this.txbBodegaModificar.Size = new System.Drawing.Size(429, 26);
            this.txbBodegaModificar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de la bodega:";
            // 
            // gridModificar
            // 
            this.gridModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridModificar.DataSource = this.bodegasBindingSource;
            this.gridModificar.Location = new System.Drawing.Point(8, 97);
            this.gridModificar.MainView = this.gvModificar;
            this.gridModificar.Name = "gridModificar";
            this.gridModificar.Size = new System.Drawing.Size(580, 276);
            this.gridModificar.TabIndex = 1;
            this.gridModificar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvModificar});
            this.gridModificar.Click += new System.EventHandler(this.gridModificar_Click);
            // 
            // gvModificar
            // 
            this.gvModificar.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvModificar.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvModificar.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvModificar.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvModificar.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvModificar.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvModificar.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvModificar.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvModificar.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvModificar.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvModificar.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvModificar.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvModificar.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvModificar.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvModificar.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvModificar.Appearance.Empty.Options.UseBackColor = true;
            this.gvModificar.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvModificar.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvModificar.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvModificar.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvModificar.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvModificar.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvModificar.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvModificar.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvModificar.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvModificar.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvModificar.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvModificar.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvModificar.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvModificar.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvModificar.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvModificar.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvModificar.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvModificar.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvModificar.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvModificar.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvModificar.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvModificar.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvModificar.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvModificar.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvModificar.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvModificar.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvModificar.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvModificar.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvModificar.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvModificar.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvModificar.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvModificar.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvModificar.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvModificar.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvModificar.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvModificar.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvModificar.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvModificar.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvModificar.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvModificar.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvModificar.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvModificar.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvModificar.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvModificar.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvModificar.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvModificar.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvModificar.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvModificar.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvModificar.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvModificar.Appearance.GroupRow.Options.UseFont = true;
            this.gvModificar.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvModificar.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvModificar.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvModificar.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvModificar.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvModificar.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvModificar.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvModificar.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvModificar.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvModificar.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvModificar.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvModificar.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvModificar.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvModificar.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvModificar.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvModificar.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.OddRow.Options.UseBackColor = true;
            this.gvModificar.Appearance.OddRow.Options.UseForeColor = true;
            this.gvModificar.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvModificar.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvModificar.Appearance.Preview.Options.UseBackColor = true;
            this.gvModificar.Appearance.Preview.Options.UseForeColor = true;
            this.gvModificar.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvModificar.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvModificar.Appearance.Row.Options.UseBackColor = true;
            this.gvModificar.Appearance.Row.Options.UseForeColor = true;
            this.gvModificar.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvModificar.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvModificar.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvModificar.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvModificar.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvModificar.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvModificar.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvModificar.Appearance.VertLine.Options.UseBackColor = true;
            this.gvModificar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3});
            this.gvModificar.GridControl = this.gridModificar;
            this.gvModificar.Name = "gvModificar";
            this.gvModificar.OptionsBehavior.Editable = false;
            this.gvModificar.OptionsCustomization.AllowFilter = false;
            this.gvModificar.OptionsCustomization.AllowGroup = false;
            this.gvModificar.OptionsCustomization.AllowSort = false;
            this.gvModificar.OptionsMenu.EnableColumnMenu = false;
            this.gvModificar.OptionsView.EnableAppearanceEvenRow = true;
            this.gvModificar.OptionsView.EnableAppearanceOddRow = true;
            this.gvModificar.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.Caption = "Bodegas";
            this.gridColumn1.FieldName = "bodega";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.MaxWidth = 20;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 20;
            // 
            // tpEliminar
            // 
            this.tpEliminar.Controls.Add(this.btnEliminar);
            this.tpEliminar.Controls.Add(this.gridbodegasEliminar);
            this.tpEliminar.Location = new System.Drawing.Point(4, 27);
            this.tpEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.tpEliminar.Name = "tpEliminar";
            this.tpEliminar.Padding = new System.Windows.Forms.Padding(4);
            this.tpEliminar.Size = new System.Drawing.Size(596, 396);
            this.tpEliminar.TabIndex = 2;
            this.tpEliminar.Text = "Eliminar";
            this.tpEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Image = global::Seguimiento_y_Control.Properties.Resources.close_icon30;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(488, 350);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 38);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gridbodegasEliminar
            // 
            this.gridbodegasEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridbodegasEliminar.DataSource = this.bodegasBindingSource;
            this.gridbodegasEliminar.Location = new System.Drawing.Point(8, 7);
            this.gridbodegasEliminar.MainView = this.gvBodegasEliminar;
            this.gridbodegasEliminar.Name = "gridbodegasEliminar";
            this.gridbodegasEliminar.Size = new System.Drawing.Size(581, 337);
            this.gridbodegasEliminar.TabIndex = 0;
            this.gridbodegasEliminar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBodegasEliminar});
            // 
            // gvBodegasEliminar
            // 
            this.gvBodegasEliminar.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegasEliminar.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvBodegasEliminar.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegasEliminar.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvBodegasEliminar.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvBodegasEliminar.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvBodegasEliminar.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvBodegasEliminar.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvBodegasEliminar.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvBodegasEliminar.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvBodegasEliminar.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvBodegasEliminar.Appearance.Empty.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvBodegasEliminar.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegasEliminar.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvBodegasEliminar.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegasEliminar.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvBodegasEliminar.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvBodegasEliminar.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvBodegasEliminar.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvBodegasEliminar.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvBodegasEliminar.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvBodegasEliminar.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvBodegasEliminar.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvBodegasEliminar.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegasEliminar.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvBodegasEliminar.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegasEliminar.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvBodegasEliminar.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvBodegasEliminar.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegasEliminar.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegasEliminar.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvBodegasEliminar.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegasEliminar.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegasEliminar.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvBodegasEliminar.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvBodegasEliminar.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegasEliminar.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegasEliminar.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvBodegasEliminar.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvBodegasEliminar.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvBodegasEliminar.Appearance.GroupRow.Options.UseFont = true;
            this.gvBodegasEliminar.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegasEliminar.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvBodegasEliminar.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvBodegasEliminar.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvBodegasEliminar.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvBodegasEliminar.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvBodegasEliminar.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvBodegasEliminar.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvBodegasEliminar.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvBodegasEliminar.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.OddRow.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.OddRow.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvBodegasEliminar.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvBodegasEliminar.Appearance.Preview.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.Preview.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvBodegasEliminar.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvBodegasEliminar.Appearance.Row.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.Row.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvBodegasEliminar.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvBodegasEliminar.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvBodegasEliminar.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvBodegasEliminar.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvBodegasEliminar.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvBodegasEliminar.Appearance.VertLine.Options.UseBackColor = true;
            this.gvBodegasEliminar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbodega1,
            this.gridColumn4});
            this.gvBodegasEliminar.GridControl = this.gridbodegasEliminar;
            this.gvBodegasEliminar.Name = "gvBodegasEliminar";
            this.gvBodegasEliminar.OptionsBehavior.Editable = false;
            this.gvBodegasEliminar.OptionsCustomization.AllowFilter = false;
            this.gvBodegasEliminar.OptionsCustomization.AllowGroup = false;
            this.gvBodegasEliminar.OptionsCustomization.AllowSort = false;
            this.gvBodegasEliminar.OptionsMenu.EnableColumnMenu = false;
            this.gvBodegasEliminar.OptionsView.EnableAppearanceEvenRow = true;
            this.gvBodegasEliminar.OptionsView.EnableAppearanceOddRow = true;
            this.gvBodegasEliminar.OptionsView.ShowGroupPanel = false;
            // 
            // colbodega1
            // 
            this.colbodega1.AppearanceCell.Options.UseTextOptions = true;
            this.colbodega1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbodega1.AppearanceHeader.Options.UseTextOptions = true;
            this.colbodega1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colbodega1.Caption = "Bodega";
            this.colbodega1.FieldName = "bodega";
            this.colbodega1.Name = "colbodega1";
            this.colbodega1.Visible = true;
            this.colbodega1.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.MaxWidth = 20;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 20;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(604, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bodegas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Bodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 462);
            this.Controls.Add(this.tabBodegas);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(620, 500);
            this.Name = "Frm_Bodegas";
            this.Text = "Bodegas";
            this.Load += new System.EventHandler(this.Frm_Bodegas_Load);
            this.tabBodegas.ResumeLayout(false);
            this.tpAgregar.ResumeLayout(false);
            this.tpAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBodegas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBodegas)).EndInit();
            this.tpMidificar.ResumeLayout(false);
            this.tpMidificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvModificar)).EndInit();
            this.tpEliminar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridbodegasEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBodegasEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBodegas;
        private System.Windows.Forms.TabPage tpAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txbBodega;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridBodegas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBodegas;
        private System.Windows.Forms.TabPage tpMidificar;
        private System.Windows.Forms.TabPage tpEliminar;
        private System.Windows.Forms.BindingSource bodegasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
        private System.Windows.Forms.Button btnEliminar;
        private DevExpress.XtraGrid.GridControl gridbodegasEliminar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBodegasEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txbBodegaModificar;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridModificar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvModificar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}