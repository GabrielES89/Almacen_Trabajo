namespace Almacen1.Productos
{
    partial class frm_Nuevo_MF
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorMAC = new System.Windows.Forms.Label();
            this.lblBarra1 = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.lblMAC = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cbFactura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNoFactura = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tmError = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 231);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lblErrorMAC);
            this.panel1.Controls.Add(this.lblBarra1);
            this.panel1.Controls.Add(this.txtMAC);
            this.panel1.Controls.Add(this.lblMAC);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.cbFactura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNoFactura);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 214);
            this.panel1.TabIndex = 32;
            // 
            // lblErrorMAC
            // 
            this.lblErrorMAC.AutoSize = true;
            this.lblErrorMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMAC.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorMAC.Location = new System.Drawing.Point(92, 112);
            this.lblErrorMAC.Name = "lblErrorMAC";
            this.lblErrorMAC.Size = new System.Drawing.Size(187, 16);
            this.lblErrorMAC.TabIndex = 235;
            this.lblErrorMAC.Text = "La MAC no puede estar vacia.";
            this.lblErrorMAC.Visible = false;
            // 
            // lblBarra1
            // 
            this.lblBarra1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra1.Location = new System.Drawing.Point(94, 104);
            this.lblBarra1.Name = "lblBarra1";
            this.lblBarra1.Size = new System.Drawing.Size(452, 2);
            this.lblBarra1.TabIndex = 77;
            // 
            // txtMAC
            // 
            this.txtMAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAC.Location = new System.Drawing.Point(93, 80);
            this.txtMAC.MaxLength = 17;
            this.txtMAC.Multiline = true;
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(452, 29);
            this.txtMAC.TabIndex = 0;
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMAC.Location = new System.Drawing.Point(3, 81);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(45, 18);
            this.lblMAC.TabIndex = 76;
            this.lblMAC.Text = "MAC:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Maroon;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(397, 156);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(149, 44);
            this.btn_cancelar.TabIndex = 74;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(227, 156);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(149, 44);
            this.btn_guardar.TabIndex = 73;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cbFactura
            // 
            this.cbFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFactura.FormattingEnabled = true;
            this.cbFactura.Location = new System.Drawing.Point(94, 142);
            this.cbFactura.Name = "cbFactura";
            this.cbFactura.Size = new System.Drawing.Size(101, 26);
            this.cbFactura.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(95, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 2);
            this.label3.TabIndex = 65;
            // 
            // lblNoFactura
            // 
            this.lblNoFactura.AutoSize = true;
            this.lblNoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNoFactura.Location = new System.Drawing.Point(-2, 145);
            this.lblNoFactura.Name = "lblNoFactura";
            this.lblNoFactura.Size = new System.Drawing.Size(90, 18);
            this.lblNoFactura.TabIndex = 64;
            this.lblNoFactura.Text = "No. Factura:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(211, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(144, 36);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "Registrar";
            // 
            // tmError
            // 
            this.tmError.Interval = 5000;
            this.tmError.Tick += new System.EventHandler(this.tmError_Tick);
            // 
            // frm_Nuevo_MF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 254);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Nuevo_MF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_Nuevo_MF";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBarra1;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cbFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNoFactura;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblErrorMAC;
        private System.Windows.Forms.Timer tmError;
    }
}