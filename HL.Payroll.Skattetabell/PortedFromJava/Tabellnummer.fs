﻿module internal Tabellnummer

open Tabelltype
open Konstanter

type Tabellnummer =
    {
        tabelltype:Tabelltype;
        tabellFradrag:int;
        klasseFradrag:int;
        trygdeavgiftstype:string;
        trekk_i_12_mnd:bool;
        overskytendeProsent:int;
        isStandardFradrag:bool;
        ikkeTrygdeavgift:bool;
        lavSatsTrygdeavgift:bool;
    }

let private isSF tabelltype = //isStandardFradrag
    match tabelltype with
    | Tabelltype.STANDARDFRADRAG 
    | Tabelltype.SJØ 
    | Tabelltype.FINNMARK -> true
    | _ -> false
    
let private ikkeTA trygdeavgiftstype = 
    trygdeavgiftstype.Equals("Ingen")

let private lavSatsTA trygdeavgiftstype = //lavSatsTrygdeavgift() 
    trygdeavgiftstype.Equals("Lav")
    

let private ctr // ConstructTabellnummerRecord 
    (tabelltype, tabellFradrag, 
      klasseFradrag, trygdeavgiftstype, 
      trekk_i_12_mnd, overskytendeProsent) =
    {
        tabelltype = tabelltype;
        tabellFradrag = int tabellFradrag;
        klasseFradrag = klasseFradrag;
        trygdeavgiftstype = trygdeavgiftstype;
        trekk_i_12_mnd = trekk_i_12_mnd;
        overskytendeProsent = overskytendeProsent;
        isStandardFradrag = isSF tabelltype;
        ikkeTrygdeavgift = ikkeTA trygdeavgiftstype;
        lavSatsTrygdeavgift = lavSatsTA trygdeavgiftstype;
    }
    |> Some

