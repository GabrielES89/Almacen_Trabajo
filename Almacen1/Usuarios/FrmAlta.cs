﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen1.Usuarios
{
    public partial class FrmAlta : Form
    {
        //Clases
        Class.Cls_Usuarios usuarios = new Class.Cls_Usuarios();
        Class.ClsPrivilegios privilegios = new Class.ClsPrivilegios();
        Class.ClsUtilidades util = new Class.ClsUtilidades();
        //Datatables
        //Variables
        public FrmAlta()
        {
            InitializeComponent();
        }

        void registrar()
        {
            try
            {
                if (txt_usuario.Text == "" || txt_pass.Text == "" || cbx_empleado.Text == "" || cbx_privilegio.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos");
                }
                else
                {
                    usuarios._set(txt_usuario.Text, txt_pass.Text, cbx_privilegio.SelectedValue.ToString(), cbx_empleado.SelectedValue.ToString());
                    MessageBox.Show("Registrado con éxito");
                    FrmListadoUsuarios.cambio = "1";
                    this.Close();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede registrar el empleado Codigo de error: U-001");
            }
        }

        void load()
        {
            util._get_select(cbx_empleado, "tb_empleados");
            util._get_select(cbx_privilegio, "tb_privilegios");
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            registrar();
        }
    }
}
