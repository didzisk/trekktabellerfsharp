module internal Periode

open Tabellnummer

type PeriodeData =
    {
        inntektsPeriode:double;
        trekkPeriode:double;
        inntektsPeriodePensjon:double;
        trekkPeriodePensjon:double;
        inntektsPeriodeStandardfradrag:double;
        trekkPeriodeStandardfradrag:double;
        avrunding:int;
        maxTrekkgrunnlag:int;
    }

let private getInntektsPeriode tabellnummer px = 
    match px with
    | None -> None
    | Some(pd) ->
        match tabellnummer.tabelltype with
        | Tabelltype.PENSJONIST -> Some {pd with inntektsPeriode = pd.inntektsPeriodePensjon}
        | Tabelltype.VANLIG -> Some pd
        | _ -> Some {pd with inntektsPeriode = pd.inntektsPeriodeStandardfradrag}

let private getTrekkPeriode tabellnummer (px:Option<PeriodeData>) = 
    match px with
    | None -> None
    | Some(pd) ->
        match tabellnummer.tabelltype with
        | Tabelltype.PENSJONIST -> Some {pd with trekkPeriode = pd.trekkPeriodePensjon}
        | Tabelltype.VANLIG -> Some pd
        | _ when tabellnummer.trekk_i_12_mnd -> Some {pd with trekkPeriode = pd.inntektsPeriodeStandardfradrag}
        |_ -> Some {pd with trekkPeriode = pd.trekkPeriodeStandardfradrag}

type Periode =
    | PERIODE_1_MAANED = 1
    | PERIODE_14_DAGER = 2
    | PERIODE_1_UKE = 3
    | PERIODE_4_DAGER = 4
    | PERIODE_3_DAGER = 5
    | PERIODE_2_DAGER = 6
    | PERIODE_1_DAG = 7

let ConstructPeriodeRec 
    (inntektsPeriode, trekkPeriode,
            inntektsPeriodePensjon, trekkPeriodePensjon,
            inntektsPeriodeStandardfradrag, trekkPeriodeStandardfradrag,
            avrunding, maxTrekkgrunnlag) = 
    Some {
        inntektsPeriode = inntektsPeriode;
        trekkPeriode = trekkPeriode;
        inntektsPeriodePensjon = inntektsPeriodePensjon;
        trekkPeriodePensjon = trekkPeriodePensjon;
        inntektsPeriodeStandardfradrag = inntektsPeriodeStandardfradrag;
        trekkPeriodeStandardfradrag = trekkPeriodeStandardfradrag;
        avrunding = avrunding;
        maxTrekkgrunnlag = maxTrekkgrunnlag;
    }

let InitializePeriodeData (periode:int) tnr = 
    match tnr with
        | None -> None
        | Some tabellnummer ->
        match enum periode with
            | Periode.PERIODE_1_MAANED -> ConstructPeriodeRec (12.12, 10.5,               12.0, 11.0,              12.0, 10.5, 100, 99800 )
            | Periode.PERIODE_14_DAGER -> ConstructPeriodeRec (26.26, 23.0,               26.0, 24.0,              26.0, 23.0,   50, 46000 )
            | Periode.PERIODE_1_UKE    -> ConstructPeriodeRec (52.52, 46.0,               52.0, 48.0,              52.0, 46.0,   20, 23000 )
            | Periode.PERIODE_4_DAGER  -> ConstructPeriodeRec (60.60, (60.0*46.0)/52.0,   91.0, (91.0*11.0)/12.0,   91.0, (91.0*10.5)/12.0, 20, 19900 )
            | Periode.PERIODE_3_DAGER  -> ConstructPeriodeRec (80.80, (80.0*46.0)/52.0,  122.0, (122.0*11.0)/12.0, 122.0, (122.0*10.5)/12., 20, 14900 )
            | Periode.PERIODE_2_DAGER -> ConstructPeriodeRec (121.20, (120.0*46.0)/52.0, 183.0, (183.0*11.0)/12.0, 183.0, (183.0*10.5)/12.0, 20, 9900 )
            | Periode.PERIODE_1_DAG   -> ConstructPeriodeRec (242.40, (240.0*46.0)/52.0, 365.0, (365.0*11.0)/12.0, 365.0, (365.0*10.5)/12.0, 20, 4900 )
            | _ -> None
        |> getInntektsPeriode tabellnummer
        |> getTrekkPeriode tabellnummer
