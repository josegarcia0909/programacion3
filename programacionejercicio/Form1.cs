using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int[] edades = new int[5];
        public string[] nombres = new string[5];

        private void ingresarbutton_Click(object sender, EventArgs e)
        {
  
            for (int i = 0; i < nombres.Length && i < edades.Length; i++ )
            {
                nombres[i] = Microsoft.VisualBasic.Interaction.InputBox("Escribe el nombre de esta persona");
                edades[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Escribe la edad de esta persona"));
                comboBox1.Items.Add(nombres[i]+ " " + edades[i]);

                
            }
            

        }

        private void ascendenteebutton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < nombres.Length; i++)
            {
                Array.Sort(nombres);
                comboBox1.Items.Add(nombres[i]);
            }

     
        }

        private void descendentebutton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < nombres.Length; i++)
            {
                Array.Sort(nombres);
                Array.Reverse(nombres);
                comboBox1.Items.Add(nombres[i]);
            }
        }
    }
}
