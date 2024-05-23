using PreExamen_Dquan.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreExamen_Dquan
{
    public partial class Form1 : Form
    { 
        Lista equipoMunicipal = new Lista();
        Lista equipoMixco = new Lista();
        public Lista0 Equipos = new Lista0();
        public Lista0 Equipos1 = new Lista0();
        public Lista0 Equipos2 = new Lista0();

        public Form1()
        {
            InitializeComponent();
            UploadTeam();
            UploadTeam1();
            UploadTeam2();
            Limpiar();
        }

        public void UploadTeam()
        {
            Equipos.addList("--- Selecciona un equipo ---");
            Equipos.addList("Municipal");
            Equipos.addList("Mixco");
            comboBox1.DataSource = Equipos.addList();
        }

        public void UploadTeam1()
        {
            Equipos1.addList("--- Selecciona un equipo ---");
            Equipos1.addList("Municipal");
            Equipos1.addList("Mixco");
            comboBox2.DataSource = Equipos1.addList();
        }

        public void UploadTeam2()
        {
            Equipos2.addList("--- Selecciona un equipo ---");
            Equipos2.addList("Municipal");
            Equipos2.addList("Mixco");
            comboBox3.DataSource = Equipos2.addList();
        }

        private void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                var valorMuni = equipoMunicipal.InsertarNodo(comboBox1.Text, 
                    Convert.ToInt32(textBox1.Text), 
                    textBox2.Text, 
                    textBox3.Text, 
                    Convert.ToInt64(textBox4.Text));
                MessageBox.Show(valorMuni);
                Limpiar();
            } else
            {
                var valorMix = equipoMixco.InsertarNodo(comboBox1.Text,
                    Convert.ToInt32(textBox1.Text),
                    textBox2.Text,
                    textBox3.Text,
                    Convert.ToInt64(textBox4.Text));
                MessageBox.Show(valorMix);
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (comboBox2.SelectedIndex == 1)
            {
                label9.Text = equipoMunicipal.desplegarLista();
            } else if (comboBox2.SelectedIndex == 2)
            {
                label9.Text = equipoMixco.desplegarLista();
            } else
            {
                label9.Text = "------------------------------------------------------------------------------------";
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 1 && textBox5.Text != "")
            {
                equipoMunicipal.EliminarNodo(Convert.ToInt32(textBox5.Text));

            } else if (comboBox2.SelectedIndex == 2 && textBox5.Text != "")
            {
                equipoMixco.EliminarNodo(Convert.ToInt32(textBox5.Text));
            } else
            {
                label13.Text = "Ingrese los datos correspondientes.";
            }
            Limpiar();
        }
    }
}
