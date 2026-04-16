using System.Collections.ObjectModel;
using WitcherCodex.Models.Entities.Sinais;
using WitcherCodex.Repository.Data.Sinais;

namespace WitcherCodex.WPF.ViewModels.Sinais
{
    public class SinaisViewModel : BindableBase
    {
        private readonly SinaisRepository _repository;

        public ObservableCollection<SinaisEntity> Sinais { get; set; }

        public SinaisViewModel()
        {
            _repository = new SinaisRepository();

            Sinais = new ObservableCollection<SinaisEntity>(_repository.GetSinais());
        }
    }
}
