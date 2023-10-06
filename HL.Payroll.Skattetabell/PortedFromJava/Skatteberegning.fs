module internal Skatteberegning

open Utils
open Konstanter
open Tabellnummer
open Periode

let beregnKommuneskatt konstanter alminneligInntektAar =
    if  alminneligInntektAar > 0 then
        double alminneligInntektAar * konstanter.SKATTORE / 100.0 |> RoundAwayFromZero |> int
    else
        0

let beregnFelleseskatt konstanter tabellnummer  alminneligInntektAar =
        if (alminneligInntektAar < 0) then
             0
        else
            if tabellnummer.tabelltype = Tabelltype.FINNMARK then
                double alminneligInntektAar * konstanter.FELLES_SKATT_FINNMARK / 100.0 |> RoundAwayFromZero |> int
            else
                double alminneligInntektAar * konstanter.FELLES_SKATT_VANLIG / 100.0 |> RoundAwayFromZero |> int

let beregnTrinnskatt konstanter tabellnummer personInntektAar = 

    let prosentTrinn3 =
        match tabellnummer.tabelltype with
        | Tabelltype.FINNMARK -> konstanter.PROSENT_TRINN3_FINNMARK
        | _ -> konstanter.PROSENT_TRINN3

    let TRINNSKATT1 = 
        match personInntektAar with
        | LT konstanter.TRINN1 x -> 0.0
        | LT konstanter.TRINN2 x -> double (x - konstanter.TRINN1) * konstanter.PROSENT_TRINN1 / 100.0
        | _ -> double (konstanter.TRINN2 - konstanter.TRINN1) * konstanter.PROSENT_TRINN1 / 100.0
    let TRINNSKATT2 = 
        match personInntektAar with
        | LT konstanter.TRINN2 x -> 0.0
        | LT konstanter.TRINN3 x -> double (x - konstanter.TRINN2) * konstanter.PROSENT_TRINN2 / 100.0
        | _ -> double (konstanter.TRINN3 - konstanter.TRINN2) * konstanter.PROSENT_TRINN2 / 100.0
    let TRINNSKATT3 = 
        match personInntektAar with
        | LT konstanter.TRINN3 x -> 0.0
        | LT konstanter.TRINN4 x -> double (x - konstanter.TRINN3 ) * prosentTrinn3 / 100.0
        | _ -> double (konstanter.TRINN4 - konstanter.TRINN3) * prosentTrinn3 / 100.0
    let TRINNSKATT4 = 
        match personInntektAar with
        | LT konstanter.TRINN4 x -> 0.0
        | LT konstanter.TRINN5 x -> double (x - konstanter.TRINN4 ) * konstanter.PROSENT_TRINN4 / 100.0
        | _ -> double (konstanter.TRINN5 - konstanter.TRINN4) * konstanter.PROSENT_TRINN4 / 100.0
    let TRINNSKATT5 = 
        match personInntektAar with
        | LT konstanter.TRINN5 x -> 0.0
        | _ -> double (personInntektAar - konstanter.TRINN5) * konstanter.PROSENT_TRINN5 / 100.0

    TRINNSKATT1 + TRINNSKATT2 + TRINNSKATT3 + TRINNSKATT4
    |> RoundAwayFromZero |> int

let private beregnTrygdeavgiftLavSats konstanter personInntektAar =
    if (personInntektAar > konstanter.LAV_GRENSE_TRYGDEAVGIFT) then
        double personInntektAar * konstanter.LAV_TRYGDEAVG_PROSENT / 100.0 |> RoundAwayFromZero |> int
    else
        double (personInntektAar - konstanter.AVG_FRI_TRYGDEAVGIFT) * konstanter.TRYGDE_PROSENT / 100.0 |> RoundAwayFromZero |> int

let private beregnTrygdeavgiftHoySats konstanter personInntektAar =
    if (personInntektAar > konstanter.HOY_GRENSE_TRYGDEAVGIFT) then
       double personInntektAar * konstanter.HOY_TRYGDEAVG_PROSENT / 100.0 |> RoundAwayFromZero |> int
    else 
       double (personInntektAar - konstanter.AVG_FRI_TRYGDEAVGIFT) * konstanter.TRYGDE_PROSENT / 100.0 |> RoundAwayFromZero |> int
    
let beregnTrygdeavgift konstanter tabellnummer personInntektAar =
    if (personInntektAar < konstanter.AVG_FRI_TRYGDEAVGIFT) then
         0
    else
        if tabellnummer.ikkeTrygdeavgift then
             0
        else
            if (tabellnummer.lavSatsTrygdeavgift) then
                 beregnTrygdeavgiftLavSats konstanter personInntektAar
            else
                 beregnTrygdeavgiftHoySats konstanter personInntektAar

let beregnOverskytendeTrekk tabellnummer periode avrundetTrekkgrunnlag =
    if periode.maxTrekkgrunnlag > avrundetTrekkgrunnlag then
        0
    else
        (double ((avrundetTrekkgrunnlag - periode.maxTrekkgrunnlag) * tabellnummer.overskytendeProsent)) / 100.0 
        |> RoundAwayFromZero |> int
