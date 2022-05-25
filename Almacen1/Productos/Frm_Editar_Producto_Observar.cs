using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Productos
{
    public partial class Frm_Editar_Producto_Observar : Form
    {
        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();

        // Datatables
        DataTable dt;
        DataTable dtFolio = new DataTable();
        DataTable dtEstatus = new DataTable();

        // Variables
        int Fila;
        int Cambios;

        public Frm_Editar_Producto_Observar(DataTable dt, int Fila, int Cambios)
        {
            InitializeComponent();
            this.dt = dt;
            this.Fila = Fila;
            this.Cambios = Cambios;
            Cargar();
        }
        void CargarNombre()
        {
            lblNombre.Left = (panel1.Width / 2) - (lblNombre.Width / 2);
            if (lblNombre.Width > panel1.Width)
            {
                lblNombre.Font = new Font("Arial Narrow ", lblNombre.Font.Size - 1, FontStyle.Underline);
                CargarNombre();
            }
        }
        void Cargar ()
        {
            lblNombre.Text = dt.Rows[0]["Nombre"].ToString();
            txtSerie.Text = dt.Rows[Fila]["Serie"].ToString();
            txtMac.Text = dt.Rows[Fila]["Mac"].ToString();
            ObjProductos._consult_Factura(dtFolio);
            for (int i = 0; i < dtFolio.Rows.Count; i++)
            {
                cbFolio.Items.Add(dtFolio.Rows[i][1]);
                if (dt.Rows[Fila]["Folio"].ToString() == dtFolio.Rows[i][1].ToString())
                {
                    cbFolio.SelectedIndex = i;
                }
            }
            ObjProductos._consult_Status(dtEstatus);
            for (int i = 0; i < dtEstatus.Rows.Count; i++)
            {
                cbEstatus.Items.Add(dtEstatus.Rows[i][1]);
                if (dt.Rows[Fila]["Status"].ToString() == dtEstatus.Rows[i][1].ToString())
                {
                    cbEstatus.SelectedIndex = i;
                }
            }
            CargarNombre();
            lblId.Text = dt.Rows[Fila]["Id_SMF"].ToString();
            lblId.Left = lblNombre.Width - lblId.Width + lblNombre.Left;
            lblId.Top = lblNombre.Height + lblNombre.Top;
            if (Cambios == 1)
            {
                pSerie.Visible = false;
                pFE.Top = pMac.Top;
                pMac.Top = pSerie.Top;
                btn_cancelar.Top = txtModificar.Top = pFE.Top + pFE.Height + 20;
                panel1.Height = btn_cancelar.Top + btn_cancelar.Height + 20;
                panel2.Height = btn_cancelar.Top + btn_cancelar.Height + 32;
                this.Height = panel2.Height + panel2.Top + 10;
            }
            if (Cambios == 2)
            {
                pMac.Visible = false;
                pFE.Top = pMac.Top;
                btn_cancelar.Top = txtModificar.Top = pFE.Top + pFE.Height + 20;
                panel1.Height = btn_cancelar.Top + btn_cancelar.Height + 20;
                panel2.Height = btn_cancelar.Top + btn_cancelar.Height + 32;
                this.Height = panel2.Height + panel2.Top + 10;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
