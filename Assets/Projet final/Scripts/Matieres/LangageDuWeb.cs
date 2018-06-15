using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class LangageDuWeb : Matiere
{
    public override void chargementQuestions()
    {
        ajouterQuestion(new Questions("Quel caractère marque le début d'une entité ?",
                        new Proposition("&", true ),
                        new Proposition("#", false),
                        new Proposition("$", false),
                        new Proposition("@", false)
                        ));


        ajouterQuestion(new Questions("Comment écrit-on un commentaire en HTML ?",
                        new Proposition("<!-- Ceci est un commentaire -->", true),
                        new Proposition("<!-- Ceci est un commentaire !-->", false),
                        new Proposition("<-- Ceci est un commentaire -->", false),
                        new Proposition("//Ceci est un commentaire", false)
                        ));


        ajouterQuestion(new Questions("Quelle balise permet de mettre un texte en gras ?",
                        new Proposition("<strong>", true),
                        new Proposition("<em>", false),
                        new Proposition("<br>", false),
                        new Proposition("<gras>", false)
                        ));


        ajouterQuestion(new Questions("Quelles sont les spécificités de la balise <p>",
                        new Proposition("elle crée un paragraphe",true ),
                        new Proposition("elle provoque un saut de ligne", true),
                        new Proposition("elle provoque un saut de page", false)
                        ));


        ajouterQuestion(new Questions("Quelle est la syntaxe correcte pour indiquer un lien hypertexte ?",
                        new Proposition("<a href='page.html'> Lien </a>", true),
                        new Proposition("<a href='page.html'> Lien <a>", false),
                        new Proposition("<a lref='page.html'> Lien </a>", false),
                        new Proposition("<link href='page.html'> Lien </link>", false)
                        ));


        ajouterQuestion(new Questions("Comment indique-t'on la source d'une image dans la balise <img> ?",
                        new Proposition("avec l'attribut : src", true),
                        new Proposition("avec l'attribut : source", false),
                        new Proposition("avec l'attribut : href",false ),
                        new Proposition("avec l'attribut : link", false)
                        ));


        ajouterQuestion(new Questions("La balise <ul> permet de créer une liste...",
                        new Proposition("ordonnée", false),
                        new Proposition("non ordonnée", true)
                        ));


        ajouterQuestion(new Questions("Combien existe-t'il de niveau pour la balise titre <h..>",
                        new Proposition("6", true),
                        new Proposition("4",false ),
                        new Proposition("3", false),
                        new Proposition("10",false )
                        ));


        ajouterQuestion(new Questions("Une ligne dans un tableau en HTML commence par la balise...",
                        new Proposition("<tr>",true ),
                        new Proposition("<td>", false),
                        new Proposition("<th>", false),
                        new Proposition("<trow>", false)
                        ));


        ajouterQuestion(new Questions("Comment écrit-on du CSS dans un fichier HTML ?",
                        new Proposition("avec la balise <style>",true ),
                        new Proposition("avec la balise <css>", false)
                        ));


        ajouterQuestion(new Questions("En CSS, comment sélectionne-t'on un attribut 'id' d'un fichier HTML ?",
                        new Proposition("avec '#'", true),
                        new Proposition("avec '.'", false)
                        ));


        ajouterQuestion(new Questions("En CSS, comment selectionne-t'on un attribut 'class' d'un fichier HTML ?",
                        new Proposition("avec '#'", false),
                        new Proposition("avec '.'", true)
                        ));


        ajouterQuestion(new Questions("Comment accède-t'on à une pseudo-classe d'un sélecteur en CSS ?",
                        new Proposition("avec ':'", true),
                        new Proposition("avec '.'",false ),
                        new Proposition("avec ';'", false),
                        new Proposition("avec '-'",false )
                        ));


        ajouterQuestion(new Questions("En CSS, comment modifie-t'on l'alignement du texte ?",
                        new Proposition("avec la propriété text-align", true),
                        new Proposition("avec la propriété alignment", false),
                        new Proposition("avec la propriété text-aligment", false )
                        ));


        ajouterQuestion(new Questions("En CSS, une balise de type bloc crée un retour à la ligne...",
                        new Proposition("avant",true ),
                        new Proposition("après",true )
                        ));


        ajouterQuestion(new Questions("En HTML, quelle balise marque le début d'un formulaire ?",
                        new Proposition("<form>", true),
                        new Proposition("<formulaire>", false),
                        new Proposition("<fill>", false),
                        new Proposition("<forms>", false)
                        ));


        ajouterQuestion(new Questions("Quelle balise permet d'insérer un élément audio sur une page HTML ?",
                        new Proposition("<audio>", true),
                        new Proposition("<music>", false),
                        new Proposition("<sound>", false),
                        new Proposition("<song>", false)
                        ));


        ajouterQuestion(new Questions("Comment peut-on ajouter du style à une page HTML ?",
                        new Proposition("en reliant un fichier .css à la page HTML",true ),
                        new Proposition("en écrivant le style dans le fichier HTML",true )
                        ));


        ajouterQuestion(new Questions("Comment relie-t'on un fichier .css à une page HTML ?",
                        new Proposition("avec la balise <link>", true),
                        new Proposition("avec la balise <css>", false)
                        ));


        ajouterQuestion(new Questions("Quelle est la première ligne d'un fichier HTML ?",
                        new Proposition("<!DOCTYPE html>", true),
                        new Proposition("<html>", false),
                        new Proposition("<head>", false),
                        new Proposition("<html lang='fr'>",false )
                        ));


        
    }
}

