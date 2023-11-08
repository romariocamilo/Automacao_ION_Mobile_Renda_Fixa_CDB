// using Core_Automacao.Models.Mobile;
// using System;

// namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
// {
//     public class Comprovante
//     {
//         public ElementoMobile IconeIonItau { get; set; }
//         public ElementoMobile BotaoFechar { get; set; }
//         public ElementoMobile TextoComprovanteAplicacao { get; set; }
//         public ElementoMobile TextoSolicitadoData { get; set; }
//         public ElementoMobile TextoValorASerAplicado { get; set; }
//         public ElementoMobile TextoValorAplicacao { get; set; }
//         public ElementoMobile TextoDataDaSolicitacao { get; set; }
//         public ElementoMobile TextoDataAplicacao { get; set; }
//         public ElementoMobile TextoRendaFixaPosFixado { get; set; }
//         public ElementoMobile TextoNomeProdutoCDB { get; set; }
//         public ElementoMobile TextoRentabilidade { get; set; }
//         public ElementoMobile TextoValorRentabilidade { get; set; }
//         public ElementoMobile TextoRisco { get; set; }
//         public ElementoMobile TextoValorRisco { get; set; }
//         public ElementoMobile TextoDataVencimento { get; set; }
//         public ElementoMobile TextoValorDataVencimento { get; set; }
//         public ElementoMobile TextoResgate { get; set; }
//         public ElementoMobile TextoValorResgate { get; set; }
//         public ElementoMobile CampoComprovante { get; set; }
//         public ElementoMobile TextoMomentoResgate { get; set; }
//         public ElementoMobile TextoIncidenciaIOF { get; set; }
//         public ElementoMobile TextoExibicaoComprovante { get; set; }
//         public ElementoMobile TextoFGC { get; set; }
//         public ElementoMobile BotaoEnviaComprovante { get; set; }
//         public ElementoMobile TextoNativoEnviaComprovante { get; set; }


//         public Comprovante()
//         {
//             IconeIonItau = new ElementoMobile("com.itau.investimentos.debug:id/invest_logo");
//             BotaoFechar = new ElementoMobile("Fechar", textoEsperado: "Fechar");
//             TextoComprovanteAplicacao = new ElementoMobile("com.itau.investimentos.debug:id/title", textoEsperado: "Comprovante de aplicação");
//             TextoSolicitadoData = new ElementoMobile("com.itau.investimentos.debug:id/headerSubText", textoEsperado: $"Solicitado em {DateTime.Now.ToString("dd/MM/yy")}, às ");
//             TextoValorASerAplicado = new ElementoMobile("com.itau.investimentos.debug:id/text_label", textoEsperado: "Valor a ser aplicado");
//             TextoValorAplicacao = new ElementoMobile("com.itau.investimentos.debug:id/text_value", textoEsperado: "R$ 1,00");
//             TextoDataDaSolicitacao = new ElementoMobile("com.itau.investimentos.debug:id/text_label", textoEsperado: "Data da solicitação");
//             TextoDataAplicacao = new ElementoMobile("com.itau.investimentos.debug:id/text_value", textoEsperado: $"hoje, {DateTime.Now.ToString("dd/MM/yy")}");
//             TextoRendaFixaPosFixado = new ElementoMobile("com.itau.investimentos.debug:id/text_label", textoEsperado: "Renda Fixa Pós-fixado");
//             TextoNomeProdutoCDB = new ElementoMobile("com.itau.investimentos.debug:id/text_value", textoEsperado: "CDB DI Itaú - ");
//             TextoRentabilidade = new ElementoMobile("com.itau.investimentos.debug:id/label_text_ct", textoEsperado: "Rentabilidade");
//             TextoValorRentabilidade = new ElementoMobile("com.itau.investimentos.debug:id/value_text_ct", textoEsperado: ",00% do CDI");
//             TextoRisco = new ElementoMobile("com.itau.investimentos.debug:id/invLeftTitle", textoEsperado: "Risco");
//             TextoValorRisco = new ElementoMobile("com.itau.investimentos.debug:id/tvRisk", textoEsperado: "Risco Baixo");
//             TextoDataVencimento = new ElementoMobile("com.itau.investimentos.debug:id/label_text", textoEsperado: "Data de vencimento");
//             TextoValorDataVencimento = new ElementoMobile("com.itau.investimentos.debug:id/value_text", textoEsperado: "/20");
//             TextoResgate = new ElementoMobile("com.itau.investimentos.debug:id/label_text", textoEsperado: "Resgate");
//             TextoValorResgate = new ElementoMobile("com.itau.investimentos.debug:id/value_text", textoEsperado: "diário, com crédito no mesmo dia.");
//             CampoComprovante = new ElementoMobile("com.itau.investimentos.debug:id/identifyReceipt", textoEsperado: "comprovante");
            
//             TextoMomentoResgate = new ElementoMobile("com.itau.investimentos.debug:id/textInfo", textoEsperado: "A qualquer momento o cliente poderá solicitar o resgate total ou parcial da aplicação.");
//             TextoIncidenciaIOF = new ElementoMobile("com.itau.investimentos.debug:id/textInfo", textoEsperado: "Há incidência de tabela regressiva de IOF para liquidações antes de 30 dias contados da data de aplicação.");
//             TextoExibicaoComprovante = new ElementoMobile("com.itau.investimentos.debug:id/textInfo", textoEsperado: "O comprovante final é exibido apenas uma vez, para consultar novamente acesse a plataforma Itaú pela internet ou app.");
//             TextoFGC = new ElementoMobile("com.itau.investimentos.debug:id/textInfo", textoEsperado: "Produto coberto pelo FGC (Fundo Garantidor de Créditos), que garante créditos de instituições financeiras até o limite de R$250 mil de acordo com a sua regulamentação. O limite é válido por CPF e/ou CNPJ, por instituição financeiras ou conglomerado.");
//             BotaoEnviaComprovante = new ElementoMobile("com.itau.investimentos.debug:id/label", textoEsperado: "Enviar comprovante");
//             TextoNativoEnviaComprovante = new ElementoMobile("android:id/title", textoEsperado: "Comprovante_de_aplicação");
//         }
//     }
// }