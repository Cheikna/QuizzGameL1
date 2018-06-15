using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anglais : Matiere
{

    public override void chargementQuestions()
    {
        ajouterQuestion(new Questions("Pourquoi emploi-t'on le génitif des noms ?",
                        new Proposition("Pour exprimer un rapport de possession", true),
                        new Proposition("Pour exprimer un rapport de parenté", true),
                        new Proposition("Pour exprimer la pluralité d'un élément", false)
                        ));

        ajouterQuestion(new Questions("Traduisez \"La voiture de Derek\" en utilisant le génitif",
                        new Proposition("Derek's car", true),
                        new Proposition("Car's Derek", false),
                        new Proposition("The car of Derek", false),
                        new Proposition("Derek has a car", false)
                        ));

        ajouterQuestion(new Questions("Traduisez \"La maison de nos amis\" en utilisant le génitif",
                        new Proposition("Our friends' house", true),
                        new Proposition("Our friends's house", false),
                        new Proposition("The houses of our friends", false)
                        ));

        ajouterQuestion(new Questions("Comment se forment les pluriels irréguliers non terminés par un 's' comme 'children' ?",
                        new Proposition("Comme les singuliers", true),
                        new Proposition("On met une apostrophe après la dernière lettre (ex: children')", false),
                        new Proposition("On ne peut pas utiliser le génitif", false),
                        new Proposition("On doit remplacer le pluriel par un autre mot", false)
                        ));

        ajouterQuestion(new Questions("Traduisez \"Les malheurs des autres\" en utilisant le génitif",
                        new Proposition("Other people's misfortunes", true),
                        new Proposition("Other people misfortunes", false),
                        new Proposition("Other peoples' misfortunes", false)
                        ));

        ajouterQuestion(new Questions("Génitif : Doit-on ajouter un 's' pour les noms propres terminés par un 's' ?",
                        new Proposition("Oui", true),
                        new Proposition("Non", false)
                        ));

        ajouterQuestion(new Questions("Génitif : Dans quel(s) cas le génitif a-t'il été bien utilisé ?",
                        new Proposition("My sister's husband", true),
                        new Proposition("The dog's tail", true),
                        new Proposition("The table's leg", false)
                        ));

        ajouterQuestion(new Questions("Le génitif est utilisé pour...",
                        new Proposition("Un nom de personne", true),
                        new Proposition("Un nom neutre personnifié comme les noms des pays, villes...", true),
                        new Proposition("Des groupes et des collectivités", true),
                        new Proposition("Un nom d'animal", true)));

        ajouterQuestion(new Questions("Est-ce-que la phrase \"I can hear a car, I think it's the doctor's\" est correcte ? ",
                        new Proposition("Oui", true),
                        new Proposition("Non", false)));

        ajouterQuestion(new Questions("Quelles sont les fonctions des formes verbales en \"-ing\" ?",
                        new Proposition("Exprimer un nom", true),
                        new Proposition("Exprimer un temps personnel", true),
                        new Proposition("Exprimer un infinitif", true),
                        new Proposition("Exprimer un prétérit", false)
                        ));

        ajouterQuestion(new Questions("Quel est la particularité d'un gérondif ?",
                        new Proposition("il a les caractéristiques d'un nom et d'un verbe", true),
                        new Proposition("il permet d'exprimer la possession", false),
                        new Proposition("il permet d'éviter l'utilisation du génitif", false)));

        ajouterQuestion(new Questions("En tant que nom, le gérondif...",
                        new Proposition("peut avoit un sens général", true),
                        new Proposition("peut se conjuguer à la voix passive", false)));

        ajouterQuestion(new Questions("Lorsqu'il s'agit d'actions précises (ou définies), on utilise...",
                        new Proposition("le gérondif", false),
                        new Proposition("le présent", true)));

        ajouterQuestion(new Questions("Peut-on utiliser le gérondif après le prépositions 'except' et 'but' ?",
                        new Proposition("Non", true),
                        new Proposition("Oui", false)));

        ajouterQuestion(new Questions("L'utilisation d'un gérondif après \"for\" s'emploie pour...",
                        new Proposition("indiquer une cause", true),
                        new Proposition("indiquer un motif", true),
                        new Proposition("indiquer la possession", false)));

        ajouterQuestion(new Questions("Dans quel cas utilise-t'on le gérondif après 'to' ?",
                        new Proposition("quand 'to' est une préposition", true),
                        new Proposition("quand 'to' n'est pas une préposition", false)));
                        
    }
}
