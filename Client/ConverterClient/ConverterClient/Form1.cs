using System;
using System.ServiceModel;
using System.Windows.Forms;
using ConverterClient.ConverterServiceReference;

namespace ConverterClient
{
    public partial class Form1 : Form
    {
        ConverterContractClient proxy = new ConverterContractClient();
        public Form1()
        {
            InitializeComponent();
            comboBoxСonvertibleType.Items.Add("Meters");
            comboBoxСonvertibleType.Items.Add("Celsius");
            comboBoxСonvertibleType.Items.Add("Fahrenheit");
            comboBoxСonvertibleType.SelectedItem = comboBoxСonvertibleType.Items[0];
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double data = Convert.ToDouble(textBoxInputСonvertibleData.Text);
                ConvertedUnits convertedUnits = null;
                switch (comboBoxСonvertibleType.Text)
                {
                    case "Meters":
                        {
                            if (data >= 0)
                                convertedUnits = proxy.LinearMeasure(data);
                            else
                                throw new FormatException();
                            textBoxInch.Text = convertedUnits.Inch.ToString();
                            textBoxFoot.Text = convertedUnits.Foot.ToString();
                            textBoxYard.Text = convertedUnits.Yard.ToString();
                        }
                        break;
                    case "Celsius":
                        {
                            convertedUnits = proxy.CelsiusToFahrenheit(data);
                            textBoxTemperature.Text = convertedUnits.Fahrenheit.ToString();
                            labelTemperature.Text = "Fahrenheit";
                        }
                        break;
                    case "Fahrenheit":
                        {
                            convertedUnits = proxy.FahrenheitToCelsius(data);
                            textBoxTemperature.Text = convertedUnits.Celsius.ToString();
                            labelTemperature.Text = "Celsius";
                        }
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect value entered!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Incorrect value entered!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("The server return empty value!");
            }
            catch (EndpointNotFoundException)
            {
                MessageBox.Show("The server is currently unavailable!");
            }
        }
    }
}
