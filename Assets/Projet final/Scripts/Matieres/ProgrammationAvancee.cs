using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ProgrammationAvancee : Matiere
{
    public override void chargementQuestions()
    {
        ajouterQuestion(new Questions("Quels sont les avantages d'un paquetage ?",
                    new Proposition("il permet de regrouper plusieurs sous-programmes", true),
                    new Proposition("il permet d'éviter de réécrire du code",true ),
                    new Proposition("il permet d'éviter les exceptions",false )
                    ));


        ajouterQuestion(new Questions("En Ada, existe-t'il des paquetages déjà prêts à l'emploi ?",
                        new Proposition("Oui",true ),
                        new Proposition("Non",false )
                        ));


        ajouterQuestion(new Questions("De combien de partie(s) est constitué un packetage ?",
                        new Proposition("1", false ),
                        new Proposition("2", true),
                        new Proposition("3", false),
                        new Proposition("4",false )
                        ));


        ajouterQuestion(new Questions("La partie spécification d'un paquetage Pack se trouve dans le fichier...",
                        new Proposition("Pack.ads",true ),
                        new Proposition("Pack.adb",false )
                        ));


        ajouterQuestion(new Questions("La partie corps d'un paquetage Pack se trouve dans le fichier...",
                        new Proposition("Pack.ads", false),
                        new Proposition("Pack.adb", true)
                        ));

        ajouterQuestion(new Questions("Comment rend-on accessible un paquetage Pack dans un programme ?",
                        new Proposition("avec la clause with Pack", true ),
                        new Proposition("avec la clause import Pack", false),
                        new Proposition("avec la clause use Pack", false),
                        new Proposition("avec la clause get Pack", false)
                        ));


        ajouterQuestion(new Questions("Un pile est une structure de données qui permet de se souvenir de...",
                        new Proposition("la dernière donnée sauvegardée", true),
                        new Proposition("la première donnée sauvegardée",false )
                        ));


        ajouterQuestion(new Questions("Dans un pile, l'ajout et le supression se font...",
                        new Proposition("au même bout de la structure", true),
                        new Proposition("sur des bouts différents de la structure",false )
                        ));


        ajouterQuestion(new Questions("Comment faire pour avoir des piles de différents types ?",
                        new Proposition("créer des piles de types différents",false ),
                        new Proposition("utiliser le mécanisme de généricité",true )
                        ));


        ajouterQuestion(new Questions("Dans le cas d'une file, l'ajout et la supression se font...",
                        new Proposition("aux deux bout de la structure",true ),
                        new Proposition("au même bout de la structure", false)
                        ));


        ajouterQuestion(new Questions("Quel type utilise-t'on pour déclarer une exception ?",
                        new Proposition("exception",true ),
                        new Proposition("warning",false ),
                        new Proposition("constraint error", false),
                        new Proposition("program error",false )
                        ));


        ajouterQuestion(new Questions("Comment lève-t'on une exception déclarée ?",
                        new Proposition("avec l'instruction raise",true ),
                        new Proposition("avec l'instruction throw",false )
                        ));


        ajouterQuestion(new Questions("Comment traite-t'on une exception ?",
                        new Proposition("exception when identificateur_exception1 => ...", true),
                        new Proposition("exception if identificateur_exception1 => ...", false),
                        new Proposition("exception case identificateur_exception1 => ...", false)
                        ));


        
    }
}
