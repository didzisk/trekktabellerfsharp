module internal Skattetabell2014internal

open System

type TABELLTYPE =
    | VANLIG = 1
    | PENSJONIST = 2
    | STANDARD_FRADRAG = 3
    | SJO = 4   

type KLASSE = 
    | KLASSE1 = 1
    | KLASSE2 = 2

type TAB_TREKK_PERIODE =
    | MAANED = 1
    | ``14-DAGER`` = 2
    | UKE = 3
    | ``4-DAGER`` = 4
    | ``3-DAGER`` = 5
    | ``2-DAGER`` = 6           
    | ``1-DAG``   = 7

let ``MAX-TRK-GRLAG`` trekkperiode =
    match trekkperiode with 
    | 1 -> 79800M
    | 2 -> 36800M
    | 3 -> 18400M
    | 4 -> 15900M
    | 5 -> 11900M
    | 6 ->  7900M
    | 7 ->  3900M
    | _ -> 0M

let private ``ANT-INNT-PERIODER-VANLIG`` trekkperiode = 
    match trekkperiode with 
    | 1 ->  12.12M
    | 2 ->  26.26M
    | 3 ->  52.52M
    | 4 ->  60.60M
    | 5 ->  80.80M
    | 6 -> 121.20M
    | 7 -> 242.40M
    | _ -> 0M

let private ``ANT-TRK-PERIODER-VANLIG`` trekkperiode =
    match trekkperiode with 
    | 1 -> 10.5M
    | 2 -> 23.0M
    | 3 -> 46.0M
    | 4 -> Math.Round ((60M * 46M) / 52M, 7)
    | 5 -> Math.Round ((80M * 46M) / 52M, 7)
    | 6 -> Math.Round ((120M * 46M) / 52M, 7)
    | 7 -> Math.Round ((240M * 46M) / 52M, 7)
    | _ -> 10.5M

let private ``ANT-INNT-PERIODER-PENSJONIST`` trekkperiode = 
    match trekkperiode with 
    | 1 ->  12M
    | 2 ->  26M
    | 3 ->  52M
    | 4 ->  91M
    | 5 -> 122M
    | 6 -> 183M
    | 7 -> 365M
    | _ -> 0M

let private ``ANT-TRK-PERIODER-PENSJONIST`` trekkperiode =
    match trekkperiode with 
    | 1 -> 11M
    | 2 -> 24M
    | 3 -> 48M
    | 4 -> Math.Round ( (91M * 11M) / 12M, 7)
    | 5 -> Math.Round ((122M * 11M) / 12M, 7)
    | 6 -> Math.Round ((183M * 11M) / 12M, 7)
    | 7 -> Math.Round ((365M * 11M) / 12M, 7)
    | _ -> 11M

let private ``ANT-INNT-PERIODER-STFRADRAG`` trekkperiode = 
    match trekkperiode with 
    | 1 ->  12M
    | 2 ->  26M
    | 3 ->  52M
    | 4 ->  91M
    | 5 -> 122M
    | 6 -> 183M
    | 7 -> 365M
    | _ -> 0M

let ``ANT-TRK-PERIODER-STFRADRAG`` trekkperiode =
    match trekkperiode with 
    | 1 -> 10.5M
    | 2 -> 23.0M
    | 3 -> 46.0M
    | 4 -> Math.Round ((91M * 10.5M) / 12M, 7)
    | 5 -> Math.Round ((122M * 10.5M) / 12M, 7)
    | 6 -> Math.Round ((183M * 10.5M) / 12M, 7)
    | 7 -> Math.Round ((365M * 10.5M) / 12M, 7)
    | _ -> 10.5M

let private ``ANT-INNT-PERIODER-SJO`` trekkperiode = 
    match trekkperiode with 
    | 1 ->  12M
    | 2 ->  26M
    | 3 ->  52M
    | _ ->  0M

let private ``ANT-TRK-PERIODER-SJO`` trekkperiode = 
    match trekkperiode with 
    | 1 ->  12M
    | 2 ->  26M
    | 3 ->  52M
    | _ ->  0M

        (*-----------------------------------------------------------------
        * KLASSE-FRADRAG
        *-----------------------------------------------------------------*)
