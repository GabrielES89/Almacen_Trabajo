namespace Almacen1.Productos
{
    partial class Frm_Productos_Editar
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
            this.lblBarra5 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lblBarra4 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblBarra3 = new System.Windows.Forms.Label();
            this.txtParte = new System.Windows.Forms.TextBox();
            this.lblParte = new System.Windows.Forms.Label();
            this.lblBarra2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblBarra1 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModificar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.rtxDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.tmError = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 465);
            this.panel2.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNota4);
            this.panel1.Controls.Add(this.lblNota3);
            this.panel1.Controls.Add(this.lblNota2);
            this.panel1.Controls.Add(this.lblNota1);
            this.panel1.Controls.Add(this.lblBarra5);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.lblBarra4);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblBarra3);
            this.panel1.Controls.Add(this.txtParte);
            this.panel1.Controls.Add(this.lblParte);
            this.panel1.Controls.Add(this.lblBarra2);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Controls.Add(this.lblModelo);
            this.panel1.Controls.Add(this.lblBarra1);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.txtModificar);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.cbMarca);
            this.panel1.Controls.Add(this.rtxDescripcion);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblBarra5
            // 
            this.lblBarra5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra5.Location = new System.Drawing.Point(16, 357);
            this.lblBarra5.Name = "lblBarra5";
            this.lblBarra5.Size = new System.Drawing.Size(434, 2);
            this.lblBarra5.TabIndex = 76;
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
            // lblBarra4
            // 
            this.lblBarra4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra4.Location = new System.Drawing.Point(16, 335);
            this.lblBarra4.Name = "lblBarra4";
            this.lblBarra4.Size = new System.Drawing.Size(434, 2);
            this.lblBarra4.TabIndex = 63;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(16, 285);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 23);
            this.lblDescripcion.TabIndex = 62;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblBarra3
            // 
            this.lblBarra3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra3.Location = new System.Drawing.Point(90, 235);
            this.lblBarra3.Name = "lblBarra3";
            this.lblBarra3.Size = new System.Drawing.Size(360, 2);
            this.lblBarra3.TabIndex = 60;
            // 
            // txtParte
            // 
            this.txtParte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParte.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtParte.Location = new System.Drawing.Point(90, 215);
            this.txtParte.MaxLength = 50;
            this.txtParte.Multiline = true;
            this.txtParte.Name = "txtParte";
            this.txtParte.Size = new System.Drawing.Size(360, 29);
            this.txtParte.TabIndex = 56;
            // 
            // lblParte
            // 
            this.lblParte.AutoSize = true;
            this.lblParte.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParte.ForeColor = System.Drawing.Color.Black;
            this.lblParte.Location = new System.Drawing.Point(32, 215);
            this.lblParte.Name = "lblParte";
            this.lblParte.Size = new System.Drawing.Size(50, 23);
            this.lblParte.TabIndex = 59;
            this.lblParte.Text = "Parte:";
            // 
            // lblBarra2
            // 
            this.lblBarra2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra2.Location = new System.Drawing.Point(90, 165);
            this.lblBarra2.Name = "lblBarra2";
            this.lblBarra2.Size = new System.Drawing.Size(360, 2);
            this.lblBarra2.TabIndex = 58;
            // 
            // txtModelo
            // 
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelo.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtModelo.Location = new System.Drawing.Point(90, 145);
            this.txtModelo.MaxLength = 50;
            this.txtModelo.Multiline = true;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(360, 29);
            this.txtModelo.TabIndex = 55;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Black;
            this.lblModelo.Location = new System.Drawing.Point(16, 145);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(66, 23);
            this.lblModelo.TabIndex = 57;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblBarra1
            // 
            this.lblBarra1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarra1.Location = new System.Drawing.Point(90, 100);
            this.lblBarra1.Name = "lblBarra1";
            this.lblBarra1.Size = new System.Drawing.Size(360, 2);
            this.lblBarra1.TabIndex = 50;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Black;
            this.lblMarca.Location = new System.Drawing.Point(25, 75);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(58, 23);
            this.lblMarca.TabIndex = 49;
            this.lblMarca.Text = "Marca:";
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
            // cbMarca
            // 
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarca.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(90, 75);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(380, 30);
            this.cbMarca.TabIndex = 54;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            this.cbMarca.Leave += new System.EventHandler(this.cbMarca_Leave);
            // 
            // rtxDescripcion
            // 
            this.rtxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxDescripcion.Font = new System.Drawing.Font("Arial Narrow", 12.75F);
            this.rtxDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rtxDescripcion.Location = new System.Drawing.Point(16, 315);
            this.rtxDescripcion.Name = "rtxDescripcion";
            this.rtxDescripcion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxDescripcion.Size = new System.Drawing.Size(434, 44);
            this.rtxDescripcion.TabIndex = 77;
            this.rtxDescripcion.Text = "";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNota1.Location = new System.Drawing.Point(87, 108);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(36, 13);
            this.lblNota1.TabIndex = 237;
            this.lblNota1.Text = "Nota1";
            this.lblNota1.Visible = false;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNota2.Location = new System.Drawing.Point(87, 177);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(36, 13);
            this.lblNota2.TabIndex = 238;
            this.lblNota2.Text = "Nota1";
            this.lblNota2.Visible = false;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNota3.Location = new System.Drawing.Point(87, 247);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(36, 13);
            this.lblNota3.TabIndex = 239;
            this.lblNota3.Text = "Nota1";
            this.lblNota3.Visible = false;
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota4.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNota4.Location = new System.Drawing.Point(17, 362);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(36, 13);
            this.lblNota4.TabIndex = 240;
            this.lblNota4.Text = "Nota1";
            this.lblNota4.Visible = false;
            // 
            // tmError
            // 
            this.tmError.Interval = 5000;
            this.tmError.Tick += new System.EventHandler(this.tmError_Tick);
            // 
            // Frm_Productos_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 484);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Frm_Productos_Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Productos_Editar";
            this.Load += new System.EventHandler(this.Frm_Productos_Editar_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label lblBarra1;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button txtModificar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblBarra3;
        private System.Windows.Forms.TextBox txtParte;
        private System.Windows.Forms.Label lblParte;
        private System.Windows.Forms.Label lblBarra2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblBarra4;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lblBarra5;
        private System.Windows.Forms.RichTextBox rtxDescripcion;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Timer tmError;
    }
}