using WitcherCodex.Models.Entities.Ingredientes;
using WitcherCodex.Models.Entities.Oleos;

namespace WitcherCodex.Repository.Data.Oleos
{
    public class OleosRepository
    {
        private readonly List<OleosEntity> LstOleos;

        public OleosRepository()
        {
            LstOleos = new List<OleosEntity>
            {
                 new OleosEntity
                (
                    "Gato",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Espírito de Anão", 1, ""),
                        new IngredientesEntity("Fruto de Berbercane", 4, ""),
                        new IngredientesEntity("Essência de Água", 2, "")
                    },
                    ""
                ),
                new OleosEntity
                (
                    "Oriole Dourado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Espírito de Anão", 1, ""),
                        new IngredientesEntity("Sopro de bola", 4, ""),
                        new IngredientesEntity("Essência de Luz", 1, "")
                    },
                    ""
                ),
                new OleosEntity
                (
                    "Trovoada",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Espírito de Anão", 1, ""),
                        new IngredientesEntity("Cortinarius", 2, ""),
                        new IngredientesEntity("Embrião Endrega", 1, "")
                    },
                    ""
                )
            };
        }

        public IReadOnlyCollection<OleosEntity> GetOleos()
        {
            return LstOleos.AsReadOnly();
        }
    }
}