let ``WS-KLASSE-FRADRAG`` klasseSkatteProsent =
    let ``KLASSE1-VANLIG``   = 48800M
    let ``KLASSE2-VANLIG``   = 72000M
    let ``KLASSE1-FINNMARK`` = 63800M
    let ``KLASSE2-FINNMARK`` = 87000M
    match klasseSkatteProsent with
    | (KLASSE.KLASSE1, 6) -> ``KLASSE1-FINNMARK``
    | (KLASSE.KLASSE2, 6) -> ``KLASSE2-FINNMARK``
    | (KLASSE.KLASSE1, _) -> ``KLASSE1-VANLIG``
    | (_)   -> ``KLASSE2-VANLIG``

        (*-----------------------------------------------------------------
        * TABELL FOR PROSENT PÅ TOPPSKATT
        *-----------------------------------------------------------------*)
let ``TOPPSKATT-PROSENT`` levelSkatteProsent = 
    match levelSkatteProsent with
    | (2, _)     -> 12.0M
    | (1, 6)     ->  7.0M
    | (1, _) | _ ->  9.0M
  
let ``TOPPSKATT-LAV`` klasse = 
    match klasse with
    | KLASSE.KLASSE1     -> 527400M
    | KLASSE.KLASSE2 | _ -> 527400M

let ``TOPPSKATT-HOY`` klasse = 
    match klasse with
    | KLASSE.KLASSE1     -> 857300M
    | KLASSE.KLASSE2 | _ -> 857300M

(*-----------------------------------------------------------------
    * STANDARDFRADRAG
    *-----------------------------------------------------------------*)
let ``STFRADRAG-PROSENT`` = 10M
let ``MAX-STFRADRAG``     = 40000M

(*-----------------------------------------------------------------
    * ANVENDT MINSTEFRADRAG
    *-----------------------------------------------------------------*)
let ``ANV-MINSTE-FRAD-PROSENT``       = 37.84M
let ``ANV-MINSTE-FRAD-PROSENT-PENSJ`` = 23.76M
let ``MIN-ANV-MINSTE-FRADRAG``        = 3520M
let ``MAX-ANV-MINSTE-FRADRAG``        = 74052M
let ``MAX-ANV-MINSTE-FRADRAG-PENSJ``  = 61952M
(*-----------------------------------------------------------------
    * MINSTEFRADRAG
    *-----------------------------------------------------------------*)
let ``MINSTE-FRAD-PROSENT``      = 43M
let ``MIN-MINSTE-FRADRAG``       = 4000M
let ``MAX-MINSTE-FRADRAG``       = 84150M
(*-----------------------------------------------------------------
    * LØNNSFRADRAG
    *-----------------------------------------------------------------*)
let ``LONNSFRADRAG``           = 31800M
let ``ANV-LONNSFRADRAG``       = 27984M
(*-----------------------------------------------------------------
    * SJØ-FRADRAG
    *-----------------------------------------------------------------*)
let ``SJO-PROSENT``           = 30M
let ``MAX-SJO-FRADRAG``       = 80000M

type TabellNummerFields = 
    {
        ``WS-SKATTE-PROSENT``:int;
        ``WS-TABELL-TYPE``:int;
        ``WS-TABELL-NR``:int;
    }

let ``WS-TABELL-NUMMER`` wsTabellNummer=
    {
        ``WS-SKATTE-PROSENT`` = wsTabellNummer / 1000;
        ``WS-TABELL-TYPE`` = wsTabellNummer % 1000 / 100;
        ``WS-TABELL-NR`` = wsTabellNummer % 100
    }
(*-----------------------------------------------------------------
    * KOMMUNE/FYLKE - OG FELLES-SKATT
    *-----------------------------------------------------------------*)
let ``FELLES-SKATT-VANLIG``   = 12.95M
let ``FELLES-SKATT-FINNMARK`` =  9.45M
let SKATTORE                  = 14.05M

