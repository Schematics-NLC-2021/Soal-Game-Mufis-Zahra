using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KTPT_Score : MonoBehaviour
{
    bool ktpt1 = false;
    bool ktpt2 = false;
    bool ktpt3 = false;
    bool ktpt4 = false;
    bool ktpt5 = false;
    bool ktpt6 = false;
    bool ktpt7 = false;
    bool ktpt8 = false;
    Game_Status game_Status;
    private void Start() {
        game_Status = FindObjectOfType<Game_Status>();
    }
    public void countCorrectKTPT1()
    {
        ktpt1 = true;
        if(ktpt1)
            game_Status.countCorrect();
    }
    public void countCorrectKTPT2()
    {
        ktpt2 = true;
        if(ktpt2)
            game_Status.countCorrect();
    }
    public void countCorrectKTPT3()
    {
        ktpt3 = true;
        if(ktpt3)
            game_Status.countCorrect();
    }
    public void countCorrectKTPT4()
    {
        ktpt4 = true;
        if(ktpt4)
            game_Status.countCorrect();
    }
    public void countCorrectKTPT5()
    {
        ktpt5 = true;
        if(ktpt5)
            game_Status.countCorrect();
    }
    public void countCorrectKTPT6()
    {
        ktpt6 = true;
        if(ktpt6)
            game_Status.countCorrect();
    }
    public void countCorrectKTPT7()
    {
        ktpt7 = true;
        if(ktpt7)
            game_Status.countCorrect();
    }
    public void countCorrectKTPT8()
    {
        ktpt8 = true;
        if(ktpt8)
            game_Status.countCorrect();
    }
}
