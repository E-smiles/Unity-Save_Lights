using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Elle peut contenir un gamemanager, et etre accessible de partout
    public static GameManager instance;
    public int score;
    //Peut se faire avant le start, tout n'est pas vraiment encore initialisé
    void Awake(){
        //Si notre variable instance et null alors on dit de ne pas détruire et on sauvegarde celle qui vient de se reveiller.
        //Si il y en a deja un reveillé, alors on le détruit
        //Ne détruit pas mon objet
        if(instance == null){
            DontDestroyOnLoad(gameObject);
            instance = this;

        }else if(instance != this){
            Destroy(gameObject);
        }


    }

   

   
}
