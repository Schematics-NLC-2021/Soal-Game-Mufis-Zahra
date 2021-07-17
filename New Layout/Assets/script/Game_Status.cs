using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game_Status : MonoBehaviour
{
    [SerializeField] int correct = 0;
    public static int OnTile = 0;
    public static int CheckTile = OnTile + 1;
    [SerializeField] TextMeshProUGUI scoreText;
    // int total_tile = 28;
    public void countCorrect()
    {
        correct++;
        total();
    }
    public void ObjectOnChangeableTile()
    {
        if(OnTile == 28)
        {
            OnTile += 2; //buat berhentiin
        }
        else
        {
            OnTile++;
        }
        CheckTile++;
    }
    public void total()
    {
        scoreText.text = "Your Correct Tiles are "+ correct + " of 28";
    }
    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
