using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciCofre
{
    public partial class Form1 : Form
    {
        #region Variaveis
        private SortedList<long, long> ListaFibonacci = null;
        private SortedList<long, long> ListaCodigos = null;
        private List<long> ListaPistas = null;
        private StringBuilder sbTextoFinal = null;
        private Random randNum = null;
        private string ErroAo = "";
        private int index = 0;
        #endregion

        #region Construtor
        public Form1()
        {
            InitializeComponent();
            ListaFibonacci = new SortedList<long, long>();
            InicializaVariaveis();
            CarregarListaFibonacci();
            GerarCabecalhoTextoFinal();
        }
        #endregion

        private void btConfirmarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                ErroAo = "Converter a informação digitada no campo 'Pista'";
                if (Convert.ToInt32(tbPista.Text) > 78 || Convert.ToInt32(tbPista.Text) < 0)
                {
                    MessageBox.Show("A pista informada é inválida!");
                }
                else
                {
                    if ((lbNovaPista.Text != tbPista.Text && index == 0) || lbNovaPista.Text == tbPista.Text)
                    {
                        DateTime inicio = DateTime.Now;
                        ErroAo = "Buscar a informação na lista de Fibonacci";
                        lbCodigo.Text = ListaFibonacci[Convert.ToInt32(tbPista.Text)].ToString("0000000000000000");
                        long random = randNum.Next(0, 78);
                        AddNovaPista(random);
                        lbNovaPista.Text = ListaPistas[index].ToString();
                        ListaCodigos.Add(Convert.ToInt64(lbNovaPista.Text), Convert.ToInt64(lbCodigo.Text));
                        GerarTextoFinal(tbPista.Text, lbCodigo.Text, (DateTime.Now - inicio).ToString());
                        tbPista.Text = "";
                        if (ListaCodigos.Count == 7)
                        {
                            sbTextoFinal.AppendLine();
                            sbTextoFinal.AppendLine("=======================================");
                            MessageBox.Show(sbTextoFinal.ToString());
                            InicializaVariaveis();
                        }
                        else
                        {
                            index++;
                        }
                        tbPista.Focus();
                    }
                    else
                    {
                        MessageBox.Show("A pista já foi informada anteriormente. Favor informar a nova pista informada!");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao: " + ErroAo + "\r\nErro: " + err.Message);
            }
        }

        public void CarregarListaFibonacci()
        {
            try
            {
                ErroAo = "Carregar a lista Fibonacci";
                long a = 0; long b = 1; long aux = 0;
                ListaFibonacci.Add(a, 0);
                ListaFibonacci.Add(b, 1);
                for (int i = 2; i < 79; i++)
                {
                    ListaFibonacci.Add(i, a + b);
                    aux = a;
                    a = b;
                    b = a + aux;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro ao: " + ErroAo + "\r\nErro: " + err.Message);
            }
        }

        public void InicializaVariaveis()
        {
            ListaCodigos = new SortedList<long, long>();
            ListaPistas = new List<long>();
            sbTextoFinal = new StringBuilder();
            randNum = new Random();
            index = 0;
            tbPista.Text = "";
            lbNovaPista.Text = "";
            lbCodigo.Text = "";
        }

        public void AddNovaPista(long pista)
        {
            while (ListaPistas.Contains(pista))
            {
                pista = randNum.Next(0, 78);
            }
            ListaPistas.Add(pista);
        }

        public void GerarCabecalhoTextoFinal()
        {
            sbTextoFinal = new StringBuilder();
            sbTextoFinal.AppendLine("Foram realizados todas as buscas dos códigos. Segue abaixo as informações necessárias para abrir o cofre:");
            sbTextoFinal.AppendLine();
            sbTextoFinal.AppendLine("============Códigos gerados============");
        }

        public void GerarTextoFinal(string pista, string cod, string tempo)
        {
            sbTextoFinal.AppendLine($"Pista: {pista} | Código: {cod} | Tempo de consulta: {tempo}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stripTempo.Text = DateTime.Now.ToString();
        }

        private void tbPista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btConfirmarCodigo.PerformClick();
            }
        }
    }
}