namespace Seguimiento_y_Control.Administracion.Areas
{
    partial class Frm_Areas
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tabCntrlAreas = new System.Windows.Forms.TabControl();
            this.tpAgregar = new System.Windows.Forms.TabPage();
            this.gridAreasAgregar = new DevExpress.XtraGrid.GridControl();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvAreasAgregar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txbAreaAgregar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpModificar = new System.Windows.Forms.TabPage();
            this.gridAreasModificar = new DevExpress.XtraGrid.GridControl();
            this.gvAreasModificar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txbAreaModificar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpEliminar = new System.Windows.Forms.TabPage();
            this.gridAreasEliminar = new DevExpress.XtraGrid.GridControl();
            this.gvAreasEliminar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.tabCntrlAreas.SuspendLayout();
            this.tpAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAreasAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAreasAgregar)).BeginInit();
            this.tpModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAreasModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAreasModificar)).BeginInit();
            this.tpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAreasEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAreasEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(604, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Áreas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 56);
            this.panel1.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(492, 11);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(224, 11);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(118, 11);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 35);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 35);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tabCntrlAreas
            // 
            this.tabCntrlAreas.Controls.Add(this.tpAgregar);
            this.tabCntrlAreas.Controls.Add(this.tpModificar);
            this.tabCntrlAreas.Controls.Add(this.tpEliminar);
            this.tabCntrlAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCntrlAreas.Location = new System.Drawing.Point(0, 35);
            this.tabCntrlAreas.Name = "tabCntrlAreas";
            this.tabCntrlAreas.SelectedIndex = 0;
            this.tabCntrlAreas.Size = new System.Drawing.Size(604, 371);
            this.tabCntrlAreas.TabIndex = 7;
            this.tabCntrlAreas.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabCntrlAreas_Selected);
            // 
            // tpAgregar
            // 
            this.tpAgregar.Controls.Add(this.gridAreasAgregar);
            this.tpAgregar.Controls.Add(this.txbAreaAgregar);
            this.tpAgregar.Controls.Add(this.label1);
            this.tpAgregar.Location = new System.Drawing.Point(4, 27);
            this.tpAgregar.Name = "tpAgregar";
            this.tpAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregar.Size = new System.Drawing.Size(596, 340);
            this.tpAgregar.TabIndex = 0;
            this.tpAgregar.Text = "Agregar";
            this.tpAgregar.UseVisualStyleBackColor = true;
            // 
            // gridAreasAgregar
            // 
            this.gridAreasAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAreasAgregar.DataSource = this.areasBindingSource;
            this.gridAreasAgregar.Location = new System.Drawing.Point(8, 38);
            this.gridAreasAgregar.MainView = this.gvAreasAgregar;
            this.gridAreasAgregar.Name = "gridAreasAgregar";
            this.gridAreasAgregar.Size = new System.Drawing.Size(580, 296);
            this.gridAreasAgregar.TabIndex = 5;
            this.gridAreasAgregar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAreasAgregar});
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataSource = typeof(Seguimiento_y_Control.Entity.areas);
            // 
            // gvAreasAgregar
            // 
            this.gvAreasAgregar.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasAgregar.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasAgregar.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasAgregar.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasAgregar.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAreasAgregar.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvAreasAgregar.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvAreasAgregar.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvAreasAgregar.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasAgregar.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAreasAgregar.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvAreasAgregar.Appearance.Empty.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvAreasAgregar.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasAgregar.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasAgregar.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasAgregar.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasAgregar.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAreasAgregar.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvAreasAgregar.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvAreasAgregar.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvAreasAgregar.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvAreasAgregar.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvAreasAgregar.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAreasAgregar.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasAgregar.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasAgregar.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasAgregar.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasAgregar.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAreasAgregar.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasAgregar.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasAgregar.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAreasAgregar.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasAgregar.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasAgregar.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAreasAgregar.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvAreasAgregar.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasAgregar.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasAgregar.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasAgregar.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvAreasAgregar.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvAreasAgregar.Appearance.GroupRow.Options.UseFont = true;
            this.gvAreasAgregar.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasAgregar.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasAgregar.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasAgregar.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasAgregar.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAreasAgregar.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvAreasAgregar.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvAreasAgregar.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvAreasAgregar.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvAreasAgregar.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvAreasAgregar.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvAreasAgregar.Appearance.Preview.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.Preview.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvAreasAgregar.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvAreasAgregar.Appearance.Row.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.Row.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvAreasAgregar.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvAreasAgregar.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAreasAgregar.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvAreasAgregar.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAreasAgregar.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvAreasAgregar.Appearance.VertLine.Options.UseBackColor = true;
            this.gvAreasAgregar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colnombre});
            this.gvAreasAgregar.GridControl = this.gridAreasAgregar;
            this.gvAreasAgregar.Name = "gvAreasAgregar";
            this.gvAreasAgregar.OptionsBehavior.Editable = false;
            this.gvAreasAgregar.OptionsCustomization.AllowFilter = false;
            this.gvAreasAgregar.OptionsCustomization.AllowGroup = false;
            this.gvAreasAgregar.OptionsCustomization.AllowSort = false;
            this.gvAreasAgregar.OptionsMenu.EnableColumnMenu = false;
            this.gvAreasAgregar.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAreasAgregar.OptionsView.EnableAppearanceOddRow = true;
            this.gvAreasAgregar.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.MaxWidth = 20;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 20;
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // txbAreaAgregar
            // 
            this.txbAreaAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAreaAgregar.Location = new System.Drawing.Point(134, 6);
            this.txbAreaAgregar.Name = "txbAreaAgregar";
            this.txbAreaAgregar.Size = new System.Drawing.Size(456, 26);
            this.txbAreaAgregar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Área:";
            // 
            // tpModificar
            // 
            this.tpModificar.Controls.Add(this.gridAreasModificar);
            this.tpModificar.Controls.Add(this.txbAreaModificar);
            this.tpModificar.Controls.Add(this.label2);
            this.tpModificar.Location = new System.Drawing.Point(4, 27);
            this.tpModificar.Name = "tpModificar";
            this.tpModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tpModificar.Size = new System.Drawing.Size(596, 340);
            this.tpModificar.TabIndex = 1;
            this.tpModificar.Text = "Modificar";
            this.tpModificar.UseVisualStyleBackColor = true;
            // 
            // gridAreasModificar
            // 
            this.gridAreasModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAreasModificar.DataSource = this.areasBindingSource;
            this.gridAreasModificar.Location = new System.Drawing.Point(8, 38);
            this.gridAreasModificar.MainView = this.gvAreasModificar;
            this.gridAreasModificar.Name = "gridAreasModificar";
            this.gridAreasModificar.Size = new System.Drawing.Size(579, 296);
            this.gridAreasModificar.TabIndex = 8;
            this.gridAreasModificar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAreasModificar});
            // 
            // gvAreasModificar
            // 
            this.gvAreasModificar.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasModificar.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasModificar.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasModificar.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasModificar.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAreasModificar.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvAreasModificar.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvAreasModificar.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvAreasModificar.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasModificar.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAreasModificar.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvAreasModificar.Appearance.Empty.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvAreasModificar.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasModificar.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasModificar.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasModificar.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasModificar.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAreasModificar.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvAreasModificar.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvAreasModificar.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvAreasModificar.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvAreasModificar.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvAreasModificar.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAreasModificar.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasModificar.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasModificar.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasModificar.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasModificar.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAreasModificar.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasModificar.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasModificar.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAreasModificar.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasModificar.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasModificar.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAreasModificar.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvAreasModificar.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasModificar.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasModificar.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasModificar.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvAreasModificar.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvAreasModificar.Appearance.GroupRow.Options.UseFont = true;
            this.gvAreasModificar.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasModificar.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasModificar.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasModificar.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasModificar.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAreasModificar.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvAreasModificar.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvAreasModificar.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvAreasModificar.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvAreasModificar.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvAreasModificar.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvAreasModificar.Appearance.Preview.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.Preview.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvAreasModificar.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvAreasModificar.Appearance.Row.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.Row.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvAreasModificar.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvAreasModificar.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAreasModificar.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvAreasModificar.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAreasModificar.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvAreasModificar.Appearance.VertLine.Options.UseBackColor = true;
            this.gvAreasModificar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3});
            this.gvAreasModificar.GridControl = this.gridAreasModificar;
            this.gvAreasModificar.Name = "gvAreasModificar";
            this.gvAreasModificar.OptionsBehavior.Editable = false;
            this.gvAreasModificar.OptionsCustomization.AllowFilter = false;
            this.gvAreasModificar.OptionsCustomization.AllowGroup = false;
            this.gvAreasModificar.OptionsCustomization.AllowSort = false;
            this.gvAreasModificar.OptionsMenu.EnableColumnMenu = false;
            this.gvAreasModificar.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAreasModificar.OptionsView.EnableAppearanceOddRow = true;
            this.gvAreasModificar.OptionsView.ShowGroupPanel = false;
            this.gvAreasModificar.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvAreasModificar_RowClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.MaxWidth = 20;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 20;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nombre";
            this.gridColumn3.FieldName = "nombre";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // txbAreaModificar
            // 
            this.txbAreaModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbAreaModificar.Location = new System.Drawing.Point(133, 6);
            this.txbAreaModificar.Name = "txbAreaModificar";
            this.txbAreaModificar.Size = new System.Drawing.Size(456, 26);
            this.txbAreaModificar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre del Área:";
            // 
            // tpEliminar
            // 
            this.tpEliminar.Controls.Add(this.gridAreasEliminar);
            this.tpEliminar.Location = new System.Drawing.Point(4, 27);
            this.tpEliminar.Name = "tpEliminar";
            this.tpEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tpEliminar.Size = new System.Drawing.Size(596, 340);
            this.tpEliminar.TabIndex = 2;
            this.tpEliminar.Text = "Eliminar";
            this.tpEliminar.UseVisualStyleBackColor = true;
            // 
            // gridAreasEliminar
            // 
            this.gridAreasEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAreasEliminar.DataSource = this.areasBindingSource;
            this.gridAreasEliminar.Location = new System.Drawing.Point(8, 38);
            this.gridAreasEliminar.MainView = this.gvAreasEliminar;
            this.gridAreasEliminar.Name = "gridAreasEliminar";
            this.gridAreasEliminar.Size = new System.Drawing.Size(579, 296);
            this.gridAreasEliminar.TabIndex = 11;
            this.gridAreasEliminar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAreasEliminar});
            // 
            // gvAreasEliminar
            // 
            this.gvAreasEliminar.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasEliminar.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasEliminar.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasEliminar.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasEliminar.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAreasEliminar.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvAreasEliminar.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvAreasEliminar.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvAreasEliminar.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasEliminar.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAreasEliminar.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvAreasEliminar.Appearance.Empty.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvAreasEliminar.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasEliminar.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasEliminar.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasEliminar.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasEliminar.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAreasEliminar.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvAreasEliminar.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvAreasEliminar.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvAreasEliminar.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvAreasEliminar.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvAreasEliminar.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAreasEliminar.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasEliminar.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasEliminar.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasEliminar.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasEliminar.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAreasEliminar.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasEliminar.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasEliminar.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAreasEliminar.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasEliminar.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasEliminar.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAreasEliminar.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvAreasEliminar.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasEliminar.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasEliminar.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAreasEliminar.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvAreasEliminar.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvAreasEliminar.Appearance.GroupRow.Options.UseFont = true;
            this.gvAreasEliminar.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasEliminar.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAreasEliminar.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAreasEliminar.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAreasEliminar.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAreasEliminar.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvAreasEliminar.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvAreasEliminar.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvAreasEliminar.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvAreasEliminar.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvAreasEliminar.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvAreasEliminar.Appearance.Preview.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.Preview.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvAreasEliminar.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvAreasEliminar.Appearance.Row.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.Row.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvAreasEliminar.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvAreasEliminar.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAreasEliminar.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvAreasEliminar.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAreasEliminar.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvAreasEliminar.Appearance.VertLine.Options.UseBackColor = true;
            this.gvAreasEliminar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5});
            this.gvAreasEliminar.GridControl = this.gridAreasEliminar;
            this.gvAreasEliminar.Name = "gvAreasEliminar";
            this.gvAreasEliminar.OptionsBehavior.Editable = false;
            this.gvAreasEliminar.OptionsCustomization.AllowFilter = false;
            this.gvAreasEliminar.OptionsCustomization.AllowGroup = false;
            this.gvAreasEliminar.OptionsCustomization.AllowSort = false;
            this.gvAreasEliminar.OptionsMenu.EnableColumnMenu = false;
            this.gvAreasEliminar.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAreasEliminar.OptionsView.EnableAppearanceOddRow = true;
            this.gvAreasEliminar.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.MaxWidth = 20;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 20;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Nombre";
            this.gridColumn5.FieldName = "nombre";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // Frm_Areas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 462);
            this.Controls.Add(this.tabCntrlAreas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(620, 500);
            this.Name = "Frm_Areas";
            this.Text = "Áreas";
            this.Load += new System.EventHandler(this.Frm_Areas_Load);
            this.panel1.ResumeLayout(false);
            this.tabCntrlAreas.ResumeLayout(false);
            this.tpAgregar.ResumeLayout(false);
            this.tpAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAreasAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAreasAgregar)).EndInit();
            this.tpModificar.ResumeLayout(false);
            this.tpModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAreasModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAreasModificar)).EndInit();
            this.tpEliminar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAreasEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAreasEliminar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabControl tabCntrlAreas;
        private System.Windows.Forms.TabPage tpAgregar;
        private System.Windows.Forms.TabPage tpModificar;
        private System.Windows.Forms.TabPage tpEliminar;
        private DevExpress.XtraGrid.GridControl gridAreasAgregar;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAreasAgregar;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.TextBox txbAreaAgregar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridAreasModificar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAreasModificar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.TextBox txbAreaModificar;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridAreasEliminar;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAreasEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}