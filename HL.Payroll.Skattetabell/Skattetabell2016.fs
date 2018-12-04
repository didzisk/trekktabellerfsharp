module HL.Payroll.Skattetabell.Skattetabell2016

let beregnForskuddstrekk (trekkgrunnlag:int) tabellnummer pensjonist (tabbtrekkperiode:int) =
    Skattetabell2016internal.beregnForskuddstrekkInternal (decimal trekkgrunnlag) tabellnummer pensjonist tabbtrekkperiode
