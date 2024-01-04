using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void buttonConverter_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenha a lista de números a partir da caixa de texto
                string[] numerosString = textBoxNumeros.Text.Split(',');
                List<int> numeros = new List<int>();

                foreach (var numeroString in numerosString)
                {
                    if (int.TryParse(numeroString, out int numero))
                    {
                        numeros.Add(numero);
                    }
                    else
                    {
                        throw new FormatException("Formato inválido para os números.");
                    }
                }

                // Converta os números para as palavras "POSITIVO" ou "NEGATIVO"
                List<string> numerosConvertidos = numeros.Select(num => num >= 0 ? "POSITIVO" : "NEGATIVO").ToList();

                // Exiba o resultado na caixa de texto de saída
                textBoxResultado.Text = string.Join(", ", numerosConvertidos);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

