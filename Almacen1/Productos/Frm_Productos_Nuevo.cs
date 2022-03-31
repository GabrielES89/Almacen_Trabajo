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
    public partial class Frm_Productos_Nuevo : Form
    {
        // Formas
        Productos.Frm_Productos_MAC_Serie FormaMACYSerie;
        Productos.Producto_MAC_SERIE_Prueba FormaPrueba;

        // Actions
        public Action Actualizar;
        public Action<DataTable> Producto;

        // Clases
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();
        Class.ClsUtilidades Utilidades = new Class.ClsUtilidades();

        // datatable
        DataTable dtM = new DataTable();
        DataTable dtF = new DataTable();
        DataTable dtN = new DataTable();
        DataTable dtCodigo_QR = new DataTable();
        DataTable dtNProducto = new DataTable();

        // Variables
        bool NuevoProducto = true;
        string Codigo;

        public Frm_Productos_Nuevo()
        {
            InitializeComponent();
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
                default:
                    break;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb.Items.Add(dt.Rows[i][1].ToString());
            }
        }
        private void Frm_Productos_Nuevo_Load(object sender, EventArgs e)
        {
            
            Listas(dtM, cbMarca, 0);
            Utilidades.autocomplete_combobox(cbMarca);
            Listas(dtF, cbFactura, 1);
            Utilidades.autocomplete_combobox(cbFactura);
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
        
        void Nuevo()
        {
            ObjProductos._set(txtNombre.Text, Ids(dtM, cbMarca), txtModelo.Text, txtParte.Text, txtDescripcion.Text, txtCantidad.Text);
            Actualizar();
        }
        void SeriesYMACs()
        {
            string Id_Orden = Ids(dtF, cbFactura);
            dtN.Columns.Clear();
            dtN.Rows.Clear();
            ObjProductos._consult_Productos_Ultimo(dtN);
            //dtN.Columns.Add("Orden");
            //dtN.Columns["Orden"].SetOrdinal(dtN.Columns.Count - 2);
            //dtN.Rows[0]["Orden"] = Id_Orden;
            for (int i = 0; i < Convert.ToInt32(txtCantidad.Text) - 1; i++)
            {
                dtN.Rows.Add(dtN.Rows[0][0].ToString(), dtN.Rows[0][1].ToString(), dtN.Rows[0][2].ToString() , dtN.Rows[0][3].ToString(), dtN.Rows[0][4].ToString(), dtN.Rows[0][5].ToString(), dtN.Rows[0][6].ToString(), dtN.Rows[0][7].ToString(), Id_Orden, dtN.Rows[0][8].ToString());
            }
            if (!cbxSeries.Checked && !cbxMAC.Checked)
            {
                while (true)
                {
                    Codigo = Utilidades.Codigo_QR(8);
                    ObjProductos._consult_QR(dtCodigo_QR, Codigo);
                    if (dtCodigo_QR.Rows.Count == 0)
                    {
                        break;
                    }
                }
                ObjProductos._set_Orden(dtN.Rows[0][0].ToString(), Id_Orden, Codigo);
            }
            else
            {
                if (cbxMAC.Checked && cbxSeries.Checked)
                {
                    //FormaMACYSerie = new Productos.Frm_Productos_MAC_Serie(3, dtN, Id_Orden);
                    //FormaMACYSerie.Cerrar = Exit;
                    //FormaMACYSerie.Show();
                    //Prueba
                    FormaPrueba = new Producto_MAC_SERIE_Prueba(3, dtN, Id_Orden);
                    FormaPrueba.ShowDialog();
                }
                else
                {
                    if (cbxMAC.Checked)
                    {
                        //FormaMACYSerie = new Productos.Frm_Productos_MAC_Serie(1, dtN, Id_Orden);
                        FormaPrueba = new Producto_MAC_SERIE_Prueba(1, dtN, Id_Orden);
                        //FormaMACYSerie.Cerrar = Exit;
                        //FormaMACYSerie.Show();
                        //Prueba
                        FormaPrueba.ShowDialog();
                    }
                    else
                    {
                        if (cbxSeries.Checked)
                        {
                            //FormaMACYSerie = new Productos.Frm_Productos_MAC_Serie(2, dtN, Id_Orden);
                            FormaPrueba = new Producto_MAC_SERIE_Prueba(2, dtN, Id_Orden);
                            //FormaMACYSerie.Cerrar = Exit;
                            //FormaMACYSerie.Show();
                            //Prueba
                            FormaPrueba.ShowDialog();
                        }
                    }
                }
            }
            
            Reestablecer();
        }
        void Exit()
        {
            this.Close();
        }
        void NuevaMarca ()
        {
            bool AuxMarca = true;
            string CbText = Utilidades.QuitarEspacios(cbMarca.Text);
            for (int i = 0; i < dtM.Rows.Count; i++)
            {
                if (CbText == dtM.Rows[i][1].ToString())
                {
                    AuxMarca = false;
                }
            }
            if (AuxMarca)
            {
                if (MessageBox.Show("La marca " + CbText + " no esta registrada, ¿desea registrarla?", "Registrar marca", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ObjProductos._set_Marca(CbText);
                }
            }
            Listas(dtM, cbMarca, 0);
            Utilidades.autocomplete_combobox(cbMarca);
        }
        void Reestablecer()
        {
            txtNombre.Text = "";
            cbMarca.Text = "";
            txtModelo.Text = "";
            txtParte.Text = "";
            cbFactura.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            cbxSeries.Checked = false;
            cbxMAC.Checked = false;
        }
        void ComprobarProducto()
        {
            ObjProductos._consult_Comprobar(dtNProducto, txtNombre.Text);
            if (dtNProducto.Rows.Count != 0)
            {
                if (MessageBox.Show("El producto " + txtNombre.Text + " ya esta registrado, ¿desea registrarlo?", "Producto ya registrado", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    NuevoProducto = true;
                }
                else
                {
                    NuevoProducto = false;
                }
            }
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
            lblNota5.Visible = false;
            lblBarra5.BackColor = SystemColors.Window;
            lblBarra5.Height = 2;
            lblNota6.Visible = false;
            lblBarra6.BackColor = SystemColors.Window;
            lblBarra6.Height = 2;
            lblNota7.Visible = false;
            lblBarra7.BackColor = SystemColors.Window;
            lblBarra7.Height = 2;
            tmError.Stop();
        }

        bool ComprobarCampos()
        {
            bool ComprobarDatos = true;
            if (txtNombre.Text == "")
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
            if (cbMarca.Text == "")
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
            if (txtModelo.Text == "")
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
            if (txtParte.Text == "")
            {
                ComprobarDatos = false;
                lblNota4.Text = "Este campo no puede estar vacio.";
                lblNota4.Visible = true;
                lblBarra4.BackColor = Color.Red;
                lblBarra4.Height = 3;
                tmError.Stop();
                tmError.Start();
            }
            else
            {
                lblNota4.Visible = false;
                lblBarra4.BackColor = SystemColors.Window;
                lblBarra4.Height = 2;
            }
            if (cbFactura.Text == "")
            {
                ComprobarDatos = false;
                lblNota5.Text = "Este campo no puede estar vacio.";
                lblNota5.Visible = true;
                lblBarra5.BackColor = Color.Red;
                lblBarra5.Height = 3;
                tmError.Stop();
                tmError.Start();
            }
            else
            {
                lblNota5.Visible = false;
                lblBarra5.BackColor = SystemColors.Window;
                lblBarra5.Height = 2;
            }
            if (txtDescripcion.Text == "")
            {
                ComprobarDatos = false;
                lblNota6.Text = "Este campo no puede estar vacio.";
                lblNota6.Visible = true;
                lblBarra6.BackColor = Color.Red;
                lblBarra6.Height = 3;
                tmError.Stop();
                tmError.Start();
            }
            else
            {
                lblNota6.Visible = false;
                lblBarra6.BackColor = SystemColors.Window;
                lblBarra6.Height = 2;
            }
            if (txtCantidad.Text == "")
            {
                ComprobarDatos = false;
                lblNota7.Text = "Este campo no puede estar vacio.";
                lblNota7.Visible = true;
                lblBarra7.BackColor = Color.Red;
                lblBarra7.Height = 3;
                tmError.Stop();
                tmError.Start();
            }
            else
            {
                lblNota7.Visible = false;
                lblBarra7.BackColor = SystemColors.Window;
                lblBarra7.Height = 2;
            }
            return ComprobarDatos;
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                ComprobarProducto();
                if (NuevoProducto)
                {
                    NuevaMarca();
                    Nuevo();
                    SeriesYMACs();
                    this.Close();
                }
                else
                {
                    Producto(dtNProducto);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMarca_Leave(object sender, EventArgs e)
        {
            Utilidades.CentrarComboBox(cbMarca);
        }

        private void cbFactura_Leave(object sender, EventArgs e)
        {
            Utilidades.CentrarComboBox(cbFactura);
        }

        private void cbFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }
    }
}
