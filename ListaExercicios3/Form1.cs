using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaExercicios3
{
    public partial class FormMostrarMut : Form
    {
        public FormMostrarMut()
        {
            InitializeComponent();
            int a;
            int b;

            for (a = 500; a <= 1000; a++)
                if (a % 17 == 0){
                    textMultiplos.Text = (a.ToString() + "\n");
                }
            for (b = 500; b <= 1000; b++)
            {
                if (b % 31 == 0){
                    textMultiplos.Text = (b.ToString() + "\n");
                    


                }
            }

            
        }

        
    }
}
