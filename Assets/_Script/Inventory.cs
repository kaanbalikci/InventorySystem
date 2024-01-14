using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IPointerDownHandler
{
    private List<Slot> _slots = new List<Slot>();

    [SerializeField] private Transform _slotParent;


    void Start()
    {
        _slots = _slotParent.GetComponentsInChildren<Slot>().ToList();

    }

    // Update is called once per frame
    void Update()
    {




    }

    #region Mouse Inputs
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Týklanan Obj: " + gameObject.name + " - Týklama Baþlangýcý");
    }


    #endregion
}
