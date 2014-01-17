namespace Seguimiento_y_Control.Topos.RecepcionProveedores
{
    partial class Frm_RecepcionInterna
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbArchivo = new System.Windows.Forms.TextBox();
            this.btnBuscarArchivo = new System.Windows.Forms.Button();
            this.ofdEscaneo = new System.Windows.Forms.OpenFileDialog();
            this.gridEtiquetas = new DevExpress.XtraGrid.GridControl();
            this.gridEtiquetasTraspasadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEtiquetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coloEtiquetaTraspasada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloEtiquetaTraspasada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloEtiquetaTraspasada2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloEtiquetaTraspasada3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloEtiquetaTraspasada4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloEtiquetaTraspasada5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetasTraspasadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(799, 55);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Recepción Interna";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo de escaneo:";
            // 
            // txbArchivo
            // 
            this.txbArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbArchivo.Location = new System.Drawing.Point(237, 58);
            this.txbArchivo.Name = "txbArchivo";
            this.txbArchivo.Size = new System.Drawing.Size(428, 26);
            this.txbArchivo.TabIndex = 3;
            // 
            // btnBuscarArchivo
            // 
            this.btnBuscarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArchivo.Location = new System.Drawing.Point(671, 58);
            this.btnBuscarArchivo.Name = "btnBuscarArchivo";
            this.btnBuscarArchivo.Size = new System.Drawing.Size(30, 26);
            this.btnBuscarArchivo.TabIndex = 4;
            this.btnBuscarArchivo.Text = "...";
            this.btnBuscarArchivo.UseVisualStyleBackColor = true;
            this.btnBuscarArchivo.Click += new System.EventHandler(this.btnBuscarArchivo_Click);
            // 
            // ofdEscaneo
            // 
            this.ofdEscaneo.FileName = "*.txt";
            // 
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.gridEtiquetasTraspasadasBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(12, 131);
            this.gridEtiquetas.MainView = this.gvEtiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(775, 483);
            this.gridEtiquetas.TabIndex = 5;
            this.gridEtiquetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiquetas});
            // 
            // gridEtiquetasTraspasadasBindingSource
            // 
            this.gridEtiquetasTraspasadasBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Topos.GridEtiquetasTraspasadas);
            // 
            // gvEtiquetas
            // 
            this.gvEtiquetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coloEtiquetaTraspasada,
            this.coloEtiquetaTraspasada1,
            this.coloArticulo,
            this.coloEtiquetaTraspasada2,
            this.coloEtiquetaTraspasada3,
            this.coloEtiquetaTraspasada4,
            this.coloEtiquetaTraspasada5,
            this.colEstado});
            this.gvEtiquetas.GridControl = this.gridEtiquetas;
            this.gvEtiquetas.Name = "gvEtiquetas";
            this.gvEtiquetas.OptionsBehavior.Editable = false;
            this.gvEtiquetas.OptionsCustomization.AllowFilter = false;
            this.gvEtiquetas.OptionsCustomization.AllowGroup = false;
            this.gvEtiquetas.OptionsView.ShowGroupPanel = false;
            // 
            // coloEtiquetaTraspasada
            // 
            this.coloEtiquetaTraspasada.Caption = "Número Etiqueta";
            this.coloEtiquetaTraspasada.FieldName = "oEtiquetaTraspasada.numero_etiqueta";
            this.coloEtiquetaTraspasada.Name = "coloEtiquetaTraspasada";
            this.coloEtiquetaTraspasada.Visible = true;
            this.coloEtiquetaTraspasada.VisibleIndex = 0;
            // 
            // coloEtiquetaTraspasada1
            // 
            this.coloEtiquetaTraspasada1.AppearanceCell.Options.UseTextOptions = true;
            this.coloEtiquetaTraspasada1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coloEtiquetaTraspasada1.AppearanceHeader.Options.UseTextOptions = true;
            this.coloEtiquetaTraspasada1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coloEtiquetaTraspasada1.Caption = "Clave";
            this.coloEtiquetaTraspasada1.FieldName = "oEtiquetaTraspasada.clave_articulo";
            this.coloEtiquetaTraspasada1.Name = "coloEtiquetaTraspasada1";
            this.coloEtiquetaTraspasada1.Visible = true;
            this.coloEtiquetaTraspasada1.VisibleIndex = 1;
            // 
            // coloArticulo
            // 
            this.coloArticulo.Caption = "Articulo";
            this.coloArticulo.FieldName = "oArticulo.articulo";
            this.coloArticulo.Name = "coloArticulo";
            this.coloArticulo.Visible = true;
            this.coloArticulo.VisibleIndex = 2;
            // 
            // coloEtiquetaTraspasada2
            // 
            this.coloEtiquetaTraspasada2.AppearanceCell.Options.UseTextOptions = true;
            this.coloEtiquetaTraspasada2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coloEtiquetaTraspasada2.AppearanceHeader.Options.UseTextOptions = true;
            this.coloEtiquetaTraspasada2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coloEtiquetaTraspasada2.Caption = "Fecha Empaque";
            this.coloEtiquetaTraspasada2.FieldName = "oEtiquetaTraspasada.fecha_empaque";
            this.coloEtiquetaTraspasada2.Name = "coloEtiquetaTraspasada2";
            this.coloEtiquetaTraspasada2.Visible = true;
            this.coloEtiquetaTraspasada2.VisibleIndex = 3;
            // 
            // coloEtiquetaTraspasada3
            // 
            this.coloEtiquetaTraspasada3.AppearanceCell.Options.UseTextOptions = true;
            this.coloEtiquetaTraspasada3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coloEtiquetaTraspasada3.AppearanceHeader.Options.UseTextOptions = true;
            this.coloEtiquetaTraspasada3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coloEtiquetaTraspasada3.Caption = "Fecha Caducidad";
            this.coloEtiquetaTraspasada3.FieldName = "oEtiquetaTraspasada.fecha_caducidad";
            this.coloEtiquetaTraspasada3.Name = "coloEtiquetaTraspasada3";
            this.coloEtiquetaTraspasada3.Visible = true;
            this.coloEtiquetaTraspasada3.VisibleIndex = 4;
            // 
            // coloEtiquetaTraspasada4
            // 
            this.coloEtiquetaTraspasada4.AppearanceHeader.Options.UseTextOptions = true;
            this.coloEtiquetaTraspasada4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.coloEtiquetaTraspasada4.Caption = "Cantidad";
            this.coloEtiquetaTraspasada4.FieldName = "oEtiquetaTraspasada.cantidad";
            this.coloEtiquetaTraspasada4.Name = "coloEtiquetaTraspasada4";
            this.coloEtiquetaTraspasada4.Visible = true;
            this.coloEtiquetaTraspasada4.VisibleIndex = 5;
            // 
            // coloEtiquetaTraspasada5
            // 
            this.coloEtiquetaTraspasada5.Caption = "Unidad";
            this.coloEtiquetaTraspasada5.FieldName = "oEtiquetaTraspasada.unidad";
            this.coloEtiquetaTraspasada5.Name = "coloEtiquetaTraspasada5";
            this.coloEtiquetaTraspasada5.Visible = true;
            this.coloEtiquetaTraspasada5.VisibleIndex = 6;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            // 
            // btnRecibir
            // 
            this.btnRecibir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecibir.Enabled = false;
            this.btnRecibir.Image = global::Seguimiento_y_Control.Properties.Resources.save_icon30;
            this.btnRecibir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecibir.Location = new System.Drawing.Point(607, 620);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(88, 35);
            this.btnRecibir.TabIndex = 6;
            this.btnRecibir.Text = "Recibir";
            this.btnRecibir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecibir.UseVisualStyleBackColor = true;
            this.btnRecibir.Click += new System.EventHandler(this.btnRecibir_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = global::Seguimiento_y_Control.Properties.Resources.close_icon30;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(701, 620);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 35);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCargar.Location = new System.Drawing.Point(349, 90);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 35);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar Datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Frm_RecepcionInterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 667);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.gridEtiquetas);
            this.Controls.Add(this.btnBuscarArchivo);
            this.Controls.Add(this.txbArchivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(815, 705);
            this.Name = "Frm_RecepcionInterna";
            this.Text = "Recepcion Interna";
            this.Load += new System.EventHandler(this.Frm_RecepcionInterna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetasTraspasadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiquetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbArchivo;
        private System.Windows.Forms.Button btnBuscarArchivo;
        private System.Windows.Forms.OpenFileDialog ofdEscaneo;
        private DevExpress.XtraGrid.GridControl gridEtiquetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEtiquetas;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.BindingSource gridEtiquetasTraspasadasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coloEtiquetaTraspasada;
        private DevExpress.XtraGrid.Columns.GridColumn coloEtiquetaTraspasada1;
        private DevExpress.XtraGrid.Columns.GridColumn coloArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn coloEtiquetaTraspasada2;
        private DevExpress.XtraGrid.Columns.GridColumn coloEtiquetaTraspasada3;
        private DevExpress.XtraGrid.Columns.GridColumn coloEtiquetaTraspasada4;
        private DevExpress.XtraGrid.Columns.GridColumn coloEtiquetaTraspasada5;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
    }
}