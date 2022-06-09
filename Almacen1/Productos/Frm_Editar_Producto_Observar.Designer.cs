namespace Almacen1.Productos
{
    partial class Frm_Editar_Producto_Observar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pFE = new System.Windows.Forms.Panel();
            this.lblBarra3 = new System.Windows.Forms.Label();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.cbFolio = new System.Windows.Forms.ComboBox();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblBarra4 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.cbEstatus = new System.Windows.Forms.ComboBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lblBarra2 = new System.Windows.Forms.Label();
            this.txtMac = new System.Windows.Forms.TextBox();
            this.lblMac = new System.Windows.Forms.Label();
            this.txtModificar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pMac = new System.Windows.Forms.Panel();
            this.pSerie = new System.Windows.Forms.Panel();
            this.lblBarra1 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pFE.SuspendLayout();
            this.pMac.SuspendLayout();
            this.pSerie.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 465);
            this.panel2.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pSerie);
            this.panel1.Controls.Add(this.pMac);
            this.panel1.Controls.Add(this.pFE);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.txtModificar);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 450);
            this.panel1.TabIndex = 1;
            // 
            // pFE
            // 
            this.pFE.Controls.Add(this.lblBarra3);
            this.pFE.Controls.Add(this.lblFolio);
            this.pFE.Controls.Add(this.lblNota4);
            this.pFE.Controls.Add(this.cbFolio);
            this.pFE.Controls.Add(this.lblEstatus);
            this.pFE.Controls.Add(this.lblBarra4);
            this.pFE.Controls.Add(this.lblNota3);
            this.pFE.Controls.Add(this.cbEstatus);
            this.pFE.Location = new System.Drawing.Point(10, 216);
            this.pFE.Name = "pFE";
            this.pFE.Size = new System.Drawing.Size(460, 139);
            this.pFE.TabIndex = 247;
            // 
            // lblBarra3
            // 
            this.lblBarra3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra3.Location = new System.Drawing.Point(73, 34);
            this.lblBarra3.Name = "lblBarra3";
            this.lblBarra3.Size = new System.Drawing.Size(360, 2);
            this.lblBarra3.TabIndex = 247;
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.ForeColor = System.Drawing.Color.Black;
            this.lblFolio.Location = new System.Drawing.Point(10, 10);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(48, 23);
            this.lblFolio.TabIndex = 59;
            this.lblFolio.Text = "Folio:";
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota4.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNota4.Location = new System.Drawing.Point(70, 114);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(36, 13);
            this.lblNota4.TabIndex = 246;
            this.lblNota4.Text = "Nota1";
            this.lblNota4.Visible = false;
            // 
            // cbFolio
            // 
            this.cbFolio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFolio.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbFolio.FormattingEnabled = true;
            this.cbFolio.Location = new System.Drawing.Point(73, 9);
            this.cbFolio.Name = "cbFolio";
            this.cbFolio.Size = new System.Drawing.Size(380, 30);
            this.cbFolio.TabIndex = 54;
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatus.ForeColor = System.Drawing.Color.Black;
            this.lblEstatus.Location = new System.Drawing.Point(10, 82);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(64, 23);
            this.lblEstatus.TabIndex = 245;
            this.lblEstatus.Text = "Estatus:";
            // 
            // lblBarra4
            // 
            this.lblBarra4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra4.Location = new System.Drawing.Point(73, 106);
            this.lblBarra4.Name = "lblBarra4";
            this.lblBarra4.Size = new System.Drawing.Size(360, 2);
            this.lblBarra4.TabIndex = 243;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNota3.Location = new System.Drawing.Point(70, 42);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(36, 13);
            this.lblNota3.TabIndex = 239;
            this.lblNota3.Text = "Nota1";
            this.lblNota3.Visible = false;
            // 
            // cbEstatus
            // 
            this.cbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstatus.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbEstatus.FormattingEnabled = true;
            this.cbEstatus.Location = new System.Drawing.Point(73, 81);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(380, 30);
            this.cbEstatus.TabIndex = 244;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNota2.Location = new System.Drawing.Point(72, 44);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(36, 13);
            this.lblNota2.TabIndex = 238;
            this.lblNota2.Text = "Nota1";
            this.lblNota2.Visible = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Maroon;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(321, 385);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(149, 44);
            this.btn_cancelar.TabIndex = 75;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lblBarra2
            // 
            this.lblBarra2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra2.Location = new System.Drawing.Point(75, 32);
            this.lblBarra2.Name = "lblBarra2";
            this.lblBarra2.Size = new System.Drawing.Size(360, 2);
            this.lblBarra2.TabIndex = 58;
            // 
            // txtMac
            // 
            this.txtMac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMac.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtMac.Location = new System.Drawing.Point(75, 12);
            this.txtMac.MaxLength = 50;
            this.txtMac.Multiline = true;
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(360, 29);
            this.txtMac.TabIndex = 55;
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMac.ForeColor = System.Drawing.Color.Black;
            this.lblMac.Location = new System.Drawing.Point(10, 10);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(44, 23);
            this.lblMac.TabIndex = 57;
            this.lblMac.Text = "Mac:";
            // 
            // txtModificar
            // 
            this.txtModificar.BackColor = System.Drawing.Color.Navy;
            this.txtModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificar.ForeColor = System.Drawing.Color.White;
            this.txtModificar.Location = new System.Drawing.Point(19, 385);
            this.txtModificar.Name = "txtModificar";
            this.txtModificar.Size = new System.Drawing.Size(149, 44);
            this.txtModificar.TabIndex = 6;
            this.txtModificar.Text = "Modificar";
            this.txtModificar.UseVisualStyleBackColor = false;
            this.txtModificar.Click += new System.EventHandler(this.txtModificar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblId.Location = new System.Drawing.Point(6, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 20);
            this.lblId.TabIndex = 29;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNombre.Location = new System.Drawing.Point(3, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 37);
            this.lblNombre.TabIndex = 28;
            // 
            // pMac
            // 
            this.pMac.Controls.Add(this.lblBarra2);
            this.pMac.Controls.Add(this.lblMac);
            this.pMac.Controls.Add(this.txtMac);
            this.pMac.Controls.Add(this.lblNota2);
            this.pMac.Location = new System.Drawing.Point(10, 145);
            this.pMac.Name = "pMac";
            this.pMac.Size = new System.Drawing.Size(460, 65);
            this.pMac.TabIndex = 248;
            // 
            // pSerie
            // 
            this.pSerie.Controls.Add(this.lblBarra1);
            this.pSerie.Controls.Add(this.txtSerie);
            this.pSerie.Controls.Add(this.lblNota1);
            this.pSerie.Controls.Add(this.lblSerie);
            this.pSerie.Location = new System.Drawing.Point(10, 75);
            this.pSerie.Name = "pSerie";
            this.pSerie.Size = new System.Drawing.Size(460, 64);
            this.pSerie.TabIndex = 249;
            // 
            // lblBarra1
            // 
            this.lblBarra1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra1.Location = new System.Drawing.Point(75, 32);
            this.lblBarra1.Name = "lblBarra1";
            this.lblBarra1.Size = new System.Drawing.Size(360, 2);
            this.lblBarra1.TabIndex = 246;
            // 
            // txtSerie
            // 
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerie.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSerie.Location = new System.Drawing.Point(75, 12);
            this.txtSerie.MaxLength = 50;
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(360, 29);
            this.txtSerie.TabIndex = 245;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNota1.Location = new System.Drawing.Point(72, 44);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(36, 13);
            this.lblNota1.TabIndex = 244;
            this.lblNota1.Text = "Nota1";
            this.lblNota1.Visible = false;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.ForeColor = System.Drawing.Color.Black;
            this.lblSerie.Location = new System.Drawing.Point(10, 10);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(50, 23);
            this.lblSerie.TabIndex = 243;
            this.lblSerie.Text = "Serie:";
            // 
            // Frm_Editar_Producto_Observar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 484);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Editar_Producto_Observar";
            this.Text = "Frm_Editar_Producto_Observar";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pFE.ResumeLayout(false);
            this.pFE.PerformLayout();
            this.pMac.ResumeLayout(false);
            this.pMac.PerformLayout();
            this.pSerie.ResumeLayout(false);
            this.pSerie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.Button txtModificar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbFolio;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Label lblEstatus;
        private System.Windows.Forms.Label lblBarra4;
        private System.Windows.Forms.ComboBox cbEstatus;
        private System.Windows.Forms.Panel pFE;
        private System.Windows.Forms.Label lblBarra2;
        private System.Windows.Forms.Label lblBarra3;
        private System.Windows.Forms.Panel pSerie;
        private System.Windows.Forms.Label lblBarra1;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Panel pMac;
    }
}