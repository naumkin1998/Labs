using ElectricalElements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

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
            ElectricalCircuit electricalCircuit = new ElectricalCircuit();
            

            var resistorRead = ResistorRead();
            var inductiv = InductiveCoilRead();
            var capacitor  = CapacitorRead();

            Console.WriteLine(resistorRead.Info());
            Console.WriteLine("\n");
            Console.WriteLine(inductiv.Info());
            Console.WriteLine("\n");
            Console.WriteLine(capacitor.Info());

            Console.WriteLine("\n");
            Console.ReadLine();
        }

        /// <summary>
        /// Список действий при создании резистора
        /// </summary>
        /// <returns></returns>
        public static Resistor ResistorRead()
        {
            Resistor newResistor = new Resistor(new Complex(0, 0), 0, 0, TypeOfResistor.Linear);

            var actionsTupleList = new List<(Action Action, string Message)>
            {
                (() =>
                {
                    string nominalValue = Console.ReadLine();
                    if (!int.TryParse(nominalValue, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newResistor.ActiveResistance = Convert.ToDouble(nominalValue);
                        newResistor.ReactiveInductance = 0;
                    }
                }, "Введите номинальную величину сопротивления резистора:"),

                (() =>
                {
                    string operatingVoltage = Console.ReadLine();
                    if (!int.TryParse(operatingVoltage, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newResistor.OperatingVoltage = Convert.ToInt32(operatingVoltage);
                    }
                }, "Введите рабочее напряжение резистора:"),

                (() =>
                {
                    string powerDissipation = Console.ReadLine();
                    if (!int.TryParse(powerDissipation, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newResistor.PowerDissipation = Convert.ToInt32(powerDissipation);
                    }
                }, "Введите мощность рассеивания резистора:"),

                (() =>
                    {
                        int typeOfResistor = Convert.ToInt32(Console.ReadLine());
                        switch (typeOfResistor)
                        {
                            case 1:
                            {
                                newResistor.TypeOfResistor = TypeOfResistor.Linear;
                                return;
                            }
                            case 2:
                            {
                                newResistor.TypeOfResistor = TypeOfResistor.Varistor;
                                return;
                            }
                            case 3:
                            {
                                newResistor.TypeOfResistor = TypeOfResistor.Tensoresistors;
                                return;
                            }
                            case 4:
                            {
                                newResistor.TypeOfResistor = TypeOfResistor.Photoresistors;
                                return;
                            }
                            case 5:
                            {
                                newResistor.TypeOfResistor = TypeOfResistor.Tensoresistors;
                                return;
                            }
                            case 6:
                            {
                                newResistor.TypeOfResistor = TypeOfResistor.Magnetoresistors;
                                return;
                            }
                            default:
                            {
                                throw new ArgumentException("Введенный номер отсутствует в списке!" +
                                                            "\nПожалуйста попробуйте заново:");
                            }
                        }
                    }, "Выберите соответствующий нормер типа резистора:" +
                       "\n 1.Линейный" +
                       "\n 2.Варистор" +
                       "\n 3.Терморезистор" +
                       "\n 4.Фоторезистор" +
                       "\n 5.Тензорезистор" +
                       "\n 6.Магниторезистор")
            };

            foreach (var actionTuple in actionsTupleList)
            {
                ActionHandler(actionTuple.Action, actionTuple.Message);
            }

            return newResistor;
        }


        public static InductiveСoil InductiveCoilRead()
        {
            InductiveСoil newInductiveСoil = new InductiveСoil(0, 0, 0);
            var actionsTupleList = new List<(Action Action, string Message)>
            {
                (() =>
                {
                    string inductance = Console.ReadLine();
                    if (!int.TryParse(inductance, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newInductiveСoil.ActiveResistance = 0;
                        newInductiveСoil.ReactiveInductance = Convert.ToDouble(inductance);
                    }
                }, "Введите сопротивление индуктивности катушки:"),

                (() =>
                {
                    string lossResistance = Console.ReadLine();
                    if (!int.TryParse(lossResistance, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newInductiveСoil.LossResistance = Convert.ToInt32(lossResistance);
                    }
                }, "Введите сопротивление потерь катушки:"),

                (() =>
                {
                    string qualityFactor = Console.ReadLine();
                    if (!int.TryParse(qualityFactor, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newInductiveСoil.QualityFactor = Convert.ToInt32(qualityFactor);
                    }
                }, "Введите добротность катушки:")
            };

            foreach (var actionTuple in actionsTupleList)
            {
                ActionHandler(actionTuple.Action, actionTuple.Message);
            }

            return newInductiveСoil;
        }


        public static Capacitor CapacitorRead()
        {
            Capacitor newCapacitor = new Capacitor(0, 0, TypeOfCapacity.ConstantCapacity);
            var actionsTupleList = new List<(Action Action, string Message)>
            {
                (() =>
                {
                    string reactiveInductance = Console.ReadLine();
                    if (!int.TryParse(reactiveInductance, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newCapacitor.ReactiveInductance = Convert.ToDouble(reactiveInductance);
                        newCapacitor.ActiveResistance = 0;
                    }
                }, "Введите емкостное сопротивление конденсатора:"),

                (() =>
                {
                    string permissibleDeviation = Console.ReadLine();
                    if (!int.TryParse(permissibleDeviation, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newCapacitor.PermissibleDeviation = Convert.ToInt32(permissibleDeviation);
                    }
                }, "Введите допустимое отклонение погрешности конденсатора"),

                (() =>
                    {
                        int typeOfCapacity = Convert.ToInt32(Console.ReadLine());
                        switch (typeOfCapacity)
                        {
                            case 1:
                            {
                                newCapacitor.TypeOfCapacity = TypeOfCapacity.ConstantCapacity;
                                return;
                            }
                            case 2:
                            {
                                newCapacitor.TypeOfCapacity = TypeOfCapacity.VariableCapacity;
                                return;
                            }
                            default:
                            {
                                throw new ArgumentException("Введенный номер отсутствует в списке!" +
                                                            "\nПожалуйста попробуйте заново:");
                            }
                        }
                    }, "Выберете тип конденсатора, где: " +
                       "\n 1.Постоянная емкость" +
                       "\n 2.Переменная емкость")
            };

            foreach (var actionTuple in actionsTupleList)
            {
                ActionHandler(actionTuple.Action, actionTuple.Message);
            }

            return newCapacitor;
        }


        // <summary>
        /// Выполняет действие либо показывает ошибку
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


       /* public void ShowElements(ElectricalCircuit [] rlc)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------Список элементов}-------");
            Console.WriteLine("-------------------------------");
            if (rlc.Length != 0)
            {
                for (int i = 0; i < rlc.Length; i++)
                {
                    Console.WriteLine(rlc.SearchByIndex(i).Info());
                    Console.WriteLine();
                }
            }
        }*/
    }
}