(*-----------------------------------------------------------------
    * BEREGNER GRENSER FOR TRYGDEAVGIFTEN. MÅ ENDRES HVIS TRYGDE-
    * AVGIFTS-PROSENTEN/GRENSEN ENDRES.
    * FORMEL:
    *(AARS-INNTEKT - AVG-FRI-TRYGDEAVGIFT) * 0.25 = AARS-INNTEKT
    *                                           * TRYGDEAVGIFT-PROSENT
    * DET VIL ALTSÅ SI:
    *     (X - 39600) * 0.25 = X * 0.082(ELLER 0.051 VED LAV)
    *                      X = 58929 (VED HØY TRYGDEAVGIFT)
    *                      X = 49749 (VED LAV TRYGDEAVGIFT)
    *-----------------------------------------------------------------*)
let ``LAV-GRENSE-TRYGDEAVGIFT`` = 49749M
let ``HOY-GRENSE-TRYGDEAVGIFT`` = 58929M
let ``TRYGDE-PROSENT``          = 25M
let ``LAV-TRYGDEAVG-PROSENT``   = 5.1M
let ``HOY-TRYGDEAVG-PROSENT``   = 8.2M
let ``AVG-FRI-TRYGDEAVGIFT``    = 39600M

type InterneVerdier =
    {
        tabellnummer:int;
        tabelltype:TABELLTYPE;
        trekkperiode:int;
        ``WS-TREKK-GRLAG``:decimal;
        antTrekkPerioder:decimal;
        antInntektsPerioder:decimal;
        KLASSE:KLASSE;
        ``MAX-TREKK-GRUNNLAG``:decimal;
        ``OVERSKYTENDE-TREKK``:decimal;
        tfields:TabellNummerFields;
        ``WS-TRGRL-AVRUNDET``:decimal;
        ``AARS-INNTEKT``:decimal;
        ``ANV-MINSTE-FRADRAG``:decimal;
        ``MINSTE-FRADRAG``:decimal;
        ``SKATTBAR-INNTEKT``:decimal;
        ``KOMMUNE-SKATT``:decimal;
        ``FELLES-SKATT``:decimal;
        ``TRYGDE-AVGIFT``:decimal;
        ``SUM-TOPP-SKATT``:decimal;
    }

let ``B-BEREGN-OVERSKYTENDE-TREKK`` interne:InterneVerdier = 
    let ``OVERSKYTENDE-PROSENT``=
        match interne.tabellnummer with
        | 7300 | 7400 -> 0.54M
        | 7350 | 7450 -> 0.47M
        | 7500 | 7600 -> 0.39M
        | 7550 | 7650 -> 0.45M
        | 7700 | 7800 -> 0.44M
        | 0100 | 0200 -> 0.39M
        | 0101 | 0201 -> 0.47M
        | 6300 | 6400 -> 0.50M
        | 6350 | 6450 -> 0.44M
        | 6500 | 6600 -> 0.36M
        | 6550 | 6650 -> 0.41M
        | 6700 | 6800 -> 0.41M
        | 7150 | 7250 -> 0.47M
        | 7160 | 7260 -> 0.39M
        | 7170 | 7270 -> 0.45M
        | _ when interne.tabelltype = TABELLTYPE.PENSJONIST -> 0.48M
        | _ -> 0.54M //WHEN VANLIG
    let delekonstant = 
        match enum<TAB_TREKK_PERIODE> interne.trekkperiode with 
        | TAB_TREKK_PERIODE.MAANED -> 100M
        | TAB_TREKK_PERIODE.``14-DAGER`` -> 50M
        | _ -> 20M
    let avrundetTrekkgrunnlag=Math.Truncate interne.``WS-TREKK-GRLAG``/delekonstant * delekonstant

    if avrundetTrekkgrunnlag>interne.``MAX-TREKK-GRUNNLAG`` then
        { 
            interne with
                ``WS-TREKK-GRLAG``=interne.``MAX-TREKK-GRUNNLAG``;
                ``OVERSKYTENDE-TREKK``=
                    (avrundetTrekkgrunnlag - interne.``MAX-TREKK-GRUNNLAG``) *
                    ``OVERSKYTENDE-PROSENT``
        }
    else
        interne


