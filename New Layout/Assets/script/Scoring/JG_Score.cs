using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JG_Score : MonoBehaviour
{
    bool jg1 = false;
    Game_Status game_Status;
    private void Start() {
        game_Status = FindObjectOfType<Game_Status>();
    }
    
    public void countCorrectJG1()
    {
        jg1 = true;
        if(jg1)
            game_Status.countCorrect();
    }
}
