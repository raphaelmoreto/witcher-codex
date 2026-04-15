using WitcherCodex.Models.Entities.Base;
using WitcherCodex.Models.Entities.Ingredientes;

namespace WitcherCodex.Models.Entities.Oleos
{
    public class OleosEntity : BaseEntity
    {
        public string Nome { get; private set; }

        private List<IngredientesEntity> Ingredientes;

        public OleosEntity(string nome, List<IngredientesEntity> ingredientes, string imagem)
        {
            SetNome(nome);
            SetIngredientes(ingredientes);
            SetImagem(imagem);
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Equals(Nome))
                return;

            Nome = nome;
        }

        public void SetIngredientes(List<IngredientesEntity> ingredientes)
        {
            if (ingredientes == null)
                return;

            if (!ingredientes.Any())
                return;

            Ingredientes = new List<IngredientesEntity>(ingredientes);
        }

        public void SetImagem(string imagem)
        {
            if (string.IsNullOrWhiteSpace(imagem) || imagem.Equals(Imagem))
                return;

            Imagem = imagem;
        }
    }
}
