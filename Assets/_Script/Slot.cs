using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour , IDropHandler
{
    public GameObject _holdObject;
    private bool _isHoldObject;
    void Start()
    {
        if(transform.GetChild(0) != null)
        {
            _holdObject = transform.GetChild(0).gameObject;
            _isHoldObject = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(gameObject.name + " Drop ");

        if(_isHoldObject == false)
        {
            Transform droppedTransform = eventData.pointerDrag.transform;
            droppedTransform.SetParent(transform);

        }

    }
}
