using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merise : Matiere 
{
	public Merise()
	{
		
	}

	public override void chargementQuestions()
	{
		ajouterQuestion (new Questions("Comment peut-on définir le terme SI ?", 
			new Proposition("ensemble de moyens utilisés par l'entreprise pour collecter, mémoriser, traiter, distribuer et consulter des informations",true), 
			new Proposition("terme qui peut être une conjonction et exprimer à la fois la condition, la répétition, l'hypothèse et est également un adverbe",false), 
			new Proposition("ensemble des moyens informatiques mis en oeuvre pour assurer le traitement automatisé (matériels et logiciels)",false) ) );
		
		ajouterQuestion (new Questions("Que signifie l'acronyme SI ?", 
			new Proposition("Système d'Information",true), 
			new Proposition("Système Informatique",false) ) );
        
		ajouterQuestion (new Questions("Le système d'information d'un entreprise est un ensemble de moyens...", 
			new Proposition("humains",true), 
			new Proposition("matériels",true), 
			new Proposition("immatériels",true) ) );

        ajouterQuestion(new Questions("Le système d'information d'un entreprise est une ressource...",
            new Proposition("essentielle", true),
            new Proposition("négligeable", false),
            new Proposition("secondaire", false)));

        ajouterQuestion(new Questions("Quels sont le(s) niveau(x)  de répresentation d'un SI ?",
            new Proposition("conceptuel", true),
            new Proposition("organisationnel", true),
            new Proposition("opérationnel", true),
            new Proposition("financier", false)));

        ajouterQuestion(new Questions("Comment peut-on trier les niveaux de représentation d'un SI ?",
            new Proposition("conceptuel, organisationnel, opérationnel", true),
            new Proposition("organisationnel, conceptuel, fiancier, opérationnel", false),
            new Proposition("organisationnel, conceptuel, opérationnel", false),
            new Proposition("opérationnel, organisationnel, conceptuel", false)));

        ajouterQuestion(new Questions("Que représente le niveau conceptuel du système ?",
            new Proposition("ensemble des informations et des traitements décrivant le fonctionnement de l'entreprise", true),
            new Proposition("exprime la réalité telle qu'elle est perçu par les acteurs de l'entreprise", false),
            new Proposition("représente les moyens mis en oeuvre pour gérer les données ou activer les traitement", false)));

        ajouterQuestion(new Questions("Que représente le niveau organisationnel (ou logique) du système ?",
            new Proposition("ensemble des informations et des traitements décrivant le fonctionnement de l'entreprise", false),
            new Proposition("exprime la réalité telle qu'elle est perçu par les acteurs de l'entreprise", true),
            new Proposition("représente les moyens mis en oeuvre pour gérer les données ou activer les traitement", false)));

        ajouterQuestion(new Questions("Un schéma conceptuel de données est...",
                        new Proposition("indépendant de considérations techniques ou organisationnelles.", true),
                        new Proposition("dépendant de considérations techniques ou organisationnelles", false)
                        ));

        ajouterQuestion(new Questions("Quel est le résultat d'une modélisation conceptuelle des données ?",
                        new Proposition("un schéma", true),
                        new Proposition("un texte", false)
                        ));


        ajouterQuestion(new Questions("Quels sont les principaux concepts d'un modèle ?",
                        new Proposition("entité type", true),
                        new Proposition("association type", true),
                        new Proposition("propriété type", true),
                        new Proposition("contraintes d'intégrité", true)
                        ));

        ajouterQuestion(new Questions("Comment peut-on représenter le concept d'entité type ?",
                        new Proposition("par un ensemble d’objets de même nature concrets ou abstraits et présentant un intérêt", true),
                        new Proposition("par un ensemble d’associations de même nature entre deux ou plusieurs occurrences d’entités ayant un intérêt", false)
                        ));

        ajouterQuestion(new Questions("Comment peut-on représenter le concept d'association type ?",
                        new Proposition("par un ensemble d’objets de même nature concrets ou abstraits et présentant un intérêt", false),
                        new Proposition("par un ensemble d’associations de même nature entre deux ou plusieurs occurrences d’entités ayant un intérêt", true)
                        ));


        ajouterQuestion(new Questions("Comment nomme-t'on les éléments d'une classe entités ?",
                        new Proposition("des occurrences", true),
                        new Proposition("des valeurs", false),
                        new Proposition("des types", false),
                        new Proposition("des entités", false)
                        ));


        ajouterQuestion(new Questions("Une contrainte d’intégrité est définie comme une assertion qui...",
                        new Proposition("doit être vérifiée par des données à des instants déterminés.", true),
                        new Proposition("doit être vérifiée par des données à des instants indéterminés.", false)
                        ));

        ajouterQuestion(new Questions("Peut-on décrire une entité avec des proriétés qui ne lui sont pas propres ?",
                        new Proposition("Non", true),
                        new Proposition("Oui", false)
                        ));


        ajouterQuestion(new Questions("Dans la démarche de création d'un MCD, est-il possible d'assimiler l'élément type et l'élément individuel ?",
                        new Proposition("Non",true ),
                        new Proposition("Oui",false )
                        ));


        ajouterQuestion(new Questions("Que signifie l'acronyme MCD ?",
                        new Proposition("Modélisation de Création des Données", false),
                        new Proposition("Modélisation Conceptuelle des Données", true)
                        ));

        ajouterQuestion(new Questions("Les entités types sont décrites par...",
                        new Proposition("des propriétés types",true ),
                        new Proposition("des associations types",false )
                        ));


        ajouterQuestion(new Questions("La possession d'un identifiant pour une entité est...",
                        new Proposition("obligatoire",true ),
                        new Proposition("facultative",false )
                        ));


        /*ajouterQuestion(new Questions("",
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", )
                        ));

        ajouterQuestion(new Questions("",
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", )
                        ));


        ajouterQuestion(new Questions("",
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", )
                        ));


        ajouterQuestion(new Questions("",
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", )
                        ));*/
    }



}
