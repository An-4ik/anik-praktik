using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AndroidTouch : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public GameObject Player;
    public void OnBeginDrag(PointerEventData eventData)  //проведение пальцем по оси Y
    {
        if ((Mathf.Abs(eventData.delta.x) < (Mathf.Abs(eventData.delta.y))))
        {
            if (eventData.delta.y > 0)
            {
                Player.GetComponent<Move>().moveUp = true;
            }
            else
            {
                Player.GetComponent<Move>().moveDown = true;
            }
        }
    }


    public void OnDrag(PointerEventData eventData)
    {
        //здесь пусто :)
    }
}
