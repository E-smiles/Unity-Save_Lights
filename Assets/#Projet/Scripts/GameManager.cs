using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;

    void Start()
    {
        //Ne détruit pas mon objet
        DontDestroyOnLoad(gameObject);
    }

   
}
