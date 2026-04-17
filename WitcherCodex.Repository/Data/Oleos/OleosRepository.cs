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
                //OLÉOS NORMAIS
                new OleosEntity
                (
                    "Óleo Amaldiçoado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Sebo de Cachorro", 1),
                        new IngredientesEntity("Acônito", 4)
                    },
                    @"/Assets/Imagens/Oleos/oleo-amaldicoado.png"
                ),
                new OleosEntity
                (
                    "Óleo de Besta",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Sebo de Cachorro", 1),
                        new IngredientesEntity("Fígado de Lobo", 2)
                    },
                    @"/Assets/Imagens/Oleos/oleo-besta.png"
                ),
                new OleosEntity
                (
                    "Óleo Draconídeo",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Sebo de Cachorro", 1),
                        new IngredientesEntity("Sementes de Ergot", 4)
                    },
                    @"/Assets/Imagens/Oleos/oleo-draconideo.png"
                ),
                new OleosEntity
                (
                    "Óleo Elemental",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Sebo de Cachorro", 1),
                        new IngredientesEntity("Bola de Algodão", 4)
                    },
                    @"/Assets/Imagens/Oleos/oleo-elemental.png"
                ),
                new OleosEntity
                (
                    "Óleo Espectro",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 1),
                        new IngredientesEntity("Arenaria", 4)
                    },
                    @"/Assets/Imagens/Oleos/oleo-espectros.png"
                ),
                new OleosEntity
                (
                    "Óleo Híbrido",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Sebo de Cachorro", 1),
                        new IngredientesEntity("Pétalas de Murta Branca", 4)
                    },
                    @"/Assets/Imagens/Oleos/oleo-hibrido.png"
                ),
                new OleosEntity
                (
                    "Óleo Insectoide",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Sebo de Cachorro", 1),
                        new IngredientesEntity("Ranogrina", 4)
                    },
                    @"/Assets/Imagens/Oleos/oleo-insectoide.png"
                ),
                new OleosEntity
                (
                    "Óleo Necrófago",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Sebo de Cachorro", 1),
                        new IngredientesEntity("Sopro de Bola", 4)
                    },
                    @"/Assets/Imagens/Oleos/oleo-necrofago.png"
                ),
                new OleosEntity
                (
                    "Óleo Ogroid",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 1),
                        new IngredientesEntity("Pétalas de Ginatia", 4)
                    },
                    @"/Assets/Imagens/Oleos/oleo-ogroid.png"
                ),
                new OleosEntity
                (
                    "Óleo Relicto",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Sebo de Cachorro", 1),
                        new IngredientesEntity("Visco", 5)
                    },
                    @"/Assets/Imagens/Oleos/oleo-relicto.png"
                ),
                new OleosEntity
                (
                    "Óleo de Vampiro",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Sebo de Cachorro", 2),
                        new IngredientesEntity("Água Ducal", 4)
                    },
                    @"/Assets/Imagens/Oleos/oleo-vampiro.png"
                ),
                new OleosEntity
                (
                    "Veneno do Enforcado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Sebo de Cachorro", 1),
                        new IngredientesEntity("Arenaria", 4)
                    },
                    @"/Assets/Imagens/Oleos/veneno-enforcado.png"
                ),

                //ÓLEOS APRIMORADOS/POTENCIALIZADOS
                new OleosEntity
                (
                    "Óleo Amaldiçoado Potencializado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 1),
                        new IngredientesEntity("Óleo Amaldiçoado", 1),
                        new IngredientesEntity("Ocultar Ekimmara", 1),
                        new IngredientesEntity("Bola de Algodão", 1),
                        new IngredientesEntity("Acônito", 1),
                        new IngredientesEntity("Fruta Balisse", 1),
                        new IngredientesEntity("Fígado de Lobo", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-amaldicoado-potencializado.png"
                ),
                new OleosEntity
                (
                    "Óleo Bestial Potencializado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 5),
                        new IngredientesEntity("Óleo de Besta", 1),
                        new IngredientesEntity("Pele de Urso", 1),
                        new IngredientesEntity("Celidônia", 1),
                        new IngredientesEntity("Bola de Algodão", 1),
                        new IngredientesEntity("Grama de Bisão", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-bestial-potencializado.png"
                ),
                new OleosEntity
                (
                    "Óleo Draconídeo Aprimorado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 1),
                        new IngredientesEntity("Óleo Draconídeo", 1),
                        new IngredientesEntity("Estômago de Basilisco", 1),
                        new IngredientesEntity("Fígado do Guerreiro Nekker", 1),
                        new IngredientesEntity("Moleyarrow", 1),
                        new IngredientesEntity("Arenaria", 1),
                        new IngredientesEntity("Bryonia", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-draconideo-aprimorado.png"
                ),
                new OleosEntity
                (
                    "Óleo Elemental Aprimorado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 1),
                        new IngredientesEntity("Óleo Elementa", 1),
                        new IngredientesEntity("Moleyarrow", 1),
                        new IngredientesEntity("Bola de Algodão", 1),
                        new IngredientesEntity("Pimenta da Jamaica", 1),
                        new IngredientesEntity("Madressilva", 1),
                        new IngredientesEntity("Espinheiro-Cervino", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-elemental-aprimorado.png"
                ),
                new OleosEntity
                (
                    "Óleo Espectro Aprimorado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 1),
                        new IngredientesEntity("Óleo Espectro", 1),
                        new IngredientesEntity("Essência do Espectro", 1),
                        new IngredientesEntity("Arenaria", 1),
                        new IngredientesEntity("Visco", 1),
                        new IngredientesEntity("Fígado de Lobo", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-espectros-aprimorado.png"
                ),
                new OleosEntity
                (
                    "Óleo Híbrido Aprimorado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 1),
                        new IngredientesEntity("Óleo Híbrido", 1),
                        new IngredientesEntity("Olho de Erynia", 1),
                        new IngredientesEntity("Pétalas de Ginatia", 1),
                        new IngredientesEntity("Pétalas de Murta Branca", 1),
                        new IngredientesEntity("Hornwort", 1),
                        new IngredientesEntity("Bryonia", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-hibrido-aprimorado.png"
                ),
                new OleosEntity
                (
                    "Óleo Insectoide Aprimorado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 1),
                        new IngredientesEntity("Óleo Insectoide", 1),
                        new IngredientesEntity("Endrega Heart", 1),
                        new IngredientesEntity("Bola de Algodão", 1),
                        new IngredientesEntity("Ranogrina", 1),
                        new IngredientesEntity("Hornwort", 1),
                        new IngredientesEntity("Madressilva", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-insectoide-aprimorado.png"
                ),
                new OleosEntity
                (
                    "Óleo Necrófago Aprimorado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 4),
                        new IngredientesEntity("Óleo Necrófago", 1),
                        new IngredientesEntity("Sangue de Rotfiend", 1),
                        new IngredientesEntity("Sopro de bola", 1),
                        new IngredientesEntity("Arenaria", 1),
                        new IngredientesEntity("Pringrape", 1),
                        new IngredientesEntity("Cortinarius", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-necrofago-aprimorado.png"
                ),
                new OleosEntity
                (
                    "Óleo Ogroid Aprimorado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 2),
                        new IngredientesEntity("Óleo Ogroid", 1),
                        new IngredientesEntity("Fígado de Troll das Cavernas", 1),
                        new IngredientesEntity("Longruba", 1),
                        new IngredientesEntity("Ranogrina", 1),
                        new IngredientesEntity("Pétalas de Ginatia", 1),
                        new IngredientesEntity("Ribleaf", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-ogroid-aprimorado.png"
                ),
                new OleosEntity
                (
                    "Óleo Relicto Aprimorado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 2),
                        new IngredientesEntity("Óleo Relicto", 1),
                        new IngredientesEntity("Dente de Bruxa d'Água", 1),
                        new IngredientesEntity("Fígado de Troll das Cavernas", 1),
                        new IngredientesEntity("Flores de Mendigo", 1),
                        new IngredientesEntity("Guarda-chuvas de Lúpulo", 1),
                        new IngredientesEntity("Mofo Verde", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-relicto-aprimorado.png"
                ),
                new OleosEntity
                (
                    "Óleo Vampiro Potencializado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 2),
                        new IngredientesEntity("Óleo de Vampiro", 1),
                        new IngredientesEntity("Quinta Essência", 1),
                        new IngredientesEntity("Pedra de Vinho", 1),
                        new IngredientesEntity("Cortinarius", 1),
                        new IngredientesEntity("Acônito", 1),
                        new IngredientesEntity("Ribleaf", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-vampiro-potencializado.png"
                ),
                new OleosEntity
                (
                    "Veneno do Enforcado Aprimorado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Gordura de Urso", 1),
                        new IngredientesEntity("Veneno do Enforcado", 1),
                        new IngredientesEntity("Fibra Han", 1),
                        new IngredientesEntity("Olho Nekker", 1),
                        new IngredientesEntity("Folhas de Salsa-do-diabo", 1),
                        new IngredientesEntity("Arenaria", 1),
                        new IngredientesEntity("Raiz de Mandrágora", 1)
                    },
                    @"/Assets/Imagens/Oleos/veneno-enforcado-aprimorado.png"
                ),

                //ÓLEOS SUPERIOR
                new OleosEntity
                (
                    "Óleo Amaldiçoado Superior",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 1),
                        new IngredientesEntity("Óleo Amaldiçoado Potencializado", 1),
                        new IngredientesEntity("Ocultar Ekimmara", 1),
                        new IngredientesEntity("Fígado de Troll das Cavernas", 1),
                        new IngredientesEntity("Acônito", 1),
                        new IngredientesEntity("Visco", 1),
                        new IngredientesEntity("Rubedo", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-amaldicoado-superior.png"
                ),
                new OleosEntity
                (
                    "Óleo Draconídeo Superior",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 1),
                        new IngredientesEntity("Óleo Draconídeo Aprimorado", 1),
                        new IngredientesEntity("Estômago de Basilisco", 1),
                        new IngredientesEntity("Fígado do Guerreiro Nekker", 1),
                        new IngredientesEntity("Nostrix", 1),
                        new IngredientesEntity("Bryonia", 1),
                        new IngredientesEntity("Albedo", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-draconideo-superior.png"
                ),
                new OleosEntity
                (
                    "Óleo Elemental Superior",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 1),
                        new IngredientesEntity("Óleo Elementa Aprimorado", 1),
                        new IngredientesEntity("Nostrix", 1),
                        new IngredientesEntity("Essência do Espectro", 1),
                        new IngredientesEntity("Pimenta da Jamaica", 1),
                        new IngredientesEntity("Madressilva", 1),
                        new IngredientesEntity("Albedo", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-elemental-superior.png"
                ),
                new OleosEntity
                (
                    "Óleo Espectro Superior",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 1),
                        new IngredientesEntity("Óleo Specter aprimorado", 1),
                        new IngredientesEntity("Essência do Espectro", 1),
                        new IngredientesEntity("Longruba", 1),
                        new IngredientesEntity("Visco", 1),
                        new IngredientesEntity("Sementes de Ergot", 1),
                        new IngredientesEntity("Rebis", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-espectros-superior.png"
                ),
                new OleosEntity
                (
                    "Óleo Híbrido Superior",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 1),
                        new IngredientesEntity("Óleo Híbrido Aprimorado", 1),
                        new IngredientesEntity("Olho de Erynia", 1),
                        new IngredientesEntity("Pétalas de Ginatia", 1),
                        new IngredientesEntity("Pétalas de Murta Branca", 1),
                        new IngredientesEntity("Grama de bisão", 1),
                        new IngredientesEntity("Albedo", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-hibrido-superior.png"
                ),
                new OleosEntity
                (
                    "Óleo Inseticida Superior",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 1),
                        new IngredientesEntity("Óleo Insetóide Aprimorado", 1),
                        new IngredientesEntity("Endrega Heart", 1),
                        new IngredientesEntity("Bola de Algodão", 1),
                        new IngredientesEntity("Hornwort", 1),
                        new IngredientesEntity("Musgo de sangue", 1),
                        new IngredientesEntity("Hidrógeno", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-insectoide-superior.png"
                ),
                new OleosEntity
                (
                    "Óleo Necrófago Superior",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 5),
                        new IngredientesEntity("Óleo Necrófago Aprimorado", 1),
                        new IngredientesEntity("Sangue do Devorador", 1),
                        new IngredientesEntity("Flores de Mendigo", 1),
                        new IngredientesEntity("Arenaria", 1),
                        new IngredientesEntity("Pringrape", 1),
                        new IngredientesEntity("Hidrógeno", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-necrofago-superior.png"
                ),
                new OleosEntity
                (
                    "Óleo Ogroid Superior",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 2),
                        new IngredientesEntity("Óleo Ogroid Aprimorado", 1),
                        new IngredientesEntity("Fígado de Troll das Cavernas", 1),
                        new IngredientesEntity("Arenaria", 1),
                        new IngredientesEntity("Ranogrina", 1),
                        new IngredientesEntity("Ribleaf", 1),
                        new IngredientesEntity("Éter", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-ogroid-superior.png"
                ),
                new OleosEntity
                (
                    "Óleo Relicto Superior",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 4),
                        new IngredientesEntity("Óleo Relicto Aprimorado", 1),
                        new IngredientesEntity("Sangue do Devorador", 1),
                        new IngredientesEntity("Guarda-chuvas de Lúpulo", 1),
                        new IngredientesEntity("Flores de Mendigo", 1),
                        new IngredientesEntity("Mofo Verde", 1),
                        new IngredientesEntity("Nigredo", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-relicto-superior.png"
                ),
                new OleosEntity
                (
                    "Óleo Vampiro Superior",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 2),
                        new IngredientesEntity("Óleo Vampiro Potencializado", 1),
                        new IngredientesEntity("Quinta Essência", 1),
                        new IngredientesEntity("Pedra de Vinho", 1),
                        new IngredientesEntity("Cortinarius", 1),
                        new IngredientesEntity("Acônito", 1),
                        new IngredientesEntity("Vermelhão", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-vampiro-superior.png"
                ),
                new OleosEntity
                (
                    "Óleo Superior para Animais",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 1),
                        new IngredientesEntity("Óleo Bestial Potencializado", 1),
                        new IngredientesEntity("Estômago de Basilisco", 1),
                        new IngredientesEntity("Celidônia", 1),
                        new IngredientesEntity("Bola de Algodão", 1),
                        new IngredientesEntity("Grama de bisão", 1),
                        new IngredientesEntity("Rubedo", 1)
                    },
                    @"/Assets/Imagens/Oleos/oleo-superior-animais.png"
                ),
                new OleosEntity
                (
                    "Veneno Superior do Enforcado",
                    new List<IngredientesEntity>
                    {
                        new IngredientesEntity("Pasta de Alquimia", 1),
                        new IngredientesEntity("Veneno do Enforcado Aprimorado", 1),
                        new IngredientesEntity("Musgo de Sangue", 1),
                        new IngredientesEntity("Sangue do Devorador", 1),
                        new IngredientesEntity("Folhas de Salsa-do-diabo", 1),
                        new IngredientesEntity("Mofo Verde", 1),
                        new IngredientesEntity("Quebec", 1)
                    },
                    @"/Assets/Imagens/Oleos/veneno-superior-enforcado.png"
                ),
            };
        }

        public IReadOnlyCollection<OleosEntity> GetOleos()
        {
            return LstOleos.AsReadOnly();
        }
    }
}
