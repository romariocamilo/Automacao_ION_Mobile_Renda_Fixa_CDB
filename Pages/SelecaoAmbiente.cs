using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class SelecaoAmbiente
    {
        public ElementoMobile CheckBoxNovoCiam { get; private set; }
        public ElementoMobile BotaoSeguirParaApp { get; private set; }

        public SelecaoAmbiente()
        {
            CheckBoxNovoCiam = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "switchCIAMRenewedBtn", "CIAM", string.Empty, string.Empty);
            BotaoSeguirParaApp = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "btnStartApp", "seguir para o app", string.Empty, string.Empty);
        }
    }
}