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
        originalScale = transform.localScale;
        hoverScale = originalScale * 1.5f; // Adjust the scale factor as needed
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Enlarge the card when the mouse enters
        transform.localScale = hoverScale;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Return the card to its original size when the mouse exits
        transform.localScale = originalScale;
    }
}