let ``B-SETT-VERDIER-VANLIG`` interne = 
    let klasse = enum<KLASSE> interne.tfields.``WS-TABELL-TYPE``             
    let maxTrekkGrunnlag = ``MAX-TRK-GRLAG`` interne.trekkperiode
    let antInntektsPerioder =
        match interne.tfields.``WS-TABELL-NR`` with
        | 50 | 60 | 70 -> ``ANT-INNT-PERIODER-STFRADRAG`` interne.trekkperiode
        | _ -> ``ANT-INNT-PERIODER-VANLIG`` interne.trekkperiode
    let antTrekkPerioder =
        match interne.tfields.``WS-TABELL-NR`` with
        | 50 | 60 -> ``ANT-INNT-PERIODER-STFRADRAG`` interne.trekkperiode
        | 70 -> ``ANT-TRK-PERIODER-STFRADRAG`` interne.trekkperiode
        | _ -> ``ANT-TRK-PERIODER-VANLIG`` interne.trekkperiode
    {
        interne with
            KLASSE=klasse;
            ``MAX-TREKK-GRUNNLAG``=decimal maxTrekkGrunnlag;
            antInntektsPerioder = antInntektsPerioder;
            antTrekkPerioder = antTrekkPerioder;
    }
    |> ``B-BEREGN-OVERSKYTENDE-TREKK``

let ``B-SETT-VERDIER-PENSJONIST`` interne =

    let klasse = enum<KLASSE> interne.tfields.``WS-TABELL-TYPE``             
    let maxTrekkGrunnlag = ``MAX-TRK-GRLAG`` interne.trekkperiode
    let antInntektsPerioder =
        ``ANT-INNT-PERIODER-PENSJONIST`` interne.trekkperiode
    let antTrekkPerioder =
        ``ANT-TRK-PERIODER-PENSJONIST`` interne.trekkperiode
    {
        interne with
            KLASSE=klasse;
            ``MAX-TREKK-GRUNNLAG``=decimal maxTrekkGrunnlag;
            antInntektsPerioder = antInntektsPerioder;
            antTrekkPerioder = antTrekkPerioder;
    }
    |> ``B-BEREGN-OVERSKYTENDE-TREKK``

let ``B-SETT-VERDIER-STFRADRAG`` interne =
    let klasse = 
        match interne.tfields.``WS-TABELL-TYPE`` with
        | 3 | 5 | 7 -> KLASSE.KLASSE1
        | _ -> KLASSE.KLASSE2
    let maxTrekkGrunnlag = ``MAX-TRK-GRLAG`` interne.trekkperiode
    let antInntektsPerioder =
        ``ANT-INNT-PERIODER-STFRADRAG`` interne.trekkperiode
    let antTrekkPerioder =
        match interne.tabellnummer with
        | 7350 | 7450 | 7500 | 7600 | 7700 | 7800
        | 6350 | 6450 | 6500 | 6600 | 6700 | 6800 -> ``ANT-INNT-PERIODER-STFRADRAG`` interne.trekkperiode
        | _ -> ``ANT-TRK-PERIODER-STFRADRAG`` interne.trekkperiode
    {
        interne with
            KLASSE=klasse;
            ``MAX-TREKK-GRUNNLAG``=decimal maxTrekkGrunnlag;
            antInntektsPerioder = antInntektsPerioder;
            antTrekkPerioder = antTrekkPerioder;
    }
    |> ``B-BEREGN-OVERSKYTENDE-TREKK``

let ``B-SETT-VERDIER-SJO`` interne =
    let klasse = 
        match interne.tfields.``WS-TABELL-TYPE`` with
        | 1 -> KLASSE.KLASSE1
        | _ -> KLASSE.KLASSE2
    let maxTrekkGrunnlag = ``MAX-TRK-GRLAG`` interne.trekkperiode
    let antInntektsPerioder =
        ``ANT-INNT-PERIODER-SJO`` interne.trekkperiode
    let antTrekkPerioder =
        ``ANT-TRK-PERIODER-SJO`` interne.trekkperiode
    {
        interne with
            KLASSE=klasse;
            ``MAX-TREKK-GRUNNLAG``=decimal maxTrekkGrunnlag;
            antInntektsPerioder = antInntektsPerioder;
            antTrekkPerioder = antTrekkPerioder;
    }
    |> ``B-BEREGN-OVERSKYTENDE-TREKK``

    
