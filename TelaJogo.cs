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
    public partial class TelaJogo : Form
    {
        bool created = false;
        IPersonagens ipersonagem;
        Personagens personagem;
        Jogador jogador;
        public TelaJogo()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            jogador = new Jogador();
            this.Controls.Add(jogador);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Down && jogador.Bottom < this.MaximumSize.Height) jogador.Top = jogador.Top + 50;

            if (e.KeyCode == Keys.Left && jogador.Left > 0) jogador.Left = jogador.Left - 50;

            if (e.KeyCode == Keys.Up && jogador.Top > 0 ) jogador.Top = jogador.Top - 50;

            if (e.KeyCode == Keys.Right && jogador.Right < MaximumSize.Width) jogador.Left = jogador.Left + 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FluxoDePersonagens();

            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(timer1.Enabled)
             FluxoDePersonagens();

        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                FluxoDePersonagens();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                FluxoDePersonagens();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                FluxoDePersonagens();
        }
        private void FluxoDePersonagens() {
            if (created == false)
            {
                ipersonagem = PegarPersonagemAleatorio();
                personagem = (Personagens)ipersonagem;
                this.Controls.Add(personagem);
                created = true;
            }

            if ((personagem.Top) < this.MinimumSize.Height)
            {
                personagem.Top = personagem.Top + 5 * Configuracoes.MultiplicadorDeVelocidade();
            }
            else
            {
                created = false;
            }

            if (jogador.Bounds.IntersectsWith(personagem.Bounds) && (ipersonagem is Cloroquina || ipersonagem is Coronavirus) && !ipersonagem.EncostouNoJogador())
            {
                ipersonagem.EncostarNoJogador(jogador, timer1);
                lblVidaValue.Text = jogador.RetornarValorVida().ToString();
            }
            if (jogador.Bounds.IntersectsWith(personagem.Bounds) && (ipersonagem is AuxilioEmergencial || ipersonagem is Fakenews) && !ipersonagem.EncostouNoJogador())
            {
                ipersonagem.EncostarNoJogador(jogador, timer1);
                lblScoreValue.Text = Configuracoes.Score.ToString();
            }

        }

        private List<IPersonagens> AdicionarPersonagensNaLista() {
            List<IPersonagens> p = new List<IPersonagens>();
            p.Add(new Cloroquina(PegarPosicaoXAleatoria()));
            p.Add(new AuxilioEmergencial(PegarPosicaoXAleatoria()));
            p.Add(new Coronavirus(PegarPosicaoXAleatoria()));
            p.Add(new Fakenews(PegarPosicaoXAleatoria()));
            return p;
        }

        private IPersonagens PegarPersonagemAleatorio() {
            var list = AdicionarPersonagensNaLista();
            var r = new Random();
            int indice = r.Next(list.Count);
            return list[indice];
        }

        private int PegarPosicaoXAleatoria() {

            List<int> list = new List<int>();
            for (int i = 0; i < MaximumSize.Width; i = i + 200) {

                list.Add(i);
            }

            Random r = new Random();
            int indice = r.Next(0, list.Count);
            return list[indice];
        }

        
    }
}
