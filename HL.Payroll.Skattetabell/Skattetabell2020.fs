module HL.Payroll.Skattetabell.Skattetabell2020

let beregnForskuddstrekk (trekkgrunnlag:int) tabellnummer pensjonist (tabbtrekkperiode:int) =
    Skattetabell.beregnForskuddstrekkInternal Konstanter2020.konstanter trekkgrunnlag tabellnummer pensjonist tabbtrekkperiode