(*


      *************************************** 0100 - 0201 **************
       B-SETT-VERDIER-SJO SECTION.
      ******************************************************************

 
           MOVE ANT-INNT-PERIODER-SJO (WS-TAB-TREKK-PERIODE)
                TO ANT-INNTEKTS-PERIODER
           MOVE ANT-TRK-PERIODER-SJO (WS-TAB-TREKK-PERIODE)
                TO ANT-TREKK-PERIODER

           IF WS-TREKK-GRLAG > MAX-TREKK-GRUNNLAG
              PERFORM B-BEREGN-OVERSKYTENDE-TREKK
           END-IF.

*)
let ``B-AVRUNDING`` interne = 
    let avrInterne=
        match enum<TAB_TREKK_PERIODE> interne.trekkperiode with
        | TAB_TREKK_PERIODE.MAANED ->
            {
                interne with 
                    ``WS-TREKK-GRLAG`` = Math.Truncate (interne.``WS-TREKK-GRLAG`` / 100M) * 100M + 50M;
                    ``WS-TRGRL-AVRUNDET`` = Math.Truncate (interne.``WS-TREKK-GRLAG`` / 100M) * 100M;
            }
        | TAB_TREKK_PERIODE.``14-DAGER`` ->
            {
                interne with 
                    ``WS-TREKK-GRLAG`` = Math.Truncate (interne.``WS-TREKK-GRLAG`` / 50M) * 50M + 25M;
                    ``WS-TRGRL-AVRUNDET`` = Math.Truncate (interne.``WS-TREKK-GRLAG`` / 50M) * 50M;
            }
        | _ ->
            {
                interne with 
                    ``WS-TREKK-GRLAG`` = Math.Truncate (interne.``WS-TREKK-GRLAG`` / 20M) * 20M + 10M;
                    ``WS-TRGRL-AVRUNDET`` = Math.Truncate (interne.``WS-TREKK-GRLAG`` / 20M) * 20M;
            }
    { avrInterne with ``AARS-INNTEKT`` = avrInterne.``WS-TREKK-GRLAG`` * avrInterne.antInntektsPerioder}

let EnsureWithinLimits l1 l2 value =
    let lowLimit = min l1 l2
    let highLimit = max l1 l2
    if value < lowLimit then
        lowLimit
    else
        if value > highLimit then
            highLimit
        else
            value

let (|LT|_|) limit i =
    if i<limit then 
        Some(i)
    else 
        None

let (|BETWEEN|_|) low high i =
    if i>low && i<high then
        Some(i)
    else
        None

