using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_Drag : MonoBehaviour
{
    [SerializeField] GameObject prefabsObject;

    // Start is called before the first frame update
    void Start()
    {
        var Item = (GameObject)Instantiate(prefabsObject,transform.position,Quaternion.identity);
        // Item.transform.parent = gameObject.transform;
        Item.transform.SetParent(gameObject.transform);
    }

    // Update is called once per frame
    public void DuplicateObject()
    {
        var Item = (GameObject)Instantiate(prefabsObject,transform.position,Quaternion.identity);
        // Item.transform.parent = gameObject.transform;
        Item.transform.SetParent(gameObject.transform);
    }
}
