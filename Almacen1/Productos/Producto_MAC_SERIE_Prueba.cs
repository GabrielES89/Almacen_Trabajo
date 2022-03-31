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
            lblProducto.Text = dtN.Rows[0]["Nombre"].ToString();
            lblMarca.Text = "Marca: " + dtN.Rows[0]["Marca"].ToString();
            lblModelo.Text = "Modelo: " +  dtN.Rows[0]["Modelo"].ToString();
            lblParte.Text = "Parte: " + dtN.Rows[0]["Parte"].ToString();
            rtxtDescripcion.Text = dtN.Rows[0]["Descripción"].ToString();
            lblCantidad.Text = "Cantidad: " + dtN.Rows[0]["Cantidad"].ToString();
            Id = dtN.Rows[0][0].ToString();
            lblId.Text = Id;
            lblId.Left = lblProducto.Left + lblProducto.Width;
            dtN.Columns.Remove("id");
            dtN.Columns.Remove("Cantidad");
            dtN.Columns.Remove("Nombre");
            dtN.Columns.Remove("Marca");
            dtN.Columns.Remove("Modelo");
            dtN.Columns.Remove("Parte");
            dtN.Columns.Remove("Descripción");
            dtN.Columns.Remove("Orden");
            this.AuxPrimera = AuxPrimera;
            switch (AuxPrimera)
            {
                case 1:
                    dtN.Columns.Remove("Serie");
                    btnSeries.Visible = false;
                    btnMAC.Left = btnSeries.Left;
                    break;
                case 2:
                    dtN.Columns.Remove("MAC");
                    btnMAC.Visible = false;
                    break;
                default:
                    break;
            }
            DGV1.DataSource = dtN;
            DGV1.Columns["Editar"].DisplayIndex = DGV1.Columns.Count - 1;
        }
        string Codigo_QR()
        {
            Random ObjRandom = new Random();
            string Resultado = "";
            for (int i = 0; i < 8; i++)
            {
                int NumOLet = ObjRandom.Next(0, 2);
                if (NumOLet == 1)
                {
                    Resultado += ObjRandom.Next(9);
                }
                else
                {
                    int aux = ObjRandom.Next(65, 123);
                    while (aux > 90 && aux < 97)
                    {
                        aux = ObjRandom.Next(65, 123);
                    }
                    Resultado += Convert.ToChar(aux);
                }
            }
            return Resultado;
        }
        void BDGV1SM()
        {

            int CountDGV1 = DGV1.ColumnHeadersHeight;
            CountDGV1 += DGV1.Rows.GetRowsHeight(0);
            CountDGV1 += DGV1.Rows.GetRowsHeight(0) / DGV1.Rows.Count;
            PanelDGV.Height = CountDGV1;
            btnMAC.Top = PanelDGV.Top + PanelDGV.Height - 10;
            btnSeries.Top = PanelDGV.Top + PanelDGV.Height - 10;
            btnMAC.Left = PanelDGV.Left + DGV1.Columns["Serie"].Width + ((DGV1.Columns["MAC"].Width / 2) - btnMAC.Width / 2);
            btnSeries.Left = PanelDGV.Left + ((DGV1.Columns["Serie"].Width / 2) - btnMAC.Width / 2);
            if (btnSeries.Top + btnSeries.Height >= this.Height || btnMAC.Top + btnMAC.Height >= this.Height)
            {
                if (this.WindowState == FormWindowState.Normal)
                {

                    btnMAC.Location = new Point(728, 220);
                    btnSeries.Location = new Point(10, 220);
                }
                else
                {
                    int Hola = this.Width - btnMAC.Width - 10;
                    btnMAC.Location = new Point(1234, 220);
                    btnSeries.Location = new Point(10, 220);
                }
            }
            if (PanelDGV.Top + PanelDGV.Height >= this.Height)
            {
                PanelDGV.Height = this.Height - PanelDGV.Top - 25;
            }
        }
        void BDGV1S()
        {
            btnMAC.Visible = false;
            int CountDGV1 = DGV1.ColumnHeadersHeight;
            CountDGV1 += DGV1.Rows.GetRowsHeight(0);
            CountDGV1 += DGV1.Rows.GetRowsHeight(0) / DGV1.Rows.Count;
            PanelDGV.Height = CountDGV1;
            btnSeries.Top = PanelDGV.Top + PanelDGV.Height - 10;
            btnSeries.Left = PanelDGV.Left + (DGV1.Columns["Serie"].Width / 2) - (btnSeries.Width / 2);
            if (btnSeries.Top + btnSeries.Height >= this.Height || btnMAC.Top + btnMAC.Height >= this.Height)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    btnSeries.Location = new Point(10, 220);
                }
                else
                {
                    btnSeries.Location = new Point(10, 220);
                }
            }
            if (PanelDGV.Top + PanelDGV.Height >= this.Height)
            {
                PanelDGV.Height = this.Height - PanelDGV.Top - 25;
            }
        }
        void BDGV1M()
        {
            btnSeries.Visible = false;
            int CountDGV1 = DGV1.ColumnHeadersHeight;
            CountDGV1 += DGV1.Rows.GetRowsHeight(0);
            CountDGV1 += DGV1.Rows.GetRowsHeight(0) / DGV1.Rows.Count;
            PanelDGV.Height = CountDGV1;
            btnMAC.Top = PanelDGV.Top + PanelDGV.Height - 10;
            btnMAC.Left = PanelDGV.Left + ((DGV1.Columns["MAC"].Width / 2) - btnMAC.Width / 2);
            if (btnMAC.Top + btnMAC.Height >= this.Height)
            {
                if (this.WindowState == FormWindowState.Normal)
                {

                    btnMAC.Location = new Point(728, 220);
                }
                else
                {
                    btnMAC.Location = new Point(1234, 220);
                }
            }
            if (PanelDGV.Top + PanelDGV.Height >= this.Height)
            {
                PanelDGV.Height = this.Height - PanelDGV.Top - 25;
            }
        }
        void condicional()
        {
            if (AuxPrimera == 3)
                BDGV1SM();
            if (AuxPrimera == 1)
                BDGV1M();
            if (AuxPrimera == 2)
                BDGV1S();
        }
        private void Producto_MAC_SERIE_Prueba_Load(object sender, EventArgs e)
        {
            //condicional();
        }

        private void DGV1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            bool Comprobador = true;
            for (int i = 0; i < DGV1.Rows.Count; i++)
            {
                for (int j = 1; j < DGV1.Columns.Count; j++)
                {
                    if (DGV1[j, i].Value.ToString() == "")
                    {
                        Comprobador = false;
                    }
                }
            }
            if (Comprobador)
            {
                btnGuardar.Visible = true;
            }
            else
            {
                btnGuardar.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MAC
            if (AuxPrimera == 1)
            {
                for (int i = 0; i < DGV1.Rows.Count; i++)
                {
                    ObjProductos._set_MAC(DGV1["MAC", i].Value.ToString(), Id, id_orden_almacen, Codigo_QR());
                }
            }
            //Serie
            if (AuxPrimera == 2)
            {
                for (int i = 0; i < DGV1.Rows.Count; i++)
                {
                    ObjProductos._set_Serie(DGV1["Serie", i].Value.ToString(), Id, id_orden_almacen, Codigo_QR());
                }
            }
            // MAC y Serie
            if (AuxPrimera == 3)
            {
                for (int i = 0; i < DGV1.Rows.Count; i++)
                {
                    ObjProductos._set_Serie_MAC(DGV1["Serie", i].Value.ToString(), DGV1["MAC", i].Value.ToString(), Id, id_orden_almacen, Codigo_QR());
                }
            }
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            VentanaSerie = new Frm_Agregar_Serie(DGV1, 0, 1);
            VentanaSerie.ShowDialog();
        }

        private void btnMAC_Click(object sender, EventArgs e)
        {
            switch (AuxPrimera)
            {
                case 1:
                    VentanaMAC = new Frm_Agregar_Mac(DGV1, 0, 1);
                    VentanaMAC.ShowDialog();
                    break;
                case 3:
                    VentanaMAC = new Frm_Agregar_Mac(DGV1, 0, 2);
                    VentanaMAC.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
