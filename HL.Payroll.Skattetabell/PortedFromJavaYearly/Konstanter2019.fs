﻿module internal Konstanter2019
open Konstanter

let konstanter =
    {
        KLASSE1_VANLIG = 56550
        KLASSE2_VANLIG = 56550
        KLASSE1_FINNMARK = 72050
        KLASSE2_FINNMARK = 72050
        TRINN1 = 174500
        TRINN2 = 245650
        TRINN3 = 617500
        TRINN4 = 964800
        AVG_FRI_TRYGDEAVGIFT = 54650
        MAX_STFRADRAG = 40000
        MIN_ANV_MINSTE_FRADRAG = 3520
        MAX_ANV_MINSTE_FRADRAG = 88704
        MAX_ANV_MINSTE_FRADRAG_PENSJ = 74844
        MIN_MINSTE_FRADRAG = 4000
        MAX_MINSTE_FRADRAG = 100800
        LONNSFRADRAG = 31800
        ANV_LONNSFRADRAG = 27984
        MAX_SJO_FRADRAG = 80000

        PROSENT_TRINN1 = 1.9;
        PROSENT_TRINN2 = 4.2;
        PROSENT_TRINN3 = 13.2;
        PROSENT_TRINN3_FINNMARK = 11.2;
        PROSENT_TRINN4 = 16.2;
        FELLES_SKATT_VANLIG = 7.85;
        FELLES_SKATT_FINNMARK = 4.35;
        SKATTORE = 14.15;
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
