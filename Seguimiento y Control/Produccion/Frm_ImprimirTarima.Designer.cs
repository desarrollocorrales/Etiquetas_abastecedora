namespace Seguimiento_y_Control.Produccion
{
    partial class Frm_ImprimirTarima
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNumPedido = new System.Windows.Forms.TextBox();
            this.btnBuscarPedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridEtiquetas = new DevExpress.XtraGrid.GridControl();
            this.tarimasGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEtiquetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTarima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarima1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarima2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarima3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscarTarimas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarimasGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "ddd dd/MMM/yyyy";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(79, 72);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 26);
            this.dtpFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pedido:";
            // 
            // txbNumPedido
            // 
            this.txbNumPedido.Location = new System.Drawing.Point(79, 40);
            this.txbNumPedido.Name = "txbNumPedido";
            this.txbNumPedido.Size = new System.Drawing.Size(200, 26);
            this.txbNumPedido.TabIndex = 3;
            // 
            // btnBuscarPedido
            // 
            this.btnBuscarPedido.Location = new System.Drawing.Point(285, 40);
            this.btnBuscarPedido.Name = "btnBuscarPedido";
            this.btnBuscarPedido.Size = new System.Drawing.Size(129, 26);
            this.btnBuscarPedido.TabIndex = 4;
            this.btnBuscarPedido.Text = "Buscar Pedido";
            this.btnBuscarPedido.UseVisualStyleBackColor = true;
            this.btnBuscarPedido.Click += new System.EventHandler(this.btnBuscarPedido_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(743, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Imprimir Tarima";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.tarimasGridBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(12, 104);
            this.gridEtiquetas.MainView = this.gvEtiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(719, 272);
            this.gridEtiquetas.TabIndex = 6;
            this.gridEtiquetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiquetas});
            // 
            // tarimasGridBindingSource
            // 
            this.tarimasGridBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Produccion.TarimasGrid);
            // 
            // gvEtiquetas
            // 
            this.gvEtiquetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTarima,
            this.colArticulo,
            this.colTarima1,
            this.colTarima2,
            this.colTarima3});
            this.gvEtiquetas.GridControl = this.gridEtiquetas;
            this.gvEtiquetas.Name = "gvEtiquetas";
            this.gvEtiquetas.OptionsBehavior.Editable = false;
            this.gvEtiquetas.OptionsCustomization.AllowFilter = false;
            this.gvEtiquetas.OptionsCustomization.AllowGroup = false;
            this.gvEtiquetas.OptionsView.ShowGroupPanel = false;
            // 
            // colTarima
            // 
            this.colTarima.Caption = "Numero de Etiqueta";
            this.colTarima.FieldName = "Tarima.numero_etiqueta";
            this.colTarima.Name = "colTarima";
            this.colTarima.Visible = true;
            this.colTarima.VisibleIndex = 0;
            // 
            // colArticulo
            // 
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 1;
            // 
            // colTarima1
            // 
            this.colTarima1.Caption = "Fecha Producción";
            this.colTarima1.FieldName = "Tarima.fecha_creacion";
            this.colTarima1.Name = "colTarima1";
            this.colTarima1.Visible = true;
            this.colTarima1.VisibleIndex = 4;
            // 
            // colTarima2
            // 
            this.colTarima2.Caption = "Cantidad";
            this.colTarima2.FieldName = "Tarima.cantidad";
            this.colTarima2.Name = "colTarima2";
            this.colTarima2.Visible = true;
            this.colTarima2.VisibleIndex = 2;
            // 
            // colTarima3
            // 
            this.colTarima3.Caption = "Unidad";
            this.colTarima3.FieldName = "Tarima.unidad";
            this.colTarima3.Name = "colTarima3";
            this.colTarima3.Visible = true;
            this.colTarima3.VisibleIndex = 3;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Location = new System.Drawing.Point(334, 382);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 26);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBuscarTarimas
            // 
            this.btnBuscarTarimas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarTarimas.Location = new System.Drawing.Point(656, 74);
            this.btnBuscarTarimas.Name = "btnBuscarTarimas";
            this.btnBuscarTarimas.Size = new System.Drawing.Size(75, 26);
            this.btnBuscarTarimas.TabIndex = 8;
            this.btnBuscarTarimas.Text = "Buscar Tarimas";
            this.btnBuscarTarimas.UseVisualStyleBackColor = true;
            this.btnBuscarTarimas.Click += new System.EventHandler(this.btnBuscarTarimas_Click);
            // 
            // Frm_ImprimirTarima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 420);
            this.Controls.Add(this.btnBuscarTarimas);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gridEtiquetas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarPedido);
            this.Controls.Add(this.txbNumPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ImprimirTarima";
            this.Text = "Imprimir Tarima";
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarimasGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNumPedido;
        private System.Windows.Forms.Button btnBuscarPedido;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridEtiquetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtiquetas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscarTarimas;
        private System.Windows.Forms.BindingSource tarimasGridBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTarima;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarima1;
        private DevExpress.XtraGrid.Columns.GridColumn colTarima2;
        private DevExpress.XtraGrid.Columns.GridColumn colTarima3;
    }
}