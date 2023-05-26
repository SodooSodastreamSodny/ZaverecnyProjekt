# ZaverecnyProjekt
##Hra Kámen Nůžky Papír

Toto je jednoduchá konzolová hra Kámen Nůžky Papír implementovaná v jazyce C#. Hra umožňuje hráči hrát proti počítačovému protihráči.
#Jak hrát

    Hra začíná s počátečním skóre 0 pro hráče i počítačového protihráče.
    V každém kole je hráč vyzván k zvolení svého tahu:
        Zadejte "1" pro kámen
        Zadejte "2" pro nůžky
        Zadejte "3" pro papír
    Počítačový protihráč náhodně vybere svůj tah.
    Výsledek kola je zobrazen:
        Pokud hráč i počítač zvolí stejný tah, je to remíza.
        Pokud tah hráče porazí tah počítače, hráč vyhrává kolo a jeho skóre se zvýší o 1.
        Pokud tah počítače porazí tah hráče, počítač vyhrává kolo a jeho skóre se zvýší o 1.
    Hra pokračuje, dokud buď hráč nebo počítač nedosáhnou skóre 5.
    Na konci hry je zobrazeno konečné skóre, ukazující počet výher hráče a počítače.
