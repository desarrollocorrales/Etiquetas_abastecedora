namespace Seguimiento_y_Control.Produccion
{
    partial class Frm_Tarimas
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
            this.gridEtiquetas = new DevExpress.XtraGrid.GridControl();
            this.etiquetasTarimasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEtiquetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colChecked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtiqueta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtiqueta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEtiqueta3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumPedido = new System.Windows.Forms.TextBox();
            this.btnBuscaPedido = new System.Windows.Forms.Button();
            this.txbArticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscaArticulo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasTarimasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(734, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Crear Tarima ";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.etiquetasTarimasBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(13, 102);
            this.gridEtiquetas.MainView = this.gvEtiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(710, 366);
            this.gridEtiquetas.TabIndex = 1;
            this.gridEtiquetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiquetas});
            // 
            // etiquetasTarimasBindingSource
            // 
            this.etiquetasTarimasBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Produccion.EtiquetasTarimas);
            // 
            // gvEtiquetas
            // 
            this.gvEtiquetas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.Empty.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvEtiquetas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvEtiquetas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvEtiquetas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEtiquetas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvEtiquetas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEtiquetas.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvEtiquetas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseFont = true;
            this.gvEtiquetas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEtiquetas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEtiquetas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEtiquetas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvEtiquetas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvEtiquetas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvEtiquetas.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvEtiquetas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvEtiquetas.Appearance.Preview.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.Preview.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvEtiquetas.Appearance.Row.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.Row.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvEtiquetas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvEtiquetas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEtiquetas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEtiquetas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvEtiquetas.Appearance.VertLine.Options.UseBackColor = true;
            this.gvEtiquetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colChecked,
            this.colEtiqueta,
            this.colEtiqueta1,
            this.colEtiqueta2,
            this.colEtiqueta3});
            this.gvEtiquetas.GridControl = this.gridEtiquetas;
            this.gvEtiquetas.Name = "gvEtiquetas";
            this.gvEtiquetas.OptionsCustomization.AllowGroup = false;
            this.gvEtiquetas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEtiquetas.OptionsView.EnableAppearanceOddRow = true;
            this.gvEtiquetas.OptionsView.ShowGroupPanel = false;
            // 
            // colChecked
            // 
            this.colChecked.Caption = " ";
            this.colChecked.FieldName = "Checked";
            this.colChecked.Name = "colChecked";
            this.colChecked.Visible = true;
            this.colChecked.VisibleIndex = 0;
            // 
            // colEtiqueta
            // 
            this.colEtiqueta.Caption = "Etiqueta";
            this.colEtiqueta.FieldName = "Etiqueta.numero_etiqueta";
            this.colEtiqueta.Name = "colEtiqueta";
            this.colEtiqueta.OptionsColumn.AllowEdit = false;
            this.colEtiqueta.Visible = true;
            this.colEtiqueta.VisibleIndex = 1;
            // 
            // colEtiqueta1
            // 
            this.colEtiqueta1.Caption = "Articulo";
            this.colEtiqueta1.FieldName = "Etiqueta.articulos.articulo";
            this.colEtiqueta1.Name = "colEtiqueta1";
            this.colEtiqueta1.OptionsColumn.AllowEdit = false;
            this.colEtiqueta1.Visible = true;
            this.colEtiqueta1.VisibleIndex = 2;
            // 
            // colEtiqueta2
            // 
            this.colEtiqueta2.Caption = "Cantidad";
            this.colEtiqueta2.FieldName = "Etiqueta.cantidad";
            this.colEtiqueta2.Name = "colEtiqueta2";
            this.colEtiqueta2.OptionsColumn.AllowEdit = false;
            this.colEtiqueta2.Visible = true;
            this.colEtiqueta2.VisibleIndex = 3;
            // 
            // colEtiqueta3
            // 
            this.colEtiqueta3.Caption = "Unidad";
            this.colEtiqueta3.FieldName = "Etiqueta.unidad";
            this.colEtiqueta3.Name = "colEtiqueta3";
            this.colEtiqueta3.OptionsColumn.AllowEdit = false;
            this.colEtiqueta3.Visible = true;
            this.colEtiqueta3.VisibleIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pedido:";
            // 
            // txbNumPedido
            // 
            this.txbNumPedido.BackColor = System.Drawing.Color.White;
            this.txbNumPedido.Enabled = false;
            this.txbNumPedido.Location = new System.Drawing.Point(78, 38);
            this.txbNumPedido.Name = "txbNumPedido";
            this.txbNumPedido.Size = new System.Drawing.Size(205, 26);
            this.txbNumPedido.TabIndex = 3;
            // 
            // btnBuscaPedido
            // 
            this.btnBuscaPedido.Location = new System.Drawing.Point(289, 38);
            this.btnBuscaPedido.Name = "btnBuscaPedido";
            this.btnBuscaPedido.Size = new System.Drawing.Size(35, 26);
            this.btnBuscaPedido.TabIndex = 4;
            this.btnBuscaPedido.Text = "...";
            this.btnBuscaPedido.UseVisualStyleBackColor = true;
            this.btnBuscaPedido.Click += new System.EventHandler(this.btnBuscaPedido_Click);
            // 
            // txbArticulo
            // 
            this.txbArticulo.Location = new System.Drawing.Point(78, 70);
            this.txbArticulo.Name = "txbArticulo";
            this.txbArticulo.Size = new System.Drawing.Size(454, 26);
            this.txbArticulo.TabIndex = 5;
            this.txbArticulo.TextChanged += new System.EventHandler(this.txbArticulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Articulo:";
            // 
            // btnBuscaArticulo
            // 
            this.btnBuscaArticulo.Location = new System.Drawing.Point(538, 69);
            this.btnBuscaArticulo.Name = "btnBuscaArticulo";
            this.btnBuscaArticulo.Size = new System.Drawing.Size(35, 26);
            this.btnBuscaArticulo.TabIndex = 7;
            this.btnBuscaArticulo.Text = "...";
            this.btnBuscaArticulo.UseVisualStyleBackColor = true;
            this.btnBuscaArticulo.Click += new System.EventHandler(this.btnBuscaArticulo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(638, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 26);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCrear.Enabled = false;
            this.btnCrear.Location = new System.Drawing.Point(333, 474);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(69, 26);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "Crear";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // Frm_Tarimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBuscaArticulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbArticulo);
            this.Controls.Add(this.btnBuscaPedido);
            this.Controls.Add(this.txbNumPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridEtiquetas);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Frm_Tarimas";
            this.Text = "Crear Tarima";
            this.Load += new System.EventHandler(this.Frm_Tarimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiquetasTarimasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private DevExpress.XtraGrid.GridControl gridEtiquetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtiquetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumPedido;
        private System.Windows.Forms.Button btnBuscaPedido;
        private System.Windows.Forms.TextBox txbArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscaArticulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.BindingSource etiquetasTarimasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colChecked;
        private DevExpress.XtraGrid.Columns.GridColumn colEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colEtiqueta2;
        private DevExpress.XtraGrid.Columns.GridColumn colEtiqueta3;
        private DevExpress.XtraGrid.Columns.GridColumn colEtiqueta1;
    }
}