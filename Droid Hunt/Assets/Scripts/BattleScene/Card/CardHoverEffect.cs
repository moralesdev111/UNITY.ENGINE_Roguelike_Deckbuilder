using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Vector3 originalScale;
    private Vector3 hoverScale;

    private void Start()
    {
        SetScales();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = hoverScale;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = originalScale;
    }

    private void SetScales()
    {
        originalScale = transform.localScale;
        hoverScale = originalScale * 1.5f;
    }
}
