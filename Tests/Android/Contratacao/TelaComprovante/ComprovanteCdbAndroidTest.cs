// using Automacao_ION_Mobile_Renda_Fixa_CDB.Commons;
// using Core_Automacao.Plataformas.Mobile;
// using Core_Automacao.Models;
// using NUnit.Framework;
// using Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaComprovante;

// namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Tests.Android.Contratacao.TelaComprovante
// {
//     public class ComprovanteCdbAndroidTest
//     {
//         private readonly ComprovanteCdbHelper _comprovanteCdbHelper;
//         private AppiumService _service;
//         private Uteis _uteis;

//         public ComprovanteCdbAndroidTest()
//         {
//             _comprovanteCdbHelper = new ComprovanteCdbHelper();
//             _uteis = new Uteis();
//         }

//         [SetUp, Retry(3)]
//         public void Setup()
//         {
//             _service = new AppiumService(PlataformaMobile.Android);
//             _uteis.AcessoPadraoTelaCotacaoCDBAndroid(_service, Constants.AGENCIA, Constants.CONTA, Constants.SENHA);
//         }

//         [TearDown]
//         public void TearDown()
//         {
//             if (_service is not null)
//             {
//                 _service.Desliga_Conexao();
//             }
//         }

//         [Test, Order(1), Retry(3)]
//         public void SnapShotTelaComprovanteTest()
//         {
//             _comprovanteCdbHelper.SnapShotTelaComprovanteHelper(_service);

//             Assert.IsNotNull(_comprovanteCdbHelper.comprovante.IconeIonItau.ElementoAndroid);
//             Assert.IsNotNull(_comprovanteCdbHelper.comprovante.BotaoFechar.ElementoAndroid);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoComprovanteAplicacao.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoComprovanteAplicacao.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoSolicitadoData.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoSolicitadoData.TextoObtido.Substring(0, 27));
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoValorASerAplicado.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoValorASerAplicado.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoValorAplicacao.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoValorAplicacao.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoDataDaSolicitacao.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoDataDaSolicitacao.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoDataAplicacao.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoDataAplicacao.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoRendaFixaPosFixado.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoRendaFixaPosFixado.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoNomeProdutoCDB.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoNomeProdutoCDB.TextoObtido.Substring(0, 14));
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoRentabilidade.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoRentabilidade.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoValorRentabilidade.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoValorRentabilidade.TextoObtido.Substring(3, 11));
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoRisco.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoRisco.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoValorRisco.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoValorRisco.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoDataVencimento.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoDataVencimento.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoValorDataVencimento.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoValorDataVencimento.TextoObtido.Substring(5, 3));
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoResgate.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoResgate.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoValorResgate.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoValorResgate.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.CampoComprovante.TextoEsperado, _comprovanteCdbHelper.comprovante.CampoComprovante.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoMomentoResgate.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoMomentoResgate.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoIncidenciaIOF.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoIncidenciaIOF.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoExibicaoComprovante.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoExibicaoComprovante.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoFGC.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoFGC.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.BotaoEnviaComprovante.TextoEsperado, _comprovanteCdbHelper.comprovante.BotaoEnviaComprovante.TextoObtido);
//         }

//         [Test, Order(2), Retry(3)]
//         public void VerificaBotaoEnviaComprovanteTest()
//         {
//             _comprovanteCdbHelper.VerificaBotaoEnviaComprovanteHelper(_service);

//             Assert.AreEqual(_comprovanteCdbHelper.comprovante.TextoNativoEnviaComprovante.TextoEsperado, _comprovanteCdbHelper.comprovante.TextoNativoEnviaComprovante.TextoObtido);
//         }

//         [Test, Order(3), Retry(3)]
//         public void VerificaTextoComprovanteTest()
//         {
//             string textoInseridoComprovante = _comprovanteCdbHelper.VerificaTextoComprovanteHelper(_service);

//             Assert.AreEqual(textoInseridoComprovante, _comprovanteCdbHelper.comprovante.CampoComprovante.TextoObtido);
//         }

//         [Test, Order(4), Retry(3)]
//         public void VerificaBotaoVoltarTelaComprovanteTest()
//         {
//             _comprovanteCdbHelper.VerificaBotaoVoltarTelaComprovanteHelper(_service);

//             Assert.IsNotNull(_comprovanteCdbHelper.sucesso.BotaoFechar);
//             Assert.AreEqual(_comprovanteCdbHelper.sucesso.TextoSolicitacaoFeita.TextoEsperado, _comprovanteCdbHelper.sucesso.TextoSolicitacaoFeita.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.sucesso.BotaoVerComprovante.TextoEsperado, _comprovanteCdbHelper.sucesso.BotaoVerComprovante.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.sucesso.TextoOQueFazer.TextoEsperado, _comprovanteCdbHelper.sucesso.TextoOQueFazer.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.sucesso.BotaoAcompanharInvestimento.TextoEsperado, _comprovanteCdbHelper.sucesso.BotaoAcompanharInvestimento.TextoObtido);
//             Assert.AreEqual(_comprovanteCdbHelper.sucesso.BotaoInvestirOutroProduto.TextoEsperado, _comprovanteCdbHelper.sucesso.BotaoInvestirOutroProduto.TextoObtido);
//         }
//     }
// }