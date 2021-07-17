using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hati_Score : MonoBehaviour
{
    Game_Status game_Status;
    bool hati1 = false;
    bool hati2 = false;
    bool hati3 = false;
    bool hati4 = false;
    bool hati5 = false;
    bool hati6 = false;
    bool hati7 = false;
    bool hati8 = false;
    private void Start() {
        game_Status = FindObjectOfType<Game_Status>();
    }
    public void countCorrectHati1()
    {
        hati1 = true;
        if(hati1)
            game_Status.countCorrect();
    }
    public void countCorrectHati2()
    {
        hati2 = true;
        if(hati2)
            game_Status.countCorrect();
    }
    public void countCorrectHati3()
    {
        hati3 = true;
        if(hati3)
            game_Status.countCorrect();
    }
    public void countCorrectHati4()
    {
        hati4 = true;
        if(hati4)
            game_Status.countCorrect();
    }
    public void countCorrectHati5()
    {
        hati5 = true;
        if(hati5)
            game_Status.countCorrect();
    }
    public void countCorrectHati6()
    {
        hati6 = true;
        if(hati6)
            game_Status.countCorrect();
    }
    public void countCorrectHati7()
    {
        hati7 = true;
        if(hati7)
            game_Status.countCorrect();
    }
    public void countCorrectHati8()
    {
        hati8 = true;
        if(hati8)
            game_Status.countCorrect();
    }
}
