using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BaseDeDonnees : Matiere
{
    public override void chargementQuestions()
    {
        ajouterQuestion(new Questions("Comment peut-on représenter m'absence de valeur ?",
                        new Proposition("par <null>", true ),
                        new Proposition("par rien", true )
                        ));


        ajouterQuestion(new Questions("Quel est le but d'un identifiant ?",
                        new Proposition("de désigner une ligne d'une table", true ),
                        new Proposition("de référencer une ligne d'une autre table", false )
                        ));


        ajouterQuestion(new Questions("Quel est le but d'une clé étrangère d'une table S ?",
                        new Proposition("sa valeur sert à référencer une ligne d'une autre table", true ),
                        new Proposition("de désigner une ligne unique de la table S", false )
                        ));


        ajouterQuestion(new Questions("Un identifiant primaire est constitué de colonnes...",
                        new Proposition("obligatoires",true ),
                        new Proposition("facultatives", false )
                        ));


        ajouterQuestion(new Questions("Le schéma d'une table spécifie...",
                        new Proposition("le nom de la table", true ),
                        new Proposition("l'identifiant primaire", true ),
                        new Proposition("les clés étrangères", true ),
                        new Proposition("le nom et le type de chaque colonne",true )
                        ));


        ajouterQuestion(new Questions("Quelle requête permet de créer la table Ecole avec les colonnes Nom et Adresse ?",
                        new Proposition("CREATE TABLE Ecole(Nom Varchar(30), Adresse varchar(20))", true ),
                        new Proposition("CREATE Ecole(Nom Varchar(30), Adresse varchar(20))", false),
                        new Proposition("CREATE TABLE Ecole(Nom , Adresse)", false ),
                        new Proposition("CREATE Ecole(Nom , Adresse)", false)
                        ));


        ajouterQuestion(new Questions("Quelle commande permet de modifier une table ?",
                        new Proposition("ALTER TABLE", true),
                        new Proposition("MODIFY TABLE", false ),
                        new Proposition("CHANGE TABLE", false ),
                        new Proposition("SET TABLE", false )
                        ));


        ajouterQuestion(new Questions("Par quelle requête ajoute-t'on une nouvelle colonne dans une table ?",
                        new Proposition("ALTER TABLE nom_table  ADD(colonne1 type)", true),
                        new Proposition("CHANGE TABLE nom_table  ADD(colonne1 type)", false),
                        new Proposition("SET TABLE nom_table  ADD(colonne1 type)", false),
                        new Proposition("MODIFY TABLE nom_table  ADD(colonne1 type)", false)
                        ));


        ajouterQuestion(new Questions("Quelle requête permet de supprimer une table ?",
                        new Proposition("DROP TABLE nom_table", true),
                        new Proposition("DELETE TABLE nom_table", false)
                        ));


        ajouterQuestion(new Questions("La requête SELECT permet...",
                        new Proposition("d'extraire des données des tables",true ),
                        new Proposition("d'insérer de nouvelles lignes dans une table", false ),
                        new Proposition("de supprimer des lignes d'une table", false ),
                        new Proposition("de modifier les valeurs de colonnes de lignes", false)
                        ));


        ajouterQuestion(new Questions("La requête INSERT permet...",
                        new Proposition("d'insérer de nouvelles lignes dans une table", true),
                        new Proposition("d'extraire des données des tables", false),
                        new Proposition("de supprimer des lignes d'une table", false),
                        new Proposition("de modifier les valeurs de colonnes de lignes", false)
                        ));


        ajouterQuestion(new Questions("La requête DELETE permet...",
                        new Proposition("de supprimer des lignes d'une table",true ),
                        new Proposition("d'extraire des données des tables", false),
                        new Proposition("d'insérer de nouvelles lignes dans une table", false),
                        new Proposition("de modifier les valeurs de colonnes de lignes",false )
                        ));


        ajouterQuestion(new Questions("La requête UPDATE permet...",
                        new Proposition("de modifier les valeurs de colonnes de lignes", true),
                        new Proposition("d'extraire des données des tables", false),
                        new Proposition("d'insérer de nouvelles lignes dans une table", false),
                        new Proposition("de supprimer des lignes d'une table", false)
                        ));


        ajouterQuestion(new Questions("Comment insère-t'on une ligne à la table Etudiant(ID, NOM, PRENOM) ?",
                        new Proposition("INSERT INTO Etudiant VALUES (1, 'DIGGLE', 'John')", true),
                        new Proposition("INSERT TO Etudiant VALUES (1, 'DIGGLE', 'John')", false),
                        new Proposition("INSERT VALUES (1, 'DIGGLE', 'John') INTO Etudiant",false ),
                        new Proposition("INSERT VALUES (1, 'DIGGLE', 'John') TO Etudiant", false)
                        ));


        ajouterQuestion(new Questions("Quelle commande permet de modifier une ou plusieurs lignes qui respectent une condition ?",
                        new Proposition("UPDATE nom_table SET colonne1=expression1, colonnes2=expression2 WHERE condition", true),
                        new Proposition("UPDATE nom_table SET colonne1=expression1, colonnes2=expression2", false )
                        ));


        ajouterQuestion(new Questions("Quelle commande permet de supprimer une ou plusieurs lignes qui respectent une condition ?",
                        new Proposition("DELETE FROM nom_table WHERE condition",true ),
                        new Proposition("DROP FROM nom_table WHERE condition", false),
                        new Proposition("REMOVE FROM nom_table WHERE condition",false )
                        ));


        ajouterQuestion(new Questions("Lors d'une requête avec un SELECT, comment sélectionne-t'on tous les attributs de la relation ?",
                        new Proposition("avec le symbole *", true ),
                        new Proposition("en écrivant ALL après SELECT", false )
                        ));


        ajouterQuestion(new Questions("Lors d'une requête avec un SELECT, comment élimine-t'on les tuples en double ?",
                        new Proposition("avec l'utilisation du mot-clé DISTINCT",true ),
                        new Proposition("avec l'utilisation du mot-clé DIFFERENT", false)
                        ));


        ajouterQuestion(new Questions("Qu'obtient-on avec la requête : SELECT COUNT(*) FROM Livraison WHERE NomP = ‘xxa1’",
                        new Proposition("le nombre de livraisons de la pièce de nom ‘ xxa1 ’", true),
                        new Proposition("le nombre total de livraisons", false)
                        ));


        ajouterQuestion(new Questions("Quel mot-clé permet de faire un test d'intervalle lors d'une requête SELECT ?",
                        new Proposition("BETWEEN", true ),
                        new Proposition("LIKE", false ),
                        new Proposition("COUNT", false ),
                        new Proposition("WITH",false )
                        ));


        
    }
}
