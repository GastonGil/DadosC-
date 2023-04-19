using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadosC
{
    public partial class Dados : Form
    {
        bool primeraVez = true;
        string[] arrayNombresJugadores;
        int contador = 0;
        int cantidadDeJugadores = 0;
        public Dados()
        {
            InitializeComponent();
        }

        private void Cubilete_Click(object sender, EventArgs e)
        {
            if (primeraVez) {
                CantidadJugadores FormCantidadDeJugadores = new CantidadJugadores();
                FormCantidadDeJugadores.ShowDialog();
                int cantidadDeJugadores = int.Parse(FormCantidadDeJugadores.getTIngresarCantidad().Text);
                arrayNombresJugadores = new string[cantidadDeJugadores];
                
                int i;
                for (i = 0; i < cantidadDeJugadores; i++)
                {
                    NombresJugadores FormNombresJugadores = new NombresJugadores();
                    FormNombresJugadores.getTIngresarNombres().Text = "Ingrese el nombre del jugador: " + (i+1);
                    FormNombresJugadores.ShowDialog();
                    arrayNombresJugadores[i] = FormNombresJugadores.getTIngresarNombres().Text;
                }
                primeraVez = false;
            }
            if(contador == cantidadDeJugadores)
            {
                contador = 0;
            }

            MessageBox.Show("Es el turno de: " + arrayNombresJugadores[contador], "A tirar los dados");
            int Num1 = 0;
            int Num2 = 0;
            int Num3 = 0;
            int Num4 = 0;
            int Num5 = 0;
            CambiarDado(ref Dado1, ref Num1);
            CambiarDado(ref Dado2, ref Num2);
            CambiarDado(ref Dado3, ref Num3);
            CambiarDado(ref Dado4, ref Num4);
            CambiarDado(ref Dado5, ref Num5);

            bool SalioJugadaServida = false;

            MostrarMensajesDeJugadas(Num1, Num2, Num3, Num4, Num5, ref SalioJugadaServida);

            if(SalioJugadaServida == false){
                int i = 0;
                bool CambiaDado1 = true, CambiaDado2 = true, CambiaDado3 = true, CambiaDado4 = true, CambiaDado5 = true;
                for (i = 0; i < 2; i++)
                {
                    DialogResult respuesta = MessageBox.Show("Guardas el valor del dado 1?", "Dado 1", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        CambiaDado1 = false;
                    }

                    respuesta = MessageBox.Show("Guardas el valor del dado 2?", "Dado 2", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        CambiaDado2 = false;
                    }

                    respuesta = MessageBox.Show("Guardas el valor del dado 3?", "Dado 3", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        CambiaDado3 = false;
                    }

                    respuesta = MessageBox.Show("Guardas el valor del dado 4?", "Dado 4", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes) {
                        CambiaDado4 = false;
                    }

                    respuesta = MessageBox.Show("Guardas el valor del dado 5?", "Dado 5", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes) {
                        CambiaDado5 = false;
                    }

                    if (CambiaDado1) {
                        CambiarDado(ref Dado1, ref Num1);
                    }
                    if (CambiaDado2) {
                        CambiarDado(ref Dado2, ref Num2);
                    }
                    if (CambiaDado3) {
                        CambiarDado(ref Dado3, ref Num3);
                    }
                    if (CambiaDado4) {
                        CambiarDado(ref Dado4, ref Num4);
                    }
                    if (CambiaDado5)
                    {
                        CambiarDado(ref Dado5, ref Num5);
                    }
                    MostrarMensajesDeJugadas(Num1, Num2, Num3, Num4, Num5, ref SalioJugadaServida);
                }

            }
            contador++;
        }

        public int NumDado()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
        



        public void CambiarImagenDado(ref PictureBox DadoX,int Num)
        {
            switch (Num)
            {
                case 1:
                    DadoX.Image = Properties.Resources.dado1;
                    break;
                case 2:
                    DadoX.Image = Properties.Resources.dado2;
                    break;
                case 3:
                    DadoX.Image = Properties.Resources.dado3;
                    break;
                case 4:
                    DadoX.Image = Properties.Resources.dado4;
                    break;
                case 5:
                    DadoX.Image = Properties.Resources.dado5;
                    break;
                case 6:
                    DadoX.Image = Properties.Resources.dado6;
                    break;
            }
        }
        public void CambiarTamaño(ref PictureBox DadoX)
        {
            DadoX.Size = new Size(94, 95);
            DadoX.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void CambiarDado(ref PictureBox DadoX, ref int Num)
        {
            Num = NumDado();
            CambiarTamaño(ref DadoX);
            CambiarImagenDado(ref DadoX, Num);
        }

        public bool EsEscalera(int num1 ,int num2,int num3,int num4,int num5)
        {
            int[]Numeros = new int[5];
            Numeros[0] = num1;
            Numeros[1] = num2;
            Numeros[2] = num3;
            Numeros[3] = num4;
            Numeros[4] = num5;
            int I = 0;
            bool HayEscalera;
            bool Hay1 = true;
            bool Hay6 = true;
            int [] ArrayAVerificar = Numeros.Distinct().ToArray();

            if(Numeros.Length < ArrayAVerificar.Length || Numeros.Length > ArrayAVerificar.Length)
            {
                HayEscalera = false;
            }
            else
            {
                Hay1 = false;
                Hay6 = false;
                for(I = 0; I < Numeros.Length; I++)
                {
                    if (Numeros[I] == 1)
                    {
                        Hay1 = true;
                    }else if (Numeros[I] == 6)
                    {
                        Hay6 = true;
                    }
                }
            }
            if (Hay1 && Hay6 ) {
                HayEscalera = false;
            } else {
                HayEscalera = true;
            }
            return HayEscalera;
        }

        public bool EsPoker(int num1, int num2, int num3, int num4, int num5)
        {
            int[] Numeros = new int[5];
            Numeros[0] = num1;
            Numeros[1] = num2;
            Numeros[2] = num3;
            Numeros[3] = num4;
            Numeros[4] = num5;
            int[] ArrayAVerificar = Numeros.Distinct().ToArray();
            bool HayPoker = (ArrayAVerificar.Length == 2) ? true : false;
            return HayPoker;
        }

        public bool EsFull(int num1, int num2, int num3, int num4, int num5)
        {
            int[] Numeros = new int[5];
            Numeros[0] = num1;
            Numeros[1] = num2;
            Numeros[2] = num3;
            Numeros[3] = num4;
            Numeros[4] = num5;
            int I;
            int Posible1 = 0;
            int Posible2 = 0;

            for(I=0;I < Numeros.Length; I++)
            {
                if (I == 0)
                {
                    Posible1 = Numeros[I];
                }
                if(Posible2 == 0)
                {
                    if(Numeros[I] != Posible1)
                    {
                        Posible2 = Numeros[I];
                    }
                }
            }

            int contadorPosible1 = 0;
            int contadorPosible2 = 0;
            for (I = 0; I < Numeros.Length; I++)
            {
                if(Posible1 == Numeros[I])
                {
                    contadorPosible1++;
                }else if(Posible2 == Numeros[I])
                {
                    contadorPosible2++;
                }
            }

            bool HayFull = (contadorPosible1 == 2 && contadorPosible2 == 3 || contadorPosible1 == 3 && contadorPosible2 == 2)
                ? true : false;
            return HayFull;
        }

        public bool EsGenerala(int num1, int num2, int num3, int num4, int num5)
        {
            int[] Numeros = new int[5];
            Numeros[0] = num1;
            Numeros[1] = num2;
            Numeros[2] = num3;
            Numeros[3] = num4;
            Numeros[4] = num5;
            int[] ArrayAVerificar = Numeros.Distinct().ToArray();
            bool HayGenerala = (ArrayAVerificar.Length == 1) ? true : false;
            return HayGenerala;
        }

        public bool EsDobleGenerala(int num1, int num2, int num3, int num4, int num5)
        {
            int[] Numeros = new int[5];
            Numeros[0] = num1;
            Numeros[1] = num2;
            Numeros[2] = num3;
            Numeros[3] = num4;
            Numeros[4] = num5;
            int i;
            int contador = 0;
            for (i=0; i < Numeros.Length; i++)
            {
                if(Numeros[i] == 1)
                {
                    contador++;
                }
            }

            bool HayDobleGenerala = (contador == 5) ? true : false;
            return HayDobleGenerala;
        }

        public void MostrarMensajesDeJugadas(int Num1, int Num2, int Num3, int Num4, int Num5, ref bool Salio)
        {
            Salio = false;
            if( EsEscalera(Num1, Num2, Num3, Num4, Num5))
            {
                MessageBox.Show("Hiciste Escalera", "Felicitaciones");
                Salio = true;
            }else if(EsPoker(Num1, Num2, Num3, Num4, Num5))
            {
                MessageBox.Show("Hiciste Poker", "Felicitaciones");
                Salio = true;
            }else if(EsFull(Num1, Num2, Num3, Num4, Num5))
            {
                MessageBox.Show("Hiciste Full", "Felicitaciones");
                Salio = true;
            }else if(EsGenerala(Num1, Num2, Num3, Num4, Num5))
            {
                MessageBox.Show("Hiciste Generala", "Felicitaciones");
                Salio = true;
            }else if(EsDobleGenerala(Num1, Num2, Num3, Num4, Num5))
            {
                MessageBox.Show("Hiciste Doble Generala", "Felicitaciones");
                Salio = true;
            }
        }
    }
}
