using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_Drag : MonoBehaviour
{
    [SerializeField] GameObject prefabsObject;
    [SerializeField] GameObject HatiDuplicate;
    [SerializeField] GameObject JGDuplicate;
    [SerializeField] GameObject SGTGDuplicate;
    [SerializeField] GameObject LGKRNDuplicate;
    [SerializeField] GameObject KTPTDuplicate;
    Vector3 JGPos;
    Vector3 SGTGPos;
    Vector3 LGKRNPos;
    Vector3 HatiPos;
    Vector3 KTPTPos;
    GameObject posisiDuplikasi;

    // Start is called before the first frame update
    private void Start()
    {
        var Item = (GameObject)Instantiate(prefabsObject,transform.position,Quaternion.identity);
        // Item.transform.parent = gameObject.transform;
        Item.transform.SetParent(gameObject.transform);
        Debug.Log(gameObject.transform.position);

        JGPos = new Vector3(1052,873,0);
        SGTGPos = new Vector3(1050,737,0);
        LGKRNPos = new Vector3(1052,593,0);
        HatiPos = new Vector3(1052,453,0);
        KTPTPos = new Vector3(1049,312,0);

        posisiDuplikasi = GameObject.Find("KTPT_Drag_Tile");
    }
    public void DuplicateObjectHati()
    {
        var ItemHati = (GameObject)Instantiate(HatiDuplicate,HatiPos,Quaternion.identity);
        Debug.Log(ItemHati.name);
        Debug.Log(ItemHati.transform.position);
        // Item.transform.parent = gameObject.transform;
        ItemHati.transform.SetParent(posisiDuplikasi.transform);
    }
    public void DuplicateObjectJG()
    {
        var ItemJG = (GameObject)Instantiate(JGDuplicate,JGPos,Quaternion.identity);
        Debug.Log(ItemJG.name);
        // Debug.Log(gameObject.transform);
        // Item.transform.parent = gameObject.transform;
        ItemJG.transform.SetParent(posisiDuplikasi.transform);
    }
    public void DuplicateObjectSGTG()
    {
        var ItemSGTG = (GameObject)Instantiate(SGTGDuplicate,SGTGPos,Quaternion.identity);
        Debug.Log(ItemSGTG.name);
        // Debug.Log(gameObject.transform);
        // Item.transform.parent = gameObject.transform;
        ItemSGTG.transform.SetParent(posisiDuplikasi.transform);
    }
    public void DuplicateObjectLGKRN()
    {
        var ItemLGKRN = (GameObject)Instantiate(LGKRNDuplicate,LGKRNPos,Quaternion.identity);
        Debug.Log(ItemLGKRN.name);
        // Debug.Log(gameObject.transform);
        // Item.transform.parent = gameObject.transform;
        ItemLGKRN.transform.SetParent(posisiDuplikasi.transform);
    }
    public void DuplicateObjectKTPT()
    {
        var ItemKTPT = (GameObject)Instantiate(KTPTDuplicate,KTPTPos,Quaternion.identity);
        Debug.Log(ItemKTPT.name);
        // Debug.Log(gameObject.name);
        // Item.transform.parent = gameObject.transform;
        ItemKTPT.transform.SetParent(posisiDuplikasi.transform);
    }
}
