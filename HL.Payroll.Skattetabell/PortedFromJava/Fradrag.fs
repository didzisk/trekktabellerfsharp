module internal Fradrag

open Tabelltype
open Tabellnummer
open System
open Utils
open Konstanter

let beregnMinstefradragVanlig konstanter personInntektAar =
    let minstefradrag = 
        double personInntektAar * konstanter.ANV_MINSTE_FRAD_PROSENT / 100.0
        |> RoundAwayFromZero
        |> int
        |> EnsureWithinLimits konstanter.MIN_ANV_MINSTE_FRADRAG konstanter.MAX_ANV_MINSTE_FRADRAG
        |> EnsureAtLeast konstanter.ANV_LONNSFRADRAG
        |> EnsureWithinLimits 0 personInntektAar
    minstefradrag

let beregnMinstefradragPensjon konstanter personInntektAar =
    let minstefradrag = 
        double personInntektAar * konstanter.ANV_MINSTE_FRAD_PROSENT_PENSJ / 100.0
        |> RoundAwayFromZero 
        |> int
        |> EnsureWithinLimits konstanter.MIN_ANV_MINSTE_FRADRAG konstanter.MAX_ANV_MINSTE_FRADRAG_PENSJ
        |> EnsureWithinLimits 0 personInntektAar
    minstefradrag

let beregnMinstefradragSjo konstanter personInntektAar =
    let minstefradrag = 
        double personInntektAar * konstanter.MINSTE_FRAD_PROSENT / 100.0
        |> RoundAwayFromZero
        |> int
        |> EnsureWithinLimits konstanter.MIN_MINSTE_FRADRAG  konstanter.MAX_MINSTE_FRADRAG
        |> EnsureWithinLimits konstanter.LONNSFRADRAG personInntektAar
    minstefradrag

let beregnMinsteFradrag konstanter tabellnummer personInntektAar = 
    match tabellnummer.tabelltype with

    | Tabelltype.PENSJONIST ->
        beregnMinstefradragPensjon konstanter personInntektAar
    | Tabelltype.SJØ ->
        beregnMinstefradragSjo konstanter personInntektAar
    | _ -> beregnMinstefradragVanlig konstanter personInntektAar

let beregnStandardFradrag konstanter tabellnummer personInntektAar =
    if (tabellnummer.isStandardFradrag) then
        double personInntektAar * double konstanter.STFRADRAG_PROSENT / 100.0
        |> RoundAwayFromZero
        |> int
        |> EnsureWithinLimits 0 konstanter.MAX_STFRADRAG
    else
        0

let beregnSjoFradrag konstanter tabellnummer personInntektAar =
    if tabellnummer.tabelltype = Tabelltype.SJØ then
        double personInntektAar * double konstanter.SJO_PROSENT / 100.0
        |> RoundAwayFromZero
        |> int
        |> EnsureWithinLimits 0 konstanter.MAX_SJO_FRADRAG
    else
        0
