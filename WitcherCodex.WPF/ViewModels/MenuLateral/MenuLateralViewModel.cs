using System.Windows.Input;
using WitcherCodex.WPF.ViewModels.Command;
using WitcherCodex.WPF.Views.Bestiario;
using WitcherCodex.WPF.Views.Ingredientes;
using WitcherCodex.WPF.Views.Oleos;
using WitcherCodex.WPF.Views.Pocoes;
using WitcherCodex.WPF.Views.Sinais;

namespace WitcherCodex.WPF.ViewModels.MenuLateral
{
    public class MenuLateralViewModel : BindableBase
    {
        //INTERFACE DO FRAMEWORK "Prism". RESPONSÁVEL POR GERENCIAR NAVEGAÇÃO ENTRE VIEWS DENTRO DA APLICAÇÃO WPF. É COMO SE FOSSE UM CONTROLADOR DE QUADRO
        private readonly IRegionManager _regionManager;

        public ICommand MostrarBestiarioCommand { get; }
        public ICommand MostrarIngredientesCommand { get; }
        public ICommand MostrarOleosCommand { get;  }
        public ICommand MostrarPocoesCommand { get; }
        public ICommand MostrarSinaisCommand { get; }

        public MenuLateralViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            //O "RequestNavigate" É O MÉTODO DO "Prism" QUE FAZ A NAVEGAÇÃO ENTRE TELAS. TROCA O QUE ESTÁ SENDO EXIBIDO
            //"MainRegion" É O NOME DA REGIÃO DEFINIDO NA VIEW "MainWindow.xaml". É COMO SE FOSSE UM QUADRO NA TELA
            MostrarBestiarioCommand = new RelayCommand(_ =>
                _regionManager.RequestNavigate("MainRegion", nameof(BestiarioView)));

            MostrarIngredientesCommand = new RelayCommand(_ =>
                _regionManager.RequestNavigate("MainRegion", nameof(IngredientesView)));

            MostrarOleosCommand = new RelayCommand(_ =>
                _regionManager.RequestNavigate("MainRegion", nameof(OleosView)));

            MostrarPocoesCommand = new RelayCommand(_ =>
                _regionManager.RequestNavigate("MainRegion", nameof(PocoesView)));

            MostrarSinaisCommand = new RelayCommand(_ =>
                _regionManager.RequestNavigate("MainRegion", nameof(SinaisView)));
        }
    }
}
