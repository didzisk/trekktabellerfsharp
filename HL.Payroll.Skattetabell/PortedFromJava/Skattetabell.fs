module internal Skattetabell

let internal beregnForskuddstrekkInternal konstanter inittabell (trekkgrunnlag:int)  tabellnummer pensjonist (tabbtrekkperiode:int) =
    let tab = inittabell tabellnummer pensjonist konstanter
    let perx = Periode.InitializePeriodeData tabbtrekkperiode tab
    match perx with
    | None -> 0
    | Some per ->
        match Trekkrutine.beregnTabelltrekk konstanter tab per trekkgrunnlag with
        | None -> 0
        | Some skatt -> skatt


