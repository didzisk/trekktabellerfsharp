using FileHelpers;

namespace HL.Payroll.Tests.Skattetabell
{
    [FixedLengthRecord] 
    class TrekkRecord2018
    {
        [FieldFixedLength(1)]
        public int Dummy1 = 0;
        [FieldFixedLength(4)]
        public int Tabellnummer = 0;
        [FieldFixedLength(1)]
        public int Trekkperiode = 0;

        [FieldFixedLength(1)] 
        public bool TabelltypeIsPensjon = false;
        [FieldFixedLength(6)]
        public int Trekkgrunnlag = 0;
        [FieldFixedLength(6)]
        public int Trekk = 0;
    }

    /*
    Trekktabellene har 6 kolonner. De inneholder:
   (Kolonne 0 - Dummy, alltid '1')
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
    Kolonne 4 (D)	Trekkgrunnlag	6 posisjoner
    Kolonne 5 (E)	Trekk	6 posisjoner    
    */
}
