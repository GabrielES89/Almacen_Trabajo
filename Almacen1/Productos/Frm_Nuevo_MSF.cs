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
    public partial class Frm_Nuevo_MSF : Form
    {
        //Datatables
        DataTable dt;
        public Frm_Nuevo_MSF(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Nuevo_MSF_Load(object sender, EventArgs e)
        {

        }
    }
}
