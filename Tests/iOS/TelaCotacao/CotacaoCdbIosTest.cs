// using Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.iOS.TelaCotacao;
// using Core_Automacao.Models;
// using Core_Automacao.Plataformas.Mobile;
// using NUnit.Framework;

// namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Tests.iOS.TelaCotacao
// {
//     public class CotacaoCdbIosTest
//     {
//         private readonly CotacaoCdbHelper _cotacaoCdbHelper;
//         private AppiumService _service;
//         private const string NAO_EXECUTA_ACESSO_PADRAO = "NAO_EXECUTA_ACESSO_PADRAO";

//         public CotacaoCdbIosTest()
//         {
//             _cotacaoCdbHelper = new CotacaoCdbHelper();
//         }

//         [SetUp]
//         public void Setup()
//         {
//             var categoria = TestContext.CurrentContext.Test.Properties.Get("Category");
//             _service = new AppiumService(PlataformaMobile.iOS);

//             if (categoria is not NAO_EXECUTA_ACESSO_PADRAO)
//             {
//                 _cotacaoCdbHelper.AcessoPadraoTelaCotacaoCDB(_service);
//             }
//         }

//         [TearDown]
//         public void TearDown()
//         {
//             _service.Desliga_Conexao();
//         }

//         [Test, Retry(3), Order(1)]
//         public void SnapShotTelaCotacaoTest()
//         {
//             _cotacaoCdbHelper.SnapShotTelaCotacaoHelper(_service);

//             Assert.IsNotNull(_cotacaoCdbHelper.cotacaoCDB.BotaoVoltar.ElementoIOS);
//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.Paginacao.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.Paginacao.TextoObtido);
//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoTituloCDB.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.TextoTituloCDB.TextoObtido.Substring(0, 11));
//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoDisponivelParaAplicacao.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.TextoDisponivelParaAplicacao.TextoObtido.Substring(0, 27));
//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoAplicar.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.TextoAplicar.TextoObtido);
//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoValorAplicacao.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.TextoValorAplicacao.TextoObtido);
//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoDataAplicacao.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.TextoDataAplicacao.TextoObtido);
//             // Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoNaoAlteraDataAplicacao.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.TextoNaoAlteraDataAplicacao.TextoObtido);
//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.BotaoUmRealInsercaoRapida.TextoObtido);
//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.BotaoDoisReaisInsercaoRapida.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.BotaoDoisReaisInsercaoRapida.TextoObtido);
//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.BotaoTresReaisInsercaoRapida.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.BotaoTresReaisInsercaoRapida.TextoObtido);
//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.BotaoQuatroReaisInsercaoRapida.TextoObtido);
//         }

//         [Test, Retry(3), Order(2)]
//         public void VerificaBotaoVoltarTelaCotacaoTest()
//         {
//             _cotacaoCdbHelper.VerificaBotaoVoltarTelaCotacaoHelper(_service);

//             Assert.AreEqual(_cotacaoCdbHelper.informacoesGeraisCDB.TextoBancoItauAndroid.TextoEsperado, _cotacaoCdbHelper.informacoesGeraisCDB.TextoBancoItauAndroid.TextoObtido);
//             Assert.AreEqual(_cotacaoCdbHelper.informacoesGeraisCDB.TextoCDBDIItau.TextoEsperado, _cotacaoCdbHelper.informacoesGeraisCDB.TextoCDBDIItau.TextoObtido.Substring(0, 11));
//         }

//         [Test, Retry(3), Order(3)]
//         public void VerificaBotoesInsercaoRapidaTest()
//         {
//             _cotacaoCdbHelper.VerificaBotoesInsercaoRapidaHelper(_service);

//             Assert.AreEqual("10,00", _cotacaoCdbHelper.cotacaoCDB.TextoValorAplicacao.TextoObtido.Substring(3));
//         }

//         [Test, Retry(3), Order(4)]
//         public void VerificaMensagemValorMinimoTest()
//         {
//             _cotacaoCdbHelper.VerificaMensagemValorMinimoHelper(_service);

//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoMensagemValorMinimoIOS.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.TextoMensagemValorMinimoIOS.TextoObtido);
//         }

//         [Test, Retry(3), Order(5)]
//         public void VerificaMensagemValorMultiploTest()
//         {
//             _cotacaoCdbHelper.VerificaMensagemValorMultiploHelper(_service);

//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoMensagemValorMultiploIOS.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.TextoMensagemValorMultiploIOS.TextoObtido);
//         }

//         [Test, Retry(3), Order(6)]
//         public void VerificaMensagemValorMaximoTest()
//         {
//             _cotacaoCdbHelper.VerificaMensagemValorMaximoHelper(_service);

//         }

//         [Test, Retry(3), Order(7)]
//         // [Category(NAO_EXECUTA_ACESSO_PADRAO)]
//         public void VerificaMensagemSemSaldoTest()
//         {
//             _cotacaoCdbHelper.VerificaMensagemSemSaldoHelper(_service);

//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.TextoMensagemSemSaldo.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.TextoMensagemSemSaldo.TextoObtido);
//         }

//         [Test, Retry(3), Order(8)]
//         public void VerificaQuebraDeLinhaValorGrandeTest()
//         {
//             int valorAntesQuebra = _cotacaoCdbHelper.VerificaQuebraDeLinhaValorGrandeHelper(_service);

//             Assert.IsTrue(valorAntesQuebra < _cotacaoCdbHelper.cotacaoCDB.TextoValorAplicacao.ElementoIOS.Location.Y);
//         }

//         [Test, Retry(3), Order(9)]
//         public void VerificaBotaoContinuarHabilitadoTest()
//         {
//             _cotacaoCdbHelper.VerificaBotaoContinuarHabilitadoHelper(_service);

//             Assert.IsNotNull(_cotacaoCdbHelper.cotacaoCDB.BotaoContinuar.ElementoIOS);
//             Assert.AreEqual(_cotacaoCdbHelper.cotacaoCDB.BotaoContinuar.TextoEsperado, _cotacaoCdbHelper.cotacaoCDB.BotaoContinuar.TextoObtido);
//         }

//         [Test, Retry(3)]
//         public void VerificaBotaoContinuarDesabilitadoTest()
//         {
//             _cotacaoCdbHelper.VerificaBotaoContinuarDesabilitadoHelper(_service);

//             Assert.AreEqual("Não exibido na tela", _cotacaoCdbHelper.cotacaoCDB.BotaoContinuar.ElementoVisivelNaTela);
//         }
//     }
// }