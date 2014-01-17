namespace Seguimiento_y_Control.Administracion
{
    partial class Frm_AdmImpresoras
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
            this.gridImpresoras = new DevExpress.XtraGrid.GridControl();
            this.impresoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvImpresoras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNombreImpresora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridImpresoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impresoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImpresoras)).BeginInit();
            this.SuspendLayout();
            // 
            // gridImpresoras
            // 
            this.gridImpresoras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridImpresoras.DataSource = this.impresoraBindingSource;
            this.gridImpresoras.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridImpresoras.Location = new System.Drawing.Point(16, 39);
            this.gridImpresoras.MainView = this.gvImpresoras;
            this.gridImpresoras.Margin = new System.Windows.Forms.Padding(4);
            this.gridImpresoras.Name = "gridImpresoras";
            this.gridImpresoras.Size = new System.Drawing.Size(587, 349);
            this.gridImpresoras.TabIndex = 0;
            this.gridImpresoras.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvImpresoras});
            // 
            // impresoraBindingSource
            // 
            this.impresoraBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Administracion.Impresora);
            // 
            // gvImpresoras
            // 
            this.gvImpresoras.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvImpresoras.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvImpresoras.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvImpresoras.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvImpresoras.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvImpresoras.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvImpresoras.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvImpresoras.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gvImpresoras.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvImpresoras.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvImpresoras.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvImpresoras.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvImpresoras.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvImpresoras.Appearance.Empty.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvImpresoras.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvImpresoras.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvImpresoras.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvImpresoras.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvImpresoras.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvImpresoras.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvImpresoras.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvImpresoras.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvImpresoras.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gvImpresoras.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gvImpresoras.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvImpresoras.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvImpresoras.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvImpresoras.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvImpresoras.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvImpresoras.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvImpresoras.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvImpresoras.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvImpresoras.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvImpresoras.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvImpresoras.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvImpresoras.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvImpresoras.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvImpresoras.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvImpresoras.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvImpresoras.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvImpresoras.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvImpresoras.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvImpresoras.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvImpresoras.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvImpresoras.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvImpresoras.Appearance.GroupRow.Options.UseFont = true;
            this.gvImpresoras.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvImpresoras.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvImpresoras.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvImpresoras.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvImpresoras.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvImpresoras.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvImpresoras.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gvImpresoras.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvImpresoras.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvImpresoras.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvImpresoras.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvImpresoras.Appearance.OddRow.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.OddRow.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gvImpresoras.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gvImpresoras.Appearance.Preview.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.Preview.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvImpresoras.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvImpresoras.Appearance.Row.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.Row.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvImpresoras.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gvImpresoras.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvImpresoras.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvImpresoras.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvImpresoras.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvImpresoras.Appearance.VertLine.Options.UseBackColor = true;
            this.gvImpresoras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreImpresora,
            this.colID});
            this.gvImpresoras.GridControl = this.gridImpresoras;
            this.gvImpresoras.Name = "gvImpresoras";
            this.gvImpresoras.OptionsBehavior.Editable = false;
            this.gvImpresoras.OptionsCustomization.AllowFilter = false;
            this.gvImpresoras.OptionsCustomization.AllowGroup = false;
            this.gvImpresoras.OptionsMenu.EnableColumnMenu = false;
            this.gvImpresoras.OptionsView.EnableAppearanceEvenRow = true;
            this.gvImpresoras.OptionsView.EnableAppearanceOddRow = true;
            this.gvImpresoras.OptionsView.ShowGroupPanel = false;
            // 
            // colNombreImpresora
            // 
            this.colNombreImpresora.FieldName = "NombreImpresora";
            this.colNombreImpresora.Name = "colNombreImpresora";
            this.colNombreImpresora.Visible = true;
            this.colNombreImpresora.VisibleIndex = 1;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(528, 395);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 35);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Impresoras";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_AdmImpresoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gridImpresoras);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(635, 480);
            this.Name = "Frm_AdmImpresoras";
            this.ShowIcon = false;
            this.Text = "Administración de Impresoras";
            this.Load += new System.EventHandler(this.Frm_AdmImpresoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridImpresoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impresoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvImpresoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridImpresoras;
        private DevExpress.XtraGrid.Views.Grid.GridView gvImpresoras;
        private System.Windows.Forms.BindingSource impresoraBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreImpresora;
        private System.Windows.Forms.Button btnGuardar;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private System.Windows.Forms.Label label1;
    }
}