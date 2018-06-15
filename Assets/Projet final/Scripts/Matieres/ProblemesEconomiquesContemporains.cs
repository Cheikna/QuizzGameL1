using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class ProblemesEconomiquesContemporains : Matiere
    {

        public override void chargementQuestions()
        {
            ajouterQuestion(new Questions("Quels sont les besoins illimités ?",
                        new Proposition("primaire",true ),
                        new Proposition("secondaires", true),
                        new Proposition("de civilisation", true )
                        ));


            ajouterQuestion(new Questions("Donnez les principaux actes économiques",
                        new Proposition("échange sur le marché", true ),
                        new Proposition("production de biens économiques", true ),
                        new Proposition("fixation du prix", true )
                        ));


            ajouterQuestion(new Questions("Les ménages sont des acteurs car ils...",
                        new Proposition("investissent pour produire des biens ou des services", false ),
                        new Proposition("consomment des biens ou des services ou peuvent épargner", true ),
                        new Proposition("reçoivent les dépôts et l'épargne des ménages", false ),
                        new Proposition("produisent des services gratuits", false)
                        ));


            ajouterQuestion(new Questions("Les entreprises sont des acteurs car elles...",
                        new Proposition("investissent pour produire des biens ou des services", true),
                        new Proposition("consomment des biens ou des services ou peuvent épargner", false),
                        new Proposition("reçoivent les dépôts et l'épargne des ménages", false),
                        new Proposition("produisent des services gratuits", false)
                        ));


            ajouterQuestion(new Questions("Les banques sont des acteurs car elles...",
                        new Proposition("investissent pour produire des biens ou des services", false),
                        new Proposition("consomment des biens ou des services ou peuvent épargner", false),
                        new Proposition("reçoivent les dépôts et l'épargne des ménages", true),
                        new Proposition("produisent des services gratuits", false)
                        ));


            ajouterQuestion(new Questions("Les administrations sont des acteurs car elles...",
                        new Proposition("investissent pour produire des biens ou des services", false),
                        new Proposition("consomment des biens ou des services ou peuvent épargner", false),
                        new Proposition("reçoivent les dépôts et l'épargne des ménages", false),
                        new Proposition("produisent des services gratuits",true )
                        ));


            ajouterQuestion(new Questions("Sur quoi repose le fonctionnement du marché ?",
                        new Proposition("le respect des règles de la concurrence", true ),
                        new Proposition("l'accès des intervenants à la formation", true ),
                        new Proposition("la confiance mutuelle entre les intervenants", true),
                        new Proposition("sa durée", false )
                        ));


            ajouterQuestion(new Questions("Pourquoi le prix influence les décisions des agents économiques ?",
                        new Proposition("car c'est un indicateur de rareté", true ),
                        new Proposition("car tout objet doit avoir un prix", false ),
                        new Proposition("permet de procéder à une analyse coût/avantage/risque", true )
                        ));


            ajouterQuestion(new Questions("L'Etat a pour rôle de...",
                        new Proposition("produire des services publics non marchands", true ),
                        new Proposition("produire des services publics marchands",false ),
                        new Proposition("redistribuer des revenus", true ),
                        new Proposition("réguler l'activité économique", true )
                        ));


            ajouterQuestion(new Questions("Quels sont les effets d'une masse monétaire trop importante ?",
                        new Proposition("la demande est plus soutenue sans que l'offre ne suive",true ),
                        new Proposition("hausse généralisée des prix : inflation", true ),
                        new Proposition("la demande est ralentie", false ),
                        new Proposition("ralentissement de la hausse des prix", false )
                        ));


            ajouterQuestion(new Questions("Quels sont les effets d'une masse monétaire insuffisante ?",
                        new Proposition("la demande est plus soutenue sans que l'offre ne suive", false),
                        new Proposition("hausse généralisée des prix : inflation", false),
                        new Proposition("la demande est ralentie", true),
                        new Proposition("ralentissement de la hausse des prix", true)
                        ));


            ajouterQuestion(new Questions("La banque sert à...",
                        new Proposition("recevoir les dépôts d'argent de ses clients", true ),
                        new Proposition("accorder des crédits sans avoir évalué le risque et l'endettement", false ),
                        new Proposition("accorder des crédits après avoir évalué le risque et l'endettement", true)
                        ));


            ajouterQuestion(new Questions("En quoi le marché des changes est-il important ?",
                        new Proposition("c'est une nécessité pour les règlements internationaux", true),
                        new Proposition("il sert à aider les banques en faillite", false),
                        new Proposition("c'est une nécessité pour les règlements nationaux", false )
                        ));


            ajouterQuestion(new Questions("La création de richesses est mesurée par..",
                        new Proposition("la valeur ajoutée (VA) au niveau de l'entreprise",true ),
                        new Proposition("le Produit Intérieur Brut (PIB) au niveau du pays", true )
                        ));


            ajouterQuestion(new Questions("La croissance est...",
                        new Proposition("l'évolution du PIB réel (en volume) d'une année sur l'autre", true ),
                        new Proposition("l'évolution de la valeur ajoutée d'une année sur l'autre", false)
                        ));


            ajouterQuestion(new Questions("Le PIB tient compte...",
                        new Proposition("des revenus disponibles", true ),
                        new Proposition("de la consommation",true ),
                        new Proposition("de l'épargne", true )
                        ));


            ajouterQuestion(new Questions("Les facteurs de croissances sont...",
                        new Proposition("les facteurs de production (travail, capital)", true ),
                        new Proposition("les investissements", true )
                        ));


            ajouterQuestion(new Questions("Une croissance extensive est due à...",
                        new Proposition("une augmentation de la quantité de facteurs de production", true ),
                        new Proposition("une amélioration de la productivité", false)
                        ));


            ajouterQuestion(new Questions("Dans quelle catégorie place-t'on les pays émergents ?",
                        new Proposition("les pas développés",false ),
                        new Proposition("les pays en développement", true )
                        ));


            ajouterQuestion(new Questions("Quels sont les critères qui indiquent le niveau de développement ?",
                        new Proposition("économiques (PIB)", true ),
                        new Proposition("sociaux (taux de scolarisation,...)",true ),
                        new Proposition("démographiques (espérance de vie,...)", true ),
                        new Proposition("indice de pauvreté", false )
                        ));


            ajouterQuestion(new Questions("Par quels indicateurs le niveau de développement s'apprécie-t'il ?",
                        new Proposition("indicateur du développement humain (IDH)",true ),
                        new Proposition("indice de pauvreté multidimensionnelle (IPM)", true ),
                        new Proposition("économiques (PIB)", false),
                        new Proposition("sociaux (taux de scolarisation,...)", false)
                        ));


            ajouterQuestion(new Questions("Les objectifs du développement durable sont...",
                        new Proposition("lutter contre les conséquences négatives de la croissances", true),
                        new Proposition("mettre en oeuvre un développement répondant aux besoins actuels", true),
                        new Proposition("ne pas compromettre les générations futures de répondres à leurs besoins", true),
                        new Proposition("répondre à nos besoins sans se préoccuper des générations futures", false )
                        ));


            ajouterQuestion(new Questions("Les indicateurs du développement durable sont",
                        new Proposition("l'empreinte écologique", true ),
                        new Proposition("le PIB vert", true ),
                        new Proposition("le PIB",false ),
                        new Proposition("le bonheur intérieur brut (BIB)",true )
                        ));


            ajouterQuestion(new Questions("Comment les politiques du développement durable sont-elles mises en oeuvre ?",
                        new Proposition("par des conférences internationales", true),
                        new Proposition("par des décisions de l'Union Européenne", true),
                        new Proposition("par des initiatives d'entreprises ou d'organismes privés", true),
                        new Proposition("par des petits comités", false)
                        ));
        }
    }

