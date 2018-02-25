using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_client.WorkCarRef;

namespace c_client
{
    class Program
    {
        static void Main(string[] args)
        {

            WorkCarClient workcar = new WorkCarClient("BasicHttpBinding_IWorkCar");
            int global_id = 0;
            string action = "0";
            Console.WriteLine("Добрый день");
            while (action != "4")
            {
                Console.WriteLine(
                    "Что вы хотите сделать:\n" +
                      "1 - Добавить запись об автомобиле\n" +
                        "2 - Просмотреть все записи\n" +
                         "3 - Удалить запись\n" +
                          "4 - Выход\n"
                    );
                action = Console.ReadLine();
                if (action == "1")
                {
                    Car car = new Car();
                    Console.WriteLine("Введите название модели автомобиля");
                    car.modelName = Console.ReadLine();
                    Console.WriteLine("Введите название марки");
                    car.mark = Console.ReadLine();
                    Console.WriteLine("Регистрационный номер");
                    car.regnum = Console.ReadLine();
                    Console.WriteLine("Категория автомобилей");
                    car.category = Console.ReadLine();
                  //  car.create = DateTime.Now;
                    workcar.AddCars(car);
                    Console.WriteLine("Машина добавлена");
                }

                else if (action == "2")
                {
                    Console.Clear();
                    Car[] spisok = workcar.GetCars();
                    if (spisok.Length > 0)
                    {
                        foreach (Car car in spisok)
                        {
                            Console.WriteLine("№" + car.id + ":" + car.modelName );
                        }
                    }
                    else
                    {
                        Console.WriteLine("Машин в базе данных нет!\n");
                    }
                }
                else if (action == "3")
                {
                    Console.WriteLine("Машину с каким номером удалить?");
                    string id = Console.ReadLine();
                    workcar.DelCar(Convert.ToInt32(id));
                }
            }
            Console.WriteLine("ДО свидания!");
            Console.ReadLine();

        }


    }
    }

