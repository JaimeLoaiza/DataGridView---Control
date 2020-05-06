namespace Proyecto_DataGridView___Control
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvTablaProductos = new System.Windows.Forms.DataGridView();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblInformacionDetalle = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvTablaProductos
            // 
            this.DgvTablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombreProducto,
            this.PrecioProducto});
            this.DgvTablaProductos.Location = new System.Drawing.Point(15, 217);
            this.DgvTablaProductos.Name = "DgvTablaProductos";
            this.DgvTablaProductos.Size = new System.Drawing.Size(430, 277);
            this.DgvTablaProductos.TabIndex = 0;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(12, 18);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(59, 13);
            this.lblIdProducto.TabIndex = 1;
            this.lblIdProducto.Text = "IdProducto";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(145, 18);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(90, 13);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(275, 18);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(83, 13);
            this.lblPrecioProducto.TabIndex = 3;
            this.lblPrecioProducto.Text = "Precio Producto";
            // 
            // lblInformacionDetalle
            // 
            this.lblInformacionDetalle.AutoSize = true;
            this.lblInformacionDetalle.Location = new System.Drawing.Point(12, 150);
            this.lblInformacionDetalle.Name = "lblInformacionDetalle";
            this.lblInformacionDetalle.Size = new System.Drawing.Size(104, 13);
            this.lblInformacionDetalle.TabIndex = 4;
            this.lblInformacionDetalle.Text = "Información - Detalle";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(15, 34);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(100, 20);
            this.txtIdProducto.TabIndex = 5;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(148, 34);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProducto.TabIndex = 6;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(278, 34);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProducto.TabIndex = 7;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(15, 76);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(100, 34);
            this.btnAgregarProducto.TabIndex = 8;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Location = new System.Drawing.Point(148, 76);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(100, 34);
            this.btnBorrarProducto.TabIndex = 9;
            this.btnBorrarProducto.Text = "Borrar Producto";
            this.btnBorrarProducto.UseVisualStyleBackColor = true;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "Id Producto";
            this.IdProducto.Name = "IdProducto";
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            // 
            // PrecioProducto
            // 
            this.PrecioProducto.HeaderText = "Precio Producto";
            this.PrecioProducto.Name = "PrecioProducto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 506);
            this.Controls.Add(this.btnBorrarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.lblInformacionDetalle);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.DgvTablaProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTablaProductos;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblInformacionDetalle;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnBorrarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioProducto;
    }
}

