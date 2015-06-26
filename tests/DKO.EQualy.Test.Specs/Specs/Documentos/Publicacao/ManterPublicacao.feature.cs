﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18408
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DKO.EQualy.Test.Specs.Specs.Documentos.Publicacao
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ManterPublicacaoDocumentoFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ManterPublicacao.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "ManterPublicacaoDocumento", "\r\nQuero realizar a publicação do documento para uso do setor que solicitou o docu" +
                    "mentos", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "ManterPublicacaoDocumento")))
            {
                DKO.EQualy.Test.Specs.Specs.Documentos.Publicacao.ManterPublicacaoDocumentoFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 9
#line hidden
        }
        
        public virtual void PublicarODocumentoSolicitadoPeloSetorDoTipoFisicoParaUsoComCopiaControlada(string titulo, string dataPublicacao, string dataValidade, string qtdCopiasPermitidas, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("publicar o documento solicitado pelo setor do tipo fisico para uso com copia cont" +
                    "rolada", exampleTags);
#line 12
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 13
testRunner.Given(string.Format("as informações  {0} e {1} e {2} e <LocalFisico> e {3} para uso nas rotinas de tra" +
                        "balho com uso de documentos com copia controlada", titulo, dataPublicacao, dataValidade, qtdCopiasPermitidas), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 14
testRunner.When("executar a publicação do documento com copia controlada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
testRunner.Then("o documento deve ser atualizado para o status \"Publicado\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line 17
testRunner.And("um email de aviso com a informação \"Documento publicado para uso\" deve ser enviad" +
                    "o para os <CodigoDosRevisores>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("publicar o documento solicitado pelo setor do tipo fisico para uso com copia cont" +
            "rolada")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ManterPublicacaoDocumento")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "\"Titulo do documento\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Titulo", "\"Titulo do documento\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DataPublicacao", "\"20/11/2014\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DataValidade", "\"31/12/2020\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:QtdCopiasPermitidas", "1")]
        public virtual void PublicarODocumentoSolicitadoPeloSetorDoTipoFisicoParaUsoComCopiaControlada_TituloDoDocumento()
        {
            this.PublicarODocumentoSolicitadoPeloSetorDoTipoFisicoParaUsoComCopiaControlada("\"Titulo do documento\"", "\"20/11/2014\"", "\"31/12/2020\"", "1", ((string[])(null)));
        }
        
        public virtual void PublicarODocumentoSolicitadoPeloSetorDoTipoFisicoParaUsoComSemCopiaControlada(string titulo, string dataPublicacao, string dataValidade, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("publicar o documento solicitado pelo setor do tipo fisico para uso com sem copia " +
                    "controlada", exampleTags);
#line 26
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 27
testRunner.Given(string.Format("as informações  {0} e {1} e {2} e <LocalFisico> para uso nas rotinas de trabalho", titulo, dataPublicacao, dataValidade), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 28
testRunner.When("executar a publicação do documento sem copia controlada", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 30
testRunner.Then("o documento deve ser atualizado para o status \"Publicado\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line 31
testRunner.And("um email de aviso com a informação \"Documento sem copia controlada foi publicado " +
                    "para uso\" deve ser enviado para os <CodigoDosRevisores>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("publicar o documento solicitado pelo setor do tipo fisico para uso com sem copia " +
            "controlada")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ManterPublicacaoDocumento")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "\"Titulo do documento\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Titulo", "\"Titulo do documento\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DataPublicacao", "\"20/11/2014\"")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:DataValidade", "\"31/12/2020\"")]
        public virtual void PublicarODocumentoSolicitadoPeloSetorDoTipoFisicoParaUsoComSemCopiaControlada_TituloDoDocumento()
        {
            this.PublicarODocumentoSolicitadoPeloSetorDoTipoFisicoParaUsoComSemCopiaControlada("\"Titulo do documento\"", "\"20/11/2014\"", "\"31/12/2020\"", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
