
namespace CryptoProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImportText = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesencriptado = new System.Windows.Forms.TextBox();
            this.txtTextoEncriptado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDesecnriptar = new System.Windows.Forms.Button();
            this.cmbAlgoritmos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClavePublica = new System.Windows.Forms.RichTextBox();
            this.lblClave1 = new System.Windows.Forms.Label();
            this.btnImportKeys = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnImportText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDesencriptado);
            this.panel2.Controls.Add(this.txtTextoEncriptado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnDesecnriptar);
            this.panel2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 314);
            this.panel2.TabIndex = 10;
            // 
            // btnImportText
            // 
            this.btnImportText.BackColor = System.Drawing.Color.White;
            this.btnImportText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportText.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.btnImportText.ForeColor = System.Drawing.Color.Black;
            this.btnImportText.Location = new System.Drawing.Point(741, 37);
            this.btnImportText.Name = "btnImportText";
            this.btnImportText.Size = new System.Drawing.Size(205, 101);
            this.btnImportText.TabIndex = 19;
            this.btnImportText.Text = "Importar Texto";
            this.btnImportText.UseVisualStyleBackColor = false;
            this.btnImportText.Click += new System.EventHandler(this.btnImportText_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label5.Location = new System.Drawing.Point(30, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "Resultado";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtDesencriptado
            // 
            this.txtDesencriptado.BackColor = System.Drawing.Color.White;
            this.txtDesencriptado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesencriptado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txtDesencriptado.Location = new System.Drawing.Point(282, 175);
            this.txtDesencriptado.Multiline = true;
            this.txtDesencriptado.Name = "txtDesencriptado";
            this.txtDesencriptado.Size = new System.Drawing.Size(347, 101);
            this.txtDesencriptado.TabIndex = 16;
            // 
            // txtTextoEncriptado
            // 
            this.txtTextoEncriptado.BackColor = System.Drawing.Color.White;
            this.txtTextoEncriptado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTextoEncriptado.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txtTextoEncriptado.Location = new System.Drawing.Point(282, 37);
            this.txtTextoEncriptado.Multiline = true;
            this.txtTextoEncriptado.Name = "txtTextoEncriptado";
            this.txtTextoEncriptado.Size = new System.Drawing.Size(347, 101);
            this.txtTextoEncriptado.TabIndex = 15;
            this.txtTextoEncriptado.TextChanged += new System.EventHandler(this.txtTextoEncriptado_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(30, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Texto encriptado";
            // 
            // btnDesecnriptar
            // 
            this.btnDesecnriptar.BackColor = System.Drawing.Color.White;
            this.btnDesecnriptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnDesecnriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesecnriptar.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.btnDesecnriptar.Location = new System.Drawing.Point(741, 175);
            this.btnDesecnriptar.Name = "btnDesecnriptar";
            this.btnDesecnriptar.Size = new System.Drawing.Size(205, 101);
            this.btnDesecnriptar.TabIndex = 13;
            this.btnDesecnriptar.Text = "Desencriptar";
            this.btnDesecnriptar.UseVisualStyleBackColor = false;
            this.btnDesecnriptar.Click += new System.EventHandler(this.btnDesecnriptar_Click);
            // 
            // cmbAlgoritmos
            // 
            this.cmbAlgoritmos.BackColor = System.Drawing.Color.White;
            this.cmbAlgoritmos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAlgoritmos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgoritmos.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.cmbAlgoritmos.ForeColor = System.Drawing.Color.Black;
            this.cmbAlgoritmos.FormattingEnabled = true;
            this.cmbAlgoritmos.IntegralHeight = false;
            this.cmbAlgoritmos.ItemHeight = 20;
            this.cmbAlgoritmos.Items.AddRange(new object[] {
            "TDES",
            "RSA"});
            this.cmbAlgoritmos.Location = new System.Drawing.Point(754, 118);
            this.cmbAlgoritmos.Name = "cmbAlgoritmos";
            this.cmbAlgoritmos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAlgoritmos.Size = new System.Drawing.Size(205, 26);
            this.cmbAlgoritmos.TabIndex = 11;
            this.cmbAlgoritmos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbAlgoritmos_DrawItem);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label6.Location = new System.Drawing.Point(43, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccione el algoritmo:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clave Pública";
            // 
            // txtClavePublica
            // 
            this.txtClavePublica.BackColor = System.Drawing.Color.White;
            this.txtClavePublica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClavePublica.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.txtClavePublica.ForeColor = System.Drawing.Color.Black;
            this.txtClavePublica.Location = new System.Drawing.Point(282, 148);
            this.txtClavePublica.Name = "txtClavePublica";
            this.txtClavePublica.ReadOnly = true;
            this.txtClavePublica.Size = new System.Drawing.Size(347, 81);
            this.txtClavePublica.TabIndex = 3;
            this.txtClavePublica.Text = "";
            // 
            // lblClave1
            // 
            this.lblClave1.AutoSize = true;
            this.lblClave1.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.lblClave1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.lblClave1.Location = new System.Drawing.Point(30, 148);
            this.lblClave1.Name = "lblClave1";
            this.lblClave1.Size = new System.Drawing.Size(145, 27);
            this.lblClave1.TabIndex = 2;
            this.lblClave1.Text = "Clave privada";
            // 
            // btnImportKeys
            // 
            this.btnImportKeys.BackColor = System.Drawing.Color.White;
            this.btnImportKeys.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btnImportKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportKeys.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.btnImportKeys.ForeColor = System.Drawing.Color.Black;
            this.btnImportKeys.Location = new System.Drawing.Point(741, 72);
            this.btnImportKeys.Name = "btnImportKeys";
            this.btnImportKeys.Size = new System.Drawing.Size(205, 81);
            this.btnImportKeys.TabIndex = 6;
            this.btnImportKeys.Text = "Importar Llaves";
            this.btnImportKeys.UseVisualStyleBackColor = false;
            this.btnImportKeys.Click += new System.EventHandler(this.btnImportKeys_Click);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.White;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.Location = new System.Drawing.Point(282, 16);
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(347, 81);
            this.txtClave.TabIndex = 1;
            this.txtClave.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.btnImportKeys);
            this.panel1.Controls.Add(this.lblClave1);
            this.panel1.Controls.Add(this.txtClavePublica);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 246);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 61);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lucha contra rusia";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(30, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "desencriptado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 770);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAlgoritmos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desencriptar RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDesecnriptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesencriptado;
        private System.Windows.Forms.TextBox txtTextoEncriptado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAlgoritmos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImportText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtClavePublica;
        private System.Windows.Forms.Label lblClave1;
        private System.Windows.Forms.Button btnImportKeys;
        private System.Windows.Forms.RichTextBox txtClave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

