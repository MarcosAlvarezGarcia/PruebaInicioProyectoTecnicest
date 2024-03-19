using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaInicioProyectoTecnicest
{
    public partial class Form1 : Form
    {
        private double axisX = 0;
        private double axisY = 0;
        private double axisZ = 0;
        private double axisU = 0;
        private double valor = 0;
        private Timer timerAdd;
        private Timer timerSubstract;

        class Coordinates
        {
            // Propiedades de las coordenadas x, y, z, u
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
            public double U { get; set; }

            // Constructor para inicializar las coordenadas
            public Coordinates(double x, double y, double z, double u)
            {
                X = x;
                Y = y;
                Z = z;
                U = u;
            }

            // Método para imprimir las coordenadas del punto
            public void ImprimirCoordenadas()
            {
                Console.WriteLine($"Coordenadas: ({X}, {Y}, {Z}, {U})");
                MessageBox.Show($"Coordenadas: ({X}, {Y}, {Z}, {U})");
            }
        }

        public Form1()
        {
            InitializeComponent();

            //Crear un temporizador
            timerAdd = new Timer();
            timerAdd.Interval = 1000; // Intervalo de tiempo en milisegundos
            timerAdd.Tick += Timer_Tick_Add;

            timerSubstract = new Timer();
            timerSubstract.Interval = 1000;
            timerSubstract.Tick += Timer_Tick_Substract;
        }

        private void Timer_Tick_Add(object sender, EventArgs e)
        {
            // Incrementar el valor y actualizar el texto del TextBox
            switch (axisSelector.SelectedIndex)
            {
                case 0:
                    axisX++;
                    textBox1.Text = Convert.ToString(axisX);
                    break;
                case 1:
                    axisY++;
                    textBox1.Text = Convert.ToString(axisY);
                    break;
                case 2:
                    axisZ++;
                    textBox1.Text = Convert.ToString(axisZ);
                    break;
                case 3:
                    axisU++;
                    textBox1.Text = Convert.ToString(axisU);
                    break;
            }
        }

        private void Timer_Tick_Substract(object sender, EventArgs e)
        {
            // Incrementar el valor y actualizar el texto del TextBox
            switch (axisSelector.SelectedIndex)
            {
                case 0:
                    axisX--;
                    textBox1.Text = Convert.ToString(axisX);
                    break;
                case 1:
                    axisY--;
                    textBox1.Text = Convert.ToString(axisY);
                    break;
                case 2:
                    axisZ--;
                    textBox1.Text = Convert.ToString(axisZ);
                    break;
                case 3:
                    axisU--;
                    textBox1.Text = Convert.ToString(axisU);
                    break;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (bttnStart.Text == "OFF")
            {
                bttnStart.Text = "ON";
                bttnStart.BackColor = Color.Green;
                axisSelector.Enabled = true;
                regiserCoordinates.Enabled = true;
            }
            else
            {
                bttnStart.Text = "OFF";
                bttnStart.BackColor = Color.Red;
                axisSelector.Enabled = false;
                bttnMin.Enabled = false;
                bttnMax.Enabled = false;
                axisSelector.Text = "Select an axis";
                labelAxis.Text = "No axis selected";
                textBox1.Visible = false;
                regiserCoordinates.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String axisSelected = axisSelector.SelectedItem as String;
            labelAxis.Text = axisSelected;
            textBox1.Visible = true;
            bttnMin.Enabled = true;
            bttnMax.Enabled = true;
            switch (axisSelector.SelectedIndex)
            {
                case 0:
                    textBox1.Text = Convert.ToString(axisX);
                    break;
                case 1:
                    textBox1.Text = Convert.ToString(axisY);
                    break;
                case 2:
                    textBox1.Text = Convert.ToString(axisZ);
                    break;
                case 3:
                    textBox1.Text = Convert.ToString(axisU);
                    break;
            }

        }

        // Manejar el evento MouseDown del botón para iniciar el temporizador
        private void bttnMin_MouseDown(object sender, MouseEventArgs e)
        {
            timerSubstract.Start();
        }
        private void bttnMax_MouseDown(object sender, MouseEventArgs e)
        {
            timerAdd.Start();
        }

        // Manejar el evento MouseUp del botón para detener el temporizador
        private void bttnMin_MouseUp(object sender, MouseEventArgs e)
        {
            timerSubstract.Stop();
        }
        private void bttnMax_MouseUp(object sender, MouseEventArgs e)
        {
            timerAdd.Stop();
        }

        private void regiserCoordinates_Click(object sender, EventArgs e)
        {
            // Guardar un objeto de tipo Coordinates con coordenadas específicas
            Coordinates coordinates = new Coordinates(axisX, axisY, axisZ, axisU);

            // Imprimir las coordenadas del punto
            coordinates.ImprimirCoordenadas();

            Console.ReadLine();
        }
    }
}
