using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragged : MonoBehaviour,IBeginDragHandler,IEndDragHandler, IDragHandler
{
    Vector3 startPosition;
    Transform StartParent;
    public static GameObject itemBeingDragged;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public static Vector3 resetPosition;
    Place_Drag place_Drag;

    private void Awake() 
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        place_Drag = FindObjectOfType<Place_Drag>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;

        resetPosition = this.transform.localPosition;
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        StartParent = transform.parent;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        itemBeingDragged = null;

        if(transform.parent != StartParent)
        {
            canvasGroup.alpha = 1f;
            canvasGroup.blocksRaycasts = true;
            transform.position = startPosition;

            place_Drag.DuplicateObject();
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x,resetPosition.y,resetPosition.z);
            canvasGroup.alpha = 1f;
            canvasGroup.blocksRaycasts = true;
        }
    }
}