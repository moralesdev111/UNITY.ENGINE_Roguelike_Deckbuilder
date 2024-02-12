using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayCard : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        if(GameManager.Instance.player.currentEnergy >= eventData.pointerClick.GetComponent<CardInstance>().card.energyCost)
        {
            PlaceHolderPlayCard(eventData);
        }
        
    }

    private void PlaceHolderPlayCard(PointerEventData eventData)
    {
        GameManager.Instance.player.currentEnergy -= eventData.pointerClick.GetComponent<CardInstance>().card.energyCost;
        GameManager.Instance.enemy.currentParts -= eventData.pointerClick.GetComponent<CardInstance>().card.utilityValue;
        Destroy(gameObject);
        GameManager.Instance.playerHand.Container.Remove(eventData.pointerClick.GetComponent<CardInstance>().card);
    }
}
