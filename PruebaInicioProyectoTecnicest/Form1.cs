using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PruebaInicioProyectoTecnicest
{


    public partial class Form1 : Form
    {
        private double axisX = 0;
        private double axisY = 0;
        private double axisZ = 0;
        private double axisU = 0;
        private Timer timerAdd;
        private Timer timerSubstract;
        public const int speedConstant = 5000;
        public int speed;


        class Coordinates
        {
            // Propiedades de las coordenadas: name, x, y, z, u
            public string name {  get; set; }
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
            public double U { get; set; }

            // Constructor para inicializar las coordenadas
            public Coordinates(string name, double X, double Y, double Z, double U)
            {
                this.name = name;
                this.X = X;
                this.Y = Y;
                this.Z = Z;
                this.U = U;
            }

            // Método para imprimir las coordenadas del punto
            public void ImprimirCoordenadas()
            {
                Console.WriteLine($"Coordinates: X({X}); Y({Y}); Z({Z}); U({U})");
                MessageBox.Show($"Coordinates: X({X}); Y({Y}); Z({Z}); U({U})");
            }
        }

        List<Coordinates> coordinatesList = new List<Coordinates>();

        public Form1()
        {
            InitializeComponent();

            //Crear un temporizador
            timerAdd = new Timer();
            speed = speedConstant / speedBar.Value;
            timerAdd.Interval = speed; // Intervalo de tiempo en milisegundos
            timerAdd.Tick += Timer_Tick_Add;

            timerSubstract = new Timer();
            timerSubstract.Interval = speed;
            timerSubstract.Tick += Timer_Tick_Substract;

            // Defino la propiedad de visualización en el ListBox del objeto Coordinate
            coordListBox.DisplayMember = "name";
        }

        private void Timer_Tick_Add(object sender, EventArgs e)
        {
            // Incrementar el valor y actualizar los textos
            switch (axisSelector.SelectedIndex)
            {
                case 0:
                    axisX++;
                    axisCoordinate.Text = Convert.ToString(axisX);
                    coordinates.Text = "Coordinates: X (" + axisX + "); Y (" + axisY + "); Z (" + axisZ + "); U (" + axisU + ")";
                    break;
                case 1:
                    axisY++;
                    axisCoordinate.Text = Convert.ToString(axisY);
                    coordinates.Text = "Coordinates: X (" + axisX + "); Y (" + axisY + "); Z (" + axisZ + "); U (" + axisU + ")";
                    break;
                case 2:
                    axisZ++;
                    axisCoordinate.Text = Convert.ToString(axisZ);
                    coordinates.Text = "Coordinates: X (" + axisX + "); Y (" + axisY + "); Z (" + axisZ + "); U (" + axisU + ")";
                    break;
                case 3:
                    axisU++;
                    axisCoordinate.Text = Convert.ToString(axisU);
                    coordinates.Text = "Coordinates: X (" + axisX + "); Y (" + axisY + "); Z (" + axisZ + "); U (" + axisU + ")";
                    break;
            }
        }

        private void Timer_Tick_Substract(object sender, EventArgs e)
        {
            // Disminuir el valor y actualizar el texto del TextBox
            switch (axisSelector.SelectedIndex)
            {
                case 0:
                    axisX--;
                    axisCoordinate.Text = Convert.ToString(axisX);
                    coordinates.Text = "Coordinates: X (" + axisX + "); Y (" + axisY + "); Z (" + axisZ + "); U (" + axisU + ")";
                    break;
                case 1:
                    axisY--;
                    axisCoordinate.Text = Convert.ToString(axisY);
                    coordinates.Text = "Coordinates: X (" + axisX + "); Y (" + axisY + "); Z (" + axisZ + "); U (" + axisU + ")";
                    break;
                case 2:
                    axisZ--;
                    axisCoordinate.Text = Convert.ToString(axisZ);
                    coordinates.Text = "Coordinates: X (" + axisX + "); Y (" + axisY + "); Z (" + axisZ + "); U (" + axisU + ")";
                    break;
                case 3:
                    axisU--;
                    axisCoordinate.Text = Convert.ToString(axisU);
                    coordinates.Text = "Coordinates: X (" + axisX + "); Y (" + axisY + "); Z (" + axisZ + "); U (" + axisU + ")";
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
                speedBar.Enabled = true;
                coordinates.Text = "Coordinates: X (" + axisX + "); Y (" + axisY + "); Z ("+ axisZ + "); U (" + axisU + ")";
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
                axisCoordinate.Visible = false;
                regiserCoordinates.Enabled = false;
                speedBar.Value = 25;
                speedBar.Enabled = false;
                coordListBox.Enabled = false;
                coordListBox.SelectedIndex = -1;
                coordinates.Text = "Coordinates: X (); Y (); Z (); U ()";
                searchedCoordsLabel.Text = "Searched coordinates: X (); Y (); Z (); U ()";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String axisSelected = axisSelector.SelectedItem as String;
            labelAxis.Text = axisSelected;
            axisCoordinate.Visible = true;
            bttnMin.Enabled = true;
            bttnMax.Enabled = true;
            switch (axisSelector.SelectedIndex)
            {
                case 0:
                    axisCoordinate.Text = Convert.ToString(axisX);
                    break;
                case 1:
                    axisCoordinate.Text = Convert.ToString(axisY);
                    break;
                case 2:
                    axisCoordinate.Text = Convert.ToString(axisZ);
                    break;
                case 3:
                    axisCoordinate.Text = Convert.ToString(axisU);
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

        private void speedBar_ValueChanged(object sender, EventArgs e)
        {
            speed = speedConstant / speedBar.Value;
            // Actualizo el valor numérico en un TextBox
            timerSubstract.Interval = speed;
            timerAdd.Interval = speed;
        }

        private void regiserCoordinates_Click(object sender, EventArgs e)
        {
            string name = InputBox.Show("Enter a name for the coordinates", "Name entry");
            // Guardar un objeto de tipo Coordinates con coordenadas específicas
            Coordinates coordinates = new Coordinates(name, axisX, axisY, axisZ, axisU);
            coordinatesList.Add(coordinates);

            // Imprimir las coordenadas del punto
            coordinates.ImprimirCoordenadas();

            Console.ReadLine();

  
            // Asigno la lista de objetos al DataSource de la lista
            coordListBox.DataSource = null;
            coordListBox.DataSource = coordinatesList;
            // Defino la propiedad de visualización en el ListBox del objeto Coordinate
            coordListBox.DisplayMember = "name";
            coordListBox.SelectedIndex = -1;
        }

        private void coordListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Acciones que quieres realizar cuando se selecciona un elemento en el ListBox
            if (coordListBox.SelectedIndex != -1) // Verificar si hay un elemento seleccionado
            {            
                Coordinates searchedCoordinates = coordListBox.SelectedItem as Coordinates;
                searchedCoordsLabel.Text = "Searched coordinates: X (" + searchedCoordinates.X + "); Y (" + searchedCoordinates.Y + "); Z (" + searchedCoordinates.Z + "); U (" + searchedCoordinates.U + ")";
            }
        }
    }

    public static class InputBox
    {
        public static string Show(string prompt, string title)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = prompt;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new System.Drawing.Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new System.Drawing.Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
                return textBox.Text;
            else
                return null;
        }
    }
}
