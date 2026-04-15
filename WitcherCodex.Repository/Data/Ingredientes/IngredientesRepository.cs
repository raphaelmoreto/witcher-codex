using WitcherCodex.Models.Entities.Ingredientes;

namespace WitcherCodex.Repository.Data.Ingredientes
{
    public class IngredientesRepository
    {
        private readonly List<IngredientesEntity> LstIngredientes;

        public IngredientesRepository()
        {
            LstIngredientes = new List<IngredientesEntity>
            {
                new IngredientesEntity("Celidônia", 5, ""),
                new IngredientesEntity("Cortinarius", 3, ""),
                new IngredientesEntity("Sangue de Monstro", 10, ""),
                new IngredientesEntity("Essência de Espectro", 2, ""),
                new IngredientesEntity("Veneno de Wyvern", 4, ""),
                new IngredientesEntity("Coração de Nekker", 6, ""),
                new IngredientesEntity("Pétalas de Mandrágora", 8, ""),
                new IngredientesEntity("Raiz de Alghoul", 7 , "")
            };
        }

        public IReadOnlyCollection<IngredientesEntity> GetIngredientes()
        {
            return LstIngredientes.AsReadOnly();
        }
    }
}
