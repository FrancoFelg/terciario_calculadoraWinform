using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_FFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                calcular();
            }
            catch (DivideByZeroException ex)
            {
                errorMessage("No se puede dividir por 0");
            }
            catch (InvalidOperationException ex)
            {

            }
            catch (Exception ex)
            {
                errorMessage("Ha ocurrido un error interno: " + ex.Message);
            }

        }

        private void calcular()
        {

            if (!(radioBtnSuma.Checked || radioBtnResta.Checked || radioBtnMult.Checked || radioBtnDiv.Checked))
            {
                errorMessage("Debe ingresar el tipo de operacion a realizar");
                return;
            }
            //throw new Exception();


            decimal number1;
            bool success1 = Decimal.TryParse(inpNumb1.Text, out number1);

            decimal number2;
            bool success2 = Decimal.TryParse(inpNumb2.Text, out number2);

            if (!(success1 && success2))
            {
                errorMessage("Debe ingresar numeros válidos");
                return;
            }

            Decimal result = 0;
            if (radioBtnSuma.Checked) result = number1 + number2;
            if (radioBtnResta.Checked) result = number1 - number2;
            if (radioBtnMult.Checked) result = number1 * number2;


            if (radioBtnDiv.Checked)
            {
                if (number2 == 0)
                {
                    //errorMessage("No se puede dividir por 0");
                    throw new DivideByZeroException();
                    return;
                }

                txtError.Text = "";

                //borra el padding
                result = number1 / number2;
            };


            txtError.Text = "";
            txtError.Padding = new Padding(0);
            txtResultNumber.Text = result.ToString();
        }
        private void refresh()
        {
            txtError.Text = "";
            txtError.Padding = new Padding(0);
            txtResultNumber.Text = "";
            inpNumb1.Text = "";
            inpNumb2.Text = "";

            radioBtnSuma.Checked = false;
            radioBtnResta.Checked = false;
            radioBtnMult.Checked = false;
            radioBtnDiv.Checked = false;
        }

        private void errorMessage(string message)
        {
            txtError.Text = message;
            txtError.Padding = new Padding(8);
            txtError.BackColor = Color.Red;
            txtError.ForeColor = Color.Black;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void inpNumb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpNumb1_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
