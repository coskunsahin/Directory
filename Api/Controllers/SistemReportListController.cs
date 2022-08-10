using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MassTransit;

using System;
using System.Threading.Tasks;

using System.Collections.Generic;
using RabbitMQ.Client;
using Newtonsoft.Json;
using System.Text;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemReportListController : ControllerBase
    {

        
        [HttpPost]
        public async Task<IActionResult>Sistem()
        {
            List<Raporlar> raporlarlistesi = new List<Raporlar>();
            raporlarlistesi.Add(new Raporlar { Raportname = "PEOPLE", Rapordiractory = "https://localhost:5001/api/People/2", mesaj = "1.rapor" });
            raporlarlistesi.Add(new Raporlar { Raportname = "PEOPLE", Rapordiractory = "https://localhost:5001/api/People", mesaj = "2.rapor" });
            raporlarlistesi.Add(new Raporlar { Raportname = "Contact", Rapordiractory = "https://localhost:5001/api/Contact", mesaj = "3.rapor" });
            raporlarlistesi.Add(new Raporlar { Raportname = "Contact", Rapordiractory = "https://localhost:5001/api/Contact/34", mesaj = "4.rapor" });

            ConnectionFactory cfBaglantiBilgileri = new ConnectionFactory()
            {
                HostName = "localhost",
                Port = 5672,
                UserName = "guest",
                Password = "guest"
            };

            using (var cfBaglanti = cfBaglantiBilgileri.CreateConnection())
            using (var chnKanal = cfBaglanti.CreateModel())
            {
                chnKanal.QueueDeclare
                (
                    queue: "info-message",
                    durable: false,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                );

                string strJson = JsonConvert.SerializeObject(raporlarlistesi);
                byte[] bytMesajIcerigi = Encoding.UTF8.GetBytes(strJson);

                chnKanal.BasicPublish
                (
                    exchange: "",
                    routingKey: "info-message",
                    basicProperties: null,
                    body: bytMesajIcerigi
                );
            }


            return Ok();
            }
          
        }
    }

public class Raporlar
{
    public string Raportname { get; set; }
    public string Rapordiractory { get; set; }
    public string mesaj { get; set; }

}