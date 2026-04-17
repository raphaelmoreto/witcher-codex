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
                    TipoCriaturas_Monstros.ESPECTROS,
                    "Aparição do Meio-Dia",
                    "Esses monstros aparecem nos campos quando o sol está a pino. Grãos balançando em um dia sem vento anunciam sua chegada. Eles dançam em círculos à luz do dia e atraem os agricultores para se juntarem a eles. Como são fantasmas , ninguém que se junta a eles sai do círculo vivo.",
                    new List<string> { "Sinal Yrden", "Óleo Espectro", "Sinal Quen" },
                    @"/Assets/Imagens/Criaturas_Monstros/aparicao-meio-dia.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.FERAS,
                    "Berserker",
                    "São teriántropos que se transformam em ursos ou meio-ursos. Como outras criaturas semelhantes, eles são pouco feridos por aço, mas ainda são muito vulneráveis ​​à prata .",
                    new List<string> { "Sinal Igni", "Óleo de Besta", "Sinal Quen" },
                    @"/Assets/Imagens/Criaturas_Monstros/berserker.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.ESPECTROS,
                    "Bruxa D'Água",
                    "Parentes distantes das bruxas sepulcrais, estas criaturas espreitam pelos pântanos, córregos e litorais atacando viajantes desavisados. Apesar de serem grandes e corcundas, as bruxas aquáticas são excelentes nadadoras capazes de se mover livre e facilmente em seu ambiente natural.",
                    new List<string> { "Sinal Igni", "Óleo Necrófago", "Sinal Aard" },
                    @"/Assets/Imagens/Criaturas_Monstros/bruxa-agua.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.FERAS,
                    "Cachorro",
                    "Os cães são descendentes carnívoros dos lobos que foram domesticados pelos humanos . Embora geralmente dóceis, podem tornar-se selvagens, amaldiçoados, ter uma voracidade anormal ou tudo isso junto. Nesses casos, são tratados como predadores.",
                    new List<string> { "Sinal Igni", "Óleo de Besta", "Sinal Aard" },
                    @"/Assets/Imagens/Criaturas_Monstros/cachorro.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.NECROFAGOS,
                    "Carniçal",
                    "Os carniçais , uma subespécie, tornaram-se os comedores de cadáveres mais comuns, geralmente encontrados vagando em bandos, distinguíveis de seus primos, os alghouls , pela palidez doentia de seu semblante.",
                    new List<string> { "Fogo", "Óleo Necrófagos", "Sinal Igni" },
                    @"/Assets/Imagens/Criaturas_Monstros/carnical.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.DRACONIDEOS,
                    "Cocatriz",
                    "Espécie de draconídeo originário de Zerrikania e criado no Norte durante o século XIII. Mais tarde, tornando-se uma praga e às vezes aterrorizando comunidades, eles têm bicos semelhantes aos de pássaros, asas palmadas, dentes afiados como navalhas, garras recurvadas e papadas carmesim.",
                    new List<string> { "Fogo", "Óleo Necrófagos", "Sinal Igni" },
                    @"/Assets/Imagens/Criaturas_Monstros/cocatriz.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.VAMPIROS,
                    "Ekimmara",
                    "Um ekimma ou ekimmara é um tipo de vampiro inferior, semelhante aos fugitivos . Estes tendem a ser mais cruéis e animalescos.",
                    new List<string> { "Óleo de Vampiros", "Sinal Quen", "Sangramento" },
                    @"/Assets/Imagens/Criaturas_Monstros/ekimmara.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.RELIQUIAS,
                    "Fugas",
                    "Fugas era um dos muitos servos das Damas da Floresta , que viviam em Bald Mountain.",
                    new List<string> { "Óleo Relicto", "Sinal Igni" },
                    @"/Assets/Imagens/Criaturas_Monstros/fugas.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.OGROIDES,
                    "Golyat",
                    "Golyat é o nome do gigante que o bruxo Geralt de Rivia , junto com Milton de Peyrac-Peyran , Palmerin de Launfal e Guillaume de Launfal , encontraram ao entrar em Toussaint . Ele tinha força suficiente para levantar e arremessar um cavalo com apenas uma mão. Usava a mó de um moinho de vento destruído como um enorme porrete.",
                    new List<string> { "Sianal Quen", "Ataques Pesados", "Óleo Ogroid" },
                    @"/Assets/Imagens/Criaturas_Monstros/golyat.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.HIBRIDOS,
                    "Grifo",
                    "Criatura com o corpo, pernas e cauda de um leão e a cabeça, asas e garras de uma águia. Eles são conhecidos por brincar com suas presas, comendo-as vivas, pedaço por pedaço.",
                    new List<string> { "Sinal Aard", "Óleo Híbrido", "Besta" },
                    @"/Assets/Imagens/Criaturas_Monstros/grifo.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.FERAS,
                    "Lobisomen",
                    "Os lobisomens são teriántropos que se transformam em lobos ou meio-lobos. Como outras criaturas semelhantes, eles são pouco feridos por aço, mas muito vulneráveis ​​à prata .",
                    new List<string> { "Sinal Igni", "Óleo de Besta", "Besta", "Bombas de Lua de Mel" },
                    @"/Assets/Imagens/Criaturas_Monstros/lobisomen.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.FERAS,
                    "Lobo",
                    "Os lobos são uma espécie de animal selvagem agressiva e carnívora, aparentada aos cães domésticos encontrados em assentamentos humanos.",
                    new List<string> { "Sinal Igni", "Óleo Amaldiçoado" },
                    @"/Assets/Imagens/Criaturas_Monstros/lobo.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.AMALDICOADOS,
                    "Principe Sapo",
                    "O Príncipe Sapo que rondava os esgotos de Oxenfurt era na verdade o Príncipe Sirvat , [ 1 ] um herdeiro do trono de Ofiri . Ele havia sido amaldiçoado inadvertidamente por Olgierd von Everec, que estava furioso quando os pais de Iris , o amor de Olgierd , planejaram dar a mão da filha em casamento ao príncipe visitante.",
                    new List<string> { "Sinal Igni", "Óleo Amaldiçoado", "Sinal Yrden" },
                    @"/Assets/Imagens/Criaturas_Monstros/principe-sapo.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.FERAS,
                    "Ulfhedinn",
                    "Ulfhedinn são um tipo de lobisomem encontrado apenas ao redor de Skellige . Eles têm habilidades de combate mais fortes por conta própria, mas, ao contrário dos lobisomens comuns, não podem invocar lobos para ajudá-los",
                    new List<string> { "Sinal Igni", "Óleo Amaldiçoado", "Sinal Yrden" },
                    @"/Assets/Imagens/Criaturas_Monstros/ulfhedinn.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.FERAS,
                    "Urso",
                    "Os ursos são mamíferos onívoros encontrados no Continente e são habitantes naturais do mundo , o que significa que não chegaram durante a Conjunção das Esferas.",
                    new List<string> { "Sinal Igni", "Óleo de Besta", "Sinal Quen" },
                    @"/Assets/Imagens/Criaturas_Monstros/urso.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.VAMPIROS,
                    "Dettlaff",
                    "Dettlaff van der Eretein , também conhecido como a Besta de Beauclair , era um vampiro superior responsável por regenerar Emiel Regis Rohellec Terzieff-Godefroy com seu sangue e cuidar dele até que se recuperasse após ser morto por Vilgefortz no ataque ao castelo de Stygga.",
                    new List<string> { "Sinal Aard", "Óleo de Vampriro", "Bomba de Lua de Mel", "Bomba Estrela Dançante" },
                    @"/Assets/Imagens/Criaturas_Monstros/vampiro-dettlaff.png"
                ),
                new Criaturas_MonstrosEntity
                (
                    TipoCriaturas_Monstros.DRACONIDEOS,
                    "Wyvern",
                    "são uma espécie ameaçada de ornitossauro com pescoços serpentinos e longas caudas que terminam em um tridente venenoso, adornado quase completamente com escamas escuras.",
                    new List<string> { "Sinal Aard", "Óleo Draconídeo", "Besta" },
                    @"/Assets/Imagens/Criaturas_Monstros/wyvern.png"
                )                
            };
        }

        public IReadOnlyCollection<Criaturas_MonstrosEntity> GetCriaturas()
        {
            return LstCriaturas.AsReadOnly();
        }
    }
}
