using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        string [] nombre;
        double[] edad;


        int datos;

        private void btn_tamaño_Click(object sender, EventArgs e)
        {
            {
                //arreglo 

                try
                {
                    if (txt_nombre.Text.Trim() != "")
                    {


                        datos = int.Parse(txt_nombre.Text.Trim());

                        nombre = new string[datos];
                        edad = new double[datos];




                        for (int i = 0; i < datos; i++)
                        {
                            nombre[i] = Microsoft.VisualBasic.Interaction.InputBox("Escribi el nombre del estudiante ");
                            edad[i] = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Escribi la edad del estudiante: "));
                        }
                    }

                }
               



                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }











            }
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < datos; i++)
            {
                cbx_mostrar.Items.Add(nombre[i]);
                cbx_mostrar.Items.Add(edad[i]);
            }
            
        }
    }
}
