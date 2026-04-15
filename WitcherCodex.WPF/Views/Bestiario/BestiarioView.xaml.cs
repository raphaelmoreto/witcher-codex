using System.Windows.Controls;
using WitcherCodex.WPF.ViewModels.Bestiario;

namespace WitcherCodex.WPF.Views.Bestiario
{
    /// <summary>
    /// Interaction logic for BestiarioView.xaml
    /// </summary>
    public partial class BestiarioView : UserControl
    {
        public BestiarioView()
        {
            InitializeComponent();
            DataContext = new BestiarioViewModel();
        }
    }
}
