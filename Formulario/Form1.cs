﻿using Formulario.Dato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato = new Usuario();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            grilla.DataSource = tabla;

        }

        private void Guardar()
        {
            UsuarioModel modelo = new UsuarioModel()
            {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text)
            };
            dato.Guardar(modelo);
        }

        private void Consultar()
        {
            foreach(var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila); 
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
        }
    }
}
