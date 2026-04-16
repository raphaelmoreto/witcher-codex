using System.Collections.ObjectModel;
using WitcherCodex.Models.Entities.Oleos;
using WitcherCodex.Repository.Data.Oleos;

namespace WitcherCodex.WPF.ViewModels.Oleos
{
    public class OleosViewModel : BindableBase
    {
        private readonly OleosRepository _repository;

        public ObservableCollection<OleosEntity> Oleos { get; set; }

        public OleosViewModel()
        {
            _repository = new OleosRepository();
            Oleos = new ObservableCollection<OleosEntity>(_repository.GetOleos());
        }
    }
}
