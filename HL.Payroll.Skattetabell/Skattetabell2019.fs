module HL.Payroll.Skattetabell.Skattetabell2019

let beregnForskuddstrekk (trekkgrunnlag:int) tabellnummer pensjonist (tabbtrekkperiode:int) =
    Skattetabell.beregnForskuddstrekkInternal Konstanter2019.konstanter trekkgrunnlag tabellnummer pensjonist tabbtrekkperiode
