using WitcherCodex.Models.Entities.Base;

namespace WitcherCodex.Models.Entities.Ingredientes
{
    public class IngredientesEntity : BaseEntity
    {
        public string Nome { get; private set; } = string.Empty;

        public int Quantidade { get; private set; } = 0;

        public IngredientesEntity(string nome, int quantidade, string? imagem = null)
        {
            SetNome(nome);
            SetQuantidade(quantidade);
            SetImagem(imagem);
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Equals(Nome))
                return;

            Nome = nome;
        }

        public void SetQuantidade(int quantidade)
        {
            if (quantidade <= 0)
                return;

            Quantidade = quantidade;
        }

        public void SetImagem(string? imagem)
        {
            if (string.IsNullOrWhiteSpace(imagem) || imagem.Equals(Imagem))
                return;

            Imagem = imagem;
        }
    }
}
