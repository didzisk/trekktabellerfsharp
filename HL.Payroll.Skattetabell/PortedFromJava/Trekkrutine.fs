module internal Trekkrutine

open System
open Periode
open Tabellnummer
open Skatteberegning
open Utils

let private finnAvrundetTrekkgrunnlag periode trekkgrunnlag =
    let avrunding = periode.avrunding
    (trekkgrunnlag / avrunding * avrunding) + (avrunding / 2)

let private finnAlminneligInntektAar konstanter tabellnummer personInntektAar =
    personInntektAar
            - Fradrag.beregnMinsteFradrag konstanter tabellnummer personInntektAar
            - tabellnummer.tabellFradrag
            - Fradrag.beregnStandardFradrag konstanter tabellnummer personInntektAar
            - Fradrag.beregnSjoFradrag konstanter tabellnummer personInntektAar
            - tabellnummer.klasseFradrag;

let private beregnSkatt konstanter tabellnummer personInntektAar alminneligInntektAar =
    Skatteberegning.beregnKommuneskatt konstanter alminneligInntektAar
                + Skatteberegning.beregnFelleseskatt konstanter tabellnummer  alminneligInntektAar
                + Skatteberegning.beregnTrinnskatt konstanter tabellnummer personInntektAar
                + Skatteberegning.beregnTrygdeavgift konstanter tabellnummer personInntektAar

let private beregnTrekk tabellnummer periode sumSkatt =
    double sumSkatt / periode.trekkPeriode
    |> match tabellnummer.tabelltype with
       | Tabelltype.SJØ -> Math.Floor
       | _ -> RoundAwayFromZero
    |> int

let  beregnTabelltrekk konstanter tnr periode trekkgrunnlag =
    match tnr with
    | None -> None
    | Some tabellnummer ->
        let avrTrGrlPhase1 = finnAvrundetTrekkgrunnlag periode trekkgrunnlag

        let overskytendeTrekk = Skatteberegning.beregnOverskytendeTrekk tabellnummer periode avrTrGrlPhase1

        let avrundetTrekkgrunnlag = 
            match overskytendeTrekk with
            | GT 0 x -> periode.maxTrekkgrunnlag
            | _ -> avrTrGrlPhase1

        let personInntektAar = double avrundetTrekkgrunnlag * periode.inntektsPeriode |> RoundAwayFromZero |> int

        let alminneligInntektAar = finnAlminneligInntektAar konstanter tabellnummer personInntektAar 

        let sumSkatt = beregnSkatt konstanter tabellnummer personInntektAar alminneligInntektAar

        let trekk = (beregnTrekk tabellnummer periode sumSkatt) + overskytendeTrekk

        if (trekk > trekkgrunnlag && overskytendeTrekk = 0) then
            Some trekkgrunnlag
        else Some trekk
