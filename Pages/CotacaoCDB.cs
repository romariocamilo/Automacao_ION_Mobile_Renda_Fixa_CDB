using Core_Automacao.Models;
using Core_Automacao.Models.Mobile;
using System;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class CotacaoCDB
    {
        public ElementoMobile BotaoVoltar { get; set; }
        public ElementoMobile TextoTituloCDBDiItau { get; set; }
        public ElementoMobile TextoPaginacao { get; set; }
        public ElementoMobile TextoDisponivelParaAplicacao { get; set; }
        public ElementoMobile TextoAplicar { get; set; }
        public ElementoMobile TextoValorRS000 { get; set; }
        public ElementoMobile TextoDataAplicacao { get; set; }
        public ElementoMobile TextoNaoAlteraDataAplicacao { get; set; }
        public ElementoMobile BotaoUmRealInsercaoRapida { get; set; }
        public ElementoMobile BotaoDoisReaisInsercaoRapida { get; set; }
        public ElementoMobile BotaoTresReaisInsercaoRapida { get; set; }
        public ElementoMobile BotaoQuatroReaisInsercaoRapida { get; set; }
        public ElementoMobile TrilhoBotoesInsercaoRapida { get; set; }
        public ElementoMobile TextoMensagemValorMinimo { get; set; }
        public ElementoMobile TextoMensagemValorMultiplo { get; set; }
        public ElementoMobile TextoMensagemValorMaximo { get; set; }
        public ElementoMobile TextoMensagemSemSaldo { get; set; }
        public ElementoMobile BotaoContinuar { get; set; }

        public CotacaoCDB()
        {
            BotaoVoltar = new ElementoMobile(TipoIdentificador.IdAcessibilidade, TipoIdentificador.IdAcessibilidade, "Voltar", "back_button", string.Empty, string.Empty);
            TextoPaginacao = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.Name, "currentStepLabel", "step_counter", "1 de 2", "Passo 1 de 2");
            TextoTituloCDBDiItau = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "counterToolbarTitle", "navigation_title", "CDB DI Itaú - ", "CDB DI Itaú - ");
            TextoDisponivelParaAplicacao = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "available_amount_info_content_view", "LabelInfo", "Disponível para aplicação: R$ ", "Disponível para aplicação: R$ ");
            TextoAplicar = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "label_description_action_text", "LabelCurrencyDescription", "Aplicar", "Aplicar");
            TextoValorRS000 = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "input_currency", "TextFieldCurrencyInput", "R$0,00", "R$ 0,00");
            TextoDataAplicacao = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "label_date_action_text", "LabelDateDescription", "hoje, " + DateTime.Now.ToString("dd/MM/yy"), "hoje, " + DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy"));
            TextoNaoAlteraDataAplicacao = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "label_date_warning_message", "Por enquanto não é possível aterar a data", "Por enquanto não é possível aterar a data", "Por enquanto não é possível aterar a data");
            BotaoUmRealInsercaoRapida = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "textValue", "+ R$ 1,00", "+ R$ 1,00", "+ R$ 1,00");
            BotaoDoisReaisInsercaoRapida = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "textValue", "+ R$ 2,00", "+ R$ 2,00", "+ R$ 2,00");
            BotaoTresReaisInsercaoRapida = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "textValue", "+ R$ 3,00", "+ R$ 3,00", "+ R$ 3,00");
            BotaoQuatroReaisInsercaoRapida = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "textValue", "+ R$ 4,00", "+ R$ 4,00", "+ R$ 4,00");
            TrilhoBotoesInsercaoRapida = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "recycleView", "recycleView", string.Empty, string.Empty);
            TextoMensagemValorMinimo = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "label_value_warning_message", "LabelCurrencyMessage", "Valor mínimo para aplicação: R$ 1,00", "Valor mínimo para aplicação: 1 real e 0 centavo");
            TextoMensagemValorMultiplo = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "label_value_warning_message", "Valor aplicado precisa ser múltiplo de: R$ 1,00", "Valor aplicado precisa ser múltiplo de: R$ 1,00", "Valor aplicado precisa ser múltiplo de: 1 real e 0 centavo");
            TextoMensagemValorMaximo = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "label_value_warning_message", "LabelCurrencyMessage", "Valor máximo para aplicação: R$ 10.000.000,00", "Valor máximo para aplicação: 10.000.000 reais e 0 centavo");
            TextoMensagemSemSaldo = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "label_value_warning_message", "LabelCurrencyMessage", "Saldo insuficiente, altere o valor para continuar", "Saldo insuficiente, altere o valor para continuar");
            BotaoContinuar = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "label", "Continuar", "Continuar", "Continuar");
        }
    }
}