let ``B-BEREGN-FRADRAG`` interne =
    let interneWithMinstefradrag=
        match interne.tabelltype with
        | TABELLTYPE.VANLIG | TABELLTYPE.STANDARD_FRADRAG
            (******************************************************************
            *  BEREGNER MINSTEFRADRAG
            *  FOR VANLIG OG STANDARD-FRADRAG TABELLER
            *  HER BRUKES ANVENDT MINSTEFRADRAG
            *-----------------------------------------------------------------*)
            -> 
                let ws_lonnsfradrag =
                   interne.``AARS-INNTEKT``
                   |> EnsureWithinLimits 0M ``ANV-LONNSFRADRAG``

                let anv_minste_fradrag = 
                   interne.``AARS-INNTEKT`` * ``ANV-MINSTE-FRAD-PROSENT`` / 100M
                   |> EnsureWithinLimits ``MIN-ANV-MINSTE-FRADRAG````MAX-ANV-MINSTE-FRADRAG`` 
                   |> max ws_lonnsfradrag
                   |> EnsureWithinLimits 0M interne.``AARS-INNTEKT``

                { interne with
                    ``ANV-MINSTE-FRADRAG`` = anv_minste_fradrag;
                }
           
        | TABELLTYPE.PENSJONIST 
            (******************************************************************
            *  BEREGNER MINSTEFRADRAG
            *  FOR PENSJONIST- TABELLER
            *  HER BRUKES ANVENDT MINSTEFRADRAG
            *-----------------------------------------------------------------*)
            ->  { interne with
                    ``ANV-MINSTE-FRADRAG`` = 
                        interne.``AARS-INNTEKT`` * ``ANV-MINSTE-FRAD-PROSENT-PENSJ`` / 100M
                        |> EnsureWithinLimits ``MIN-ANV-MINSTE-FRADRAG`` ``MAX-ANV-MINSTE-FRADRAG-PENSJ``
                }


        | TABELLTYPE.SJO 
            (*-----------------------------------------------------------------
            *  BEREGNER MINSTEFRADRAG
            *  FOR SJØ-TABELLER
            *  HER BRUKES REELT MINSTEFRADRAG
            *-----------------------------------------------------------------*)
            ->  let ws_lonnsfradrag =
                    interne.``AARS-INNTEKT``
                    |> EnsureWithinLimits 0M LONNSFRADRAG
                let minstefradrag =
                    (interne.``AARS-INNTEKT`` * ``MINSTE-FRAD-PROSENT``) / 100M
                    |> EnsureWithinLimits ``MIN-MINSTE-FRADRAG`` ``MAX-MINSTE-FRADRAG``
                    |> EnsureWithinLimits interne.``AARS-INNTEKT`` ws_lonnsfradrag
                { interne with
                    ``MINSTE-FRADRAG``=minstefradrag;
                }
        | _ -> interne

        (**-----------------------------------------------------------------
        * BEREGNER DET FRADRAG/TILLEGG I INNTEKTEN MAN SKAL TA HENSYN
        * TIL VED BEREGNING AV FORSKUDDSTREKK.
        * DETTE BEREGNES BARE FOR VANLIGE OG PENSJONIST-TABELLER.
        * STANDARDFRADRAG- OG SJØ-TABELLENE HAR IKKE SLIKT FRADRAG.
        *-----------------------------------------------------------------*)

    let FRADRAG =
        match interneWithMinstefradrag.tabelltype with
        | TABELLTYPE.VANLIG 
        | TABELLTYPE.PENSJONIST ->
            match interneWithMinstefradrag.tfields.``WS-TABELL-NR`` with
            | LT 10 x -> decimal x * 4000M
            | 10 -> 41000M
            | 11 -> 46000M
            | 12 -> 53000M
            | BETWEEN 12 20 x -> decimal (x-7)*10000M
            | BETWEEN 19 29 x -> decimal -(x-19)*4000M
            | 29 -> -41000M
            | 30 -> -46000M
            | 31 -> -53000M
            | 32 -> -60000M
            | 33 -> -67000M
            | _ -> 0M
        | _ -> 0M
        (*-----------------------------------------------------------------
        * BEREGNER STANDARDFRADRAG
        *-----------------------------------------------------------------*)
    let ``ST-FRADRAG``=
        match interneWithMinstefradrag.tabelltype with
            | TABELLTYPE.SJO
            | TABELLTYPE.STANDARD_FRADRAG -> (interneWithMinstefradrag.``AARS-INNTEKT`` * ``STFRADRAG-PROSENT``) / 100M
            | _ -> 0M
        |> EnsureWithinLimits 0M ``MAX-STFRADRAG``
        (*-----------------------------------------------------------------
        * BEREGNER SJOMANNS-FRADRAG
        *-----------------------------------------------------------------*)
    let ``SJO-FRADRAG``=
        match interneWithMinstefradrag.tabelltype with
            | TABELLTYPE.SJO -> (interneWithMinstefradrag.``AARS-INNTEKT`` * ``SJO-PROSENT``) / 100M
            | _ -> 0M
        |> EnsureWithinLimits 0M ``MAX-SJO-FRADRAG``
        (*-----------------------------------------------------------------
        * BEREGNER KLASSEFRADRAG
        *-----------------------------------------------------------------*)
    let ``KLASSE-FRADRAG`` = 
        ``WS-KLASSE-FRADRAG``(interneWithMinstefradrag.KLASSE, interneWithMinstefradrag.tfields.``WS-SKATTE-PROSENT``)

    {interneWithMinstefradrag with
        ``SKATTBAR-INNTEKT`` = interneWithMinstefradrag.``AARS-INNTEKT``
                                - interneWithMinstefradrag.``ANV-MINSTE-FRADRAG``
                                - interneWithMinstefradrag.``MINSTE-FRADRAG``
                                - FRADRAG
                                - ``ST-FRADRAG``
                                - ``SJO-FRADRAG``
                                - ``KLASSE-FRADRAG``
    }

