using WitcherCodex.Models.Entities.Sinais;

namespace WitcherCodex.Repository.Data.Sinais
{
    public class SinaisRepository
    {
        private readonly List<SinaisEntity> LstSinais;

        public SinaisRepository()
        {
            LstSinais = new List<SinaisEntity>
            {
                new SinaisEntity
                (
                    "Aard",
                    "O sinal Aard atordoa os oponentes ou, em alguns casos, os derruba no chão. Sua habilidade principal é uma rajada direcionada de energia telecinética que desestabiliza os oponentes, deixando-os vulneráveis ​​a um ataque subsequente.",
                    @"Assets/Imagens/Sinais/Aard.png"
                ),
                new SinaisEntity
                (
                    "Igni",
                    "O Sinal Igni causa dano de fogo e tem uma chance de aplicar o efeito Queimadura nos seus oponentes. Sua habilidade principal é uma rajada de fogo direcionada que causa dano aos inimigos. O dano aumenta com a intensidade do Sinal.",
                    @"Assets/Imagens/Sinais/Igni.png"
                ),
                new SinaisEntity
                (
                    "Yrden",
                    "Lance o Sinal de Yrden para criar uma armadilha mágica que desacelera  qualquer um que entrar em sua área de efeito. Sua habilidade principal é uma armadilha mágica que desacelera os inimigos que entram em sua área de efeito.",
                    @"Assets/Imagens/Sinais/Yrden.png"
                ),
                new SinaisEntity
                (
                    "Quen",
                    "O Sinal Quen protege você contra danos e certos efeitos críticos. Sua habilidade principal é um escudo protetor que dura até absorver dano equivalente a 8% da Vitalidade máxima.",
                    @"Assets/Imagens/Sinais/Quen.png"
                ),
                new SinaisEntity
                (
                    "Axii",
                    "Você pode usar o Sinal Axii para desorientar temporariamente seus oponentes. Sua habilidade principal é enfeitiçar a mente de um oponente, eliminando-o temporariamente do combate.",
                    @"Assets/Imagens/Sinais/Axii.png"
                )
            };
        }

        public IReadOnlyCollection<SinaisEntity> GetSinais()
        {
            return LstSinais.AsReadOnly();
        }
    }
}
