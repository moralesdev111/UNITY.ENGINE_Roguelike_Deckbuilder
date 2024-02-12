using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SetTargetingUIActive : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject playArrow;


    public void OnPointerClick(PointerEventData eventData)
    {
        CheckIfWeCanPlayCard(eventData);
    }

    private void CheckIfWeCanPlayCard(PointerEventData eventData)
    {
        if (GameManager.Instance.player.currentEnergy >= eventData.pointerClick.GetComponent<CardInstance>().card.energyCost)
        {
            playArrow.SetActive(true);
        }
        else
        {
            return;
        }
    }
}