let ``B-BEREGN-NETTOSKATT`` interne =
        let ``FELLES-SKATT-PROSENT`` = 
            match interne.tfields.``WS-SKATTE-PROSENT`` with
            | 6 -> ``FELLES-SKATT-FINNMARK``
            | _ -> ``FELLES-SKATT-VANLIG``
        (*-----------------------------------------------------------------
        * HVIS SKATTBAR-INNTEKT ER NEGATIV, SKAL DET IKKE BEREGNES
        * KOMMUNE- OG FELLES-SKATT.
        *-----------------------------------------------------------------*)
        match interne.``SKATTBAR-INNTEKT`` with
        | LT 0M x -> interne
        | _ -> {interne with
                    ``KOMMUNE-SKATT`` =
                        interne.``SKATTBAR-INNTEKT`` * ``SKATTORE`` / 100M;
                    ``FELLES-SKATT`` =
                        interne.``SKATTBAR-INNTEKT`` * ``FELLES-SKATT-PROSENT`` / 100M;
                }

let ``B-BEREGN-TRYGDEAVGIFT`` interne =
        (*-----------------------------------------------------------------
        * LUKER UT DE FOREKOMSTENE HVOR DET IKKE SKAL BETALES TRYGDEAVGIFT
        *-----------------------------------------------------------------*)
    match interne.tabellnummer, interne.tabelltype with
    | 7500, _ | 7550, _ | 7600, _ | 7650, _ | 0100, _ | 0200, _
    | 6500, _ | 6550, _ | 6600, _ | 6650, _
    | 7160, _ | 7170, _ | 7260, _ | 7270, _ -> interne
    | _ when interne.``AARS-INNTEKT`` < ``AVG-FRI-TRYGDEAVGIFT`` -> interne
        (*-----------------------------------------------------------------
        * BEREGNER DE MED LAV FOLKETRYGD
        *-----------------------------------------------------------------*)
    | 7700, _ | 7800, _ | 6700, _ | 6800, _  
    | _, TABELLTYPE.PENSJONIST ->
        if interne.``AARS-INNTEKT`` > ``LAV-GRENSE-TRYGDEAVGIFT`` then
            {interne with
                ``TRYGDE-AVGIFT`` =
                    (interne.``AARS-INNTEKT`` * ``LAV-TRYGDEAVG-PROSENT``) / 100M
            }
        else
            {interne with
                ``TRYGDE-AVGIFT`` =
                    (interne.``AARS-INNTEKT`` - ``AVG-FRI-TRYGDEAVGIFT``) *
                    ``TRYGDE-PROSENT`` / 100M
            }
        (*-----------------------------------------------------------------
        * BEREGNER DE MED HØY FOLKETRYGD
        *-----------------------------------------------------------------*)
    | _ ->
        if interne.``AARS-INNTEKT`` > ``HOY-GRENSE-TRYGDEAVGIFT`` then
            {interne with
                ``TRYGDE-AVGIFT`` =
                    (interne.``AARS-INNTEKT`` * ``HOY-TRYGDEAVG-PROSENT``) / 100M
            }
        else
            {interne with
                ``TRYGDE-AVGIFT`` =
                    (interne.``AARS-INNTEKT`` - ``AVG-FRI-TRYGDEAVGIFT``) *
                    ``TRYGDE-PROSENT`` / 100M
            }

