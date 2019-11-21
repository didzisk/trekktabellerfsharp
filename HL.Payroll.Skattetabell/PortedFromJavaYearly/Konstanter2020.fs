﻿module internal Konstanter2020

open System
open Konstanter

let konstanter =
    {
        KLASSE1_VANLIG = 51300
        KLASSE2_VANLIG = 0
        KLASSE1_FINNMARK = 66800
        KLASSE2_FINNMARK = 0
        TRINN1 = 180800
        TRINN2 = 254500
        TRINN3 = 639750
        TRINN4 = 999550
        AVG_FRI_TRYGDEAVGIFT = 54650
        MAX_STFRADRAG = 40000
        MIN_ANV_MINSTE_FRADRAG = 3520
        MAX_ANV_MINSTE_FRADRAG = 91916
        MAX_ANV_MINSTE_FRADRAG_PENSJ = 76956
        MIN_MINSTE_FRADRAG = 4000
        MAX_MINSTE_FRADRAG = 104450
        LONNSFRADRAG = 31800
        ANV_LONNSFRADRAG = 27984
        MAX_SJO_FRADRAG = 80000

        PROSENT_TRINN1 = 1.9;
        PROSENT_TRINN2 = 4.2;
        PROSENT_TRINN3 = 13.2;
        PROSENT_TRINN3_FINNMARK = 11.2;
        PROSENT_TRINN4 = 16.2;
        FELLES_SKATT_VANLIG = 8.45;
        FELLES_SKATT_FINNMARK = 4.95;
        SKATTORE = 13.55;
        TRYGDE_PROSENT = 25.0;
        LAV_TRYGDEAVG_PROSENT = 5.1;
        HOY_TRYGDEAVG_PROSENT = 8.2;
        ANV_MINSTE_FRAD_PROSENT = 39.6;
        ANV_MINSTE_FRAD_PROSENT_PENSJ = 27.28;
        MINSTE_FRAD_PROSENT = 45.0;
        STFRADRAG_PROSENT = 10.0;
        SJO_PROSENT = 30.0;

        LAV_GRENSE_TRYGDEAVGIFT = 0
        HOY_GRENSE_TRYGDEAVGIFT = 0

        OVERSKYTENDE_PROSENT_VANLIG = 54;
        OVERSKYTENDE_PROSENT_PENSJONIST = 48;
        OVERSKYTENDE_PROSENT_7300_7400 = 54;
        OVERSKYTENDE_PROSENT_7350_7450 = 47;
        OVERSKYTENDE_PROSENT_7500_7600 = 39;
        OVERSKYTENDE_PROSENT_7550_7650 = 44;
        OVERSKYTENDE_PROSENT_7700_7800 = 44;
        OVERSKYTENDE_PROSENT_0100_0200 = 39;
        OVERSKYTENDE_PROSENT_0101_0201 = 47;
        OVERSKYTENDE_PROSENT_6300_6400 = 50;
        OVERSKYTENDE_PROSENT_6350_6450 = 43;
        OVERSKYTENDE_PROSENT_6500_6600 = 35;
        OVERSKYTENDE_PROSENT_6550_6650 = 40;
        OVERSKYTENDE_PROSENT_6700_6800 = 40;
        OVERSKYTENDE_PROSENT_7150_7250 = 47;
        OVERSKYTENDE_PROSENT_7160_7260 = 39;
        OVERSKYTENDE_PROSENT_7170_7270 = 44;

        OVERSKYTENDE_PROSENT_7300 = 54;
        OVERSKYTENDE_PROSENT_7350 = 47;
        OVERSKYTENDE_PROSENT_7500 = 39;
        OVERSKYTENDE_PROSENT_7550 = 44;
        OVERSKYTENDE_PROSENT_7700 = 44;
        OVERSKYTENDE_PROSENT_0100 = 39;
        OVERSKYTENDE_PROSENT_0101 = 47;
        OVERSKYTENDE_PROSENT_6300 = 50;
        OVERSKYTENDE_PROSENT_6350 = 43;
        OVERSKYTENDE_PROSENT_6500 = 35;
        OVERSKYTENDE_PROSENT_6550 = 40;
        OVERSKYTENDE_PROSENT_6700 = 40;
        OVERSKYTENDE_PROSENT_7150 = 47;
        OVERSKYTENDE_PROSENT_7160 = 39;
        OVERSKYTENDE_PROSENT_7170 = 44;
    }
    |> KonstanterWithTrygdeavgift