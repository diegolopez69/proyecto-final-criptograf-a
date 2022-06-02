
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
            this.lblClave1 = new System.Windows.Forms.Label();
            this.txtClavePublica = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportKeys = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.txtClave = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClave1
            // 
            this.lblClave1.AutoSize = true;
            this.lblClave1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.lblClave1.Location = new System.Drawing.Point(4, 46);
            this.lblClave1.Name = "lblClave1";
            this.lblClave1.Size = new System.Drawing.Size(37, 13);
            this.lblClave1.TabIndex = 2;
            this.lblClave1.Text = "Clave";
            // 
            // txtClavePublica
            // 
            this.txtClavePublica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.txtClavePublica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClavePublica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.txtClavePublica.Location = new System.Drawing.Point(365, 65);
            this.txtClavePublica.Name = "txtClavePublica";
            this.txtClavePublica.ReadOnly = true;
            this.txtClavePublica.Size = new System.Drawing.Size(329, 96);
            this.txtClavePublica.TabIndex = 3;
            this.txtClavePublica.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(365, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clave Publica";
            // 
            // btnImportKeys
            // 
            this.btnImportKeys.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btnImportKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btnImportKeys.Location = new System.Drawing.Point(594, 5);
            this.btnImportKeys.Name = "btnImportKeys";
            this.btnImportKeys.Size = new System.Drawing.Size(100, 22);
            this.btnImportKeys.TabIndex = 6;
            this.btnImportKeys.Text = "Importar Llaves";
            this.btnImportKeys.UseVisualStyleBackColor = true;
            this.btnImportKeys.Click += new System.EventHandler(this.btnImportKeys_Click);
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
            this.panel1.Location = new System.Drawing.Point(35, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 211);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnImportText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDesencriptado);
            this.panel2.Controls.Add(this.txtTextoEncriptado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnDesecnriptar);
            this.panel2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(35, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 220);
            this.panel2.TabIndex = 10;
            // 
            // btnImportText
            // 
            this.btnImportText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.btnImportText.Location = new System.Drawing.Point(365, 181);
            this.btnImportText.Name = "btnImportText";
            this.btnImportText.Size = new System.Drawing.Size(329, 23);
            this.btnImportText.TabIndex = 19;
            this.btnImportText.Text = "Importar Texto";
            this.btnImportText.UseVisualStyleBackColor = true;
            this.btnImportText.Click += new System.EventHandler(this.btnImportText_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label5.Location = new System.Drawing.Point(362, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Resultado";
            // 
            // txtDesencriptado
            // 
            this.txtDesencriptado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.txtDesencriptado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesencriptado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesencriptado.Location = new System.Drawing.Point(365, 106);
            this.txtDesencriptado.Name = "txtDesencriptado";
            this.txtDesencriptado.Size = new System.Drawing.Size(329, 19);
            this.txtDesencriptado.TabIndex = 16;
            // 
            // txtTextoEncriptado
            // 
            this.txtTextoEncriptado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.txtTextoEncriptado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTextoEncriptado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoEncriptado.Location = new System.Drawing.Point(365, 43);
            this.txtTextoEncriptado.Name = "txtTextoEncriptado";
            this.txtTextoEncriptado.Size = new System.Drawing.Size(329, 19);
            this.txtTextoEncriptado.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(362, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Texto";
            // 
            // btnDesecnriptar
            // 
            this.btnDesecnriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnDesecnriptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(161)))), ((int)(((byte)(193)))));
            this.btnDesecnriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesecnriptar.Location = new System.Drawing.Point(365, 152);
            this.btnDesecnriptar.Name = "btnDesecnriptar";
            this.btnDesecnriptar.Size = new System.Drawing.Size(329, 23);
            this.btnDesecnriptar.TabIndex = 13;
            this.btnDesecnriptar.Text = "Desencriptar";
            this.btnDesecnriptar.UseVisualStyleBackColor = false;
            this.btnDesecnriptar.Click += new System.EventHandler(this.btnDesecnriptar_Click);
            // 
            // cmbAlgoritmos
            // 
            this.cmbAlgoritmos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.cmbAlgoritmos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbAlgoritmos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgoritmos.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlgoritmos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.cmbAlgoritmos.FormattingEnabled = true;
            this.cmbAlgoritmos.IntegralHeight = false;
            this.cmbAlgoritmos.ItemHeight = 20;
            this.cmbAlgoritmos.Items.AddRange(new object[] {
            "TDES",
            "RSA"});
            this.cmbAlgoritmos.Location = new System.Drawing.Point(536, 44);
            this.cmbAlgoritmos.Name = "cmbAlgoritmos";
            this.cmbAlgoritmos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAlgoritmos.Size = new System.Drawing.Size(203, 26);
            this.cmbAlgoritmos.TabIndex = 11;
            this.cmbAlgoritmos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbAlgoritmos_DrawItem);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.label6.Location = new System.Drawing.Point(379, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccione el algoritmo:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.txtClave.Location = new System.Drawing.Point(8, 65);
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(329, 96);
            this.txtClave.TabIndex = 1;
            this.txtClave.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(781, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAlgoritmos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClave1;
        private System.Windows.Forms.RichTextBox txtClavePublica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportKeys;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.RichTextBox txtClave;
    }
}

