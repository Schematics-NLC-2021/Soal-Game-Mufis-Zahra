using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LGKRN_Score : MonoBehaviour
{
    bool lgkrn1 = false;
    bool lgkrn2 = false;
    bool lgkrn3 = false;
    bool lgkrn4 = false;
    bool lgkrn5 = false;
    bool lgkrn6 = false;
    Game_Status game_Status;
    
    private void Start() {
        game_Status = FindObjectOfType<Game_Status>();
    }
    public void countCorrectLGKRN1()
    {
        lgkrn1 = true;
        if(lgkrn1)
            game_Status.countCorrect();
    }
    public void countCorrectLGKRN2()
    {
        lgkrn2 = true;
        if(lgkrn2)
            game_Status.countCorrect();
    }
    public void countCorrectLGKRN3()
    {
        lgkrn3 = true;
        if(lgkrn3)
            game_Status.countCorrect();
    }
    public void countCorrectLGKRN4()
    {
        lgkrn4 = true;
        if(lgkrn4)
            game_Status.countCorrect();
    }
    public void countCorrectLGKRN5()
    {
        lgkrn5 = true;
        if(lgkrn5)
            game_Status.countCorrect();
    }
    public void countCorrectLGKRN6()
    {
        lgkrn6 = true;
        if(lgkrn6)
            game_Status.countCorrect();
    }
}
