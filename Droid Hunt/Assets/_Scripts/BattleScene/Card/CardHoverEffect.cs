using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Vector3 originalScale;
    [SerializeField] Image descriptionUI;
    private Vector3 originalPosition;
    private Vector3 hoverScale;
    private LayoutElement layoutElement;
    private int originalSiblingIndex; 

    private void Start()
    {
        originalPosition = transform.position;
        SetScales();
        layoutElement = GetComponent<LayoutElement>(); 
        originalSiblingIndex = transform.GetSiblingIndex();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        layoutElement.ignoreLayout = true;
        transform.localScale = hoverScale;
        descriptionUI.gameObject.SetActive(true);
        transform.position = transform.position + new Vector3(0, 60, 0);

        // Move the card to the last position among its siblings to bring it to the front
        transform.SetAsLastSibling();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        layoutElement.ignoreLayout = false;
        transform.localScale = originalScale;
        descriptionUI.gameObject.SetActive(false);

        // Move the card back to its original position among its siblings
        transform.SetSiblingIndex(originalSiblingIndex);
    }

    private void SetScales()
    {
        originalScale = transform.localScale;
        hoverScale = originalScale * 1.5f;
    }
}
