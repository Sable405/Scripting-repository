using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{

    //Create a method called "DecreaseHealth" that subtracts 20 from the "health" variable.
    //Call the "DecreaseHealth" method.

    public int Score = 0;
    public string playerName = "Kris Montes";
    public float health = 100;

    // Start is called before the first frame update
    void Start()
    {
        PrintPlayerName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void IncreaseScore () 
    {
        Score = Score + 1;
    }   

    void PrintPlayerName () 
    {
        Debug.Log(playerName);
    }
    
    void DecreaseHealth() 
    {
        health = 100 - 20;
        Debug.Log(health);
    }
}
