using WitcherCodex.Models.Entities.Ingredientes;
using WitcherCodex.Models.Entities.Pocoes;

namespace WitcherCodex.Repository.Data.Pocoes
{
    public class PocoesRepository
    {
        private readonly List<PocoesEntity> LstPocoes;

        public PocoesRepository()
        {
            LstPocoes = new List<PocoesEntity>
            {
                new PocoesEntity
                (
                    "Andorinha",
                    "Regenera vida durante o combate.",
                    30.0,
                    15,
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Celidônia", 2, ""),
                        new IngredientesEntity("Sangue de Monstro", 1, "")
                    },
                    ""
                ),
                new PocoesEntity
                (
                    "Gato",
                    "Permite enxergar no escuro.",
                    45.0,
                    10,
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Cortinarius", 2, ""),
                        new IngredientesEntity("Pétalas de Mandrágora", 1, "")
                    },
                    ""
                ),
                new PocoesEntity
                (
                    "Trovão",
                    "Aumenta o dano causado.",
                    25.0,
                    20,
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Sangue de Monstro", 2, ""),
                        new IngredientesEntity("Coração de Nekker", 1, "")
                    },
                    ""
                ),
                new PocoesEntity
                (
                    "Lua Cheia",
                    "Aumenta a vida máxima temporariamente.",
                    60.0,
                    25,
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Raiz de Alghoul", 2, ""),
                        new IngredientesEntity("Celidônia", 1, "")
                    },
                    ""
                )
            };
        }

        public IReadOnlyCollection<PocoesEntity> GetPocoes()
        {
            return LstPocoes.AsReadOnly();
        }
    }
}