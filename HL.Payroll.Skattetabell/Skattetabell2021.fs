module HL.Payroll.Skattetabell.Skattetabell2021

let beregnForskuddstrekk (trekkgrunnlag:int) tabellnummer pensjonist (tabbtrekkperiode:int) =
    Skattetabell.beregnForskuddstrekkInternal Konstanter2021.konstanter Tabellnummer2021.InitializeTabellnummerData trekkgrunnlag tabellnummer pensjonist tabbtrekkperiode
