using Core_Automacao.Models.Mobile;
using System;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class ConfirmacaoCDB
    {
        public ElementoMobile BotaoVoltar { get; set; }
        public ElementoMobile TextoTituloCDB { get; set; }
        public ElementoMobile Paginacao { get; set; }
        public ElementoMobile TextoTituloConfirmacao { get; set; }
        public ElementoMobile ScrollConfirmacao { get; set; }
        public ElementoMobile TextoValorASerAplicado { get; set; }
        public ElementoMobile TextoValorMonetario { get; set; }
        public ElementoMobile TextoDataSolicitacao { get; set; }
        public ElementoMobile TextoDataSolicitacaoHoje { get; set; }
        public ElementoMobile TextoRendaFixaPosFixado { get; set; }
        public ElementoMobile TextoProdutoCDBDIItau { get; set; }
        public ElementoMobile TextoRentabilidade { get; set; }
        public ElementoMobile TextoValorPorcentagemRentabilidade { get; set; }
        public ElementoMobile TextoRisco { get; set; }
        public ElementoMobile TextoValorRisco { get; set; }
        public ElementoMobile TextoImpostoRenda { get; set; }
        public ElementoMobile TextoDiasEPorcentagem { get; set; }
        public ElementoMobile Texto180Dias { get; set; }
        public ElementoMobile Texto225Porcento { get; set; }
        public ElementoMobile Texto181_360Dias { get; set; }
        public ElementoMobile Texto20Porcento { get; set; }
        public ElementoMobile Texto361_720Dias { get; set; }
        public ElementoMobile Texto175Porcento { get; set; }
        public ElementoMobile TextoAcima720Dias { get; set; }
        public ElementoMobile Texto15Porcento { get; set; }
        public ElementoMobile TextoResgate { get; set; }
        public ElementoMobile TextoValorResgate { get; set; }
        public ElementoMobile CampoIdentificacaoComprovante { get; set; }
        public ElementoMobile TextoInformativoResgate { get; set; }
        public ElementoMobile TextoInformativoIof { get; set; }
        public ElementoMobile TextoInformativoComprovante { get; set; }
        public ElementoMobile TextoInformativoFgc { get; set; }
        public ElementoMobile TextoInformativoLgpd { get; set; }
        public ElementoMobile BotaoPoliticaPrivacidade { get; set; }
        public ElementoMobile BotaoConfirmar { get; set; }

        public ConfirmacaoCDB()
        {
            BotaoVoltar = new ElementoMobile(TipoIdentificador.IdAcessibilidade, TipoIdentificador.IdAcessibilidade, "Voltar", "back_button", string.Empty, string.Empty);
            TextoTituloCDB = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "counterToolbarTitle", "navigation_title", "CDB DI Itaú - ", "CDB DI Itaú - ");
            Paginacao = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "currentStepLabel", "2 de 2", "2 de 2", "2 de 2");
            TextoTituloConfirmacao = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "overviewTitle", "Você precisa agora confirmar os dados.", "Você precisa agora confirmar os dados.", "Você precisa agora confirmar os dados.");
            ScrollConfirmacao = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "nestedScrollView", string.Empty, string.Empty, string.Empty);
            TextoValorASerAplicado = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "text_label", "Valor a ser aplicado 1 real e 0 centavo", "Valor a ser aplicado", "Valor a ser aplicado 1 real e 0 centavo");
            TextoValorMonetario = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "text_value", string.Empty, "R$ 1,00", string.Empty);
            TextoDataSolicitacao = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "text_label", "Data da solicitação hoje, ", "Data da solicitação", $"Data da solicitação hoje, {DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy")}");
            TextoDataSolicitacaoHoje = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "text_value", string.Empty, "hoje, " + DateTime.Now.ToString("dd/MM/yy"), string.Empty);
            TextoRendaFixaPosFixado = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "text_label", "Renda Fixa Pós-fixado CDB DI Itaú ", "Renda Fixa Pós-fixado", $"Renda Fixa Pós-fixado CDB DI Itaú {DateTime.Now.ToString("MMMM 'de' yyyy")}");
            TextoProdutoCDBDIItau = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "text_value", string.Empty, "CDB DI Itaú - ", string.Empty);
            TextoRentabilidade = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "label_text_ct", "Rentabilidade 101,00% do CDI", "Rentabilidade", string.Empty);
            TextoValorPorcentagemRentabilidade = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "value_text_ct", string.Empty, "% do CDI", string.Empty);
            TextoRisco = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "invLeftTitle", string.Empty, "Risco", string.Empty);
            TextoValorRisco = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "tvRisk", "Risco Baixo", "Risco Baixo", string.Empty);
            TextoImpostoRenda = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "label_text_ct", "Imposto de Renda, expandido", "Imposto de Renda", "Imposto de Renda, expandido");
            Texto180Dias = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "inner_label_text", "até 180 dias 22.5 + %", "até 180 dias", "até 180 dias 22.5 + %");
            Texto181_360Dias = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "inner_label_text", "de 181 até 360 dias 20.0 + %", "de 181 até 360 dias", "de 181 até 360 dias 20.0 + %");
            Texto361_720Dias = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "inner_label_text", "de 361 até 720 dias 17.5 + %", "de 361 até 720 dias", "de 361 até 720 dias 17.5 + %");
            TextoAcima720Dias = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "inner_label_text", "acima de 720 dias 15.0 + %", "acima de 720 dias", "acima de 720 dias 15.0 + %");
            Texto225Porcento = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "inner_value_text", string.Empty, "22.5%", string.Empty);
            Texto20Porcento = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "inner_value_text", string.Empty, "20.0%", string.Empty);
            Texto175Porcento = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "inner_value_text", string.Empty, "17.5%", string.Empty);
            Texto15Porcento = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "inner_value_text", string.Empty, "15.0%", string.Empty);
            TextoResgate = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "label_text", "Resgate diário, com crédito no mesmo dia.", "Resgate", "Resgate diário, com crédito no mesmo dia.");
            TextoValorResgate = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "value_text", string.Empty, "diário, com crédito no mesmo dia.", string.Empty);
            CampoIdentificacaoComprovante = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "identifyReceipt", "Identificação no comprovante", "Identificação no comprovante", "Identificação no comprovante");
            TextoInformativoResgate = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "textInfo", string.Empty, "A qualquer momento o cliente poderá solicitar o resgate total ou parcial da aplicação.", string.Empty);
            TextoInformativoIof = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "textInfo", string.Empty, "Há incidência de tabela regressiva de IOF para liquidações antes de 30 dias contados da data de aplicação.", string.Empty);
            TextoInformativoComprovante = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "textInfo", string.Empty, "O comprovante final é exibido apenas uma vez, para consultar novamente acesse a plataforma Itaú pela internet ou app.", string.Empty);
            TextoInformativoFgc = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "textInfo", string.Empty, "Produto coberto pelo FGC (Fundo Garantidor de Créditos), que garante créditos de instituições financeiras até o limite de R$250 mil de acordo com a sua regulamentação. O limite é válido por CPF e/ou CNPJ, por instituição financeiras ou conglomerado.", string.Empty);
            TextoInformativoLgpd = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "textInfo", string.Empty, "Saiba mais sobre como tratamos dados pessoais e consulte detalhes da nossa Política de Privacidade", string.Empty);
            BotaoPoliticaPrivacidade = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "primaryChoiceActionButton", string.Empty, "Política de Privacidade ", string.Empty);
            BotaoConfirmar = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "nextButton", string.Empty, "Confirmar ", string.Empty);
        }
    }
}