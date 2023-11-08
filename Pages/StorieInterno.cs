using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class StorieInterno
    {
        public ElementoMobile BotaoFechar { get; private set; }

        public StorieInterno()
        {
            BotaoFechar = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "ib_close", "Fechar", string.Empty, string.Empty);
        }
    }
}