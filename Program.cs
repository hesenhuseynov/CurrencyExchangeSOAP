using CurrencyExchangeSOAP.Services;
using SoapCore;

namespace CurrencyExchangeSOAP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddSingleton<ICurrencyExchangeService, CurrencyExchangeService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            //app.UseHttpsRedirection();

            //app.UseAuthorization();



            app.UseRouting();


            ((IApplicationBuilder)app).UseSoapEndpoint<ICurrencyExchangeService>(
       "/CurrencyExchangeService.svc",
       new SoapEncoderOptions(),
       SoapSerializer.DataContractSerializer
   );



            app.MapControllers();


            app.Run();
        }
    }
}
