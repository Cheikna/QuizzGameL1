using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroitCommercial : Matiere {

    public override void chargementQuestions()
    {
        ajouterQuestion(new Questions("Dans la phrase \"La loi répute actes de commerce\", à quoi fait référence le mot \"actes\"",
                        new Proposition("Des actes juridiques", false),
                        new Proposition("Des activités économiques", true) ));


        ajouterQuestion(new Questions("Sélectionnez les meubles corporels",
                        new Proposition("marchandises", true),
                        new Proposition("matières premières", true),
                        new Proposition("produits-finis", true),
                        new Proposition("fonds de commerce", false)));


        ajouterQuestion(new Questions("Sélectionnez les meubles incorporels",
                        new Proposition("fonds de commerce",true),
                        new Proposition("valeurs mobilières", true),
                        new Proposition("marchandises",false)));


        ajouterQuestion(new Questions("(1) Donnez les activités d'échange et de négoce",
                        new Proposition("achat de biens meubles pour les revendre", true),
                        new Proposition("achat de biens immeubles pour les revendre", true),
                        new Proposition("L'entreprise de location de meubles", true),
                        new Proposition("exploitation des mines", false) ));


        ajouterQuestion(new Questions("(2) Donnez les activités d'échange et de négoce",
                        new Proposition("entreprise de fourniture", true),
                        new Proposition("exploitation des salles de ventes publiques", true),
                        new Proposition("entreprise de manufacture", false),
                        new Proposition("entreprise de transports", false)));

        ajouterQuestion(new Questions("(3) Donnez les activités d'échange et de négoce",
                        new Proposition("exploitation des magasins généraux", true),
                        new Proposition("entreprise de transports", false),
                        new Proposition("établissements de spectacles publics", false)));


        ajouterQuestion(new Questions("(1) Donnez les activités industrielles et logistiques",
                        new Proposition("exploitation des magasins généraux", false),
                        new Proposition("exploitation des salles de ventes publiques", false),
                        new Proposition("exploitation des mines", true) ));


        ajouterQuestion(new Questions("(2) Donnez les activités industrielles et logistiques",
                        new Proposition("achat de biens meubles pour les revendre", false),
                        new Proposition("entreprise de fourniture", false),
                        new Proposition("entreprise de manufacture", true),
                        new Proposition("entreprise de transports",true)));


        ajouterQuestion(new Questions("Parmi ces propositions, lesquelles désignent des activités financières ?",
                        new Proposition("opérations de banque",true),
                        new Proposition("services de paiement", true),
                        new Proposition("services d'aide à la personne",false)));

                                       
        ajouterQuestion(new Questions("Si une personne signe une lettre de change, devient-elle une commerçante ?",
                        new Proposition("Oui",false),
                        new Proposition("Oui, si elle en signe plusieurs",false),
                        new Proposition("Non",true)));


        ajouterQuestion(new Questions("Comment une société peut-elle être commerciale ?",
                        new Proposition("en ayant pour objet l'accomplissement d'actes de commerce par nature",true),
                        new Proposition("en choisissant une forme lui conférant de plein droit la commercialité (SARL,...)", true)));


        ajouterQuestion(new Questions("Pour invoquer la commercialité d'un acte à mon profit...",
                        new Proposition("Je dois être immatriculé au registre du commerce",true),
                        new Proposition("L'autre partie doit aussi être immatriculée", false)));


        ajouterQuestion(new Questions("Quels sont les différents moyens de preuves existants ?",
                        new Proposition("Les écrits", true),
                        new Proposition("Les témoignages", true),
                        new Proposition("Les données numériques", true),
                        new Proposition("Les copies", true)));


        ajouterQuestion(new Questions("À qui s'applique le droit commercial ?",
                        new Proposition("à la personne pour qui l'acte est commercial", true),
                        new Proposition("à la personne pour qui l'acte est civil", false)));


        ajouterQuestion(new Questions("À qui s'applique le droit civil ?",
                        new Proposition("à la personne pour qui l'acte est commercial", false),
                        new Proposition("à la personne pour qui l'acte est civil", true)));


        ajouterQuestion(new Questions("Si un mineur reçoit un commerce par voie de succession, alors...",
                        new Proposition("il peut gérer ce commerce en tant que commerçant", false),
                        new Proposition("le parent survivant exploite le commerce",true),
                        new Proposition("le représentant légal donne le fonds de commerce en location-gérance", true)));


        ajouterQuestion(new Questions("Quelles sont les personnes ne pouvant pas avoir être commerçant ? ",
                        new Proposition("les mineurs", true),
                        new Proposition("tous les majeurs", false),
                        new Proposition("les majeurs sous tutelle", true),
                        new Proposition("les majeurs mis sous sauvegarde de justice", true)));


        ajouterQuestion(new Questions("Que désigne l'acronyme EIRL ?",
                        new Proposition("Entreprise Individuelle à Responsabilité Limitée", true),
                        new Proposition("Entreprise Individuelle à Responsabilité Légale", false)));


        ajouterQuestion(new Questions("Quels sont les statuts possibles pour le conjoint d'un commerçant ?",
                        new Proposition("collaborateur", true),
                        new Proposition("salarié", true),
                        new Proposition("associés",true)));


        ajouterQuestion(new Questions("Quels sont les avantages d'un capital élevé dans une société ?",
                        new Proposition("des crédits obtenus plus facilement",true),
                        new Proposition("des crédits à un taux inférieur", true)));


        ajouterQuestion(new Questions("Quels sont les biens compris dans le fonds de commerce ?",
                        new Proposition("nom commercial", true),
                        new Proposition("outillage", true),
                        new Proposition("brevets, marques, dessins et modèles", true),
                        new Proposition("créances et dettes", false)));


        ajouterQuestion(new Questions("Dans le cas de la vente, quels sont les obligations du vendeur ?",
                        new Proposition("obligation de délivrance", true),
                        new Proposition("garantie contre les vices cachés", true)));


        /*ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));


        ajouterQuestion(new Questions("",
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,),
                        new Proposition(,));*/
    }
}
