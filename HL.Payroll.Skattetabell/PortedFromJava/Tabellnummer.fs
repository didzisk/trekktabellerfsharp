module internal Tabellnummer

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
    

let ctr 
    (tabelltype, tabellFradrag:int64, 
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

