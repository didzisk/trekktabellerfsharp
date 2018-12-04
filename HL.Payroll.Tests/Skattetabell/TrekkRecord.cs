using FileHelpers;

namespace HL.Payroll.Tests.Skattetabell
{
    [FixedLengthRecord] 
    class TrekkRecord
    {
        [FieldFixedLength(4)]
        public int Tabellnummer = 0;
        [FieldFixedLength(1)]
        public int Trekkperiode = 0;

        [FieldFixedLength(1)] 
        public bool TabelltypeIsPensjon = false;
        [FieldFixedLength(5)]
        public int Trekkgrunnlag = 0;
        [FieldFixedLength(5)]
        public int Trekk = 0;
    }

    /*
    Trekktabellene har fem kolonner. De inneholder:

    Kolonne 1 (A)	Tabellnummer	4 posisjoner
    Kolonne 2 (B)	
    Trekkperiode:
    1: måned 
    2: 14 dager 
    3: uke
    4: 4 dager
    5: 3 dager
    6: 2 dager 
    7: 1 dag

    1 posisjon

    Kolonne 3 (C)	Tabelltype
    0: Lønn
    1: Pensjon	1 posisjon
    Kolonne 4 (D)	Trekkgrunnlag	5 posisjoner
    Kolonne 5 (E)	Trekk	5 posisjoner    
    */
}
