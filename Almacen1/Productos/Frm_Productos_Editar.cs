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
    public partial class Frm_Productos_Editar : Form
    {
        // Delegados
        public Action DelegadoActualizar;

        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();
        Class.ClsUtilidades Utilidades = new Class.ClsUtilidades();

        // datatable
        DataTable dt = new DataTable();
        DataTable dtM = new DataTable();
        DataTable dtF = new DataTable();
        DataTable dtS = new DataTable();

        // Variables
        int Id;

        public Frm_Productos_Editar(int Id, DataTable dt)
        {
            InitializeComponent();
            this.Id = Id;
            this.dt = dt;
        }

        void Listas(DataTable dt, ComboBox cb, int Caso)
        {
            cb.Items.Clear();
            dt.Clear();
            switch (Caso)
            {
                case 0:
                    ObjProductos._consult_Marca(dt);
                    break;
                case 1:
                    ObjProductos._consult_Factura(dt);
                    break;
                case 2:
                    ObjProductos._consult_Status(dt);
                    break;
                default:
                    break;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        void CargarNombre ()
        {
            lblNombre.Text = dt.Rows[Id][1].ToString();
            lblNombre.Left = (panel1.Width / 2) - (lblNombre.Width / 2);
            if (lblNombre.Width > panel1.Width)
            {
                lblNombre.Font = new Font("Arial Narrow ", lblNombre.Font.Size - 1, FontStyle.Underline);
                CargarNombre();
            }
        }
        void Carga()
        {
            lblId.Text = dt.Rows[Id][0].ToString();
            CargarNombre();
            lblId.Left = lblNombre.Width - lblId.Width + lblNombre.Left;
            lblId.Top = lblNombre.Height + lblNombre.Top;
            cbMarca.Text = dt.Rows[Id][2].ToString();
            Listas(dtM, cbMarca, 0);
            //Utilidades.CentrarComboBox(cbMarca);
            txtModelo.Text = dt.Rows[Id][3].ToString();
            txtParte.Text = dt.Rows[Id][4].ToString();
            rtxDescripcion.Text = dt.Rows[Id][5].ToString();
        }
        private void Frm_Productos_Editar_Load(object sender, EventArgs e)
        {
            Carga();
        }

        string Ids(DataTable dtIds, ComboBox cbIds)
        {
            string ids = "";
            string CbText = Utilidades.QuitarEspacios(cbIds.Text);
            for (int i = 0; i < dtIds.Rows.Count; i++)
            {
                if (CbText == dtIds.Rows[i][1].ToString())
                {
                    ids = dtIds.Rows[i][0].ToString();
                }
            }
            return ids;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }
        private void tmError_Tick(object sender, EventArgs e)
        {
            lblNota1.Visible = false;
            lblBarra1.BackColor = SystemColors.Window;
            lblBarra1.Height = 2;
            lblNota2.Visible = false;
            lblBarra2.BackColor = SystemColors.Window;
            lblBarra2.Height = 2;
            lblNota3.Visible = false;
            lblBarra3.BackColor = SystemColors.Window;
            lblBarra3.Height = 2;
            lblNota4.Visible = false;
            lblBarra4.BackColor = SystemColors.Window;
            lblBarra4.Height = 2;
            lblBarra5.BackColor = SystemColors.Window;
            lblBarra5.Height = 2;
            tmError.Stop();
        }
        bool ComprobarCampos()
        {
            bool ComprobarDatos = true;
            if (cbMarca.Text == "")
            {
                ComprobarDatos = false;
                lblNota1.Text = "Este campo no puede estar vacio.";
                lblNota1.Visible = true;
                lblBarra1.BackColor = Color.Red;
                lblBarra1.Height = 3;
                tmError.Stop();
                tmError.Start();
            }
            else
            {
                lblNota1.Visible = false;
                lblBarra1.BackColor = SystemColors.Window;
                lblBarra1.Height = 2;
            }
            if (txtModelo.Text == "")
            {
                ComprobarDatos = false;
                lblNota2.Text = "Este campo no puede estar vacio.";
                lblNota2.Visible = true;
                lblBarra2.BackColor = Color.Red;
                lblBarra2.Height = 3;
                tmError.Stop();
                tmError.Start();
            }
            else
            {
                lblNota2.Visible = false;
                lblBarra2.BackColor = SystemColors.Window;
                lblBarra2.Height = 2;
            }
            if (txtParte.Text == "")
            {
                ComprobarDatos = false;
                lblNota3.Text = "Este campo no puede estar vacio.";
                lblNota3.Visible = true;
                lblBarra3.BackColor = Color.Red;
                lblBarra3.Height = 3;
                tmError.Stop();
                tmError.Start();
            }
            else
            {
                lblNota3.Visible = false;
                lblBarra3.BackColor = SystemColors.Window;
                lblBarra3.Height = 2;
            }
            if (rtxDescripcion.Text == "")
            {
                ComprobarDatos = false;
                lblNota4.Text = "Este campo no puede estar vacio.";
                lblNota4.Visible = true;
                lblBarra4.BackColor = Color.Red;
                lblBarra4.Height = 3;
                lblBarra5.BackColor = Color.Red;
                lblBarra5.Height = 3;
                tmError.Stop();
                tmError.Start();
            }
            else
            {
                lblNota4.Visible = false;
                lblBarra4.BackColor = SystemColors.Window;
                lblBarra4.Height = 2;
                lblBarra5.BackColor = SystemColors.Window;
                lblBarra5.Height = 2;
            }
            return ComprobarDatos;
        }
        private void txtModificar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                ObjProductos._update(lblNombre.Text, Ids(dtM, cbMarca), txtModelo.Text, txtParte.Text, rtxDescripcion.Text, lblId.Text);
                DelegadoActualizar();
                this.Close();
            }
        }

        private void cbMarca_Leave(object sender, EventArgs e)
        {
            //Utilidades.CentrarComboBox(cbMarca);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
