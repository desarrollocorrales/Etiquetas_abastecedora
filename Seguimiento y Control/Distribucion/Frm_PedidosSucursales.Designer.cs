namespace Seguimiento_y_Control.Distribucion
{
    partial class Frm_PedidosSucursales
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
            this.gridPedidos = new DevExpress.XtraGrid.GridControl();
            this.gridPedidoSucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPedidos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSeleccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Pedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaSurtir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnImprimirPedidos = new System.Windows.Forms.Button();
            this.btnRequerir = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidoSucursalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPedidos
            // 
            this.gridPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPedidos.DataSource = this.gridPedidoSucursalBindingSource;
            this.gridPedidos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridPedidos.Location = new System.Drawing.Point(13, 81);
            this.gridPedidos.MainView = this.gvPedidos;
            this.gridPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.Size = new System.Drawing.Size(702, 349);
            this.gridPedidos.TabIndex = 0;
            this.gridPedidos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidos});
            // 
            // gridPedidoSucursalBindingSource
            // 
            this.gridPedidoSucursalBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Distribucion.GridPedidoSucursal);
            // 
            // gvPedidos
            // 
            this.gvPedidos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPedidos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvPedidos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPedidos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPedidos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPedidos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPedidos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gvPedidos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPedidos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPedidos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPedidos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.Empty.Options.UseBackColor = true;
            this.gvPedidos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPedidos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPedidos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvPedidos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPedidos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPedidos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvPedidos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPedidos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gvPedidos.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gvPedidos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPedidos.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvPedidos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPedidos.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPedidos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPedidos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPedidos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPedidos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPedidos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvPedidos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPedidos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPedidos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPedidos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPedidos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvPedidos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPedidos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPedidos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPedidos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPedidos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPedidos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvPedidos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.GroupRow.Options.UseFont = true;
            this.gvPedidos.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPedidos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvPedidos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPedidos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPedidos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPedidos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPedidos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPedidos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gvPedidos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvPedidos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvPedidos.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvPedidos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gvPedidos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gvPedidos.Appearance.Preview.Options.UseBackColor = true;
            this.gvPedidos.Appearance.Preview.Options.UseForeColor = true;
            this.gvPedidos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.Row.Options.UseBackColor = true;
            this.gvPedidos.Appearance.Row.Options.UseForeColor = true;
            this.gvPedidos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvPedidos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPedidos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gvPedidos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPedidos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPedidos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvPedidos.Appearance.VertLine.Options.UseBackColor = true;
            this.gvPedidos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSeleccion,
            this.colID_Pedido,
            this.colResponsable,
            this.colSucursal,
            this.colFechaPedido,
            this.colFechaSurtir});
            this.gvPedidos.GridControl = this.gridPedidos;
            this.gvPedidos.Name = "gvPedidos";
            this.gvPedidos.OptionsCustomization.AllowFilter = false;
            this.gvPedidos.OptionsMenu.EnableColumnMenu = false;
            this.gvPedidos.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedidos.OptionsView.EnableAppearanceOddRow = true;
            this.gvPedidos.OptionsView.ShowGroupPanel = false;
            // 
            // colSeleccion
            // 
            this.colSeleccion.AppearanceCell.Options.UseTextOptions = true;
            this.colSeleccion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSeleccion.AppearanceHeader.Options.UseTextOptions = true;
            this.colSeleccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSeleccion.Caption = " ";
            this.colSeleccion.FieldName = "Seleccion";
            this.colSeleccion.Name = "colSeleccion";
            this.colSeleccion.Visible = true;
            this.colSeleccion.VisibleIndex = 0;
            // 
            // colID_Pedido
            // 
            this.colID_Pedido.AppearanceCell.Options.UseTextOptions = true;
            this.colID_Pedido.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID_Pedido.AppearanceHeader.Options.UseTextOptions = true;
            this.colID_Pedido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID_Pedido.FieldName = "ID_Pedido";
            this.colID_Pedido.Name = "colID_Pedido";
            this.colID_Pedido.OptionsColumn.AllowEdit = false;
            this.colID_Pedido.Visible = true;
            this.colID_Pedido.VisibleIndex = 1;
            // 
            // colResponsable
            // 
            this.colResponsable.FieldName = "Responsable";
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.OptionsColumn.AllowEdit = false;
            this.colResponsable.Visible = true;
            this.colResponsable.VisibleIndex = 2;
            // 
            // colSucursal
            // 
            this.colSucursal.FieldName = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.OptionsColumn.AllowEdit = false;
            this.colSucursal.Visible = true;
            this.colSucursal.VisibleIndex = 3;
            // 
            // colFechaPedido
            // 
            this.colFechaPedido.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
            this.colFechaPedido.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaPedido.FieldName = "FechaPedido";
            this.colFechaPedido.Name = "colFechaPedido";
            this.colFechaPedido.OptionsColumn.AllowEdit = false;
            this.colFechaPedido.Visible = true;
            this.colFechaPedido.VisibleIndex = 4;
            // 
            // colFechaSurtir
            // 
            this.colFechaSurtir.AppearanceCell.Options.UseTextOptions = true;
            this.colFechaSurtir.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaSurtir.AppearanceHeader.Options.UseTextOptions = true;
            this.colFechaSurtir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFechaSurtir.FieldName = "FechaSurtir";
            this.colFechaSurtir.Name = "colFechaSurtir";
            this.colFechaSurtir.OptionsColumn.AllowEdit = false;
            this.colFechaSurtir.Visible = true;
            this.colFechaSurtir.VisibleIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Requisiciones de Sucursales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = global::Seguimiento_y_Control.Properties.Resources.close_icon30;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(275, 38);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 36);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnImprimirPedidos
            // 
            this.btnImprimirPedidos.Image = global::Seguimiento_y_Control.Properties.Resources.Printer30;
            this.btnImprimirPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirPedidos.Location = new System.Drawing.Point(116, 38);
            this.btnImprimirPedidos.Name = "btnImprimirPedidos";
            this.btnImprimirPedidos.Size = new System.Drawing.Size(153, 36);
            this.btnImprimirPedidos.TabIndex = 6;
            this.btnImprimirPedidos.Text = "Imprimir Pedidos";
            this.btnImprimirPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirPedidos.UseVisualStyleBackColor = true;
            this.btnImprimirPedidos.Click += new System.EventHandler(this.btnImprimirPedidos_Click);
            // 
            // btnRequerir
            // 
            this.btnRequerir.Image = global::Seguimiento_y_Control.Properties.Resources.checklist_icon301;
            this.btnRequerir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequerir.Location = new System.Drawing.Point(12, 38);
            this.btnRequerir.Name = "btnRequerir";
            this.btnRequerir.Size = new System.Drawing.Size(98, 36);
            this.btnRequerir.TabIndex = 5;
            this.btnRequerir.Text = "Requerir";
            this.btnRequerir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequerir.UseVisualStyleBackColor = true;
            this.btnRequerir.Click += new System.EventHandler(this.btnRequerir_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLoading.Image = global::Seguimiento_y_Control.Properties.Resources.cargando;
            this.pbLoading.Location = new System.Drawing.Point(275, 193);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(169, 94);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLoading.TabIndex = 8;
            this.pbLoading.TabStop = false;
            // 
            // Frm_PedidosSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 443);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnImprimirPedidos);
            this.Controls.Add(this.btnRequerir);
            this.Controls.Add(this.gridPedidos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_PedidosSucursales";
            this.Text = "Requisiciones de Sucursales";
            this.Shown += new System.EventHandler(this.Frm_PedidosSucursales_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidoSucursalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridPedidos;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnImprimirPedidos;
        private System.Windows.Forms.Button btnRequerir;
        private System.Windows.Forms.BindingSource gridPedidoSucursalBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSeleccion;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Pedido;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaSurtir;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaPedido;
        private System.Windows.Forms.PictureBox pbLoading;
    }
}