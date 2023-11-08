using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class BemVindo
    {
        public ElementoMobile BotaoJaSouCliente { get; private set; }
        public ElementoMobile BotaoCriaConta { get; private set; }

        public BemVindo()
        {
            BotaoJaSouCliente = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "btLogin", "Já sou cliente Itaú", string.Empty, string.Empty);
            BotaoCriaConta = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "btSignup", "Criar conta", string.Empty, string.Empty);
        }
    }
}