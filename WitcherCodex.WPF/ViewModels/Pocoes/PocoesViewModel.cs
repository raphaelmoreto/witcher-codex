using System.Collections.ObjectModel;
using WitcherCodex.Models.Entities.Pocoes;
using WitcherCodex.Repository.Data.Pocoes;

namespace WitcherCodex.WPF.ViewModels.Pocoes
{
    public class PocoesViewModel : BindableBase
    {
        private readonly PocoesRepository _repository;

        public ObservableCollection<PocoesEntity> Pocoes { get; set; }

        public PocoesViewModel()
        {
            _repository = new PocoesRepository();
            Pocoes = new ObservableCollection<PocoesEntity>(_repository.GetPocoes());
        }
    }
}
