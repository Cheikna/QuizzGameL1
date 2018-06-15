using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Algebre : Matiere
{
    public override void chargementQuestions()
    {
        ajouterQuestion(new Questions("Que peut-on dire de l'implication : P => Q ?",
                        new Proposition("si P est vraie alors Q l'est aussi", true),
                        new Proposition("pour que P soit vraie, il faut que Q soit vraie", true ),
                        new Proposition("P est une condition suffisante de Q", true),
                        new Proposition("P est une condition nécéssaire de Q", false )
                        ));


        ajouterQuestion(new Questions("Deux propositions P et Q sont équivalentes si et seulement si...",
                        new Proposition("P => Q et Q => P", true),
                        new Proposition("P => Q ou Q => P", false)
                        ));


        ajouterQuestion(new Questions("Soit E et F des ensembles. Qu'est-ce-qu'une application de E dans F ?",
                        new Proposition("tout élément de E a une image unique dans F",true ),
                        new Proposition("tout élément de F a une image unique dans E", false)
                        ));


        ajouterQuestion(new Questions("Soient E,F des ensembles et A un sous-ensemble de F. On appelle image de A...",
                        new Proposition("l'ensemble des images des éléments de A par f dans F", true ),
                        new Proposition("l'ensemble des images des éléments de A par f dans E", false )
                        ));


        ajouterQuestion(new Questions("Soit E et F des ensembles. Une application injective est une application où...",
                        new Proposition("tout élément de F a au plus un antécédent dans E",true ),
                        new Proposition("tout élément de F a au moins un antécédent dans E",false ),
                        new Proposition("tout élément de F a un antécédent unique dans E", false )
                        ));


        ajouterQuestion(new Questions("Soit E et F des ensembles. Soit E et F des ensembles. Une application surjective est une application où...",
                        new Proposition("tout élément de F a au moins un antécédent dans E", true ),
                        new Proposition("tout élément de F a au plus un antécédent dans E", false ),
                        new Proposition("tout élément de F a un antécédent unique dans E", false )
                        ));


        ajouterQuestion(new Questions("Soit E et F des ensembles. Soit E et F des ensembles. Une application bijective est une application où...",
                        new Proposition("tout élément de F a un antécédent unique dans E", true ),
                        new Proposition("tout élément de F a au plus un antécédent dans E", false),
                        new Proposition("tout élément de F a au moins un antécédent dans E", false)
                        ));


        ajouterQuestion(new Questions("Soit E et F deux ensembles. f est une application linéaire de E dans F si et seulement si il existe u et v appartenant à E² et a et b appartenant à R²...",
                        new Proposition("et f(a*u + b*v) = a*f(u) + b * f(v)", true ),
                        new Proposition("et f(a*v + b*u) = a*f(u) + b * f(v)", false)
                        ));


        ajouterQuestion(new Questions("Soit E et F deux ensembles. Un endomorphisme est...",
                        new Proposition("une application linéaire de E dans E", true),
                        new Proposition("une application linéaire bijective de E dans F",false )
                        ));


        ajouterQuestion(new Questions("Soit E et F deux ensembles. Un isomorphisme est...",
                        new Proposition("une application linéaire bijective de E dans F",true ),
                        new Proposition("une application linéaire de E dans E", false )
                        ));


        ajouterQuestion(new Questions("Soit E et F deux ensembles. Un automorphisme est...",
                        new Proposition("un endomorphisme bijectif E", true),
                        new Proposition("une application linéaire de E dans E", false),
                        new Proposition("Toute application linéaire bijective de E dans F", false)
                        ));


        ajouterQuestion(new Questions("Soit E et F deux ensembles. Que peut-on dire du noyau d'una application linéaire ?",
                        new Proposition("le noyau de f se note : Ker(f)", true ),
                        new Proposition("le noyau de f se note : Im(f)",false ),
                        new Proposition("c'est l'ensemble des vecteurs u de E tels  que f(u) = 0",true ),
                        new Proposition("l’ensemble des vecteurs v de F image d’un vecteur u de E", false )
                        ));


        ajouterQuestion(new Questions("Soit E et F deux ensembles. Que peut-on dire de l'image d'une application linéaire ?",
                        new Proposition("l'image de f se note : Im(f)", true),
                        new Proposition("l'image de f se note : Ker(f)", false ),
                        new Proposition("c'est l'ensemble des vecteurs u de E tels  que f(u) = 0", false ),
                        new Proposition("c'est l’ensemble des vecteurs v de F image d’un vecteur u de E", true )
                        ));


        ajouterQuestion(new Questions("Soit E un espace vectoriel sur IR et S = (u1,u2,..) une famille de vecteurs de E. Qu'est-ce qu'une famille génératrice ?",
                        new Proposition("toute famille finie S de vecteurs de E , telle que tout vecteur de E s’écrive comme combinaison linéaire des vecteurs de S", true),
                        new Proposition("si les vecteurs u1,u2,... sont indépendants", false )
                        ));


        ajouterQuestion(new Questions("Soit E un espace vectoriel sur IR. Qu'est-ce qu'une famille libre ?",
                        new Proposition("toute famille finie S de vecteurs de E , telle que tout vecteur de E s’écrive comme combinaison linéaire des vecteurs de S", false),
                        new Proposition("si les vecteurs u1,u2,... sont indépendants", true)
                        ));


        ajouterQuestion(new Questions("On appelle matrice diagonale d’ordre n,...",
                        new Proposition("toute matrice dont les éléments non diagonaux sont nuls.", true),
                        new Proposition("toute matrice dont les éléments non diagonaux sont non nuls.", false)
                        ));


        ajouterQuestion(new Questions("En général le produit matriciel...",
                        new Proposition("n’est pas commutatif.", true),
                        new Proposition("est pas commutatif.", false)
                        ));


        ajouterQuestion(new Questions("Soit A et B deux matrices dont le calcul de A*B est possible, alors",
                        new Proposition("Si AB = 0 on n'a pas nécessairement A = 0 ou B = 0", true),
                        new Proposition("Si AB = 0 on a nécessairement A = 0 ou B = 0", false ),
                        new Proposition("Si AB = AC , on n'a pas nécessairement B = C", true),
                        new Proposition("Si AB = AC , on a nécessairement B = C",false )
                        ));


        ajouterQuestion(new Questions("Que peut-on dire du rang de f ?",
                        new Proposition("on le note rg(f)", true),
                        new Proposition("il correspond à la dimension de Im(f)", true ),
                        new Proposition("il correspond à la dimension de Ker(f)", false)
                        ));


        ajouterQuestion(new Questions("Une matrice diagonale est inversible si et seulement si...",
                        new Proposition("tous ses éléments diagonaux sont non nuls.", true),
                        new Proposition("tous ses éléments diagonaux sont nuls.", false)
                        ));


        ajouterQuestion(new Questions("Une matrice triangulaire est inversible si et seulement si...",
                        new Proposition("tous ses éléments diagonaux sont non nuls.", true),
                        new Proposition("tous ses éléments diagonaux sont nuls.", false)
                        ));


        ajouterQuestion(new Questions("Quand peut-on dire que deux matrices sont équivalentes ?",
                        new Proposition("si elles sont les matrices d’une même application linéaire relativement à deux bases différentes", true ),
                        new Proposition("si elles ont le même rang", true),
                        new Proposition("si elles sont semblables", false )
                        ));


        ajouterQuestion(new Questions("Quand peut-on dire que deux matrices sont semblables ?",
                        new Proposition("si elles sont équivalentes", true ),
                        new Proposition("si elles ont le même rang", true )
                        ));


        /*ajouterQuestion(new Questions("",
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", ),
                        new Proposition("", )
                        ));*/
    }
}

