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
    public partial class Observar_Prueba : Form
    {
        // Clases
        Class.Cls_Registro ObjRegistro = new Class.Cls_Registro();
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();

        // Actions
        public Action Actualizar;

        // Ventanas
        Frm_Editar_MSF Ventana_MSF;
        Registro.Frm_Codigo_QR Ventana_QR;
        Productos.Frm_Nuevo_MSF Ventana_NMSF;
        Productos.frm_Nuevo_SF Ventana_SF;
        Productos.frm_Nuevo_MF Ventana_MF;
         

        // Datatable
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dtProd = new DataTable();
        DataTable dtCodigo = new DataTable();

        // Variables
        string Id;
        string Cantidad;
        int Cambios = 3;
        int Index = 0;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Observar_Prueba(string Id)
        {
            InitializeComponent();
            this.Id = Id;
        }
        void cargar()
        {
            dt = new DataTable();
            dtProd = new DataTable();
            ObjProductos._consult_Productos_Series_MACs(dt, Id);
            ObjProductos._consult_Producto(dtProd, Id);
            dt2 = dt.Copy();
            lblProducto.Text = dt2.Rows[0]["Nombre"].ToString();
            lblProducto.Location = new Point((this.Width / 2) - (lblProducto.Width / 2), PanelSuperior.Height);
            dt2.Columns.Remove("Nombre");
            dt2.Columns.Remove("Id");
            dt2.Columns.Remove("Id_SMF");
            lblMarca.Text = "Marca: " + dtProd.Rows[0]["Marca"];
            lblModelo.Text = "Modelo: " + dtProd.Rows[0]["Modelo"];
            lblParte.Text = "Parte: " + dtProd.Rows[0]["Parte"];
            lblCantidad.Text = "Cantidad: " + dtProd.Rows[0]["Cantidad"];
            Cantidad = dtProd.Rows[0]["Cantidad"].ToString();
            rtxtDescripcion.Text = dtProd.Rows[0]["Descripción"].ToString();
            lblId.Text = Id;
            lblId.Left = lblProducto.Left + lblProducto.Width;
            if (dt2.Rows[0]["Serie"].ToString() == "")
            {
                dt2.Columns.Remove("Serie");
                Cambios = 1;
                cbBuscar.Items.Clear();
                cbBuscar.Items.Add("Mac");
                cbBuscar.Items.Add("Folio");
            }
            if (dt2.Rows[0]["MAC"].ToString() == "")
            {
                dt2.Columns.Remove("MAC");
                Cambios = 2;
                cbBuscar.Items.Clear();
                cbBuscar.Items.Add("serie");
                cbBuscar.Items.Add("Folio");
            }
            DGV1.DataSource = dt2;
            cbBuscar.SelectedIndex = Index;
            AjustesDeBusqueda();
        }
        private void Observar_Prueba_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    PicMedio.BackgroundImage = Properties.Resources.Minimizar;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                    PicMedio.BackgroundImage = Properties.Resources.Max_0;
                }
            }
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicMedio_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                PicMedio.BackgroundImage = Properties.Resources.Max_0;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                PicMedio.BackgroundImage = Properties.Resources.Minimizar;
            }
        }

        private void Observar_Prueba_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                PicMedio.BackgroundImage = Properties.Resources.Minimizar;

            }
            else
            {
                PicMedio.BackgroundImage = Properties.Resources.Max_0;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            switch (Cambios)
            {
                case 1:
                    Ventana_MF = new frm_Nuevo_MF(dt, Cantidad);
                    Ventana_MF.ShowDialog();
                    break;
                case 2:
                    Ventana_SF = new frm_Nuevo_SF(dt, Cantidad);
                    Ventana_SF.ShowDialog();
                    break;
                case 3:
                    Ventana_NMSF = new Frm_Nuevo_MSF(dt, Cantidad);
                    Ventana_NMSF.ShowDialog();
                    break;
                default:
                    break;
            }
            cargar();
            Actualizar();
        }
        void Busqueda(string Valor)
        {
            DataTable Mil = new DataTable();
            ObjProductos._consult_MSF_ConFolio(Mil, Valor, txtBuscar.Text, Id);
            DGV1.DataSource = Mil;
        }
        void Busqueda()
        {
            DataTable Mil = new DataTable();
            ObjProductos._consult_MSF_Buscar(Mil, cbBuscar.Text, txtBuscar.Text, Id);
            DGV1.DataSource = Mil;
            
        }
        void BusquedaMSF()
        {
            string Campo = "";
            DataTable Mil = new DataTable();
            switch (cbBuscar.Text)
            {
                case "Mac":
                    Campo = "T_S_M.mac";
                    break;
                case "Serie":
                    Campo = "T_S_M.serie";
                    break;
                case "Folio":
                    Campo = "T_O.folio_orden";
                    break;
                case "Status":
                    Campo = "T_S_P.status_producto";
                    break;
                default:
                    break;
            }
            ObjProductos._consult_Buscar(Mil, Campo, txtBuscar.Text, Id);
            DGV1.DataSource = Mil;

        }
        void BusquedaMSF_Todos()
        {
            DataTable Mil = new DataTable();
            ObjProductos._consult_Buscar_Todos(Mil, txtBuscar.Text, Id);
            DGV1.DataSource = Mil;

        }
        void AjustesDeBusqueda()
        {
            DGV1.Columns["Indice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV1.Columns["Indice"].DisplayIndex = 0;
            DGV1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Invoke(new Action(() => DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1));
            this.Invoke(new Action(() => DGV1.Columns["Borrar"].DisplayIndex = DGV1.Columns.Count - 1));
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Index = cbBuscar.SelectedIndex;
            switch (Cambios)
            {
                case 1:
                    if (cbBuscar.Text == "Folio")
                    {
                        Busqueda("Mac");
                    }
                    else
                    {
                        Busqueda();
                    }
                    break;
                case 2:
                    if (cbBuscar.Text == "Folio")
                    {
                        Busqueda("Serie");
                    }
                    else
                    {
                        Busqueda();
                    }
                    break;
                case 3:
                    
                    if (cbBuscar.Text == "Todos")
                    {
                        BusquedaMSF_Todos();
                    }
                    else
                    {
                        BusquedaMSF();
                    }
                    break;
                default:
                    break;
            }
            if (txtBuscar.Text == "")
            {
                cargar();
            }
            AjustesDeBusqueda();
        }
    }
}
