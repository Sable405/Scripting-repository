using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{   //public Member/Gobal variables
    //Declaring Variables
    public float MoveSpeed = 10f;
    public int PlayerScore = 0;
    public string PlayerName = "John Doe";
    public bool IsPlayerActive = true;
    //private Member/Gobal variables
    private float _maxspeed = 100f;
    private int _totalScore = 0;
    private string _username = "xXXMegaM@nXXx";
    private bool _isGameOver = false;

    // Start is called before the first frame update

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //declaring local variables 
        float horizontalInput = Input.GetAxis("Horizontal");
    }
    private void UpdateScore(int amount)
    {
         //using a local variable to update the total score
         _totalScore += amount;
    }
}   
