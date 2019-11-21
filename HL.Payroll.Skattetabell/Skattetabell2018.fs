module HL.Payroll.Skattetabell.Skattetabell2018

let beregnForskuddstrekk (trekkgrunnlag:int) tabellnummer pensjonist (tabbtrekkperiode:int) =
    Skattetabell.beregnForskuddstrekkInternal Konstanter2018.konstanter Tabellnummer2019.InitializeTabellnummerData trekkgrunnlag tabellnummer pensjonist tabbtrekkperiode
