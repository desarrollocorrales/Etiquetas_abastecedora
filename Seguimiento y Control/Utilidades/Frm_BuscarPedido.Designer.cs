namespace Seguimiento_y_Control.Utilidades
{
    partial class Frm_BuscarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarPedido));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbPedidos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridArticulosRequerir = new DevExpress.XtraGrid.GridControl();
            this.articuloRequerirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvArticulosRequerir = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colarticulo_a_requerir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarticulo_a_requerir1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_a_requrir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colunidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosRequerir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloRequerirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulosRequerir)).BeginInit();
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
            this.lblTitulo.Text = "Buscar Pedido";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPedidos
            // 
            this.cbPedidos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPedidos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPedidos.FormattingEnabled = true;
            this.cbPedidos.Location = new System.Drawing.Point(319, 53);
            this.cbPedidos.Name = "cbPedidos";
            this.cbPedidos.Size = new System.Drawing.Size(121, 26);
            this.cbPedidos.TabIndex = 2;
            this.cbPedidos.SelectedIndexChanged += new System.EventHandler(this.cbPedidos_SelectedIndexChanged);
            this.cbPedidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPedidos_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de Pedido:";
            // 
            // gridArticulosRequerir
            // 
            this.gridArticulosRequerir.DataSource = this.articuloRequerirBindingSource;
            this.gridArticulosRequerir.Location = new System.Drawing.Point(12, 103);
            this.gridArticulosRequerir.MainView = this.gvArticulosRequerir;
            this.gridArticulosRequerir.Name = "gridArticulosRequerir";
            this.gridArticulosRequerir.Size = new System.Drawing.Size(640, 284);
            this.gridArticulosRequerir.TabIndex = 5;
            this.gridArticulosRequerir.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvArticulosRequerir});
            // 
            // articuloRequerirBindingSource
            // 
            this.articuloRequerirBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Produccion.ArticuloRequerir);
            // 
            // gvArticulosRequerir
            // 
            this.gvArticulosRequerir.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulosRequerir.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulosRequerir.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvArticulosRequerir.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulosRequerir.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulosRequerir.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvArticulosRequerir.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulosRequerir.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gvArticulosRequerir.Appearance.Empty.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvArticulosRequerir.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvArticulosRequerir.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulosRequerir.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulosRequerir.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulosRequerir.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvArticulosRequerir.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulosRequerir.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvArticulosRequerir.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulosRequerir.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.gvArticulosRequerir.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvArticulosRequerir.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvArticulosRequerir.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.gvArticulosRequerir.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.gvArticulosRequerir.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvArticulosRequerir.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulosRequerir.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulosRequerir.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulosRequerir.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulosRequerir.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulosRequerir.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulosRequerir.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulosRequerir.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvArticulosRequerir.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulosRequerir.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvArticulosRequerir.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulosRequerir.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulosRequerir.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvArticulosRequerir.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulosRequerir.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvArticulosRequerir.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvArticulosRequerir.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvArticulosRequerir.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvArticulosRequerir.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvArticulosRequerir.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulosRequerir.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulosRequerir.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulosRequerir.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulosRequerir.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvArticulosRequerir.Appearance.OddRow.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvArticulosRequerir.Appearance.OddRow.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvArticulosRequerir.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvArticulosRequerir.Appearance.Preview.Options.UseFont = true;
            this.gvArticulosRequerir.Appearance.Preview.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvArticulosRequerir.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvArticulosRequerir.Appearance.Row.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.Row.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvArticulosRequerir.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvArticulosRequerir.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvArticulosRequerir.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvArticulosRequerir.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvArticulosRequerir.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvArticulosRequerir.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvArticulosRequerir.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvArticulosRequerir.Appearance.VertLine.Options.UseBackColor = true;
            this.gvArticulosRequerir.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colarticulo_a_requerir,
            this.colarticulo_a_requerir1,
            this.colcantidad_a_requrir,
            this.colunidad});
            this.gvArticulosRequerir.GridControl = this.gridArticulosRequerir;
            this.gvArticulosRequerir.Name = "gvArticulosRequerir";
            this.gvArticulosRequerir.OptionsBehavior.Editable = false;
            this.gvArticulosRequerir.OptionsCustomization.AllowFilter = false;
            this.gvArticulosRequerir.OptionsCustomization.AllowGroup = false;
            this.gvArticulosRequerir.OptionsCustomization.AllowSort = false;
            this.gvArticulosRequerir.OptionsView.EnableAppearanceEvenRow = true;
            this.gvArticulosRequerir.OptionsView.EnableAppearanceOddRow = true;
            this.gvArticulosRequerir.OptionsView.ShowGroupPanel = false;
            // 
            // colarticulo_a_requerir
            // 
            this.colarticulo_a_requerir.Caption = "Clave";
            this.colarticulo_a_requerir.FieldName = "articulo_a_requerir.clave";
            this.colarticulo_a_requerir.Name = "colarticulo_a_requerir";
            this.colarticulo_a_requerir.Visible = true;
            this.colarticulo_a_requerir.VisibleIndex = 0;
            // 
            // colarticulo_a_requerir1
            // 
            this.colarticulo_a_requerir1.Caption = "Articulo";
            this.colarticulo_a_requerir1.FieldName = "articulo_a_requerir.articulo";
            this.colarticulo_a_requerir1.Name = "colarticulo_a_requerir1";
            this.colarticulo_a_requerir1.Visible = true;
            this.colarticulo_a_requerir1.VisibleIndex = 1;
            // 
            // colcantidad_a_requrir
            // 
            this.colcantidad_a_requrir.Caption = "Cantidad";
            this.colcantidad_a_requrir.FieldName = "cantidad_a_requrir";
            this.colcantidad_a_requrir.Name = "colcantidad_a_requrir";
            this.colcantidad_a_requrir.Visible = true;
            this.colcantidad_a_requrir.VisibleIndex = 2;
            // 
            // colunidad
            // 
            this.colunidad.Caption = "Unidad";
            this.colunidad.FieldName = "unidad";
            this.colunidad.Name = "colunidad";
            this.colunidad.Visible = true;
            this.colunidad.VisibleIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Seguimiento_y_Control.Properties.Resources.Ok_icon30;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(553, 393);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 37);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Productos Requeridos:";
            // 
            // Frm_BuscarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gridArticulosRequerir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPedidos);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(680, 480);
            this.MinimumSize = new System.Drawing.Size(680, 480);
            this.Name = "Frm_BuscarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Pedido";
            this.Load += new System.EventHandler(this.Frm_BuscarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridArticulosRequerir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloRequerirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvArticulosRequerir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbPedidos;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridArticulosRequerir;
        private System.Windows.Forms.BindingSource articuloRequerirBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvArticulosRequerir;
        private DevExpress.XtraGrid.Columns.GridColumn colarticulo_a_requerir;
        private DevExpress.XtraGrid.Columns.GridColumn colarticulo_a_requerir1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_a_requrir;
        private DevExpress.XtraGrid.Columns.GridColumn colunidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
    }
}