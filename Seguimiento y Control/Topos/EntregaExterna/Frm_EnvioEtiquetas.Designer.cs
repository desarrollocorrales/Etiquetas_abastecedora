namespace Seguimiento_y_Control.Topos.EntregaExterna
{
    partial class Frm_EnvioEtiquetas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCodigoSalida = new System.Windows.Forms.TextBox();
            this.gridEtiquetas = new DevExpress.XtraGrid.GridControl();
            this.gridEnvioEtiquetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEiquetas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumeroEtiqueta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveArticuo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroEtiquetaPaquete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmpresas = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ofdEscaneo = new System.Windows.Forms.OpenFileDialog();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnvioEtiquetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEiquetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(734, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Envio de etiquetas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo de Salida:";
            // 
            // txbCodigoSalida
            // 
            this.txbCodigoSalida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCodigoSalida.BackColor = System.Drawing.Color.White;
            this.txbCodigoSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodigoSalida.Location = new System.Drawing.Point(233, 70);
            this.txbCodigoSalida.MaxLength = 20;
            this.txbCodigoSalida.Name = "txbCodigoSalida";
            this.txbCodigoSalida.Size = new System.Drawing.Size(370, 26);
            this.txbCodigoSalida.TabIndex = 7;
            // 
            // gridEtiquetas
            // 
            this.gridEtiquetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiquetas.DataSource = this.gridEnvioEtiquetasBindingSource;
            this.gridEtiquetas.Location = new System.Drawing.Point(12, 136);
            this.gridEtiquetas.MainView = this.gvEiquetas;
            this.gridEtiquetas.Name = "gridEtiquetas";
            this.gridEtiquetas.Size = new System.Drawing.Size(710, 370);
            this.gridEtiquetas.TabIndex = 9;
            this.gridEtiquetas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEiquetas});
            // 
            // gridEnvioEtiquetasBindingSource
            // 
            this.gridEnvioEtiquetasBindingSource.DataSource = typeof(Seguimiento_y_Control.Clases.Topos.GridEnvioEtiquetas);
            // 
            // gvEiquetas
            // 
            this.gvEiquetas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumeroEtiqueta,
            this.colClaveArticuo,
            this.colArticulo,
            this.colCantidad,
            this.colUnidad,
            this.colEstatus,
            this.colNumeroEtiquetaPaquete});
            this.gvEiquetas.GridControl = this.gridEtiquetas;
            this.gvEiquetas.GroupCount = 1;
            this.gvEiquetas.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NumeroEtiqueta", null, "")});
            this.gvEiquetas.Name = "gvEiquetas";
            this.gvEiquetas.OptionsBehavior.Editable = false;
            this.gvEiquetas.OptionsMenu.EnableColumnMenu = false;
            this.gvEiquetas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNumeroEtiquetaPaquete, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvEiquetas.EndGrouping += new System.EventHandler(this.gvEiquetas_EndGrouping);
            // 
            // colNumeroEtiqueta
            // 
            this.colNumeroEtiqueta.FieldName = "NumeroEtiqueta";
            this.colNumeroEtiqueta.Name = "colNumeroEtiqueta";
            this.colNumeroEtiqueta.Visible = true;
            this.colNumeroEtiqueta.VisibleIndex = 0;
            // 
            // colClaveArticuo
            // 
            this.colClaveArticuo.FieldName = "ClaveArticuo";
            this.colClaveArticuo.Name = "colClaveArticuo";
            this.colClaveArticuo.Visible = true;
            this.colClaveArticuo.VisibleIndex = 1;
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
            this.colCantidad.VisibleIndex = 3;
            // 
            // colUnidad
            // 
            this.colUnidad.FieldName = "Unidad";
            this.colUnidad.Name = "colUnidad";
            this.colUnidad.Visible = true;
            this.colUnidad.VisibleIndex = 4;
            // 
            // colEstatus
            // 
            this.colEstatus.FieldName = "Estatus";
            this.colEstatus.Name = "colEstatus";
            this.colEstatus.Visible = true;
            this.colEstatus.VisibleIndex = 5;
            // 
            // colNumeroEtiquetaPaquete
            // 
            this.colNumeroEtiquetaPaquete.Caption = "Etiqueta Tarima";
            this.colNumeroEtiquetaPaquete.FieldName = "NumeroEtiquetaPaquete";
            this.colNumeroEtiquetaPaquete.Name = "colNumeroEtiquetaPaquete";
            this.colNumeroEtiquetaPaquete.Visible = true;
            this.colNumeroEtiquetaPaquete.VisibleIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lugar a enviar:";
            // 
            // cbEmpresas
            // 
            this.cbEmpresas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEmpresas.DataSource = this.empresasBindingSource;
            this.cbEmpresas.DisplayMember = "nombre";
            this.cbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresas.FormattingEnabled = true;
            this.cbEmpresas.Location = new System.Drawing.Point(233, 38);
            this.cbEmpresas.Name = "cbEmpresas";
            this.cbEmpresas.Size = new System.Drawing.Size(369, 26);
            this.cbEmpresas.TabIndex = 11;
            this.cbEmpresas.ValueMember = "id_empresa";
            this.cbEmpresas.SelectedIndexChanged += new System.EventHandler(this.cbEmpresas_SelectedIndexChanged);
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataSource = typeof(Seguimiento_y_Control.Entity.Traspasos.empresas);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEnviar.AutoSize = true;
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(339, 512);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(56, 28);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Location = new System.Drawing.Point(651, 512);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 28);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ofdEscaneo
            // 
            this.ofdEscaneo.FileName = "*.txt";
            this.ofdEscaneo.Filter = "Archivos de texto | *.txt";
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCargarDatos.AutoSize = true;
            this.btnCargarDatos.Location = new System.Drawing.Point(315, 102);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(105, 28);
            this.btnCargarDatos.TabIndex = 14;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // Frm_EnvioEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 552);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.cbEmpresas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridEtiquetas);
            this.Controls.Add(this.txbCodigoSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 590);
            this.Name = "Frm_EnvioEtiquetas";
            this.Text = "Envio de Etiquetas";
            this.Load += new System.EventHandler(this.Frm_EnvioEtiquetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnvioEtiquetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEiquetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCodigoSalida;
        private DevExpress.XtraGrid.GridControl gridEtiquetas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEiquetas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEmpresas;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private System.Windows.Forms.OpenFileDialog ofdEscaneo;
        private System.Windows.Forms.BindingSource gridEnvioEtiquetasBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEtiqueta;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveArticuo;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatus;
        private System.Windows.Forms.Button btnCargarDatos;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroEtiquetaPaquete;
    }
}