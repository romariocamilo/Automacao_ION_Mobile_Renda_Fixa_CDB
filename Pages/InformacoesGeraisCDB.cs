using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class InformacoesGeraisCDB
    {
        public ElementoMobile BotaoFecharDica { get; set; }
        public ElementoMobile BotaoInvestir { get; set; }

        public InformacoesGeraisCDB()
        {
            BotaoFecharDica = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "popup_buttom", "Fechar dica", string.Empty, string.Empty);
            BotaoInvestir = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "btn_invested", "Investir", "Investir", "Investir");
          //BotaoInvestir = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "buttonText", "Investir", string.Empty, string.Empty);
        }
    }
}