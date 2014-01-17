namespace Seguimiento_y_Control.Administracion.Reimpresiones
{
    partial class Frm_Eliminar_Etiquetas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumeroEtiqueta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gridEtiqueta = new DevExpress.XtraGrid.GridControl();
            this.gvEtiqueta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txbComentario = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiqueta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEtiqueta)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 48);
            this.label2.TabIndex = 12;
            this.label2.Text = "Eliminar Etiqueta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Numero de Etiqueta:";
            // 
            // txbNumeroEtiqueta
            // 
            this.txbNumeroEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNumeroEtiqueta.Location = new System.Drawing.Point(225, 51);
            this.txbNumeroEtiqueta.MaxLength = 13;
            this.txbNumeroEtiqueta.Name = "txbNumeroEtiqueta";
            this.txbNumeroEtiqueta.Size = new System.Drawing.Size(196, 26);
            this.txbNumeroEtiqueta.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscar.Location = new System.Drawing.Point(427, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gridEtiqueta
            // 
            this.gridEtiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEtiqueta.Location = new System.Drawing.Point(12, 83);
            this.gridEtiqueta.MainView = this.gvEtiqueta;
            this.gridEtiqueta.Name = "gridEtiqueta";
            this.gridEtiqueta.Size = new System.Drawing.Size(560, 127);
            this.gridEtiqueta.TabIndex = 16;
            this.gridEtiqueta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEtiqueta});
            // 
            // gvEtiqueta
            // 
            this.gvEtiqueta.GridControl = this.gridEtiqueta;
            this.gvEtiqueta.Name = "gvEtiqueta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Causa de la eliminación:";
            // 
            // txbComentario
            // 
            this.txbComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbComentario.Enabled = false;
            this.txbComentario.Location = new System.Drawing.Point(12, 234);
            this.txbComentario.Multiline = true;
            this.txbComentario.Name = "txbComentario";
            this.txbComentario.Size = new System.Drawing.Size(560, 134);
            this.txbComentario.TabIndex = 18;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Location = new System.Drawing.Point(255, 374);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 26);
            this.btnBorrar.TabIndex = 19;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Frm_Eliminar_Etiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txbComentario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridEtiqueta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbNumeroEtiqueta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "Frm_Eliminar_Etiquetas";
            this.Text = "Eliminar Etiquetas";
            ((System.ComponentModel.ISupportInitialize)(this.gridEtiqueta)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbComentario;
        private System.Windows.Forms.Button btnBorrar;
    }
}