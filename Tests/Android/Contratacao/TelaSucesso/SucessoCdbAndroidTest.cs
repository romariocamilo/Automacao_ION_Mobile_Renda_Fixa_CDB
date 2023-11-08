// using Automacao_ION_Mobile_Renda_Fixa_CDB.Commons;
// using Core_Automacao.Models;
// using Core_Automacao.Plataformas.Mobile;
// using NUnit.Framework;
// using Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaSucesso;

// namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Tests.Android.Contratacao.TelaSucesso
// {
//     public class SucessoCdbAndroidTest
//     {
//         private readonly SucessoCdbHelper _sucessoCdbHelper;
//         private AppiumService _service;
//         private Uteis _uteis;

//         public SucessoCdbAndroidTest()
//         {
//             _sucessoCdbHelper = new SucessoCdbHelper();
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

//         [Test, Retry(3), Order(1)]
//         public void SnapShotTelaSucessoTest()
//         {
//             _sucessoCdbHelper.SnapShotTelaSucessoHelper(_service);

//             Assert.IsNotNull(_sucessoCdbHelper.sucesso.BotaoFechar);
//             Assert.AreEqual(_sucessoCdbHelper.sucesso.TextoSolicitacaoFeita.TextoEsperado, _sucessoCdbHelper.sucesso.TextoSolicitacaoFeita.TextoObtido);
//             Assert.AreEqual(_sucessoCdbHelper.sucesso.BotaoVerComprovante.TextoEsperado, _sucessoCdbHelper.sucesso.BotaoVerComprovante.TextoObtido);
//             Assert.AreEqual(_sucessoCdbHelper.sucesso.TextoOQueFazer.TextoEsperado, _sucessoCdbHelper.sucesso.TextoOQueFazer.TextoObtido);
//             Assert.AreEqual(_sucessoCdbHelper.sucesso.BotaoAcompanharInvestimento.TextoEsperado, _sucessoCdbHelper.sucesso.BotaoAcompanharInvestimento.TextoObtido);
//             Assert.AreEqual(_sucessoCdbHelper.sucesso.BotaoInvestirOutroProduto.TextoEsperado, _sucessoCdbHelper.sucesso.BotaoInvestirOutroProduto.TextoObtido);
//         }

//         [Test, Retry(3), Order(2)]
//         public void VerificarBotaoFecharTest()
//         {
//             _sucessoCdbHelper.VerificarBotaoFecharHelper(_service);

//             Assert.AreEqual(_sucessoCdbHelper.informacoesGeraisCDB.TextoBancoItauAndroid.TextoEsperado, _sucessoCdbHelper.informacoesGeraisCDB.TextoBancoItauAndroid.TextoObtido);
//             Assert.AreEqual(_sucessoCdbHelper.informacoesGeraisCDB.TextoCDBDIItau.TextoEsperado, _sucessoCdbHelper.informacoesGeraisCDB.TextoCDBDIItau.TextoObtido.Substring(0, 11));
//             Assert.AreEqual(_sucessoCdbHelper.informacoesGeraisCDB.BotaoInvestir.TextoEsperado, _sucessoCdbHelper.informacoesGeraisCDB.BotaoInvestir.TextoObtido);
//         }

//         [Test, Retry(3), Order(3)]
//         public void VerificarBotaoVerComprovanteTest()
//         {
//             _sucessoCdbHelper.VerificarBotaoVerComprovanteHelper(_service);

//             Assert.IsNotNull(_sucessoCdbHelper.comprovante.BotaoFechar);
//             Assert.AreEqual(_sucessoCdbHelper.comprovante.TextoComprovanteAplicacao.TextoEsperado, _sucessoCdbHelper.comprovante.TextoComprovanteAplicacao.TextoObtido);
//             Assert.AreEqual(_sucessoCdbHelper.comprovante.TextoSolicitadoData.TextoEsperado, _sucessoCdbHelper.comprovante.TextoSolicitadoData.TextoObtido.Substring(0, 27));
//         }

//         [Test, Retry(3), Order(4)]
//         //[Ignore("Corrigir captura de elementos na tela de acompanhar investimentos")]
//         public void VerificarBotaoAcompanharInvestimentoTest()
//         {
//             _sucessoCdbHelper.VerificarBotaoAcompanharInvestimentoHelper(_service);

//             Assert.AreEqual(_sucessoCdbHelper.relatorio.TextoCarteira.TextoEsperado, _sucessoCdbHelper.relatorio.TextoCarteira.TextoObtido);
//             Assert.AreEqual(_sucessoCdbHelper.relatorio.TextoTodosProdutos.TextoEsperado, _sucessoCdbHelper.relatorio.TextoTodosProdutos.TextoObtido);
//         }

//         [Test, Retry(3), Order(5)]
//         public void VerificarInvestirOutroProdutoTest()
//         {
//             _sucessoCdbHelper.VerificarInvestirOutroProdutoHelper(_service);

//             Assert.IsNotNull(_sucessoCdbHelper.vitrine.TrilhoCardProdutos);
//             Assert.AreEqual(_sucessoCdbHelper.vitrine.CardCdbRendaFixaAndroid.TextoEsperado, _sucessoCdbHelper.vitrine.CardCdbRendaFixaAndroid.TextoObtido);
//         }
//     }
// }