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
            
            
            
            string action;
            string exitAction = "нет";
            do
            {
                Console.WriteLine("Хотите расчитать комплексное сопротивление? \nВведите да или нет");
                action = Console.ReadLine().ToLower();
                if (action == "да")
                {
                    Console.WriteLine("Введите номер действия, которое хотите выполнить:");
                    Console.WriteLine("1. Расчет комплексного сопротивления резистора");
                    Console.WriteLine("2. Расчет комплексного сопротивления катушки индуктивности");
                    Console.WriteLine("3. Расчет комплексного сопротивления емкости конденсатора");
                    
                    if (!int.TryParse(Console.ReadLine(), out int input))
                    {
                        Console.WriteLine("Не удалось распознать число");
                        continue;
                    }
                    try
                    {
                        switch (input)
                        {

                            case 1:
                            {
                                var resistorRead = ResistorRead();
                                Console.WriteLine(resistorRead.Info());
                                Console.WriteLine("\n");
                                break;
                            }
                            case 2:
                            {
                                    var inductiv = InductiveCoilRead();
                                    Console.WriteLine(inductiv.Info());
                                    Console.WriteLine("\n");
                                break;
                            }
                            case 3:
                            {
                                    var capacitor = CapacitorRead();
                                    Console.WriteLine(capacitor.Info());
                                    Console.WriteLine("\n");
                                break;
                            }

                            default:
                            {
                                throw new ArgumentException("Введенный номер отсутствует в списке!");
                            }
                        }
                    }
                    catch (ArgumentException e )
                    {
                        Console.WriteLine(e.Message);
                        
                    }
                }
                if (action != exitAction && action != "да")
                {
                    Console.WriteLine("Не удалось определить ответ.");
                }

            } while (action != exitAction);
            
            
            Console.ReadLine();
        }

        /// <summary>
        /// Список действий при создании резистора
        /// </summary>
        /// <returns></returns>
        public static Resistor ResistorRead()
        {
            Resistor newResistor = new Resistor(0, TypeOfResistor.Linear);

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
                        newResistor.Resistance = Convert.ToDouble(nominalValue);
                    }
                }, "Введите номинальную величину сопротивления резистора:"),

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

        /// <summary>
        /// Список действий при создании катушки индуктивности
        /// </summary>
        /// <returns></returns>
        public static InductiveСoil InductiveCoilRead()
        {
            InductiveСoil newInductiveСoil = new InductiveСoil(0, 0);
            var actionsTupleList = new List<(Action Action, string Message)>
            {
                (() =>
                {
                    string frequency = Console.ReadLine();
                    if (!int.TryParse(frequency, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newInductiveСoil.Frequency = Convert.ToInt32(frequency);
                    }
                }, "Введите частоту электрического тока:"),

                (() =>
                {
                    string inductance = Console.ReadLine();
                    if (!int.TryParse(inductance, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newInductiveСoil.Inductance = Convert.ToInt32(inductance);
                    }
                }, "Введите сопротивление индуктивности катушки:")
            };

            foreach (var actionTuple in actionsTupleList)
            {
                ActionHandler(actionTuple.Action, actionTuple.Message);
            }

            return newInductiveСoil;
        }

        /// <summary>
        /// Список действий при создании конденсатора
        /// </summary>
        /// <returns></returns>
        public static Capacitor CapacitorRead()
        {
            Capacitor newCapacitor = new Capacitor(0, 0, TypeOfCapacity.Tantalum);
            var actionsTupleList = new List<(Action Action, string Message)>
            {
                (() =>
                {
                    string frequency = Console.ReadLine();
                    if (!int.TryParse(frequency, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newCapacitor.Frequency = Convert.ToInt32(frequency);
                    }
                },"Введите частоту электрического тока:"),

                (() =>
                {
                    string reactiveInductance = Console.ReadLine();
                    if (!int.TryParse(reactiveInductance, out var number))
                    {
                        throw new ArgumentException("Введенное значение не является числовым");
                    }
                    else
                    {
                        newCapacitor.Capacitance = Convert.ToDouble(reactiveInductance);
                        
                    }
                }, "Введите емкостное сопротивление конденсатора:"),

                (() =>
                    {
                        int typeOfCapacity = Convert.ToInt32(Console.ReadLine());
                        switch (typeOfCapacity)
                        {
                            case 1:
                            {
                                newCapacitor.TypeOfCapacity = TypeOfCapacity.Aluminum;
                                return;
                            }
                            case 2:
                            {
                                newCapacitor.TypeOfCapacity = TypeOfCapacity.Ceramic;
                                return;
                            }
                            case 3:
                            {
                                newCapacitor.TypeOfCapacity = TypeOfCapacity.Polyester;
                                return;
                            }
                            case 4:
                            {
                                newCapacitor.TypeOfCapacity = TypeOfCapacity.Tantalum;
                                return;
                            }
                            default:
                            {
                                throw new ArgumentException("Введенный номер отсутствует в списке!" +
                                                            "\nПожалуйста попробуйте заново:");
                            }
                        }
                    }, "Выберете тип конденсатора, где: " +
                       "\n 1.Алюминевый" +
                       "\n 2.Керамический" +
                       "\n 3.Танталовые" +
                       "\n 4.Полиэстеровые")
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
    }

}