using Data.Enums;
using Data.Models;
using Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Services
{
    public class ShopService : IService
    {
        static String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database112.accdb";
        //static String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=d:\DZHosts\LocalUser\nikitayd\www.deluxecarshop.somee.com\Database112.accdb";
        public IEnumerable<CatalogModel> FillTable()
        {

            var models = new List<CatalogModel>();

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            string query = "SELECT Автомобиль.[Код автомобиля ], Марка.Марка, Модель.Модель, Автомобиль.Стоимость " +
                "FROM(Марка INNER JOIN Модель ON Марка.[Код марки] = Модель.[Код марки]) INNER JOIN Автомобиль ON Модель.[Код модели] = Автомобиль.[Код модели] " +
                "WHERE Автомобиль.Продана = 0 " +
                "ORDER BY Автомобиль.[Год выпуска]; ";

            try
            {
                myConnection.Open();

                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand command = new OleDbCommand(query, myConnection);
                // открываем соединение с БД

                // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    models.Add(new CatalogModel
                    {
                        AutoId = Int32.Parse(reader[0].ToString()),
                        Mark = reader[1].ToString(),
                        Model = reader[2].ToString(),
                        Price = CutPrice(reader[3].ToString())
                    });
                }
                // закрываем OleDbDataReader
                reader.Close();
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Упс, что-то пошло не так:\n " + e.Message);
            }

            return models;
        }

        public CarViewModel ShowCar(int CarId)
        {
            OleDbConnection myConnection = new OleDbConnection(connectionString);

            string query = "SELECT Автомобиль.[Код автомобиля], Марка.Марка, Модель.Модель, Автомобиль.Стоимость, Автомобиль.[Год выпуска], Автомобиль.[Тип КПП], Модель.[Масса, кг], Модель.[Мощность, л/с] "
            + "FROM(Марка INNER JOIN Модель ON Марка.[Код марки] = Модель.[Код марки]) INNER JOIN Автомобиль ON Модель.[Код модели] = Автомобиль.[Код модели] "
            + "WHERE Автомобиль.[Код автомобиля] = " + CarId.ToString();

            CarViewModel model = default;
            try
            {
                myConnection.Open();
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader reader = command.ExecuteReader();

                reader.Read();
                model = new CarViewModel()
                {
                    CarId = CarId,
                    Mark = reader[1].ToString(),
                    Model = reader[2].ToString(),
                    Price = CutPrice(reader[3].ToString()),
                    Hp = Int32.Parse(reader[7].ToString()),
                    RPM = 7600,
                    MaxSpeed = 280,
                    TimeTo100 = 3.4,
                    Color = "Зеленый"
                };
                reader.Close();
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Упс, что-то пошло не так:\n " + e.Message);
            }

            return model;
        }

        public RoleModel Login(RoleModel model)
        {
            OleDbConnection myConnection = new OleDbConnection(connectionString);

            string query = "SELECT Роль FROM Аккаунт WHERE Логин = \"" + model.login + "\" AND Пароль = \"" + model.password + "\"";

            try
            {
                myConnection.Open();
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader reader = command.ExecuteReader();

                reader.Read();
                var huy = reader[0].ToString();
                if (reader[0].ToString().ToLower() == RoleEnum.Admin.ToString().ToLower())
                {
                    model.role = reader[0].ToString().ToLower();
                    reader.Close();
                    myConnection.Close();
                    return model;
                }
                else if (reader[0].ToString().ToLower() == RoleEnum.Client.ToString().ToLower())
                {
                    model.role = reader[0].ToString().ToLower();
                    reader.Close();
                    myConnection.Close();
                    return model;
                }
                else if (reader[0].ToString().ToLower() == RoleEnum.Manager.ToString().ToLower())
                {
                    model.role = reader[0].ToString().ToLower();
                    reader.Close();
                    myConnection.Close();
                    return model;
                }
                else
                {
                    reader.Close();
                    myConnection.Close();
                    return null;
                }
                    
            }
            catch (Exception e)
            {
                Console.WriteLine("Упс, что-то пошло не так:\n " + e.Message);
            }

            return null;
        }
        public string CutPrice(string price)
        {
            int i = price.Length;
            int j = price.Length;
            while (i > 1)
            {
                if (i % 3 == 0 && i > 1)
                {
                    price = price.Insert(j - i, " ");
                    i -= 3;
                    j++;
                }
                else
                {
                    i--;
                }

            }
            return price;
        }
        public void DeleteCar(int CarId)
        {
            OleDbConnection myConnection = new OleDbConnection(connectionString);

            string query = "SELECT Автомобиль.[Код автомобиля], Марка.Марка, Модель.Модель, Автомобиль.Стоимость, Автомобиль.[Год выпуска], Автомобиль.[Тип КПП], Модель.[Масса, кг], Модель.[Мощность, л/с] "
            + "FROM(Марка INNER JOIN Модель ON Марка.[Код марки] = Модель.[Код марки]) INNER JOIN Автомобиль ON Модель.[Код модели] = Автомобиль.[Код модели] "
            + "WHERE Автомобиль.[Код автомобиля] = " + CarId.ToString();

            CarViewModel model = default;
            try
            {
                myConnection.Open();
                OleDbCommand command = new OleDbCommand(query, myConnection);
                OleDbDataReader reader = command.ExecuteReader();

                reader.Read();
                model = new CarViewModel()
                {
                    CarId = CarId,
                    Mark = reader[1].ToString(),
                    Model = reader[2].ToString(),
                    Price = CutPrice(reader[3].ToString()),
                    Hp = 550,
                    RPM = 7600,
                    MaxSpeed = 280,
                    TimeTo100 = 3.4,
                    Color = "Зеленый"
                };
                reader.Close();
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Упс, что-то пошло не так:\n " + e.Message);
            }
        }

        public bool AddCar(CarModel model)
        {
            OleDbConnection myConnection = new OleDbConnection(connectionString);

            string query = "";

            try
            {
                myConnection.Open();
                OleDbCommand command = new OleDbCommand(query, myConnection);
                

                
                
                

            }
            catch (Exception e)
            {
                Console.WriteLine("Упс, что-то пошло не так:\n " + e.Message);
            }
            return false;
        }

        public IEnumerable<SellModel> GetReportData()
        {
            var models = new List<SellModel>();

            OleDbConnection myConnection = new OleDbConnection(connectionString);

            string query = "SELECT Марка.Марка, Модель.Модель, Автомобиль.Стоимость, Менеджер.ФИО, Покупатель.ФИО, Продажа.[Дата продажи] " +
                           "FROM(((((Продажа " +
                           "INNER JOIN Автомобиль ON Автомобиль.[Код автомобиля] = Продажа.[Код автомобиля]) " +
                           "INNER JOIN Менеджер ON Менеджер.[Код менеджера] = Продажа.[Код менеджера]) " +
                           "INNER JOIN Покупатель ON Покупатель.[Код покупателя] = Продажа.[Код покупателя]) " +
                           "INNER JOIN Модель ON Автомобиль.[Код модели] = Модель.[Код модели]) " +
                           "INNER JOIN Марка ON Марка.[Код марки] = Модель.[Код марки]);";
            try
            {
                myConnection.Open();

                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand command = new OleDbCommand(query, myConnection);
                // открываем соединение с БД

                // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    models.Add(new SellModel
                    {
                        Car = new CarModel
                        {
                            Mark = reader[0].ToString(),
                            Model = reader[1].ToString(),
                            Price = reader[2].ToString(),
                        },
                        ManagerFIO = reader[3].ToString(),
                        ClientFIO = reader[4].ToString(),
                        SellDate = (DateTime)reader[5],
                    });
                }
                // закрываем OleDbDataReader
                reader.Close();
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Упс, что-то пошло не так:\n " + e.Message);
            }

            return models;
        }
        public void SellProcess(string FIO, string Phone, int CarId)
        {
            OleDbConnection myConnection = new OleDbConnection(connectionString);

            string query1 = "UPDATE Автомобиль SET Продана = 1 WHERE [Код автомобиля] = " + CarId.ToString();

            string query2 = "INSERT INTO Покупатель (ФИО, [Номер телефона])" +
                             "VALUES('" + FIO + "', " + Phone + ");";
            Random rand = new Random();
            string query3 = "INSERT INTO Продажа([Код автомобиля], [Код покупателя], [Дата продажи], [Код менеджера]) " +
            "SELECT " + CarId.ToString() + " , FIRST([Код покупателя]), Date(), " + rand.Next(1, 3).ToString() +
            " FROM Покупатель " +
            "WHERE ФИО = '" + FIO + "' and [Номер телефона] = '" + Phone + "';";
            try
            {
                myConnection.Open();

                // создаем объект OleDbCommand для выполнения запроса к БД MS Access
                OleDbCommand command1 = new OleDbCommand(query1, myConnection);
                OleDbCommand command2 = new OleDbCommand(query2, myConnection);
                OleDbCommand command3 = new OleDbCommand(query3, myConnection);
                // открываем соединение с БД

                // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Упс, что-то пошло не так:\n " + e.Message);
            }
        }
    }
}
