using System.Windows;
using WitcherCodex.WPF.Views.Bestiario;
using WitcherCodex.WPF.Views.Oleos;
using WitcherCodex.WPF.Views.Pocoes;
using WitcherCodex.WPF.Views.Sinais;

namespace WitcherCodex.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        //DEFINE QUAL SERÁ A JANELA PRINCIPAL DA APLICAÇÃO. QUANDO O APP INICIAR IRÁ ABRIR A "MainWindow"
        protected override Window CreateShell()
        {
            return new MainWindow();
        }

        //MÉTODO QUE REGISTRA AS DEPENDÊNCIAS NO CONTAINER DE DI DO "Prism"
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //REGISTRA AS VIEWS QUE PODEM SER NAVEGADAS
            containerRegistry.RegisterForNavigation<BestiarioView>();
            containerRegistry.RegisterForNavigation<OleosView>();
            containerRegistry.RegisterForNavigation<PocoesView>();
            containerRegistry.RegisterForNavigation<SinaisView>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            var regionManager = Container.Resolve<IRegionManager>();
            regionManager.RequestNavigate("MainRegion", nameof(BestiarioView));
        }
    }
}
