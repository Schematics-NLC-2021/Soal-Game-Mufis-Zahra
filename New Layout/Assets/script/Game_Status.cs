using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.InteropServices;

public class Game_Status : MonoBehaviour
{
    [SerializeField] GameObject Changeable_Tile1;
    [SerializeField] GameObject Changeable_Tile2;
    [SerializeField] GameObject Changeable_Tile3;
    [SerializeField] GameObject Changeable_Tile4;
    [SerializeField] GameObject Changeable_Tile5;
    [SerializeField] GameObject Changeable_Tile6;
    [SerializeField] GameObject Changeable_Tile7;
    [SerializeField] GameObject Changeable_Tile8;
    [SerializeField] GameObject Changeable_Tile9;
    [SerializeField] GameObject Changeable_Tile10;
    [SerializeField] GameObject Changeable_Tile11;
    [SerializeField] GameObject Changeable_Tile12;
    [SerializeField] GameObject Changeable_Tile13;
    [SerializeField] GameObject Changeable_Tile14;
    [SerializeField] GameObject Changeable_Tile15;
    [SerializeField] GameObject Changeable_Tile16;
    [SerializeField] GameObject Changeable_Tile17;
    [SerializeField] GameObject Changeable_Tile18;
    [SerializeField] GameObject Changeable_Tile19;
    [SerializeField] GameObject Changeable_Tile20;
    [SerializeField] GameObject Changeable_Tile21;
    [SerializeField] GameObject Changeable_Tile22;
    [SerializeField] GameObject Changeable_Tile23;
    [SerializeField] GameObject Changeable_Tile24;
    [SerializeField] GameObject Changeable_Tile25;
    [SerializeField] GameObject Changeable_Tile26;
    [SerializeField] GameObject Changeable_Tile27;
    [SerializeField] GameObject Changeable_Tile28;

    [SerializeField] GameObject Hati;
    [SerializeField] GameObject JG;
    [SerializeField] GameObject SGTG;
    [SerializeField] GameObject LGKRN;
    [SerializeField] GameObject KTPT;
    [SerializeField] Button Submit;
    [SerializeField] Button Restart;
    [SerializeField] int correct = 0;
    public static bool GameIsFinished = false;
    public static int OnTile = 0;
    public static int CheckTile = OnTile + 1;
    [SerializeField] TextMeshProUGUI scoreText;
    public int CalculateScore;
    // int total_tile = 28;
    [DllImport("__Internal")]
    public static extern void sendscore(int score);
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
            OnTile+=1;
        }
        CheckTile++;
    }
    public void total()
    {
        scoreText.text = "Your Correct Tiles are "+ correct + " of 28";
    }
    public void sendingscore()
    { 
        CalculateScore = (int)Mathf.Round((correct * 30)/28);
        Debug.Log(CalculateScore);
        Debug.Log(correct);
        sendscore(CalculateScore);
    }
    public void FinishGame(){
        sendingscore();
    }
    public void ResetGame()
    {
        Destroy(gameObject);
    }
    public void HideButton(){ 
        Submit.gameObject.SetActive(false);
        Restart.gameObject.SetActive(false);
        DisabledScript();
    }
    public void DisabledScript(){ 
        Hati.gameObject.SetActive(false);
        JG.gameObject.SetActive(false);
        SGTG.gameObject.SetActive(false);
        LGKRN.gameObject.SetActive(false);
        KTPT.gameObject.SetActive(false);
    }
    public void RestartGame(){ 
        correct = 0;
        OnTile = 0;

        if(Changeable_Tile1.transform.childCount > 0){
            Destroy(Changeable_Tile1.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile2.transform.childCount > 0){
            Destroy(Changeable_Tile2.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile3.transform.childCount > 0){
            Destroy(Changeable_Tile3.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile4.transform.childCount > 0){
            Destroy(Changeable_Tile4.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile5.transform.childCount > 0){
            Destroy(Changeable_Tile5.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile6.transform.childCount > 0){
            Destroy(Changeable_Tile6.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile7.transform.childCount > 0){
            Destroy(Changeable_Tile7.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile8.transform.childCount > 0){
            Destroy(Changeable_Tile8.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile9.transform.childCount > 0){
            Destroy(Changeable_Tile9.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile10.transform.childCount > 0){
            Destroy(Changeable_Tile10.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile11.transform.childCount > 0){
            Destroy(Changeable_Tile11.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile12.transform.childCount > 0){
            Destroy(Changeable_Tile12.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile13.transform.childCount > 0){
            Destroy(Changeable_Tile13.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile14.transform.childCount > 0){
            Destroy(Changeable_Tile14.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile15.transform.childCount > 0){
            Destroy(Changeable_Tile15.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile16.transform.childCount > 0){
            Destroy(Changeable_Tile16.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile17.transform.childCount > 0){
            Destroy(Changeable_Tile17.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile18.transform.childCount > 0){
            Destroy(Changeable_Tile18.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile19.transform.childCount > 0){
            Destroy(Changeable_Tile19.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile20.transform.childCount > 0){
            Destroy(Changeable_Tile20.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile21.transform.childCount > 0){
            Destroy(Changeable_Tile21.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile22.transform.childCount > 0){
            Destroy(Changeable_Tile22.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile23.transform.childCount > 0){
            Destroy(Changeable_Tile23.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile24.transform.childCount > 0){
            Destroy(Changeable_Tile24.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile25.transform.childCount > 0){
            Destroy(Changeable_Tile25.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile26.transform.childCount > 0){
            Destroy(Changeable_Tile26.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile27.transform.childCount > 0){
            Destroy(Changeable_Tile27.transform.GetChild(0).gameObject);
        }

        if(Changeable_Tile28.transform.childCount > 0){
            Destroy(Changeable_Tile28.transform.GetChild(0).gameObject);
        }
    }
}
