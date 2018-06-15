using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Programmation : Matiere
{
    public override void chargementQuestions()
    {
        ajouterQuestion(new Questions("Comment déclare-t'on les variables ?",
                    new Proposition("avant le begin", true),
                    new Proposition("après le begin", false),
                    new Proposition("dans un bloc", true)
                    ));


        ajouterQuestion(new Questions("Quelle syntaxe est correcte pour affecter une valeur ?",
                        new Proposition(":= 654;", true),
                        new Proposition("= 654;",false ),
                        new Proposition("=: 654;",false ),
                        new Proposition("=> 654", false )
                        ));


        ajouterQuestion(new Questions("Peut-on affecter un integer (entier) à une variable de type float (décimal) ?",
                        new Proposition("Oui",false ),
                        new Proposition("Non",true )
                        ));


        ajouterQuestion(new Questions("Parmi les propositions suivantes, donnez les types de données complexes.",
                        new Proposition("enregistrement", true),
                        new Proposition("tableau",true ),
                        new Proposition("boolean",false ),
                        new Proposition("character",false )
                        ));


        ajouterQuestion(new Questions("Quelle est la particularité des fonctions par rapport aux procédures ?",
                        new Proposition("les fonctions renvoient un résultat", true),
                        new Proposition("les fonctions n'ont pas de paramètres",false )
                        ));


        
    }
}

