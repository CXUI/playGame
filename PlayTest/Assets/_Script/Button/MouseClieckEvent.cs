using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

[ExecuteInEditMode]
public class MouseClieckEvent : MonoBehaviour,IPointerClickHandler,IPointerDownHandler,IPointerExitHandler,IPointerUpHandler,IPointerEnterHandler {


   // public void

    /// <summary>
    /// 鼠标松开
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("鼠标松开（Anyplace）");
    }

    /// <summary>
    /// 鼠标在image上松开
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("鼠标松开（在Image）");
    }

    /// <summary>
    /// 鼠标在image点击按下
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("鼠标点击");
    }

    /// <summary>
    /// 鼠标离开image
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("鼠标离开");
    }

    /// <summary>
    /// 鼠标悬浮在image上
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("鼠标悬浮");

        QueueSaveInfortation.Instance().QueueElementCount();
          
    }
}
