using GymManagementApp.DB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApp
{
    public class ReportGenerator
    {
        public void GenerateReport()
        {
            // Создание экземпляра контекста базы данных
            using (var context = new GymManagementSystemEntities())
            {
                // Получение данных о клиентах и их посещениях
                var clientVisits = context.Clients
                                          .Select(c => new
                                          {
                                              ClientSurname = c.surnameClient,
                                              ClientName = c.nameClient,
                                              ClientPatronimic = c.patronimicClients,

                                              Attendence = c.Attendence.Select(v => v.countTrainings)
                                          }).ToList();

                // Путь к файлу отчета
                string reportPath = "Отчет.txt";

                // Создание файла отчета
                using (StreamWriter sw = new StreamWriter(reportPath))
                {
                    // Заголовок отчета
                    sw.WriteLine("Отчет о посещениях клиентов");
                    sw.WriteLine("Дата создания отчета: " + DateTime.Now.ToString());
                    sw.WriteLine("--------------------------------------------------");

                    // Запись данных о каждом клиенте
                    foreach (var client in clientVisits)
                    {
                        sw.WriteLine("Фамилия клиента: " + client.ClientSurname);
                        sw.WriteLine("Имя клиента: " + client.ClientName);
                        sw.WriteLine("Отчество клиента: " + client.ClientPatronimic);
                        sw.WriteLine("Количество посещений:");
                        foreach (var date in client.Attendence)
                        {
                            sw.WriteLine(date.ToString());
                        }
                        sw.WriteLine("--------------------------------------------------");
                    }
                }

                Console.WriteLine($"Отчет успешно создан: {reportPath}");
            }
        }
    }
}