let InitializeTabellnummerData nr pensj konstanter = 
    match nr with
    | 7100 when not pensj -> ctr (Tabelltype.VANLIG, 0L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7101 when not pensj -> ctr (Tabelltype.VANLIG, 4000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7102 when not pensj -> ctr (Tabelltype.VANLIG, 8000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7103 when not pensj -> ctr (Tabelltype.VANLIG, 12000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7104 when not pensj -> ctr (Tabelltype.VANLIG, 16000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7105 when not pensj -> ctr (Tabelltype.VANLIG, 20000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7106 when not pensj -> ctr (Tabelltype.VANLIG, 24000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7107 when not pensj -> ctr (Tabelltype.VANLIG, 28000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7108 when not pensj -> ctr (Tabelltype.VANLIG, 32000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7109 when not pensj -> ctr (Tabelltype.VANLIG, 36000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7110 when not pensj -> ctr (Tabelltype.VANLIG, 41000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7111 when not pensj -> ctr (Tabelltype.VANLIG, 46000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7112 when not pensj -> ctr (Tabelltype.VANLIG, 53000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7113 when not pensj -> ctr (Tabelltype.VANLIG, 60000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7114 when not pensj -> ctr (Tabelltype.VANLIG, 70000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7115 when not pensj -> ctr (Tabelltype.VANLIG, 80000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7116 when not pensj -> ctr (Tabelltype.VANLIG, 90000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7117 when not pensj -> ctr (Tabelltype.VANLIG, 100000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7118 when not pensj -> ctr (Tabelltype.VANLIG, 110000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7119 when not pensj -> ctr (Tabelltype.VANLIG, 120000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7120 when not pensj -> ctr (Tabelltype.VANLIG, -4000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7121 when not pensj -> ctr (Tabelltype.VANLIG, -8000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7122 when not pensj -> ctr (Tabelltype.VANLIG, -12000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7123 when not pensj -> ctr (Tabelltype.VANLIG, -16000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7124 when not pensj -> ctr (Tabelltype.VANLIG, -20000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7125 when not pensj -> ctr (Tabelltype.VANLIG, -24000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7126 when not pensj -> ctr (Tabelltype.VANLIG, -28000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7127 when not pensj -> ctr (Tabelltype.VANLIG, -32000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7128 when not pensj -> ctr (Tabelltype.VANLIG, -36000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7129 when not pensj -> ctr (Tabelltype.VANLIG, -41000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7130 when not pensj -> ctr (Tabelltype.VANLIG, -46000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7131 when not pensj -> ctr (Tabelltype.VANLIG, -53000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7132 when not pensj -> ctr (Tabelltype.VANLIG, -60000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7133 when not pensj -> ctr (Tabelltype.VANLIG, -67000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);

    | 7200 when not pensj -> ctr (Tabelltype.VANLIG, 0L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7201 when not pensj -> ctr (Tabelltype.VANLIG, 4000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7202 when not pensj -> ctr (Tabelltype.VANLIG, 8000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7203 when not pensj -> ctr (Tabelltype.VANLIG, 12000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7204 when not pensj -> ctr (Tabelltype.VANLIG, 16000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7205 when not pensj -> ctr (Tabelltype.VANLIG, 20000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7206 when not pensj -> ctr (Tabelltype.VANLIG, 24000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7207 when not pensj -> ctr (Tabelltype.VANLIG, 28000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7208 when not pensj -> ctr (Tabelltype.VANLIG, 32000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7209 when not pensj -> ctr (Tabelltype.VANLIG, 36000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7210 when not pensj -> ctr (Tabelltype.VANLIG, 41000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7211 when not pensj -> ctr (Tabelltype.VANLIG, 46000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7212 when not pensj -> ctr (Tabelltype.VANLIG, 53000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7213 when not pensj -> ctr (Tabelltype.VANLIG, 60000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7214 when not pensj -> ctr (Tabelltype.VANLIG, 70000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7215 when not pensj -> ctr (Tabelltype.VANLIG, 80000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7216 when not pensj -> ctr (Tabelltype.VANLIG, 90000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7217 when not pensj -> ctr (Tabelltype.VANLIG, 100000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7218 when not pensj -> ctr (Tabelltype.VANLIG, 110000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7219 when not pensj -> ctr (Tabelltype.VANLIG, 120000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7220 when not pensj -> ctr (Tabelltype.VANLIG, -4000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7221 when not pensj -> ctr (Tabelltype.VANLIG, -8000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7222 when not pensj -> ctr (Tabelltype.VANLIG, -12000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7223 when not pensj -> ctr (Tabelltype.VANLIG, -16000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7224 when not pensj -> ctr (Tabelltype.VANLIG, -20000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7225 when not pensj -> ctr (Tabelltype.VANLIG, -24000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7226 when not pensj -> ctr (Tabelltype.VANLIG, -28000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7227 when not pensj -> ctr (Tabelltype.VANLIG, -32000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7228 when not pensj -> ctr (Tabelltype.VANLIG, -36000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7229 when not pensj -> ctr (Tabelltype.VANLIG, -41000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7230 when not pensj -> ctr (Tabelltype.VANLIG, -46000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7231 when not pensj -> ctr (Tabelltype.VANLIG, -53000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7232 when not pensj -> ctr (Tabelltype.VANLIG, -60000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7233 when not pensj -> ctr (Tabelltype.VANLIG, -67000L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);

    | 7100 -> ctr (Tabelltype.PENSJONIST, 0L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7101 -> ctr (Tabelltype.PENSJONIST, 4000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7102 -> ctr (Tabelltype.PENSJONIST, 8000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7103 -> ctr (Tabelltype.PENSJONIST, 12000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7104 -> ctr (Tabelltype.PENSJONIST, 16000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7105 -> ctr (Tabelltype.PENSJONIST, 20000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7106 -> ctr (Tabelltype.PENSJONIST, 24000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7107 -> ctr (Tabelltype.PENSJONIST, 28000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7108 -> ctr (Tabelltype.PENSJONIST, 32000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7109 -> ctr (Tabelltype.PENSJONIST, 36000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7110 -> ctr (Tabelltype.PENSJONIST, 41000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7111 -> ctr (Tabelltype.PENSJONIST, 46000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7112 -> ctr (Tabelltype.PENSJONIST, 53000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7113 -> ctr (Tabelltype.PENSJONIST, 60000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7114 -> ctr (Tabelltype.PENSJONIST, 70000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7115 -> ctr (Tabelltype.PENSJONIST, 80000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7116 -> ctr (Tabelltype.PENSJONIST, 90000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7117 -> ctr (Tabelltype.PENSJONIST, 100000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7118 -> ctr (Tabelltype.PENSJONIST, 110000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7119 -> ctr (Tabelltype.PENSJONIST, 120000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7120 -> ctr (Tabelltype.PENSJONIST, -4000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7121 -> ctr (Tabelltype.PENSJONIST, -8000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7122 -> ctr (Tabelltype.PENSJONIST, -12000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7123 -> ctr (Tabelltype.PENSJONIST, -16000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7124 -> ctr (Tabelltype.PENSJONIST, -20000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7125 -> ctr (Tabelltype.PENSJONIST, -24000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7126 -> ctr (Tabelltype.PENSJONIST, -28000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7127 -> ctr (Tabelltype.PENSJONIST, -32000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7128 -> ctr (Tabelltype.PENSJONIST, -36000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7129 -> ctr (Tabelltype.PENSJONIST, -41000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7130 -> ctr (Tabelltype.PENSJONIST, -46000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7131 -> ctr (Tabelltype.PENSJONIST, -53000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7132 -> ctr (Tabelltype.PENSJONIST, -60000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7133 -> ctr (Tabelltype.PENSJONIST, -67000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);

    | 7200 -> ctr (Tabelltype.PENSJONIST, 0L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7201 -> ctr (Tabelltype.PENSJONIST, 4000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7202 -> ctr (Tabelltype.PENSJONIST, 8000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7203 -> ctr (Tabelltype.PENSJONIST, 12000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7204 -> ctr (Tabelltype.PENSJONIST, 16000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7205 -> ctr (Tabelltype.PENSJONIST, 20000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7206 -> ctr (Tabelltype.PENSJONIST, 24000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7207 -> ctr (Tabelltype.PENSJONIST, 28000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7208 -> ctr (Tabelltype.PENSJONIST, 32000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7209 -> ctr (Tabelltype.PENSJONIST, 36000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7210 -> ctr (Tabelltype.PENSJONIST, 41000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7211 -> ctr (Tabelltype.PENSJONIST, 46000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7212 -> ctr (Tabelltype.PENSJONIST, 53000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7213 -> ctr (Tabelltype.PENSJONIST, 60000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7214 -> ctr (Tabelltype.PENSJONIST, 70000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7215 -> ctr (Tabelltype.PENSJONIST, 80000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7216 -> ctr (Tabelltype.PENSJONIST, 90000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7217 -> ctr (Tabelltype.PENSJONIST, 100000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7218 -> ctr (Tabelltype.PENSJONIST, 110000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7219 -> ctr (Tabelltype.PENSJONIST, 120000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7220 -> ctr (Tabelltype.PENSJONIST, -4000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7221 -> ctr (Tabelltype.PENSJONIST, -8000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7222 -> ctr (Tabelltype.PENSJONIST, -12000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7223 -> ctr (Tabelltype.PENSJONIST, -16000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7224 -> ctr (Tabelltype.PENSJONIST, -20000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7225 -> ctr (Tabelltype.PENSJONIST, -24000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7226 -> ctr (Tabelltype.PENSJONIST, -28000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7227 -> ctr (Tabelltype.PENSJONIST, -32000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7228 -> ctr (Tabelltype.PENSJONIST, -36000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7229 -> ctr (Tabelltype.PENSJONIST, -41000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7230 -> ctr (Tabelltype.PENSJONIST, -46000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7231 -> ctr (Tabelltype.PENSJONIST, -53000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7232 -> ctr (Tabelltype.PENSJONIST, -60000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7233 -> ctr (Tabelltype.PENSJONIST, -67000L, konstanter.KLASSE2_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);

    | 7300 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_7300_7400);
    | 7400 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE2_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_7300_7400);
    | 7350 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE1_VANLIG, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_7350_7450);
    | 7450 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE2_VANLIG, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_7350_7450);
    | 7500 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE1_VANLIG, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_7500_7600);
    | 7600 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE2_VANLIG, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_7500_7600);
    | 7550 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE1_VANLIG, "Ingen", false, konstanter.OVERSKYTENDE_PROSENT_7550_7650);
    | 7650 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE2_VANLIG, "Ingen", false, konstanter.OVERSKYTENDE_PROSENT_7550_7650);
    | 7700 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE1_VANLIG, "Lav", true, konstanter.OVERSKYTENDE_PROSENT_7700_7800);
    | 7800 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE2_VANLIG, "Lav", true, konstanter.OVERSKYTENDE_PROSENT_7700_7800);

    | 6300 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE1_FINNMARK, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_6300_6400);
    | 6400 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE2_FINNMARK, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_6300_6400);
    | 6350 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE1_FINNMARK, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_6350_6450);
    | 6450 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE2_FINNMARK, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_6350_6450);
    | 6500 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE1_FINNMARK, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_6500_6600);
    | 6600 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE2_FINNMARK, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_6500_6600);
    | 6550 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE1_FINNMARK, "Ingen", false, konstanter.OVERSKYTENDE_PROSENT_6550_6650);
    | 6650 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE2_FINNMARK, "Ingen", false, konstanter.OVERSKYTENDE_PROSENT_6550_6650);
    | 6700 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE1_FINNMARK, "Lav", true, konstanter.OVERSKYTENDE_PROSENT_6700_6800);
    | 6800 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE2_FINNMARK, "Lav", true, konstanter.OVERSKYTENDE_PROSENT_6700_6800);

    | 0100 -> ctr (Tabelltype.SJØ, 0L, konstanter.KLASSE1_VANLIG, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_0100_0200);
    | 0200 -> ctr (Tabelltype.SJØ, 0L, konstanter.KLASSE2_VANLIG, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_0100_0200);
    | 0101 -> ctr (Tabelltype.SJØ, 0L, konstanter.KLASSE1_VANLIG, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_0101_0201);
    | 0201 -> ctr (Tabelltype.SJØ, 0L, konstanter.KLASSE2_VANLIG, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_0101_0201);

    | 7150 -> ctr (Tabelltype.SPESIAL, 0L, konstanter.KLASSE1_VANLIG, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_7150_7250);
    | 7250 -> ctr (Tabelltype.SPESIAL, 0L, konstanter.KLASSE2_VANLIG, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_7150_7250);
    | 7160 -> ctr (Tabelltype.SPESIAL, 0L, konstanter.KLASSE1_VANLIG, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_7160_7260);
    | 7260 -> ctr (Tabelltype.SPESIAL, 0L, konstanter.KLASSE2_VANLIG, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_7160_7260);
    | 7170 -> ctr (Tabelltype.SPESIAL, 0L, konstanter.KLASSE1_VANLIG, "Ingen", false, konstanter.OVERSKYTENDE_PROSENT_7170_7270);
    | 7270 -> ctr (Tabelltype.SPESIAL, 0L, konstanter.KLASSE2_VANLIG, "Ingen", false, konstanter.OVERSKYTENDE_PROSENT_7170_7270);
    | _ -> None
