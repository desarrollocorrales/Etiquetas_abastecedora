namespace Seguimiento_y_Control.Administracion.Devoluciones
{
    partial class Frm_Devoluciones
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
            this.txbArchivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gridEtiquetas = new DevExpress.XtraGrid.GridControl();
            this.gridDevolucionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEtiquetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroLote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaEmpaque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ofdBuscar = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txbComentario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevolucionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivo de Escaneo:";
            // 
            // txbArchivo
            // 
            this.txbArchivo.BackColor = System.Drawing.Color.White;
            this.txbArchivo.Enabled = false;
            this.txbArchivo.Location = new System.Drawing.Point(149, 38);
            this.txbArchivo.MaxLength = 15;
            this.txbArchivo.Name = "txbArchivo";
            this.txbArchivo.Size = new System.Drawing.Size(442, 26);
            this.txbArchivo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(684, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Devoluciones";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(597, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(30, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAceptar.Location = new System.Drawing.Point(314, 387);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 26);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.gridDevolucionesBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(12, 156);
            this.gridEtiquetas.MainView = this.gvEtiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(660, 225);
            this.gridEtiquetas.TabIndex = 8;
            this.gridEtiquetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiquetas});
            // 
            // gridDevolucionesBindingSource
            // 
            this.gridDevolucionesBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Administracion.GridDevoluciones);
            // 
            // gvEtiquetas
            // 
            this.gvEtiquetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroEtiqueta,
            this.colNumeroLote,
            this.colFechaEmpaque,
            this.colFechaCaducidad,
            this.colClaveArticulo,
            this.colArticulo,
            this.colCantidad,
            this.colUnidad,
            this.colEstado});
            this.gvEtiquetas.GridControl = this.gridEtiquetas;
            this.gvEtiquetas.Name = "gvEtiquetas";
            this.gvEtiquetas.OptionsCustomization.AllowFilter = false;
            this.gvEtiquetas.OptionsCustomization.AllowGroup = false;
            this.gvEtiquetas.OptionsView.ShowGroupPanel = false;
            // 
            // colNumeroEtiqueta
            // 
            this.colNumeroEtiqueta.FieldName = "NumeroEtiqueta";
            this.colNumeroEtiqueta.Name = "colNumeroEtiqueta";
            this.colNumeroEtiqueta.Visible = true;
            this.colNumeroEtiqueta.VisibleIndex = 0;
            // 
            // colNumeroLote
            // 
            this.colNumeroLote.FieldName = "NumeroLote";
            this.colNumeroLote.Name = "colNumeroLote";
            this.colNumeroLote.Visible = true;
            this.colNumeroLote.VisibleIndex = 3;
            // 
            // colFechaEmpaque
            // 
            this.colFechaEmpaque.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
            this.colFechaEmpaque.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaEmpaque.FieldName = "FechaEmpaque";
            this.colFechaEmpaque.Name = "colFechaEmpaque";
            this.colFechaEmpaque.Visible = true;
            this.colFechaEmpaque.VisibleIndex = 4;
            // 
            // colFechaCaducidad
            // 
            this.colFechaCaducidad.FieldName = "FechaCaducidad";
            this.colFechaCaducidad.Name = "colFechaCaducidad";
            this.colFechaCaducidad.Visible = true;
            this.colFechaCaducidad.VisibleIndex = 5;
            // 
            // colClaveArticulo
            // 
            this.colClaveArticulo.FieldName = "ClaveArticulo";
            this.colClaveArticulo.Name = "colClaveArticulo";
            this.colClaveArticulo.Visible = true;
            this.colClaveArticulo.VisibleIndex = 1;
            // 
            // colArticulo
            // 
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 2;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 6;
            // 
            // colUnidad
            // 
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 7;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 8;
            // 
            // ofdBuscar
            // 
            this.ofdBuscar.FileName = "*.txt";
            this.ofdBuscar.Filter = "Archivos de texto | *.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Comentario:";
            // 
            // txbComentario
            // 
            this.txbComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbComentario.Location = new System.Drawing.Point(149, 70);
            this.txbComentario.MaxLength = 1000;
            this.txbComentario.Multiline = true;
            this.txbComentario.Name = "txbComentario";
            this.txbComentario.Size = new System.Drawing.Size(523, 80);
            this.txbComentario.TabIndex = 3;
            // 
            // Frm_Devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 422);
            this.Controls.Add(this.txbComentario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridEtiquetas);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbArchivo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 460);
            this.Name = "Frm_Devoluciones";
            this.ShowIcon = false;
            this.Text = "Devoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevolucionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbArchivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private DevExpress.XtraGrid.GridControl gridEtiquetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtiquetas;
        private System.Windows.Forms.OpenFileDialog ofdBuscar;
        private System.Windows.Forms.BindingSource gridDevolucionesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroLote;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaEmpaque;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaCaducidad;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbComentario;
    }
}