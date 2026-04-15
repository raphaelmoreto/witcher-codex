using System.Collections.ObjectModel;
using WitcherCodex.Models.Entities.Criaturas_Monstros;
using WitcherCodex.Repository.Data.Criaturas_Monstros;

namespace WitcherCodex.WPF.ViewModels.Bestiario
{
    public class BestiarioViewModel : BindableBase
    {
        private readonly Criaturas_MonstrosRepository _repository;

        public ObservableCollection<Criaturas_MonstrosEntity> Criaturas_Monstros { get; set; }

        public BestiarioViewModel()
        {
            _repository = new Criaturas_MonstrosRepository();

            Criaturas_Monstros = new ObservableCollection<Criaturas_MonstrosEntity>(_repository.GetCriaturas());
        }
    }
}