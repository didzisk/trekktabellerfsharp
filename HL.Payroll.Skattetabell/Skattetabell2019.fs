module HL.Payroll.Skattetabell.Skattetabell2019

let beregnForskuddstrekk (trekkgrunnlag:int) tabellnummer pensjonist (tabbtrekkperiode:int) =
    Skattetabell.beregnForskuddstrekkInternal Konstanter2019.konstanter Tabellnummer2019.InitializeTabellnummerData trekkgrunnlag  tabellnummer pensjonist tabbtrekkperiode
