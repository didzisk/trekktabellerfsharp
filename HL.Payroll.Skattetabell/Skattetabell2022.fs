module HL.Payroll.Skattetabell.Skattetabell2022

let beregnForskuddstrekk (trekkgrunnlag:int) tabellnummer pensjonist (tabbtrekkperiode:int) =
    Skattetabell.beregnForskuddstrekkInternal Konstanter2022.konstanter Tabellnummer2022.InitializeTabellnummerData trekkgrunnlag tabellnummer pensjonist tabbtrekkperiode
