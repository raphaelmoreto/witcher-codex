using WitcherCodex.Models.Entities.Base;
using WitcherCodex.Models.Enum.Criaturas_Monstros;

namespace WitcherCodex.Models.Entities.Criaturas_Monstros
{
    public class Criaturas_MonstrosEntity : BaseEntity
    {
        public TipoCriaturas_Monstros Tipo { get; private set; }

        public string Nome { get; private set; } = string.Empty;

        public string Descricao { get; private set; } = string.Empty;

        private List<string> Fraquezas;

        public Criaturas_MonstrosEntity(TipoCriaturas_Monstros tipo, string nome, string descricao, List<string> fraquezas, string imagem)
        {
            SetTipo(tipo);
            SetNome(nome);
            SetDescricao(descricao);
            SetFraquezas(fraquezas);
            SetImagem(imagem);
        }

        public void SetTipo(TipoCriaturas_Monstros tipo)
        {
            if (!System.Enum.IsDefined(typeof(TipoCriaturas_Monstros), tipo))
                return;

            Tipo = tipo;
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Equals(Nome))
                return;

            Nome = nome;
        }

        public void SetDescricao(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao) || descricao.Equals(Descricao))
                return;

            Descricao = descricao;
        }

        public void SetFraquezas(List<string> fraquezas)
        {
            //GARANTE QUE NÃO É NULO
            if (fraquezas == null)
                return;

            //GARANTE QUE NÃO É VÁZIA
            if (!fraquezas.Any())
                return;

            //GARANTE QUE NÃO TEM STRINGS INVÁLIDAS
            if (fraquezas.Any(f => string.IsNullOrWhiteSpace(f)))
                return;

            Fraquezas = new List<string>(fraquezas);
        }

        public void SetImagem(string imagem)
        {
            if (string.IsNullOrWhiteSpace(imagem) || imagem.Equals(Imagem))
                return;

            Imagem = imagem;
        }

        public IReadOnlyCollection<string> GetFraquezas()
        {
            return Fraquezas.AsReadOnly();
        }
    }
}
