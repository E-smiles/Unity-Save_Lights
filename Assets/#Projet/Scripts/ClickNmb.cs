using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ClickNmb : MonoBehaviour
{
    public int ClickCount =0;
    public int HighScore;
    public TextMeshProUGUI counter;
    public TextMeshProUGUI HighScoreText;
    public string hiScorePref = "HighscoreNbr";
    
    public void Clicked(){
        ClickCount++;
        GameManager.instance.score = ClickCount;
        counter.text = ClickCount.ToString();

    }

    public void Start(){

            HighScore = PlayerPrefs.GetInt(hiScorePref,0);
            UpdateHighScoreText();
            ClickCount = GameManager.instance.score;
            counter.text = ClickCount.ToString();

    }

    public void Done(){
    //Au moment ou on click sur Done -> si le click et plus grand que le high score alors sauvegarde le high score
        if(ClickCount > HighScore){
            HighScore = ClickCount;
            PlayerPrefs.SetInt(hiScorePref, HighScore);
            UpdateHighScoreText();
        }

    //Remettre le compteur à zéro
        ClickCount =0;
    //Mettre à jour le compteur text
        counter.text = ClickCount.ToString();

        SceneManager.LoadScene("Scene2");

    }

    private void UpdateHighScoreText(){
    //Fonction me permettant de mettre à jour le texte avec le high score
        HighScoreText.text = "High Score: " + HighScore.ToString();;

    }

}
