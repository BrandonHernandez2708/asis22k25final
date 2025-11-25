using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Navegador;
namespace Capa_Vista_Hoteleria
{
    public partial class Frm_Pacientes : Form
    {
        public Frm_Pacientes()
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
                    "tbl_paciente",
                    "pk_idPaciente",
                    "nombrePaciente",
                    "apellidoPaciente",
                    "fechaNacimientoPaciente",
                    "sexoPaciente",
                    "direccionPaciente",
                    "telefonoPaciente",
                    "estadoPaciente",


            };

            string[] sEtiquetas = {
                    "id",
                    "Nombre",
                    "Apellido",
                    "Fecha de Nacimiento",
                    "Sexo",
                    "Direccion",
                    "Telefono",
                    "estado"

                };


            int id_aplicacion = 3414;
            int id_Modulo = 6;
            navegador1.IPkId_Aplicacion = id_aplicacion;
            navegador1.IPkId_Modulo = id_Modulo;
            navegador1.configurarDataGridView(config);
            navegador1.SNombreTabla = columnas[0];
            navegador1.SAlias = columnas;
            navegador1.SEtiquetas = sEtiquetas;
            navegador1.mostrarDatos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Reporte_Paciente reporte = new Frm_Reporte_Paciente();
            reporte.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string rutaChm = @"C:\asis22k25final\ayuda\componentes\navegador_examen\ayudanav.chm";

            Help.ShowHelp(this, rutaChm, "ayudanavegador.html");

        }
    }
}
