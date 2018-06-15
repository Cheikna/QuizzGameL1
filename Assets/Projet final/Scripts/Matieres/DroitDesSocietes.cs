using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DroitDesSocietes : Matiere
{

    public override void chargementQuestions()
    {
        ajouterQuestion(new Questions("Quelles sont les conditions essentielles pour la validité d'une convention ?",
                        new Proposition("le consentement des futurs associés", true ),
                        new Proposition("la capacité des parties", true ),
                        new Proposition("la détermination de l'objet de la société", true),
                        new Proposition("la cause", true)
                        ));


        ajouterQuestion(new Questions("Quelles sont les conditions de validité spécifiques au contrat de société ?",
                        new Proposition("les apports des associés",true ),
                        new Proposition("l'intention de participer aux résultats de la société", true),
                        new Proposition("l'affectio-societatis", true),
                        new Proposition("la détermination de l'objet de la société", false)
                        ));


        ajouterQuestion(new Questions("Quels peuvent être les types des apports des associés ?",
                        new Proposition("numéraire", true),
                        new Proposition("en nature",true ),
                        new Proposition("en industrie", true),
                        new Proposition("en main d'oeuvre", false)
                        ));


        ajouterQuestion(new Questions("La capacité juridique d'une société lui permet..",
                        new Proposition("d'acquérir des droits", true ),
                        new Proposition("de contracter des obligations", true),
                        new Proposition("de faire un testament", false ),
                        new Proposition("de faire une adoption", false )
                        ));


        ajouterQuestion(new Questions("Quels sont les principaux effets de la personnification d'une société ?",
                        new Proposition("une capacité juridique", true),
                        new Proposition("un patrimoine", true),
                        new Proposition("une dénomination sociale", false),
                        new Proposition("un domicile", true)
                        ));


        ajouterQuestion(new Questions("Quels sont les effets secondaires de la personnification d'une société ?",
                        new Proposition("une capacité juridique", false ),
                        new Proposition("une dénomination sociale", true ),
                        new Proposition("une nationnalité", true),
                        new Proposition("un domicile", true)
                        ));


        ajouterQuestion(new Questions("À quel moment les fondateurs doivent-ils choisir le lieu d'activité ?",
                        new Proposition("avant la rédaction des statuts", true ),
                        new Proposition("à la rédaction et signature des statuts", false ),
                        new Proposition("après la signature des statuts", false )
                        ));



        ajouterQuestion(new Questions("À quel moment les fondateurs doivent-ils enregistrer les actes auprès de l'administration fiscale ?",
                        new Proposition("avant la rédaction des statuts", false),
                        new Proposition("à la rédaction et signature des statuts", false),
                        new Proposition("après la signature des statuts", true)
                        ));


        ajouterQuestion(new Questions("Quelles sont les mentions obligatoires pour toutes les sociétés ?",
                        new Proposition("la forme sociale", true ),
                        new Proposition("la durée", true ),
                        new Proposition("le montant du capital", true ),
                        new Proposition("le nom du comptable", false )
                        ));


        ajouterQuestion(new Questions("Quelles sont les missions des commissaires aux comptes ?",
                        new Proposition("certifier la régularité des comptes annuels", true),
                        new Proposition("révéler au Procureur de la République les faits délictueux", true),
                        new Proposition("intervenir lors d'opérations particulières décidées par l'entreprise", true)
                        ));


        ajouterQuestion(new Questions("Quelles sont les particularités la SARL et de l'EURL ?",
                        new Proposition("depuis 2003, le capital minimal est de 0€", false),
                        new Proposition("les associés n'ont pas nécessairement la qualité de commerçants", true),
                        new Proposition("les associés ne sont responsables du passif de la société qu'à hauteur de leurs apports", true)
                        ));


        ajouterQuestion(new Questions("Au sein d'une SARL, les associés...",
                        new Proposition("sont uniquement des personnes physiques", false ),
                        new Proposition("sont au maximum 100", true )
                        ));


        ajouterQuestion(new Questions("Pour déposer une marque, il faut...",
                        new Proposition("qu'elle ait un caractère distinctif", true ),
                        new Proposition("qu'elle soit illicite", false),
                        new Proposition("qu'elle soit disponible", true )
                        ));

    }
}
