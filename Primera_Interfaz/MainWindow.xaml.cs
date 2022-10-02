using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Primera_Interfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Boton1_Click(object sender, RoutedEventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "";
            }
            QuitarOperador();
            Pantalla.Text = Pantalla.Text + 1;           
        }

        private void Boton2_Click(object sender, RoutedEventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "";
            }
            QuitarOperador();
            Pantalla.Text = Pantalla.Text + 2;
        }

        private void Boton3_Click(object sender, RoutedEventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "";
            }
            QuitarOperador();
            Pantalla.Text = Pantalla.Text + 3;
        }

        private void Boton4_Click(object sender, RoutedEventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "";
            }
            QuitarOperador();
            Pantalla.Text = Pantalla.Text + 4;
        }

        private void Boton5_Click(object sender, RoutedEventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "";
            }
            QuitarOperador();
            Pantalla.Text = Pantalla.Text + 5;
        }

        private void Boton6_Click(object sender, RoutedEventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "";
            }
            QuitarOperador();
            Pantalla.Text = Pantalla.Text + 6;
        }

        private void Boton7_Click(object sender, RoutedEventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "";
            }
            QuitarOperador();
            Pantalla.Text = Pantalla.Text + 7;
        }

        private void Boton8_Click(object sender, RoutedEventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "";
            }
            QuitarOperador();
            Pantalla.Text = Pantalla.Text + 8;
        }

        private void Boton9_Click(object sender, RoutedEventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "";
            }
            QuitarOperador();
            Pantalla.Text = Pantalla.Text + 9;
        }

        private void Boton0_Click(object sender, RoutedEventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                Pantalla.Text = "";
            }
            QuitarOperador();
            Pantalla.Text = Pantalla.Text + 0;
        }

        private void BotonDivide_Click(object sender, RoutedEventArgs e)
        {
            try
            {   valoresPantalla = Int32.Parse(Pantalla.Text);
                Pantalla.Text = "/";
                ValoresTemp.Text = valoresPantalla.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No puedes hacer eso, error: {0}", ex.Message);
            }
            
        }

        private void BotonSuma_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                valoresPantalla = Int32.Parse(Pantalla.Text);
                Pantalla.Text = "+";
                ValoresTemp.Text = valoresPantalla.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No puedes hacer eso, error: {0}", ex.Message);
            }
            
        }
        
        private void BotonResta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                valoresPantalla = Int32.Parse(Pantalla.Text);
                Pantalla.Text = "-";
                ValoresTemp.Text = valoresPantalla.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puedes hacer eso, error: {0}", ex.Message);
            }
            
        }

        private void BotonMultiplica_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                valoresPantalla = Int32.Parse(Pantalla.Text);
                Pantalla.Text = "*";
                ValoresTemp.Text = valoresPantalla.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puedes hacer eso, error: {0}", ex.Message);
            }
            
        }

        private void BotonBorraTodo_Click(object sender, RoutedEventArgs e)
        {
            Pantalla.Text = "";
            ValoresTemp.Text = "";
        }

        private void BotonResultado_Click(object sender, RoutedEventArgs e)
        {            
            try
            {
                if (operador == "+")
                {
                    resultadoOperacion = valoresPantalla + Int32.Parse(Pantalla.Text);
                    Pantalla.Text = resultadoOperacion.ToString();
                    ValoresTemp.Text = "";

                }
                else if (operador == "-")
                {
                    resultadoOperacion = valoresPantalla - Int32.Parse(Pantalla.Text);
                    Pantalla.Text = resultadoOperacion.ToString();
                    ValoresTemp.Text = "";

                }
                else if (operador == "*")
                {
                    resultadoOperacion = valoresPantalla * Int32.Parse(Pantalla.Text);
                    Pantalla.Text = resultadoOperacion.ToString();
                    ValoresTemp.Text = "";

                }
                else if (operador == "/")
                {
                    if(Pantalla.Text == "0")
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        Pantalla.Text = "0";
                        ValoresTemp.Text = "";
                    }
                    else
                    {
                        resultadoOperacion = valoresPantalla / Int32.Parse(Pantalla.Text);
                        Pantalla.Text = resultadoOperacion.ToString();
                        ValoresTemp.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operacion Invalida: " + ex.Message);
            }            
        }
        private void QuitarOperador()
        {
            if (Pantalla.Text == "+")
            {
                operador = "+";
                
                Pantalla.Text = "";
            }
            else if (Pantalla.Text == "-")
            {
                operador = "-";
                Pantalla.Text = "";
            }
            else if (Pantalla.Text == "*")
            {
                operador = "*";
                Pantalla.Text = "";
            }
            else if (Pantalla.Text == "/")
            {
                operador = "/";
                Pantalla.Text = "";
            }
        }
        private double valoresPantalla;
        private string operador;
        private double resultadoOperacion;
    }
}
