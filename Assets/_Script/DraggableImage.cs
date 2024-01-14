using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableImage : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Vector3 _tempPos;
    private RectTransform _rectTransform;
    private Image _image;

    public Transform LastSlotTransform;
    [HideInInspector] public bool IsDragSameImage;


    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        _image = GetComponent<Image>();
    }


    void Update()
    {
        
    }

    #region Drag Image
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        _tempPos = _rectTransform.anchoredPosition;
        _image.raycastTarget = false;
        transform.SetParent(transform.root);
        LastSlotTransform = 
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        _rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("DragEnd");
        _rectTransform.anchoredPosition = _tempPos;
        _image.raycastTarget = true;
    }
    #endregion

}
