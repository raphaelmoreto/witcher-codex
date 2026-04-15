using System.Windows.Input;
using WitcherCodex.WPF.ViewModels.Command;
using WitcherCodex.WPF.Views.Bestiario;

namespace WitcherCodex.WPF.ViewModels.MainWindow
{
    public class MainWindowViewModel : BindableBase
    {
        private object _viewAtual;
        public object ViewAtual
        {
            get => _viewAtual;
            set => SetProperty(ref _viewAtual, value);
        }

        public ICommand MostrarBestiarioCommand { get; }
        public ICommand MostrarIngredientesCommand { get; }

        public MainWindowViewModel()
        {
            MostrarBestiarioCommand = new RelayCommand(_ => ViewAtual = new BestiarioView());
            //MostrarIngredientesCommand = new RelayCommand(_ => ViewAtual = new IngredientesView());

            // View inicial
            ViewAtual = new BestiarioView();
        }
    }
}
