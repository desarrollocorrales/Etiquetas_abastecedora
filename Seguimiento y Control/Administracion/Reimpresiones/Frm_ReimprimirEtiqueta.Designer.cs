namespace Seguimiento_y_Control.Administracion.Reimpresiones
{
    partial class Frm_ReimprimirEtiqueta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumeroEtiqueta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridEtiqueta = new DevExpress.XtraGrid.GridControl();
            this.gridReimprimirEtiquetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEtiqueta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txbComentario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiqueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReimprimirEtiquetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiqueta)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Reimprimir Etiqueta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Numero de Etiqueta:";
            // 
            // txbNumeroEtiqueta
            // 
            this.txbNumeroEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNumeroEtiqueta.Location = new System.Drawing.Point(307, 38);
            this.txbNumeroEtiqueta.MaxLength = 13;
            this.txbNumeroEtiqueta.Name = "txbNumeroEtiqueta";
            this.txbNumeroEtiqueta.Size = new System.Drawing.Size(133, 26);
            this.txbNumeroEtiqueta.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Location = new System.Drawing.Point(265, 70);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridEtiqueta
            // 
            this.gridEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridEtiqueta.DataSource = this.gridReimprimirEtiquetaBindingSource;
            this.gridEtiqueta.Location = new System.Drawing.Point(12, 102);
            this.gridEtiqueta.MainView = this.gvEtiqueta;
            this.gridEtiqueta.Name = "gridEtiqueta";
            this.gridEtiqueta.Size = new System.Drawing.Size(580, 135);
            this.gridEtiqueta.TabIndex = 15;
            this.gridEtiqueta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiqueta});
            // 
            // gridReimprimirEtiquetaBindingSource
            // 
            this.gridReimprimirEtiquetaBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Administracion.GridReimprimirEtiqueta);
            // 
            // gvEtiqueta
            // 
            this.gvEtiqueta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroEtiqueta,
            this.colTipoEtiqueta,
            this.colClaveArticulo,
            this.colArticulo,
            this.colCantidad,
            this.colUnidad});
            this.gvEtiqueta.GridControl = this.gridEtiqueta;
            this.gvEtiqueta.Name = "gvEtiqueta";
            this.gvEtiqueta.OptionsCustomization.AllowGroup = false;
            this.gvEtiqueta.OptionsView.ShowGroupPanel = false;
            // 
            // colNumeroEtiqueta
            // 
            this.colNumeroEtiqueta.FieldName = "NumeroEtiqueta";
            this.colNumeroEtiqueta.Name = "colNumeroEtiqueta";
            this.colNumeroEtiqueta.Visible = true;
            this.colNumeroEtiqueta.VisibleIndex = 1;
            // 
            // colTipoEtiqueta
            // 
            this.colTipoEtiqueta.FieldName = "TipoEtiqueta";
            this.colTipoEtiqueta.Name = "colTipoEtiqueta";
            this.colTipoEtiqueta.Visible = true;
            this.colTipoEtiqueta.VisibleIndex = 0;
            // 
            // colClaveArticulo
            // 
            this.colClaveArticulo.FieldName = "ClaveArticulo";
            this.colClaveArticulo.Name = "colClaveArticulo";
            this.colClaveArticulo.Visible = true;
            this.colClaveArticulo.VisibleIndex = 2;
            // 
            // colArticulo
            // 
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 3;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 4;
            // 
            // colUnidad
            // 
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 5;
            // 
            // txbComentario
            // 
            this.txbComentario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbComentario.Enabled = false;
            this.txbComentario.Location = new System.Drawing.Point(12, 261);
            this.txbComentario.Multiline = true;
            this.txbComentario.Name = "txbComentario";
            this.txbComentario.Size = new System.Drawing.Size(580, 132);
            this.txbComentario.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Comentario:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(265, 399);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 26);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Frm_ReimprimirEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 437);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbComentario);
            this.Controls.Add(this.gridEtiqueta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbNumeroEtiqueta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(620, 475);
            this.Name = "Frm_ReimprimirEtiqueta";
            this.Text = "Reimprimir Etiqueta";
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiqueta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridReimprimirEtiquetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiqueta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumeroEtiqueta;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraGrid.GridControl gridEtiqueta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtiqueta;
        private System.Windows.Forms.TextBox txbComentario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.BindingSource gridReimprimirEtiquetaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
    }
}