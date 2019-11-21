module internal Tabellnummer2020
open Tabellnummer
open Konstanter

let InitializeTabellnummerData nr pensj konstanter = 
    match nr with
    | 7100 when not pensj -> ctr (Tabelltype.VANLIG, 0L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7101 when not pensj -> ctr (Tabelltype.VANLIG, 10000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7102 when not pensj -> ctr (Tabelltype.VANLIG, 20000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7103 when not pensj -> ctr (Tabelltype.VANLIG, 30000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7104 when not pensj -> ctr (Tabelltype.VANLIG, 40000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7105 when not pensj -> ctr (Tabelltype.VANLIG, 50000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7106 when not pensj -> ctr (Tabelltype.VANLIG, 60000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7107 when not pensj -> ctr (Tabelltype.VANLIG, 70000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7108 when not pensj -> ctr (Tabelltype.VANLIG, 80000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7109 when not pensj -> ctr (Tabelltype.VANLIG, 90000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7110 when not pensj -> ctr (Tabelltype.VANLIG, 100000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7111 when not pensj -> ctr (Tabelltype.VANLIG, 110000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7112 when not pensj -> ctr (Tabelltype.VANLIG, 120000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7113 when not pensj -> ctr (Tabelltype.VANLIG, 130000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7114 when not pensj -> ctr (Tabelltype.VANLIG, 140000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7115 when not pensj -> ctr (Tabelltype.VANLIG, 150000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7116 when not pensj -> ctr (Tabelltype.VANLIG, 160000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7117 when not pensj -> ctr (Tabelltype.VANLIG, 170000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7118 when not pensj -> ctr (Tabelltype.VANLIG, 180000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7119 when not pensj -> ctr (Tabelltype.VANLIG, 190000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7120 when not pensj -> ctr (Tabelltype.VANLIG, -10000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7121 when not pensj -> ctr (Tabelltype.VANLIG, -20000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7122 when not pensj -> ctr (Tabelltype.VANLIG, -30000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7123 when not pensj -> ctr (Tabelltype.VANLIG, -40000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7124 when not pensj -> ctr (Tabelltype.VANLIG, -50000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7125 when not pensj -> ctr (Tabelltype.VANLIG, -60000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7126 when not pensj -> ctr (Tabelltype.VANLIG, -70000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7127 when not pensj -> ctr (Tabelltype.VANLIG, -80000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7128 when not pensj -> ctr (Tabelltype.VANLIG, -90000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7129 when not pensj -> ctr (Tabelltype.VANLIG, -100000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7130 when not pensj -> ctr (Tabelltype.VANLIG, -110000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7131 when not pensj -> ctr (Tabelltype.VANLIG, -120000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7132 when not pensj -> ctr (Tabelltype.VANLIG, -130000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);
    | 7133 when not pensj -> ctr (Tabelltype.VANLIG, -140000L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_VANLIG);


    | 7100 -> ctr (Tabelltype.PENSJONIST, 0L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7101 -> ctr (Tabelltype.PENSJONIST, 10000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7102 -> ctr (Tabelltype.PENSJONIST, 20000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7103 -> ctr (Tabelltype.PENSJONIST, 30000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7104 -> ctr (Tabelltype.PENSJONIST, 40000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7105 -> ctr (Tabelltype.PENSJONIST, 50000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7106 -> ctr (Tabelltype.PENSJONIST, 60000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7107 -> ctr (Tabelltype.PENSJONIST, 70000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7108 -> ctr (Tabelltype.PENSJONIST, 80000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7109 -> ctr (Tabelltype.PENSJONIST, 90000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7110 -> ctr (Tabelltype.PENSJONIST, 100000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7111 -> ctr (Tabelltype.PENSJONIST, 110000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7112 -> ctr (Tabelltype.PENSJONIST, 120000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7113 -> ctr (Tabelltype.PENSJONIST, 130000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7114 -> ctr (Tabelltype.PENSJONIST, 140000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7115 -> ctr (Tabelltype.PENSJONIST, 150000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7116 -> ctr (Tabelltype.PENSJONIST, 160000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7117 -> ctr (Tabelltype.PENSJONIST, 170000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7118 -> ctr (Tabelltype.PENSJONIST, 180000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7119 -> ctr (Tabelltype.PENSJONIST, 190000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7120 -> ctr (Tabelltype.PENSJONIST, -10000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7121 -> ctr (Tabelltype.PENSJONIST, -20000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7122 -> ctr (Tabelltype.PENSJONIST, -30000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7123 -> ctr (Tabelltype.PENSJONIST, -40000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7124 -> ctr (Tabelltype.PENSJONIST, -50000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7125 -> ctr (Tabelltype.PENSJONIST, -60000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7126 -> ctr (Tabelltype.PENSJONIST, -70000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7127 -> ctr (Tabelltype.PENSJONIST, -80000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7128 -> ctr (Tabelltype.PENSJONIST, -90000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7129 -> ctr (Tabelltype.PENSJONIST, -100000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7130 -> ctr (Tabelltype.PENSJONIST, -110000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7131 -> ctr (Tabelltype.PENSJONIST, -120000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7132 -> ctr (Tabelltype.PENSJONIST, -130000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);
    | 7133 -> ctr (Tabelltype.PENSJONIST, -140000L, konstanter.KLASSE1_VANLIG, "Lav", false, konstanter.OVERSKYTENDE_PROSENT_PENSJONIST);



    | 7300 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE1_VANLIG, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_7300);
    | 7350 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE1_VANLIG, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_7350);
    | 7500 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE1_VANLIG, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_7500);
    | 7550 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE1_VANLIG, "Ingen", false, konstanter.OVERSKYTENDE_PROSENT_7550);
    | 7700 -> ctr (Tabelltype.STANDARDFRADRAG, 0L, konstanter.KLASSE1_VANLIG, "Lav", true, konstanter.OVERSKYTENDE_PROSENT_7700);

    | 6300 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE1_FINNMARK, "Høy", false, konstanter.OVERSKYTENDE_PROSENT_6300);
    | 6350 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE1_FINNMARK, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_6350);
    | 6500 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE1_FINNMARK, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_6500);
    | 6550 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE1_FINNMARK, "Ingen", false, konstanter.OVERSKYTENDE_PROSENT_6550);
    | 6700 -> ctr (Tabelltype.FINNMARK, 0L, konstanter.KLASSE1_FINNMARK, "Lav", true, konstanter.OVERSKYTENDE_PROSENT_6700);

    | 0100 -> ctr (Tabelltype.SJØ, 0L, konstanter.KLASSE1_VANLIG, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_0100);
    | 0101 -> ctr (Tabelltype.SJØ, 0L, konstanter.KLASSE1_VANLIG, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_0101);

    | 7150 -> ctr (Tabelltype.SPESIAL, 0L, konstanter.KLASSE1_VANLIG, "Høy", true, konstanter.OVERSKYTENDE_PROSENT_7150);
    | 7160 -> ctr (Tabelltype.SPESIAL, 0L, konstanter.KLASSE1_VANLIG, "Ingen", true, konstanter.OVERSKYTENDE_PROSENT_7160);
    | 7170 -> ctr (Tabelltype.SPESIAL, 0L, konstanter.KLASSE1_VANLIG, "Ingen", false, konstanter.OVERSKYTENDE_PROSENT_7170);
    | _ -> None


