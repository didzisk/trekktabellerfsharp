module HL.Payroll.Skattetabell.Skattetabell2023

let beregnForskuddstrekk (trekkgrunnlag:int) tabellnummer pensjonist (tabbtrekkperiode:int) =
    Skattetabell.beregnForskuddstrekkInternal Konstanter2023.konstanter Tabellnummer2023.InitializeTabellnummerData trekkgrunnlag tabellnummer pensjonist tabbtrekkperiode
