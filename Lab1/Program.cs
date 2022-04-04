using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ElectricalElements;

namespace Lab3
{
    /// <summary>
    /// Class program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main task verification code
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
        }


        public static Resistor ResistorRead()
        {
            Resistor newResistor = new Resistor();

        }


        public static InductiveСoil InductiveCoilRead()
        {
            InductiveСoil newInductiveСoil = new InductiveСoil();

        }


        public static Capacitor CapacitorRead()
        {
            Capacitor newCapacitor = new Capacitor();

        }


        // <summary>
        ///  выполняет действие либо показывает ошибку
        /// </summary>
        /// <param name="action">действие</param>
        /// <param name="inputMessage">сообщение при возникновении ошибки</param>
        private static void ActionHandler(Action action, string inputMessage)
        {
            while (true)
            {
                Console.WriteLine(inputMessage);
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message
                                      + "\nПопробуйте заново");
                }
            }
        }

    }
}