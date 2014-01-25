using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PigLatin.Tests
{
    [TestClass]
    public class PigLatinTestsPart2
    {
        private PigLatin pigLatin;

        [TestInitialize]
        public void TestInitialize()
        {
            pigLatin = new PigLatin();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            pigLatin = null;
        }

        [TestMethod]
        public void PigLatin_returns_hello_for_input_ellohay()
        {
            var result = pigLatin.PigLatinToEnglish("ellohay");
            Assert.AreEqual("hello", result);
        }

        [TestMethod]
        public void PigLatin_returns_i_for_input_iway()
        {
            var result = pigLatin.PigLatinToEnglish("iway");
            Assert.AreEqual("i", result);
        }
        
        [TestMethod]
        public void PigLatin_returns_glove_for_input_oveglay()
        {
            var result = pigLatin.PigLatinToEnglish("oveglay");
            Assert.AreEqual("glove", result);
        }

        /* Uncomment here for Extra Credit
        
         [TestMethod]
        public void PigLatin_returns_TheQuickBrownFoxJumpsOverTheLazyDog_for_input_EthayIckquayOwnbrayOxfayOverwayEthayAzylayOgday()
        {
            var result = pigLatin.PigLatinToEnglish("Ethay ickquay, ownbray oxfay umpsjay overway ethay azylay ogday.");
            Assert.AreEqual("The quick, brown fox jumps over the lazy dog.", result);
        }
    
        [TestMethod]
        public void PigLatin_returns_CodeKatasAreAGoodWayToHoneYourSkills_for_input_OdecayAtaskaArewayAwayOodgayAywayOtayOnehayOuryayIllsskay()
        {
            var result = pigLatin.PigLatinToEnglish("Odecay Ataskay areway away oodgay ayway otay onehay ouryay illsskay.");
            Assert.AreEqual("Code Katas are a good way to hone your skills.",result);
        }
         
         */
    }
}
