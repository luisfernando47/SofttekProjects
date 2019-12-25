namespace XML
{
    partial class Form1
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
            this.btnAddXML = new System.Windows.Forms.Button();
            this.btnUpdateXML = new System.Windows.Forms.Button();
            this.btnDeleteXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddXML
            // 
            this.btnAddXML.Location = new System.Drawing.Point(53, 124);
            this.btnAddXML.Name = "btnAddXML";
            this.btnAddXML.Size = new System.Drawing.Size(90, 37);
            this.btnAddXML.TabIndex = 0;
            this.btnAddXML.Text = "Crear";
            this.btnAddXML.UseVisualStyleBackColor = true;
            this.btnAddXML.Click += new System.EventHandler(this.btnAddXML_Click);
            // 
            // btnUpdateXML
            // 
            this.btnUpdateXML.Location = new System.Drawing.Point(232, 124);
            this.btnUpdateXML.Name = "btnUpdateXML";
            this.btnUpdateXML.Size = new System.Drawing.Size(90, 37);
            this.btnUpdateXML.TabIndex = 1;
            this.btnUpdateXML.Text = "Actualizar ";
            this.btnUpdateXML.UseVisualStyleBackColor = true;
            this.btnUpdateXML.Click += new System.EventHandler(this.btnUpdateXML_Click);
            // 
            // btnDeleteXML
            // 
            this.btnDeleteXML.Location = new System.Drawing.Point(395, 124);
            this.btnDeleteXML.Name = "btnDeleteXML";
            this.btnDeleteXML.Size = new System.Drawing.Size(90, 37);
            this.btnDeleteXML.TabIndex = 2;
            this.btnDeleteXML.Text = "Eliminar";
            this.btnDeleteXML.UseVisualStyleBackColor = true;
            this.btnDeleteXML.Click += new System.EventHandler(this.btnDeleteXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "XML Controler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteXML);
            this.Controls.Add(this.btnUpdateXML);
            this.Controls.Add(this.btnAddXML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddXML;
        private System.Windows.Forms.Button btnUpdateXML;
        private System.Windows.Forms.Button btnDeleteXML;
        private System.Windows.Forms.Label label1;
    }
}

