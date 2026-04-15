using WitcherCodex.Models.Entities.Base;
using WitcherCodex.Models.Entities.Ingredientes;

namespace WitcherCodex.Models.Entities.Pocoes
{
    public class PocoesEntity : BaseEntity
    {
        public string Efeitos { get; private set; } = string.Empty;

        public string Nome { get; private set; } = string.Empty;

        public double Duracao { get; private set; } = 0.0;

        public int Toxidade { get; private set; } = 0;

        public List<IngredientesEntity> Ingredientes;

        public PocoesEntity(string efeitos, string nome, double duracao, int toxidade, List<IngredientesEntity> ingredientes, string imagem)
        {
            SetEfeitos(efeitos);
            SetNome(nome);
            SetDuracao(duracao);
            SetToxidade(toxidade);
            SetIngredientes(ingredientes);
            SetImagem(imagem);
        }

        public void SetEfeitos(string efeitos)
        {
            if (string.IsNullOrWhiteSpace(efeitos) || efeitos.Equals(Efeitos))
                return;

            Efeitos = efeitos;
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Equals(Nome))
                return;

            Nome = nome;
        }

        public void SetDuracao(double duracao)
        {
            if (duracao == 0.0 || duracao == Duracao)
                return;

            Duracao = duracao;
        }

        public void SetToxidade(int toxidade)
        {
            if (toxidade <= 0)
                return;

            Toxidade = toxidade;
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

        public IReadOnlyCollection<IngredientesEntity> GetIngredientes()
        {
            return Ingredientes.AsReadOnly();
        }
    }
}
