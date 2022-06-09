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
    public partial class Frm_Nuevo_MSF : Form
    {
        //Clases
        Class.ClsUtilidades ObjUtilidades = new Class.ClsUtilidades();
        Class.Cls_Productos ObjProductos = new Class.Cls_Productos();

        //Datatables
        DataTable dt;
        DataTable dtFactura = new DataTable();
        DataTable dtConfirmacion = new DataTable();
        DataTable dtCodigo_QR = new DataTable();

        //Variables
        string Cantidad;
        string Id;
        string Codigo;

        public Frm_Nuevo_MSF(DataTable dt, string Cantidad)
        {
            InitializeComponent();
            this.dt = dt;
            this.Cantidad = Cantidad;
            this.Id = dt.Rows[0]["Id"].ToString();
            lblTitulo.Text = dt.Rows[0]["Nombre"].ToString();
            ObjProductos._consult_Factura(dtFactura);
            for (int i = 0; i < dtFactura.Rows.Count; i++)
            {
                cbFactura.Items.Add(dtFactura.Rows[i][1].ToString());
            }
            cbFactura.SelectedIndex = 0;
        }
        string Ids(DataTable dtIds, ComboBox cbIds)
        {
            string ids = "";
            string CbText = cbIds.Text;
            for (int i = 0; i < dtIds.Rows.Count; i++)
            {
                if (CbText == dtIds.Rows[i][1].ToString())
                {
                    ids = dtIds.Rows[i][0].ToString();
                }
            }
            return ids;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            lblErrorMAC.Text = "";
            lblErrorSerie.Text = "";
            bool Confirmar = false;
            dtConfirmacion = new DataTable();
            ObjProductos._consult_MSF(dtConfirmacion, "mac", txtMAC.Text, Id);
            if (dtConfirmacion.Rows.Count == 0)
            {
                Confirmar = true;
            }
            else
            {
                if (txtMAC.Text == "")
                {
                    lblErrorMAC.Text = "La MAC no puede estar vacia.";
                    lblErrorMAC.Visible = true;
                    tmError.Stop();
                    tmError.Start();
                }
                else
                {
                    lblErrorMAC.Text = "La MAC no puede ser repetida.";
                    lblErrorMAC.Visible = true;
                    tmError.Stop();
                    tmError.Start();
                }
            }
            dtConfirmacion = new DataTable();
            ObjProductos._consult_MSF(dtConfirmacion, "serie", txtSerie.Text, Id);
            if (dtConfirmacion.Rows.Count == 0)
            {
                if (Confirmar)
                {
                    if (txtMAC.Text != "")
                    {
                        if (txtSerie.Text != "")
                        {
                            while (true)
                            {
                                Codigo = ObjUtilidades.Codigo_QR(8);
                                ObjProductos._consult_QR(dtCodigo_QR, Codigo);
                                if (dtCodigo_QR.Rows.Count == 0)
                                {
                                    break;
                                }
                            }
                            ObjProductos._set_Serie_MAC(txtSerie.Text, txtMAC.Text, Id, Ids(dtFactura, cbFactura), Codigo);
                            Cantidad = (Convert.ToInt32(Cantidad) + 1).ToString();
                            ObjProductos._update_cantidad(Cantidad, Id);
                            this.Close();
                        }
                        else
                        {
                            lblErrorSerie.Text = "La serie no puede estar vacia.";
                            lblErrorSerie.Visible = true;
                            tmError.Stop();
                            tmError.Start();
                        }
                    }
                    else
                    {
                        lblErrorMAC.Text = "La MAC no puede estar vacia.";
                        lblErrorMAC.Visible = true;
                        tmError.Stop();
                        tmError.Start();
                    }
                }
                
            }
            else
            {
                if (txtSerie.Text == "")
                {
                    lblErrorSerie.Text = "La serie no puede estar vacia.";
                    lblErrorSerie.Visible = true;
                    tmError.Stop();
                    tmError.Start();
                }
                else
                {
                    lblErrorSerie.Text = "La serie no puede ser repetida.";
                    lblErrorSerie.Visible = true;
                    tmError.Stop();
                    tmError.Start();
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Nuevo_MSF_Load(object sender, EventArgs e)
        {

        }

        private void tmError_Tick(object sender, EventArgs e)
        {
            lblErrorMAC.Visible = false;
            tmError.Stop();
        }
    }
}
