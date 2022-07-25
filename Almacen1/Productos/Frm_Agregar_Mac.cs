using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Almacen1.Productos
{
    public partial class Frm_Agregar_Mac : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Variables
        DataGridView Tabla;
        int Fila, Columna, Caracter, Cambio;
        string CadenaMac;
        bool J = true;
        public Frm_Agregar_Mac()
        {

        }
            public Frm_Agregar_Mac(DataGridView Tabla, int Fila, int Columna, int Cambio)
        {
            InitializeComponent();
            lblFila.Text = (Fila + 1).ToString() + "/" + Tabla.Rows.Count.ToString();
            this.Tabla = Tabla;
            this.Fila = Fila;
            this.Columna = Columna;
            this.Cambio = Cambio;
            txtMac.Text = Tabla[Columna, Fila].Value.ToString();
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        void Verificar()
        {
            bool Comprobar = false;
            for (int i = 0; i < Tabla.Rows.Count; i++)
            {
                if (txtMac.Text == Tabla[0,i].Value.ToString())
                {
                    Comprobar = true;
                    break;
                }
            }
            if (Comprobar)
            {
                lblErrorMAC.Text = "La MAC no puede ser repetida.";
                lblErrorMAC.Visible = true;
                tmError.Start();
            }
        }
        void Guardar ()
        {
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool Error = true;
            if (txtMac.Text.Length != 17)
            {
                Error = false;
                lblErrorMAC.Text = "La mac no puede ser menor o mayor a doce caracteres";
                lblErrorMAC.Visible = true;
                tmError.Stop();
                tmError.Start();
            }
            else
            {
                bool CondiMAC = true;
                for (int i = 0; i < Fila; i++)
                {
                    if (Tabla["MAC", i].Value.ToString() == txtMac.Text)
                    {
                        CondiMAC = false;
                    }
                }
                if (CondiMAC)
                {
                    if (txtMac.Text == "")
                    {
                        Error = false;
                        lblErrorMAC.Text = "La MAC no puede estar vacia.";
                        lblErrorMAC.Visible = true;
                        tmError.Stop();
                        tmError.Start();
                    }
                    else
                    {
                        //DosPuntos(txtMac);
                        Tabla[Columna, Fila].Value = txtMac.Text;
                        txtMac.Text = "";
                        if (Fila == Tabla.Rows.Count - 1)
                        {
                            this.Close();
                        }
                        else
                        {
                            this.Fila = Fila + 1;
                            lblFila.Text = (Fila + 1).ToString() + "/" + Tabla.Rows.Count.ToString();
                        }
                        txtMac.Text = Tabla[Columna, Fila].Value.ToString();
                    }
                }
                else
                {
                    Error = false;
                    lblErrorMAC.Text = "La MAC no puede ser repetida.";
                    lblErrorMAC.Visible = true;
                    tmError.Stop();
                    tmError.Start();
                }
            }
            if (Cambio == 1)
            {
                if (Error)
                {
                    Caracter = 0;
                    this.Close();
                }
            }
            if (Error)
            {
                Caracter = 0;
            }
            txtMac.Focus();
        }
        void DosPuntos(TextBox TextoMasDosPuntos)
        {
            string Cambio = "";
            for (int i = 0; i < 6; i++)
            {
                Cambio += TextoMasDosPuntos.Text.Substring(i * 2, 2);
                if (!(i == 5))
                {
                    Cambio += ":";
                }
            }
            TextoMasDosPuntos.Text = Cambio;
        }

        private void txtMac_TextChanged(object sender, EventArgs e)
        {
            txtMac.Select(txtMac.Text.Length, 1);
            txtMac.Text = txtMac.Text.ToUpper();
        }

        private void tmError_Tick(object sender, EventArgs e)
        {
            lblErrorMAC.Visible = false;
            tmError.Stop();
        }

        private void txtMac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Caracter < 17)
            {
                if (char.IsLetterOrDigit(e.KeyChar))
                {
                    J = true;
                    Caracter++;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
            if (!(Caracter == 0))
            {
                if (e.KeyChar == 8)
                {
                    Caracter--;
                    e.Handled = false;
                    J = false;
                }
            }
            if (J)
            {
                if (Caracter % 3 == 0 && Caracter != 0)
                {
                    Caracter++;
                    txtMac.Text += ":";
                    txtMac.Select(txtMac.Text.Length, 1);
                    J = true;
                }
            }
        }

        private void btnReintentar_Click(object sender, EventArgs e)
        {
            txtMac.Text = "";
            txtMac.Focus();
        }
    }
}
