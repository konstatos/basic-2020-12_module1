using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Tooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI view;
    public string text;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        view.text = text;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        view.text = "";
    }
}
