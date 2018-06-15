using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class IntroFonctionnementEntreprises : Matiere
{
    public override void chargementQuestions()
    {
        ajouterQuestion(new Questions("L'entreprise est une unité de...",
                        new Proposition("répartition", true),
                        new Proposition("production", true)
                        ));


        ajouterQuestion(new Questions("Une entreprise est un centre de décisions...",
                        new Proposition("autonome", true),
                        new Proposition("dépendant", false)
                        ));


        ajouterQuestion(new Questions("Selon l'école des relations humaines, que doit faire une entreprise pour réaliser de meilleurs résultats ?",
                        new Proposition("s’intéresser davantage au salarié en tant que personne", true),
                        new Proposition("rechercher le profit par tous les moyens nécessaires",false )
                        ));


        ajouterQuestion(new Questions("Qui a construit la pyramide sociale des besoins de l'Homme au travail ?",
                        new Proposition("Maslow", true),
                        new Proposition("H. FAYOL", false),
                        new Proposition("D. McGergor", false),
                        new Proposition("F.Herezberg", false)
                        ));

        ajouterQuestion(new Questions("À quoi correspond la finalité d'une entreprise ? (1 réponse)",
                        new Proposition("à sa raison d'être", true),
                        new Proposition("à ses objectifs", false),
                        new Proposition("à son chiffre d'affaires", false),
                        new Proposition("à son bénéfice",false )
                        ));


        ajouterQuestion(new Questions("À quoi correspondent les finalités sociales d'une entreprise ?",
                        new Proposition("le regroupement d'hommes",true ),
                        new Proposition("l'ouverture à son environnement", true),
                        new Proposition("la préservation de l'environnement", false),
                        new Proposition("la préservation des ressources naturelles",false )
                        ));


        ajouterQuestion(new Questions("À quoi correspondent les finalités environnementales d'une entreprise ?",
                        new Proposition("le regroupement d'hommes", false),
                        new Proposition("l'ouverture à son environnement", false),
                        new Proposition("la préservation de l'environnement", true),
                        new Proposition("la préservation des ressources naturelles", true)
                        ));


        ajouterQuestion(new Questions("Autour de combien d'axe(s) l'action du manager s'organise-t'elle ?",
                        new Proposition("1", false),
                        new Proposition("2", false),
                        new Proposition("3", true),
                        new Proposition("4", false)
                        ));


        ajouterQuestion(new Questions("Autour de quel(s) d'axe(s) l'action du manager s'organise-t'elle ?",
                        new Proposition("direction",true ),
                        new Proposition("gestion",true ),
                        new Proposition("contrôle",true ),
                        new Proposition("achat",false )
                        ));


        ajouterQuestion(new Questions("Autour de quel(s) critères les entreprises sont-elles classées ?",
                        new Proposition("le type d'activité", true),
                        new Proposition("la taille ou dimension",true ),
                        new Proposition("la forme juridique", true),
                        new Proposition("le chiffre d'affaires",false )
                        ));


        ajouterQuestion(new Questions("Qui sont les acteurs des entreprises publiques ?",
                        new Proposition("l'Etat", true),
                        new Proposition("les collectivités territoriales",true ),
                        new Proposition("les citoyens", false)
                        ));


        ajouterQuestion(new Questions("Comment l'Etat intervient-il dans les entreprises publiques ?",
                        new Proposition("en étant propriétaire du capital de l'entreprise", true),
                        new Proposition("avec l'intermédiare de participations",true )
                        ));


        ajouterQuestion(new Questions("Une structure peut être caractérisée par...",
                        new Proposition("la division du travail", true),
                        new Proposition("les degrés de centralisation",true ),
                        new Proposition("les mécanismes de coordination", true),
                        new Proposition("la division des richesses", false)
                        ));


        ajouterQuestion(new Questions("La division verticale du travail est...",
                        new Proposition("la détermination du nombre de lignes hiérarchiques", true),
                        new Proposition("la détermination du nombre de fonctions ou de services", false)
                        ));


        ajouterQuestion(new Questions("La division horizontale du travail est...",
                        new Proposition("la détermination du nombre de lignes hiérarchiques", false),
                        new Proposition("la détermination du nombre de fonctions ou de services", true)
                        ));


        ajouterQuestion(new Questions("Quels sont les niveaux d'étude de l'environnement d'une entreprise ?",
                        new Proposition("le macro-environnement", true),
                        new Proposition("le micro-environnement", true),
                        new Proposition("le nano-environnement", false)
                        ));


        ajouterQuestion(new Questions("Combien d'acteurs le modèle PESTEL met-il en avant ?",
                        new Proposition("3", false),
                        new Proposition("5", false),
                        new Proposition("6",true ),
                        new Proposition("8", false)
                        ));


        ajouterQuestion(new Questions("À quoi correspond le P de l'acronyme PESTEL ?",
                        new Proposition("Politique", true),
                        new Proposition("Prévention", false),
                        new Proposition("Partage",false ),
                        new Proposition("Police", false)
                        ));


        ajouterQuestion(new Questions("Comment se nomme le principe de découpage d'un ou plusieurs marchés en différentes parties homogènes ?",
                        new Proposition("la segmentation",true ),
                        new Proposition("la diversification",false ),
                        new Proposition("la spécialisation", false),
                        new Proposition("la différenciation",false )
                        ));


        ajouterQuestion(new Questions("Quels sont les différents styles de direction d'une entreprise ?",
                        new Proposition("autoritaire",true ),
                        new Proposition("participatif", true),
                        new Proposition("paternaliste",true ),
                        new Proposition("consultatif",true )
                        ));


        ajouterQuestion(new Questions("Le diagnostic interne permet d'analyser les...",
                        new Proposition("forces",true ),
                        new Proposition("faiblesses", true),
                        new Proposition("opportunités",false ),
                        new Proposition("menaces",false )
                        ));


        ajouterQuestion(new Questions("Le diagnostic externe permet d'analyser les...",
                        new Proposition("forces", false),
                        new Proposition("faiblesses", false),
                        new Proposition("opportunités", true),
                        new Proposition("menaces", true)
                        ));


        ajouterQuestion(new Questions("La stratégie de spécialisation consiste à...",
                        new Proposition("se concentrer sur un seul domaine d'activité", true),
                        new Proposition("un changement du domaine d'activité stratégique", false),
                        new Proposition("rassembler des activités sous une autorité commune", false),
                        new Proposition("faire faire à l'extérieur en nouant des relations avec des entreprises", false)
                        ));

        ajouterQuestion(new Questions("La stratégie de diversification consiste à...",
                        new Proposition("un changement du domaine d'activité stratégique",true ),
                        new Proposition("se concentrer sur un seul domaine d'activité", false),
                        new Proposition("rassembler des activités sous une autorité commune", false),
                        new Proposition("faire faire à l'extérieur en nouant des relations avec des entreprises", false)
                        ));


        ajouterQuestion(new Questions("La stratégie d'intégration consiste à...",
                        new Proposition("rassembler des activités sous une autorité commune",true ),
                        new Proposition("se concentrer sur un seul domaine d'activité", false),
                        new Proposition("un changement du domaine d'activité stratégique", false),
                        new Proposition("faire faire à l'extérieur en nouant des relations avec des entreprises", false)
                        ));


        ajouterQuestion(new Questions("La statégie d'externalisation consiste à...",
                        new Proposition("faire faire à l'extérieur en nouant des relations avec des entreprises", true),
                        new Proposition("se concentrer sur un seul domaine d'activité", false),
                        new Proposition("un changement du domaine d'activité stratégique", false),
                        new Proposition("rassembler des activités sous une autorité commune", false)
                        ));


        /*ajouterQuestion(new Questions("",
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", )
                        ));
        */
    }
}
