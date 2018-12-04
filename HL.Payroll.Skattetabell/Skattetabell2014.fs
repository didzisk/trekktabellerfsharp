module HL.Payroll.Skattetabell.Skattetabell2014

let beregnForskuddstrekk (trekkgrunnlag:int) tabellnummer pensjonist (tabbtrekkperiode:int) =
    Skattetabell2014internal.beregnForskuddstrekkInternal (decimal trekkgrunnlag) tabellnummer pensjonist tabbtrekkperiode
