using System;

using UIKit;

namespace HolaXamarin.iOS
{
    public partial class ViewController : UIViewController
    {

        int value1 = 0;
        int value2 = 0;

        /*
         * Índice para saber la operación a realizar donde:
         * 0 suma
         * 1 resta
         * 2 multiplica
         */

        int operation = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        /*
         * addToStringNumber
         * 
         * Parámetros de entrada:
         * entero i - representa el número que se agregará a la cadena a desplegar en la calculadora
         *
         *
         * La intención de este método es agregar a la DERECHA de los números que actualmente se
         * están mostrando en la calculadora el nuevo número {i} introducido.
         *
         * ¿Por qué a la derecha?
         * Por que es el flujo de armado de decimales común para introducir datos en una calcularora
         *
         * Ejemplo:
         *
         * Si quiero introducir el número 13 y acutlamente la cadena es 0 CERO, lo que debo hacer sería lo siguiente:
         *
         * El usuario presiona 1:
         * - Eliminar el CERO y agregar el 1
         *
         * El usuario presiona 3:
         * - Agregar el 3 a la derecha del 1
         *
         * 1<-- Aquí va el 3
         * 13
         * 
         */

        public void addToStringNumber(int i) {
            if (String.Equals(resultLabel.Text, "0")) {
                resultLabel.Text = "";
            }
            resultLabel.Text = resultLabel.Text + i;
        }

        /*
         * Botónes númericos, TOUCH UP INSIDES
         *
         * Estos eventos se llaman cuando el usuario toca sobre uno de los botónes
         * con valor númerico. CAda uno llama a addToStringNumber con el valor correspondiente.
         */

        partial void Uno_TouchUpInside(UIButton sender)
        {
            addToStringNumber(1);

            //Este throw parece una línea que se generá por defecto al agregar un método "Touch Inside" desde el constructor de UI
            //throw new NotImplementedException();
        }

        partial void Dos_TouchUpInside(UIButton sender)
        {
            addToStringNumber(2);
        }

        partial void Tres_TouchUpInside(UIButton sender)
        {
            addToStringNumber(3);
        }

        partial void Cuatro_TouchUpInside(UIButton sender)
        {
            addToStringNumber(4);
        }

        partial void Cinco_TouchUpInside(UIButton sender)
        {
            addToStringNumber(5);
        }

        partial void Seis_TouchUpInside(UIButton sender)
        {
            addToStringNumber(6);
        }

        partial void Siete_TouchUpInside(UIButton sender)
        {
            addToStringNumber(7);
        }

        partial void Ocho_TouchUpInside(UIButton sender)
        {
            addToStringNumber(8);
        }

        partial void Nueve_TouchUpInside(UIButton sender)
        {
            addToStringNumber(9);
        }

        partial void Cero_TouchUpInside(UIButton sender)
        {
            addToStringNumber(0);
        }

        /*
         * Eventos de botones de suma.
         */

        partial void Sumar_TouchUpInside(UIButton sender)
        {
            operation = 0;
            value1 = Int32.Parse(resultLabel.Text);
            resultLabel.Text = "0";
        }

        partial void Restar_TouchUpInside(UIButton sender)
        {
            operation = 1;
            value1 = Int32.Parse(resultLabel.Text);
            resultLabel.Text = "0";
        }

        partial void Multiplicar_TouchUpInside(UIButton sender)
        {
            operation = 2;
            value1 = Int32.Parse(resultLabel.Text);
            resultLabel.Text = "0";
        }

        partial void EqualsButton_TouchUpInside(UIButton sender)
        {
            value2 = Int32.Parse(resultLabel.Text);

            if (operation == 0)
            {
                resultLabel.Text = "" + (value1 + value2);
            }
            else if (operation == 1)
            {
                resultLabel.Text = "" + (value1 - value2);
            }
            else {
                resultLabel.Text = "" + (value1 * value2);
            }
        }

        partial void Acbutton_TouchUpInside(UIButton sender)
        {
            value1 = 0;
            value2 = 0;
            resultLabel.Text = "0";
            operation = 0;
        }
    }
}
