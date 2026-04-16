using WitcherCodex.Models.Entities.Criaturas_Monstros;
using WitcherCodex.Models.Enum.Criaturas_Monstros;

namespace WitcherCodex.Repository.Data.Criaturas_Monstros
{
    public class Criaturas_MonstrosRepository
    {
        private readonly List<Criaturas_MonstrosEntity> LstCriaturas;

        public Criaturas_MonstrosRepository()
        {
            LstCriaturas = new List<Criaturas_MonstrosEntity>
            {
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.NECROFAGOS,
                    "Carniçal",
                    "Criaturas que se alimentam de carne morta.",
                    new List<string> { "Fogo", "Óleo contra Necrófagos", "Igni" },
                    @"/Assets/Imagens/Criaturas_Monstros/Carnical.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.ESPECTROS,
                    "Aparição do Meio-Dia",
                    "Espírito que aparece ao meio-dia em campos.",
                    new List<string> { "Yrden", "Óleo contra Espectros", "Quen" },
                    @"/Assets/Imagens/Criaturas_Monstros/Aparicao-Meio-Dia.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.VAMPIROS,
                    "Ekimmara",
                    "Vampiro ágil que drena vida.",
                    new List<string> { "Óleo contra Vampiros", "Quen", "Sangramento" },
                    @"/Assets/Imagens/Criaturas_Monstros/Ekimmara.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.OGROIDES,
                    "Golyat",
                    "Criatura enorme e extremamente forte.",
                    new List<string> { "Quen", "Ataques Pesados", "Óleo contra Ogroides" },
                    @"/Assets/Imagens/Criaturas_Monstros/Golyat.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.HIBRIDOS,
                    "Grifo",
                    "Criatura metade águia metade leão.",
                    new List<string> { "Aard", "Óleo contra Híbridos", "Besta" },
                    @"/Assets/Imagens/Criaturas_Monstros/Grifo.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.DRACONIDEOS,
                    "Wyvern",
                    "Monstro voador com veneno.",
                    new List<string> { "Aard", "Óleo contra Draconídeos", "Besta" },
                    @"/Assets/Imagens/Criaturas_Monstros/Wyvern.png"
                )                
            };
        }

        public IReadOnlyCollection<Criaturas_MonstrosEntity> GetCriaturas()
        {
            return LstCriaturas.AsReadOnly();
        }
    }
}
