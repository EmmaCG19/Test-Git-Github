namespace WinForm_Test
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxFecha = new System.Windows.Forms.MaskedTextBox();
            this.TxtBoxUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(251, 21);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 1;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(158, 88);
            this.dataGridView1.TabIndex = 2;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(23, 30);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 3;
            this.LblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // TxtBoxFecha
            // 
            this.TxtBoxFecha.Location = new System.Drawing.Point(89, 61);
            this.TxtBoxFecha.Mask = "00/00/0000";
            this.TxtBoxFecha.Name = "TxtBoxFecha";
            this.TxtBoxFecha.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxFecha.TabIndex = 5;
            this.TxtBoxFecha.ValidatingType = typeof(System.DateTime);
            // 
            // TxtBoxUsuario
            // 
            this.TxtBoxUsuario.Location = new System.Drawing.Point(89, 22);
            this.TxtBoxUsuario.Name = "TxtBoxUsuario";
            this.TxtBoxUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxUsuario.TabIndex = 6;
            this.TxtBoxUsuario.TextChanged += new System.EventHandler(this.TxtBoxUsuario_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 174);
            this.Controls.Add(this.TxtBoxUsuario);
            this.Controls.Add(this.TxtBoxFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TxtBoxUsuario;
        private System.Windows.Forms.MaskedTextBox TxtBoxFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAgregar;
    }
}

