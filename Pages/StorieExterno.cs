using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class StorieExterno
    {
        public ElementoMobile BotaoFechar { get; private set; }

        public StorieExterno()
        {
            BotaoFechar = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "ibClose", "Fechar", string.Empty, string.Empty);
        }
    }
}