using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Presentation.FSalon;
using auto_salon.Presentation.FServisnaStavka;
using auto_salon.Presentation.FUgovori;
using auto_salon.Presentation.FVozilo;
using auto_salon.Presentation.FZaposleni;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon
{
    internal static class Program
    {
        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            // WinForm inicijalizacija
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            // Data Layer
            services.AddSingleton<IDataLayer, DataLayer>();

            // Servisi
            services.AddSingleton<ISalonService, SalonService>();
            services.AddSingleton<IZaposleniService, ZaposleniService>();
            services.AddSingleton<IProizvodjacService, ProizvodjacService>();
            services.AddSingleton<IUgovoriService, UgovoriService>();
            services.AddSingleton<IVoziloService, VoziloService>();
            services.AddSingleton<IUgovoriService, UgovoriService>();
            services.AddSingleton<IServisnaStavkaService, ServisnaStavkaService>();

            // Forme i UserControl-i
            services.AddTransient<MainForm>();

            services.AddTransient<SalonUC>();
            services.AddTransient<AddSalon>();
            services.AddTransient<EditSalon>();

            services.AddTransient<VoziloUC>();
            services.AddTransient<AddVozilo>();
            services.AddTransient<VozilaSalona>();

            services.AddTransient<ZaposleniUC>();
            services.AddTransient<AddZaposleni>();
            services.AddTransient<ZaposleniSalona>();

            services.AddTransient<UgovoriUC>();

            services.AddTransient<ServisnaIstorijaVozila>();

            // 3. Kreiranje ServiceProvider-a
            ServiceProvider = services.BuildServiceProvider();

            // 4. Pokretanje glavne forme preko DI-ja
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
    }
}
