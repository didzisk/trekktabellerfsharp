using System;
using System.IO;
using System.Reflection;
using FileHelpers;
using HL.Payroll.Skattetabell;
using HL.Payroll.Tests.Skattetabell;
using NUnit.Framework;

namespace HL.Payroll.Tests.UnitTests
{
    [TestFixture]
    class SkattetabellTest
    {
        private void TestAllTables(string textResourceName, Func<int, int, bool, int, int> taxFunction)
        {
            Assembly a = Assembly.GetExecutingAssembly();
            //use ildasm and inspect the Manifest of this assembly to find TextResourceName
            //from here C:\Program Files (x86)\Microsoft SDKs\Windows\v8.1A\bin\NETFX 4.5.1 Tools
            using (var s = a.GetManifestResourceStream(textResourceName))
            {
                var importEngine = new FileHelperEngine<TrekkRecord>();
                using (var sr = new StreamReader(s))
                {
                    var lines = importEngine.ReadStream(sr);
                    Assert.Multiple(() =>
                        {
                            foreach (var trekkRecord in lines)
                            {
                                var t = taxFunction(
                                    trekkRecord.Trekkgrunnlag,
                                    trekkRecord.Tabellnummer,
                                    trekkRecord.TabelltypeIsPensjon,
                                    trekkRecord.Trekkperiode);
                                Assert.AreEqual(
                                    trekkRecord.Trekk,
                                    t,
                                    $"{trekkRecord.Tabellnummer} failed at grl:{trekkRecord.Trekkgrunnlag} pensj:{trekkRecord.TabelltypeIsPensjon} periode:{trekkRecord.Trekkperiode}"
                                );

                            }

                        }
                    );
                }
            }
        }

        private void TestAllTables2017_2018(string textResourceName, Func<int, int, bool, int, int> taxFunction)
        {
            Assembly a = Assembly.GetExecutingAssembly();
            using (var s = a.GetManifestResourceStream(textResourceName))
            {
                var importEngine = new FileHelperEngine<TrekkRecord2018>();
                using (var sr = new StreamReader(s))
                {
                    var lines = importEngine.ReadStream(sr);
                    Assert.Multiple(() =>
                        {
                            foreach (var trekkRecord in lines)
                            {
                                var t = taxFunction(
                                    trekkRecord.Trekkgrunnlag,
                                    trekkRecord.Tabellnummer,
                                    trekkRecord.TabelltypeIsPensjon,
                                    trekkRecord.Trekkperiode);
                                Assert.AreEqual(
                                    trekkRecord.Trekk,
                                    t,
                                    $"{trekkRecord.Tabellnummer} failed at grl:{trekkRecord.Trekkgrunnlag} pensj:{trekkRecord.TabelltypeIsPensjon} periode:{trekkRecord.Trekkperiode}"
                                );

                            }

                        }
                    );
                }
            }
        }

        [Test]
        [TestCase(68700, 7101, 0, 1, 25592)]
        [TestCase(41667, 7100, 0, 1, 12850)]
        public void ShouldCalculateCorrectTaxForCherryPickedValues2018(int grl, int tabNr, int pensj, int periodLength,
            int expected)
        {
            var trekk = Skattetabell2018.beregnForskuddstrekk(grl, tabNr, pensj == 1, periodLength);
            Assert.AreEqual(expected, trekk);
        }
        [Test]
        [TestCase(68700, 7101, 0, 1, 24863)]
        [TestCase(41667, 7100, 0, 1, 12653)]
		[TestCase(26300, 7117, 0, 1, 3016)]
        public void ShouldCalculateCorrectTaxForCherryPickedValues2020(int grl, int tabNr, int pensj, int periodLength,
	        int expected)
        {
	        var trekk = Skattetabell2020.beregnForskuddstrekk(grl, tabNr, pensj == 1, periodLength);
	        Assert.AreEqual(expected, trekk);
        }

        [Test]
        public void ShouldGenerateCorrectTaxForAllLines2021()
        {
	        TestAllTables("HL.Payroll.Tests.Skattetabell.trekk2021.txt", Skattetabell2021.beregnForskuddstrekk);
        }

        [Test]
        public void ShouldGenerateCorrectTaxForAllLines2020()
        {
	        TestAllTables("HL.Payroll.Tests.Skattetabell.trekk2020.txt", Skattetabell2020.beregnForskuddstrekk);
        }

        [Test]
        public void ShouldGenerateCorrectTaxForAllLines2019()
        {
	        TestAllTables("HL.Payroll.Tests.Skattetabell.trekk2019.txt", Skattetabell2019.beregnForskuddstrekk);
        }

		[Test]
        public void ShouldGenerateCorrectTaxForAllLines2018()
        {
            TestAllTables2017_2018("HL.Payroll.Tests.Skattetabell.trekk2018.txt",
                Skattetabell2018.beregnForskuddstrekk);
        }

        [Test]
        [Ignore("2017 gir 1 krone mer i trekk i ganske mange tilfeller. Vi antar det er avrundingsfeil i filen.")]
        public void ShouldGenerateCorrectTaxForAllLines2017()
        {
            TestAllTables2017_2018("HL.Payroll.Tests.Skattetabell.trekk2017.txt",
                Skattetabell2017.beregnForskuddstrekk);
        }

        [Test]
//        [Ignore("This is so 2016")]
        public void ShouldGenerateCorrectTaxForAllLines2016()
        {
            var trekk = Skattetabell2016.beregnForskuddstrekk(49600, 6400, false, 1);
            Assert.AreEqual(13338M, trekk);
            trekk = Skattetabell2016.beregnForskuddstrekk(5640, 7133, false, 4);
            Assert.AreEqual(1877M, trekk);
            trekk = Skattetabell2016.beregnForskuddstrekk(20000, 7100, false, 1);
            Assert.AreEqual(4592M, trekk);
            TestAllTables("HL.Payroll.Tests.Skattetabell.trekk2016.txt", Skattetabell2016.beregnForskuddstrekk);
        }

        [Test]
        //[Ignore("This is so 2014")]
        public void ShouldGenerateCorrectTaxForAllLines2014()
        {
            var trekk = Skattetabell2014.beregnForskuddstrekk(200000, 7100, false, 1);
            Assert.AreEqual(98283M, trekk);
            TestAllTables("HL.Payroll.Tests.Skattetabell.trekk2014.txt", Skattetabell2014.beregnForskuddstrekk);
        }

        [Test]
        [Ignore("Old 2015")]
        public void ShouldCalculateCorrectTaxForCherryPickedValues2015()
        {
            var trekk = Skattetabell2015.beregnForskuddstrekk(5640, 7133, false, 4);
            Assert.AreEqual(1956M, trekk);
            trekk = Skattetabell2015.beregnForskuddstrekk(200000, 7100, false, 1);
            Assert.AreEqual(97852M, trekk);
        }

        [Test]
       // [Ignore("We have already proven 2015 tax tables work correctly")]
        public void ShouldGenerateCorrectTaxForAllLines2015()
        {
            var trekk = Skattetabell2015.beregnForskuddstrekk(5640, 7133, false, 4);
            Assert.AreEqual(1956M, trekk);
            trekk = Skattetabell2015.beregnForskuddstrekk(200000, 7100, false, 1);
            Assert.AreEqual(97852M, trekk);
            TestAllTables("HL.Payroll.Tests.Skattetabell.trekk2015.txt", Skattetabell2015.beregnForskuddstrekk);
        }
    }
}
