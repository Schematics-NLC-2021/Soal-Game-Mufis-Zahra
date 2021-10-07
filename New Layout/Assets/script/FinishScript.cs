using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        FinishGame();
    }
    public void FinishGame(){
        Time.timeScale = 0;
    }
}
