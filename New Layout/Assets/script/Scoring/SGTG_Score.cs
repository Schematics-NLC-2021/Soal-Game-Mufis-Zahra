using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SGTG_Score : MonoBehaviour
{
    bool sgtg1 = false;
    bool sgtg2 = false;
    bool sgtg3 = false;
    bool sgtg4 = false;
    bool sgtg5 = false;
    Game_Status game_Status;
    private void Start() {
        game_Status = FindObjectOfType<Game_Status>();
    }

    public void countCorrectSGTG1()
    {
        sgtg1 = true;
        if(sgtg1)
            game_Status.countCorrect();
    }
    public void countCorrectSGTG2()
    {
        sgtg2 = true;
        if(sgtg2)
            game_Status.countCorrect();
    }
    public void countCorrectSGTG3()
    {
        sgtg3 = true;
        if(sgtg3)
            game_Status.countCorrect();
    }
    public void countCorrectSGTG4()
    {
        sgtg4 = true;
        if(sgtg4)
            game_Status.countCorrect();
    }
    public void countCorrectSGTG5()
    {
        sgtg5 = true;
        if(sgtg5)
            game_Status.countCorrect();
    }
}
