namespace Seguimiento_y_Control.Utilidades
{
    partial class Frm_BuscarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarArticulo));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gridArticulos = new DevExpress.XtraGrid.GridControl();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvArticulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colclave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(664, 50);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Buscar Artículos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridArticulos
            // 
            this.gridArticulos.DataSource = this.articulosBindingSource;
            this.gridArticulos.Location = new System.Drawing.Point(12, 85);
            this.gridArticulos.MainView = this.gvArticulos;
            this.gridArticulos.Name = "gridArticulos";
            this.gridArticulos.Size = new System.Drawing.Size(640, 302);
            this.gridArticulos.TabIndex = 5;
            this.gridArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArticulos});
            // 
            // articulosBindingSource
            // 
            this.articulosBindingSource.DataSource = typeof(Seguimiento_y_Control.Entity.articulos);
            // 
            // gvArticulos
            // 
            this.gvArticulos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvArticulos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvArticulos.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gvArticulos.Appearance.Empty.Options.UseBackColor = true;
            this.gvArticulos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvArticulos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.gvArticulos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.gvArticulos.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.gvArticulos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvArticulos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvArticulos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvArticulos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvArticulos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvArticulos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvArticulos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvArticulos.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvArticulos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvArticulos.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvArticulos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvArticulos.Appearance.Preview.Options.UseFont = true;
            this.gvArticulos.Appearance.Preview.Options.UseForeColor = true;
            this.gvArticulos.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.Row.Options.UseBackColor = true;
            this.gvArticulos.Appearance.Row.Options.UseForeColor = true;
            this.gvArticulos.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulos.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvArticulos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvArticulos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvArticulos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvArticulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colclave,
            this.colarticulo});
            this.gvArticulos.GridControl = this.gridArticulos;
            this.gvArticulos.Name = "gvArticulos";
            this.gvArticulos.OptionsBehavior.Editable = false;
            this.gvArticulos.OptionsCustomization.AllowColumnMoving = false;
            this.gvArticulos.OptionsCustomization.AllowFilter = false;
            this.gvArticulos.OptionsCustomization.AllowGroup = false;
            this.gvArticulos.OptionsCustomization.AllowSort = false;
            this.gvArticulos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvArticulos.OptionsView.EnableAppearanceOddRow = true;
            this.gvArticulos.OptionsView.ShowGroupPanel = false;
            // 
            // colclave
            // 
            this.colclave.Caption = "Clave";
            this.colclave.FieldName = "clave";
            this.colclave.Name = "colclave";
            this.colclave.Visible = true;
            this.colclave.VisibleIndex = 0;
            // 
            // colarticulo
            // 
            this.colarticulo.Caption = "Artículo";
            this.colarticulo.FieldName = "articulo";
            this.colarticulo.Name = "colarticulo";
            this.colarticulo.Visible = true;
            this.colarticulo.VisibleIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Seguimiento_y_Control.Properties.Resources.Ok_icon30;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(553, 393);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 37);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(67, 53);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(585, 26);
            this.txbBuscar.TabIndex = 3;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            // 
            // Frm_BuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 442);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gridArticulos);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(680, 480);
            this.MinimumSize = new System.Drawing.Size(680, 480);
            this.Name = "Frm_BuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar Artículos";
            this.Load += new System.EventHandler(this.Frm_BuscarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraGrid.GridControl gridArticulos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArticulos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colclave;
        private DevExpress.XtraGrid.Columns.GridColumn colarticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBuscar;
    }
}