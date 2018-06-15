using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilitaire {

    
    public static string NumberToMonth(int month)
    {
        switch(month)
        {
            case 1:
                return "Janvier";

            case 2:
                return "Février";

            case 3:
                return "Mars";

            case 4:
                return "Avril";

            case 5:
                return "Mai";

            case 6:
                return "Juin";

            case 7:
                return "Juillet";

            case 8:
                return "Août";

            case 9:
                return "Septembre";

            case 10:
                return "Octobre";

            case 11:
                return "Novembre";

            default:
                return "Décembre";
        }
    }

    public static string EnglishDayToFrench(string jour)
    {
        switch(jour.ToUpper())
        {
            case "MONDAY":
                return "Lundi";

            case "TUESDAY":
                return "Mardi";

            case "WEDNESDAY":
                return "Mercredi";

            case "THURSDAY":
                return "Jeudi";

            case "FRIDAY":
                return "Vendredi";

            case "SATURDAY":
                return "Samedi";

            default:
                return "Dimanche";
        }
    }
}
