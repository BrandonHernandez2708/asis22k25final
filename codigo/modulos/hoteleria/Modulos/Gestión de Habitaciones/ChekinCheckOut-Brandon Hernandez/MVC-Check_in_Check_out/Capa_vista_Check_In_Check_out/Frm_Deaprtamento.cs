using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_vista_Check_In_Check_out
{
    public partial class Frm_Deaprtamento : Form
    {
        public Frm_Deaprtamento()
        {
            InitializeComponent();
            Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView config = new Capa_Controlador_Navegador.Cls_ConfiguracionDataGridView
            {
                Ancho = 1100,
                Alto = 200,
                PosX = 10,
                PosY = 300,
                ColorFondo = Color.AliceBlue,
                TipoScrollBars = ScrollBars.Both,
                Nombre = "dgv_empleados"
            };

            string[] columnas = {
                    "departamento",
                    "codigo_departamento",
                    "nombre_departamento",
                    "estatus_departamento",


            };

            string[] sEtiquetas = {
                    "id",
                    "Nombre",
                    "estado"

                };


            int id_aplicacion = 3402;
            int id_Modulo = 6;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string rutaChm = @"C:\Users\USER\Documents\ayudanavegador\ayudanav.chm";

            Help.ShowHelp(this, rutaChm, "ayudanavegador.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_Departamento reporte = new Reporte_Departamento();
            reporte.Show();
        }
    }
}
