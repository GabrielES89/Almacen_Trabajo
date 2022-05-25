﻿using System;
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
    public partial class Frm_Borrar_Producto_Observar : Form
    {
        //Clases
        Class.Cls_Productos ClaseProductos = new Class.Cls_Productos();

        //Variables
        string Id;

        public Frm_Borrar_Producto_Observar(string Id, string Mac, string Serie, int Cambios)
        {
            InitializeComponent();
            this.Id = Id;
            switch (Cambios)
            {
                case 1:

                    lblTitulo.Text = Mac;
                    lblTitulo.Left = (this.Width / 2) - (lblTitulo.Width / 2);
                    break;
                case 2:
                    lblTitulo.Text = Serie;
                    lblTitulo.Left = (this.Width / 2) - (lblTitulo.Width / 2);
                    break;
                case 3:
                    lblTitulo.Text = Mac + "," + Serie;
                    lblTitulo.Left = (this.Width / 2) - (lblTitulo.Width / 2);
                    break;
                default:
                    break;
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            ClaseProductos._delete_SM(Id);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
