﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Voy a gestionar el evento KeyUp del TextBox para cambiar el texto del botón
        private void txtSeleccionarDir_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSeleccionarDir.Text.StartsWith("%") && txtSeleccionarDir.Text.EndsWith("%"))
            {
                btnSeleccionarDir.Text = "Escribir Variable de Entorno";
            }
            else
            {
                btnSeleccionarDir.Text = "Seleccionar Directorio";
            }
        }

        private void btnSeleccionarDir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSeleccionarDir.Text.StartsWith("%") && txtSeleccionarDir.Text.EndsWith("%"))
                {
                    try
                    {
                        // Guardo la ruta de la variable de entorno en una variable
                        String rutaDirectorio = Environment.GetEnvironmentVariable(txtSeleccionarDir.Text.Substring(1, txtSeleccionarDir.Text.Length - 2));
                        Directory.SetCurrentDirectory(rutaDirectorio);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        txtSeleccionarDir.Text = "";
                        MessageBox.Show("No se ha podido encontrar el directorio que has indicado. Asegúrate de que el directorio exista o de que tengas permisos para acceder a él");
                    }
                }
                else
                {
                    try
                    {
                        // Guardo la ruta en una variable y establezco el directorio actual de trabajo
                        String rutaDirectorio = txtSeleccionarDir.Text;
                        Directory.SetCurrentDirectory(rutaDirectorio);
                    }
                    catch (DirectoryNotFoundException)
                    {
                        txtSeleccionarDir.Text = "";
                        MessageBox.Show("No se ha podido encontrar el directorio que has indicado. Asegúrate de que el directorio exista o de que tengas permisos para acceder a él");
                    }
                    catch (IOException)
                    {
                        txtSeleccionarDir.Text = "";
                        MessageBox.Show("Has escrito caracteres no válidos, no se ha podido seleccionar ningún directorio");
                    }
                }


                DirectoryInfo raiz = new DirectoryInfo(Directory.GetCurrentDirectory());

                // Reinicio el TextBox
                txtInfo.Text = "Subdirectorios y archivos que contiene el directorio " + raiz.Name + ":" + Environment.NewLine;

                // Escribo los subdirectorios
                foreach (DirectoryInfo dir in raiz.GetDirectories())
                {
                    txtInfo.AppendText(dir.Name + " \\" + Environment.NewLine);
                }

                foreach (FileInfo archivo in raiz.GetFiles())
                {
                    txtInfo.AppendText(archivo.Name + Environment.NewLine);
                }


            }
            catch (ArgumentException)
            {
                MessageBox.Show("La caja de texto está vacía o contiene caracteres inválidos, escríbelo correctamente");
            }
        }
    }
}
