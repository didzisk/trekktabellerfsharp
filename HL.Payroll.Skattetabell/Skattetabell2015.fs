module HL.Payroll.Skattetabell.Skattetabell2015

let beregnForskuddstrekk (trekkgrunnlag:int) tabellnummer pensjonist (tabbtrekkperiode:int) =
    Skattetabell2015internal.beregnForskuddstrekkInternal (decimal trekkgrunnlag) tabellnummer pensjonist tabbtrekkperiode
