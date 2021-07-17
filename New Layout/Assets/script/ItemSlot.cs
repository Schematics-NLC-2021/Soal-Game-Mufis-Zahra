using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    Hati_Score hati_Score;
    JG_Score jG_Score;
    KTPT_Score kTPT_Score;
    LGKRN_Score lGKRN_Score;
    SGTG_Score sGTG_Score;

    public GameObject objectToFind;
    Game_Status game_Status;
    private void Start() {
        hati_Score = FindObjectOfType<Hati_Score>();
        jG_Score = FindObjectOfType<JG_Score>();
        kTPT_Score = FindObjectOfType<KTPT_Score>();
        lGKRN_Score = FindObjectOfType<LGKRN_Score>();
        sGTG_Score = FindObjectOfType<SGTG_Score>();
        game_Status = FindObjectOfType<Game_Status>();
    }
    public GameObject item
    {
        get{
            if(transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }
   public void OnDrop(PointerEventData eventData)
   {
       Debug.Log("OnDrop");
       if(!item)
       {
            ItemDragged.itemBeingDragged.transform.SetParent(transform);

            objectToFind = transform.GetChild(0).gameObject;
            Debug.Log(objectToFind.name);

            game_Status.ObjectOnChangeableTile();

            //pembaruan tgl 14-07-2021
            int Status1 = Game_Status.OnTile;
            int Status2 = Game_Status.CheckTile;

            //KTPT
            if(objectToFind.name == "KTPT(Clone)" && tag == "KTPT_Tile1")
            {
                kTPT_Score.countCorrectKTPT1();
            }
            else if(objectToFind.name == "KTPT(Clone)" && tag == "KTPT_Tile2")
            {
                kTPT_Score.countCorrectKTPT2();
            }
            else if(objectToFind.name == "KTPT(Clone)" && tag == "KTPT_Tile3")
            {
                kTPT_Score.countCorrectKTPT3();
            }
            else if(objectToFind.name == "KTPT(Clone)" && tag == "KTPT_Tile4")
            {
                kTPT_Score.countCorrectKTPT4();
            }
            else if(objectToFind.name == "KTPT(Clone)" && tag == "KTPT_Tile5")
            {
                kTPT_Score.countCorrectKTPT5();
            }
            else if(objectToFind.name == "KTPT(Clone)" && tag == "KTPT_Tile6")
            {
                kTPT_Score.countCorrectKTPT6();
            }
            else if(objectToFind.name == "KTPT(Clone)" && tag == "KTPT_Tile7")
            {
                kTPT_Score.countCorrectKTPT7();
            }
            else if(objectToFind.name == "KTPT(Clone)" && tag == "KTPT_Tile8")
            {
                kTPT_Score.countCorrectKTPT8();
            }
            else if(objectToFind.name == "JG(Clone)" && tag == "JG_Tile1")
            { //JajarGenjang
                jG_Score.countCorrectJG1();
            }
            else if(objectToFind.name == "Hati(Clone)" && tag == "Hati_Tile1")
            { // Hati
                hati_Score.countCorrectHati1();
            }
            else if(objectToFind.name == "Hati(Clone)" && tag == "Hati_Tile2")
            {
                hati_Score.countCorrectHati2();
            }
            else if(objectToFind.name == "Hati(Clone)" && tag == "Hati_Tile3")
            {
                hati_Score.countCorrectHati3();
            }
            else if(objectToFind.name == "Hati(Clone)" && tag == "Hati_Tile4")
            {
                hati_Score.countCorrectHati4();
            }
            else if(objectToFind.name == "Hati(Clone)" && tag == "Hati_Tile5")
            {
                hati_Score.countCorrectHati5();
            }
            else if(objectToFind.name == "Hati(Clone)" && tag == "Hati_Tile6")
            {
                hati_Score.countCorrectHati6();
            }
            else if(objectToFind.name == "Hati(Clone)" && tag == "Hati_Tile7")
            {
                hati_Score.countCorrectHati7();
            }
            else if(objectToFind.name == "Hati(Clone)" && tag == "Hati_Tile8")
            {
                hati_Score.countCorrectHati8();
            }
            else if(objectToFind.name == "Hati(Clone)" && tag == "Hati_Tile9")
            {
                hati_Score.countCorrectHati8();
            }
            else if(objectToFind.name == "LGKRN(Clone)" && tag == "LGKRN_Tile1")
            { //Lingkaran
                Debug.Log(objectToFind.name);
                lGKRN_Score.countCorrectLGKRN1();
            }
            else if(objectToFind.name == "LGKRN(Clone)" && tag == "LGKRN_Tile2")
            { 
                lGKRN_Score.countCorrectLGKRN2();
            }
            else if(objectToFind.name == "LGKRN(Clone)" && tag == "LGKRN_Tile3")
            { 
                lGKRN_Score.countCorrectLGKRN3();
            }
            else if(objectToFind.name == "LGKRN(Clone)" && tag == "LGKRN_Tile4")
            { 
                lGKRN_Score.countCorrectLGKRN4();
            }
            else if(objectToFind.name == "LGKRN(Clone)" && tag == "LGKRN_Tile5")
            { 
                lGKRN_Score.countCorrectLGKRN5();
            }
            else if(objectToFind.name == "LGKRN(Clone)" && tag == "LGKRN_Tile6")
            { 
                lGKRN_Score.countCorrectLGKRN6();
            }
            else if(objectToFind.name == "SGTG(Clone)" && tag == "SGTG_Tile1")
            { //Segitiga
                sGTG_Score.countCorrectSGTG1();
            }
            else if(objectToFind.name == "SGTG(Clone)" && tag == "SGTG_Tile3")
            { 
                sGTG_Score.countCorrectSGTG3();
            }
            else if(objectToFind.name == "SGTG(Clone)" && tag == "SGTG_Tile4")
            { 
                sGTG_Score.countCorrectSGTG4();
            }
            else if(objectToFind.name == "SGTG(Clone)" && tag == "SGTG_Tile5")
            { 
                sGTG_Score.countCorrectSGTG5();
            }
       }
   }
}
