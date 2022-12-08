using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoEstacionamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = "COM9";
                serialPort1.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error" + error);
            }
            picChoque.Visible = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("$On");
                lblon.BackColor = Color.LimeGreen;
                lblon.Text = "ON";
                picLED.Image = Properties.Resources.farolgris;
            }
            catch (Exception error)
            {
                MessageBox.Show("Se inicio la comunicacion" + error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.WriteLine("$Off"); 
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("$Off");
                lblon.BackColor = Color.Red;
                lblon.Text = "OFF";
                lblMedida.ForeColor = Color.Black;
                picLED.Image = Properties.Resources.farolgris;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                lblMedida.Invoke((MethodInvoker)(() => {
                    string SerialData = serialPort1.ReadLine();
                    lblMedida.Text = SerialData;
                    if (SerialData.Equals("$On\r"))
                    {
                        MessageBox.Show("Iniciando");
                        lblMedida.Text = "0";
                    }
                    else if (SerialData.Equals("$Off\r"))
                    {
                        MessageBox.Show("Deteniendo");
                        lblMedida.Text = "0";
                    }
                    else
                    {
                        if (double.Parse(SerialData) > 100.00)
                        {
                            lblMedida.Text = "0";
                            lblMedida.ForeColor = Color.Black;
                            picChoque.Visible = false;
                        }
                        else
                        {
                            if (double.Parse(lblMedida.Text) <= 100.00 && double.Parse(lblMedida.Text) > 50.00)
                            {
                                lblMedida.BackColor = Color.PowderBlue;
                                picLED.Image = Properties.Resources.farolverde;
                                lblMedida.ForeColor = Color.Green;
                                picChoque.Visible = false;
                                int x = picAutoR.Location.X;
                                int y = picAutoR.Location.Y;
                                x = -3;
                                Point punto = new Point(x, y);
                                picAutoR.Location = punto;
                            }
                            if (double.Parse(lblMedida.Text) <= 50.00 && double.Parse(lblMedida.Text) > 30.00)
                            {
                                picLED.Image = Properties.Resources.farol;
                                lblMedida.BackColor = Color.CadetBlue;
                                lblMedida.ForeColor = Color.Yellow;
                                picChoque.Visible = false;
                                int x = picAutoR.Location.X;
                                int y = picAutoR.Location.Y;
                                x = 10;
                                Point punto = new Point(x, y);
                                picAutoR.Location = punto;
                            }
                            if (double.Parse(lblMedida.Text) <= 30.00 && double.Parse(lblMedida.Text) > 20.00)
                            {
                                lblMedida.BackColor = Color.CadetBlue;
                                picLED.Image = Properties.Resources.farol;
                                lblMedida.ForeColor = Color.Yellow;
                                picChoque.Visible = false;
                                int x = picAutoR.Location.X;
                                int y = picAutoR.Location.Y;
                                x = 20;
                                Point punto = new Point(x, y);
                                picAutoR.Location = punto;
                            }
                            if (double.Parse(lblMedida.Text) <= 20.00 && double.Parse(lblMedida.Text) > 10.00)
                            {
                                lblMedida.BackColor = Color.PowderBlue;
                                picLED.Image = Properties.Resources.farolrojo;
                                lblMedida.ForeColor = Color.Red;
                                picChoque.Visible = false;
                                int x = picAutoR.Location.X;
                                int y = picAutoR.Location.Y;
                                x = 40;
                                Point punto = new Point(x, y);
                                picAutoR.Location = punto;
                                
                            }
                            if (double.Parse(lblMedida.Text) <= 10.00)
                            {
                                lblMedida.BackColor = Color.PowderBlue;
                                picLED.Image = Properties.Resources.farolrojo;
                                lblMedida.ForeColor = Color.Red;
                                picChoque.Visible = false;
                                int x = picAutoR.Location.X;
                                int y = picAutoR.Location.Y;
                                x = 66;
                                Point punto = new Point(x, y);
                                picAutoR.Location = punto;
                            }
                            if (double.Parse(lblMedida.Text) <= 3.00)
                            {
                                picChoque.Visible = true;
                            }
                        }
                    }
                })
                );
            }
        }


        private void tmrMov_Tick(object sender, EventArgs e)
        {
            /* Por si queremos una animacion simple
            int x = picAutoR.Location.X;
            int y = picAutoR.Location.Y;
            if (x < 77)//77
            {
                x++;
                
            }
            else if (x == 77)
            {
                x = 0;
            }         
            Point punto = new Point(x, y);
            picAutoR.Location = punto;
            */
        }

    }
}