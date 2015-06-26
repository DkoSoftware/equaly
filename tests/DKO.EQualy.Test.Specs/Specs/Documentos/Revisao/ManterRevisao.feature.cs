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
namespace DKO.EQualy.Test.Specs.Specs.Documentos.Revisao
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ManterRevisaoDocumentoFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ManterRevisao.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "ManterRevisaoDocumento", "\r\nQuero realizar a revisão do documento para solicitação de aprovação de publicaç" +
                    "ão", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "ManterRevisaoDocumento")))
            {
                DKO.EQualy.Test.Specs.Specs.Documentos.Revisao.ManterRevisaoDocumentoFeature.FeatureSetup(null);
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Realizar o download documento para analise em fase de revisão")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ManterRevisaoDocumento")]
        public virtual void RealizarODownloadDocumentoParaAnaliseEmFaseDeRevisao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar o download documento para analise em fase de revisão", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 13
 testRunner.Given("que exista um documento como nome \"testeEqualy.doc\" salvo no servidor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 15
testRunner.When("realizar o download para revisar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
testRunner.Then("o download deve ser iniciado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Realizar a aprovação do documento em fase de revisão")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ManterRevisaoDocumento")]
        public virtual void RealizarAAprovacaoDoDocumentoEmFaseDeRevisao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar a aprovação do documento em fase de revisão", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 21
 testRunner.Given("que ja tenha sido feita a analise do documento na fase de revisão", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 23
testRunner.When("realizar a aprovação em fase de revisão", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 24
testRunner.Then("o documento é disponibilizado para publicação apos a revisao", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Realizar a reprovação do documento em fase de revisão")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ManterRevisaoDocumento")]
        public virtual void RealizarAReprovacaoDoDocumentoEmFaseDeRevisao()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar a reprovação do documento em fase de revisão", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 9
this.FeatureBackground();
#line 29
 testRunner.Given("que ja tenha sido feita a analise do documento", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 30
 testRunner.And("o mesmo não esteja em conformidade com a solicitação apos a revisão", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 31
 testRunner.And("tenha justificado a reprovação com o texto \"Documento fora das conformidades do s" +
                    "olicitado\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 33
testRunner.When("realizar a reprovação", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 34
testRunner.Then("o documento é colocado em status de \"Elaboracao\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
