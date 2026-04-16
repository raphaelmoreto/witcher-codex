
namespace WitcherCodex.Models.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; protected set; }

        public string Imagem { get; protected set; } = @"Assets/Imagens/aleatorio.png";
    }
}
