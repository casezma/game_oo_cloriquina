using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrasileiroAtacado
{
    public partial class TelaInicio : Form
    {
        Size pequeno = new Size(800, 600);
        Size medio = new Size(960, 720);
        Size grande = new Size(1040, 780);

        public TelaInicio()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (opcaoPequeno.Checked || opcaoMedio.Checked || opcaoGrande.Checked) {

                var f = new TelaJogo();

                if (opcaoPequeno.Checked)
                {
                    f.MinimumSize = pequeno;
                    f.MaximumSize = pequeno;
                    f.ShowDialog();
                }
                else if (opcaoMedio.Checked)
                {
                    f.MinimumSize = medio;
                    f.MaximumSize = medio;
                    f.ShowDialog();
                }

                else if(opcaoGrande.Checked) {
                    f.MinimumSize = grande;
                    f.MaximumSize = grande;
                    f.ShowDialog();
                }
            } 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
