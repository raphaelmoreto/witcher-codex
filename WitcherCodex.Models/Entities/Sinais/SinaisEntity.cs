using WitcherCodex.Models.Entities.Base;

namespace WitcherCodex.Models.Entities.Sinais
{
    public class SinaisEntity : BaseEntity
    {
        public string Nome { get; private set; }

        public string Descricao { get; private set; }

        public SinaisEntity(string nome, string descricao, string imagem)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetImagem(imagem);
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Equals(Nome))
                return;

            Nome = nome;
        }

        public void SetDescricao(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao) || descricao.Equals(Nome))
                return;

            Descricao = descricao;
        }

        public void SetImagem(string imagem)
        {
            if (string.IsNullOrWhiteSpace(imagem) || imagem.Equals(Imagem))
                return;

            Imagem = imagem;
        }
    }
}
