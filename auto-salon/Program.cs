using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;
using auto_salon.Data;
using auto_salon.Presentation;
using auto_salon.Presentation.FKupac;
using auto_salon.Presentation.FOcene;
using auto_salon.Presentation.FProizvodjacNudi;
using auto_salon.Presentation.FPromotivnePonude;
using auto_salon.Presentation.FSalon;
using auto_salon.Presentation.FServisnaStavka;
using auto_salon.Presentation.FTestVoznja;
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
            services.AddTransient<ISalonService, SalonService>();
            services.AddTransient<IZaposleniService, ZaposleniService>();
            services.AddTransient<IProizvodjacService, ProizvodjacService>();
            services.AddTransient<IVoziloService, VoziloService>();
            services.AddTransient<IUgovoriService, UgovoriService>();
            services.AddTransient<IServisnaStavkaService, ServisnaStavkaService>();
            services.AddTransient<IKupacService, KupacService>();
            services.AddTransient<IPromotivnaPonudaService, PromotivnaPonudaService>();
            services.AddTransient<IJeOcenioService, JeOcenioService>();
            services.AddTransient<ITestVoznjaService, TestVoznjaService>();

            // Forme i UserControl-i
            services.AddTransient<MainForm>();
            services.AddTransient<Home>();

            services.AddTransient<SalonUC>();
            services.AddTransient<AddSalon>();
            services.AddTransient<EditSalon>();

            services.AddTransient<VoziloUC>();
            services.AddTransient<AddVozilo>();
            services.AddTransient<EditVozilo>();
            services.AddTransient<VozilaSalona>();

            services.AddTransient<ZaposleniUC>();
            services.AddTransient<AddZaposleni>();
            services.AddTransient<EditZaposleni>();
            services.AddTransient<ZaposleniSalona>();

            services.AddTransient<UgovoriUC>();

            services.AddTransient<ServisnaIstorijaVozila>();
            services.AddTransient<AddServisnaStavka>();

            services.AddTransient<SklapanjeUgovora>();

            services.AddTransient<AddKupac>();
            services.AddTransient<KupacUC>();

            services.AddTransient<PromotivnaPonudaUC>();
            services.AddTransient<AddPromotivnaPonuda>();
            services.AddTransient<EditPromotivnaPonuda>();
            services.AddTransient<AddVoziloToPromotivnaPonuda>();

            services.AddTransient<OceneUC>();
            services.AddTransient<EditOcena>();
            services.AddTransient<OceniProdavca>();

            services.AddTransient<ProizvodjacNudiUC>();
            services.AddTransient<AddProizvodjac>();
            services.AddTransient<EditProizvodjac>();
            services.AddTransient<AddSalonToNudi>();

            services.AddTransient<AddTestVoznja>();

            // Kreiranje ServiceProvider-a
            ServiceProvider = services.BuildServiceProvider();

            // Pokretanje glavne forme preko DI-ja
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
    }
}
