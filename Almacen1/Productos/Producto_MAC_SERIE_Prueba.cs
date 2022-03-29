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
    public partial class Producto_MAC_SERIE_Prueba : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Ventanas
        Productos.Frm_Agregar_Serie VentanaSerie;
        Productos.Frm_Agregar_Mac VentanaMAC;
        Productos.Frm_Modificar_SerieYMAC VentanaModificarMACYSerie;
        // Acciones 
        public Action Cerrar;

        // Class
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();

        // Datatable
        DataTable dt = new DataTable();
        DataTable dtCodigo_QR = new DataTable();

        // Variables
        string Id;
        int FilaS = 0;
        int FilaM = 0;
        int ContSerie = 0;
        int ContMAC = 0;
        int AuxPrimera;
        string id_orden_almacen = "";
        string Codigo;

        public Producto_MAC_SERIE_Prueba(int AuxPrimera, DataTable dtN, string id_orden_almacen)
        {
            InitializeComponent();
            this.id_orden_almacen = id_orden_almacen;
            string Hola =  dtN.Rows[0][0].ToString();
            //lblProducto.Text = dtN.Rows[0]["id"].ToString();
            //lblMarca.Text = dtN.Rows[0]["Marca"].ToString();
            //lblModelo.Text = dtN.Rows[0]["Modelo"].ToString();
            //lblParte.Text = dtN.Rows[0]["Parte"].ToString();
            //rtxtDescripcion.Text = dtN.Rows[0]["Descripción"].ToString();
            //.Text = dtN.Rows[0][8].ToString();
            Id = dtN.Rows[0][0].ToString();
            //dtN.Columns.Remove("id");
            //dtN.Columns.Remove("Cantidad");
            //dtN.Columns.Remove("Nombre");
            //dtN.Columns.Remove("Marca");
            //dtN.Columns.Remove("Modelo");
            //dtN.Columns.Remove("Parte");
            //dtN.Columns.Remove("Descripción");
            //dtN.Columns.Remove("Orden");
            this.AuxPrimera = AuxPrimera;
            switch (AuxPrimera)
            {
                case 1:
                    dtN.Columns.Remove("Serie");
                    break;
                case 2:
                    dtN.Columns.Remove("MAC");
                    break;
                default:
                    break;
            }
            DGV1.DataSource = dtN;
            DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1;
        }

        private void Producto_MAC_SERIE_Prueba_Load(object sender, EventArgs e)
        {

        }
    }
}
