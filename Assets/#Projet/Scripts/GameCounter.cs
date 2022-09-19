using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCounter : MonoBehaviour
{
    //Compter le nombre de fois qu'on à joué au jeu -> utilisation de getint - setint
    public int numberOfGames = 0;

    void Start()
    {
        //Si la clé du playerpref numGames existe, donne la valeur à numberofgames
        if(PlayerPrefs.HasKey("numGames")){
            numberOfGames = PlayerPrefs.GetInt("numGames");
        }

        //On augmente la variable
        numberOfGames++;

        //On a sauvgarder la variable on lui donnant la key et le nmb de int
        PlayerPrefs.SetInt("numGames", numberOfGames);
    }

}
