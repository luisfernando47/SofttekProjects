namespace ShoesApp
{
    partial class BusquedaProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDproduct = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscaID = new System.Windows.Forms.Button();
            this.btnBuscaNombre = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNvoReg = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnEliminaProd = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID_Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtIDproduct
            // 
            this.txtIDproduct.Location = new System.Drawing.Point(141, 40);
            this.txtIDproduct.Name = "txtIDproduct";
            this.txtIDproduct.Size = new System.Drawing.Size(100, 26);
            this.txtIDproduct.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 106);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // btnBuscaID
            // 
            this.btnBuscaID.Location = new System.Drawing.Point(291, 40);
            this.btnBuscaID.Name = "btnBuscaID";
            this.btnBuscaID.Size = new System.Drawing.Size(77, 26);
            this.btnBuscaID.TabIndex = 4;
            this.btnBuscaID.Text = "Buscar";
            this.btnBuscaID.UseVisualStyleBackColor = true;
            this.btnBuscaID.Click += new System.EventHandler(this.btnBuscaID_Click);
            // 
            // btnBuscaNombre
            // 
            this.btnBuscaNombre.Location = new System.Drawing.Point(291, 106);
            this.btnBuscaNombre.Name = "btnBuscaNombre";
            this.btnBuscaNombre.Size = new System.Drawing.Size(77, 26);
            this.btnBuscaNombre.TabIndex = 5;
            this.btnBuscaNombre.Text = "Buscar";
            this.btnBuscaNombre.UseVisualStyleBackColor = true;
            this.btnBuscaNombre.Click += new System.EventHandler(this.btnBuscaNombre_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(712, 221);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnNvoReg
            // 
            this.btnNvoReg.Location = new System.Drawing.Point(439, 106);
            this.btnNvoReg.Name = "btnNvoReg";
            this.btnNvoReg.Size = new System.Drawing.Size(77, 26);
            this.btnNvoReg.TabIndex = 7;
            this.btnNvoReg.Text = "Nuevo";
            this.btnNvoReg.UseVisualStyleBackColor = true;
            this.btnNvoReg.Click += new System.EventHandler(this.btnNvoReg_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(552, 106);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(77, 26);
            this.btnEditProd.TabIndex = 8;
            this.btnEditProd.Text = "Editar";
            this.btnEditProd.UseVisualStyleBackColor = true;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnEliminaProd
            // 
            this.btnEliminaProd.Location = new System.Drawing.Point(660, 106);
            this.btnEliminaProd.Name = "btnEliminaProd";
            this.btnEliminaProd.Size = new System.Drawing.Size(77, 26);
            this.btnEliminaProd.TabIndex = 9;
            this.btnEliminaProd.Text = "Eliminar";
            this.btnEliminaProd.UseVisualStyleBackColor = true;
            this.btnEliminaProd.Click += new System.EventHandler(this.btnEliminaProd_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(643, 414);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(94, 43);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // BusquedaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnEliminaProd);
            this.Controls.Add(this.btnEditProd);
            this.Controls.Add(this.btnNvoReg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscaNombre);
            this.Controls.Add(this.btnBuscaID);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDproduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BusquedaProducto";
            this.Text = "BusquedaProducto";
            this.Load += new System.EventHandler(this.BusquedaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDproduct;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscaID;
        private System.Windows.Forms.Button btnBuscaNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNvoReg;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Button btnEliminaProd;
        private System.Windows.Forms.Button btnreset;
    }
}