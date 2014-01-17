namespace Seguimiento_y_Control.Administracion.Articulos
{
    partial class Frm_Articulos
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gridArticulos = new DevExpress.XtraGrid.GridControl();
            this.articuloMicrosipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvArticulos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloMicrosipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Articulos Registrados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(393, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gridArticulos
            // 
            this.gridArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridArticulos.DataSource = this.articuloMicrosipBindingSource;
            this.gridArticulos.Location = new System.Drawing.Point(12, 77);
            this.gridArticulos.MainView = this.gvArticulos;
            this.gridArticulos.Name = "gridArticulos";
            this.gridArticulos.Size = new System.Drawing.Size(781, 443);
            this.gridArticulos.TabIndex = 3;
            this.gridArticulos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArticulos});
            // 
            // articuloMicrosipBindingSource
            // 
            this.articuloMicrosipBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Administracion.ArticuloMicrosip);
            // 
            // gvArticulos
            // 
            this.gvArticulos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvArticulos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvArticulos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvArticulos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvArticulos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gvArticulos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvArticulos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.Empty.Options.UseBackColor = true;
            this.gvArticulos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvArticulos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvArticulos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvArticulos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvArticulos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvArticulos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gvArticulos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gvArticulos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvArticulos.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvArticulos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvArticulos.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvArticulos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvArticulos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvArticulos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvArticulos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvArticulos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvArticulos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvArticulos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvArticulos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvArticulos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvArticulos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvArticulos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvArticulos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.GroupRow.Options.UseFont = true;
            this.gvArticulos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvArticulos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvArticulos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvArticulos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvArticulos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvArticulos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvArticulos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvArticulos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gvArticulos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvArticulos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvArticulos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvArticulos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gvArticulos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gvArticulos.Appearance.Preview.Options.UseBackColor = true;
            this.gvArticulos.Appearance.Preview.Options.UseForeColor = true;
            this.gvArticulos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.Row.Options.UseBackColor = true;
            this.gvArticulos.Appearance.Row.Options.UseForeColor = true;
            this.gvArticulos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvArticulos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvArticulos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gvArticulos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvArticulos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvArticulos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvArticulos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvArticulos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colClave,
            this.colNombre});
            this.gvArticulos.GridControl = this.gridArticulos;
            this.gvArticulos.Name = "gvArticulos";
            this.gvArticulos.OptionsBehavior.Editable = false;
            this.gvArticulos.OptionsCustomization.AllowFilter = false;
            this.gvArticulos.OptionsCustomization.AllowGroup = false;
            this.gvArticulos.OptionsCustomization.AllowSort = false;
            this.gvArticulos.OptionsMenu.EnableColumnMenu = false;
            this.gvArticulos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvArticulos.OptionsView.EnableAppearanceOddRow = true;
            this.gvArticulos.OptionsView.ShowGroupPanel = false;
            // 
            // colClave
            // 
            this.colClave.AppearanceCell.Options.UseTextOptions = true;
            this.colClave.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClave.AppearanceHeader.Options.UseTextOptions = true;
            this.colClave.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colClave.FieldName = "Clave";
            this.colClave.Name = "colClave";
            this.colClave.Visible = true;
            this.colClave.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(12, 33);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 38);
            this.btModificar.TabIndex = 4;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // Frm_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 532);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.gridArticulos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Articulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Frm_Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloMicrosipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraGrid.GridControl gridArticulos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArticulos;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.BindingSource articuloMicrosipBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colClave;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
    }
}