let ``B-BEREGN-TOPPSKATT`` interne:InterneVerdier = 
    let ``TOPP-SKATT-TRINN1`` = 
        if interne.``AARS-INNTEKT`` > ``TOPPSKATT-LAV`` interne.KLASSE then
            if interne.``AARS-INNTEKT``<``TOPPSKATT-HOY`` interne.KLASSE then
                (interne.``AARS-INNTEKT`` - ``TOPPSKATT-LAV`` interne.KLASSE) *
                ``TOPPSKATT-PROSENT`` (1, interne.tfields.``WS-SKATTE-PROSENT``) / 100M
            else
                (``TOPPSKATT-HOY`` interne.KLASSE - ``TOPPSKATT-LAV`` interne.KLASSE) *
                ``TOPPSKATT-PROSENT`` (1, interne.tfields.``WS-SKATTE-PROSENT``) / 100M
        else 
            0M
    let ``TOPP-SKATT-TRINN2`` =
        if interne.``AARS-INNTEKT``> ``TOPPSKATT-HOY`` interne.KLASSE then
            (interne.``AARS-INNTEKT`` - ``TOPPSKATT-HOY`` interne.KLASSE) *
            ``TOPPSKATT-PROSENT`` (2, interne.tfields.``WS-SKATTE-PROSENT``) / 100M
        else 
            0M
    {interne with
            ``SUM-TOPP-SKATT`` = ``TOPP-SKATT-TRINN1``
                                + ``TOPP-SKATT-TRINN2``
    }

let ``B-BEREGN-TREKK`` interne =
    let ``SUM-TREKK`` = interne.``KOMMUNE-SKATT``
                                + interne.``FELLES-SKATT``
                                + interne.``TRYGDE-AVGIFT``
                                + interne.``SUM-TOPP-SKATT``
    let trekk=
        if interne.tabelltype=TABELLTYPE.SJO then
            (``SUM-TREKK`` / interne.antTrekkPerioder)
        else
            Math.Round (``SUM-TREKK`` / interne.antTrekkPerioder, MidpointRounding.AwayFromZero)
        |> EnsureWithinLimits 0M interne.``WS-TRGRL-AVRUNDET``
    trekk + interne.``OVERSKYTENDE-TREKK``

let beregnForskuddstrekkInternal trekkgrunnlag tabellnummer pensjonist (tabbtrekkperiode:int) =

    let tfields = ``WS-TABELL-NUMMER`` tabellnummer

    let tabelltype =
        match tfields.``WS-TABELL-TYPE`` with
        | _ when tfields.``WS-SKATTE-PROSENT``=0 -> TABELLTYPE.SJO
        | _ when pensjonist -> TABELLTYPE.PENSJONIST
        | a when a < 3 -> TABELLTYPE.VANLIG
        | _ -> TABELLTYPE.STANDARD_FRADRAG

    let interne:InterneVerdier =
        {
            tabellnummer=tabellnummer;
            tabelltype=tabelltype;
            trekkperiode=tabbtrekkperiode;
            ``WS-TREKK-GRLAG``=trekkgrunnlag;
            antTrekkPerioder=0M;
            antInntektsPerioder=0M;
            KLASSE = KLASSE.KLASSE1;
            ``MAX-TREKK-GRUNNLAG``=0M;
            ``OVERSKYTENDE-TREKK``=0M;
            tfields=tfields;
            ``WS-TRGRL-AVRUNDET``=0M;
            ``AARS-INNTEKT``=0M;
            ``ANV-MINSTE-FRADRAG``=0M;
            ``MINSTE-FRADRAG``=0M;
            ``SKATTBAR-INNTEKT``=0M;
            ``KOMMUNE-SKATT``=0M;
            ``FELLES-SKATT``=0M;
            ``TRYGDE-AVGIFT``=0M;
            ``SUM-TOPP-SKATT``=0M;
        }

    interne
    |> fun x ->
        match x.tabelltype with
        | TABELLTYPE.VANLIG -> ``B-SETT-VERDIER-VANLIG`` x
        | TABELLTYPE.PENSJONIST -> ``B-SETT-VERDIER-PENSJONIST`` x
        | TABELLTYPE.STANDARD_FRADRAG -> ``B-SETT-VERDIER-STFRADRAG`` x
        | TABELLTYPE.SJO -> ``B-SETT-VERDIER-SJO`` x
        | _ -> x
    |> ``B-AVRUNDING``
    |> ``B-BEREGN-FRADRAG``
    |> ``B-BEREGN-NETTOSKATT``
    |> ``B-BEREGN-TRYGDEAVGIFT``
    |> ``B-BEREGN-TOPPSKATT``
    |> ``B-BEREGN-TREKK``
    |> int