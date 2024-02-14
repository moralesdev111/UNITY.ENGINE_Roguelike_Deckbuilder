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
        CardInstance currentCard = eventData.pointerClick.GetComponent<CardInstance>();
        if (SceneManager.Instance.player.currentEnergy >= currentCard.card.energyCost)
        {
            if(currentCard.card.cardType == Card.CardType.utility)
            {
                SceneManager.Instance.player.currentEnergy -= currentCard.card.energyCost;
                SceneManager.Instance.player.currentParts += currentCard.card.utilityValue;
                SceneManager.Instance.playerHand.Container.Remove(currentCard.card);
                Destroy(currentCard.gameObject);
            }
            else
            {
                playArrow.SetActive(true);
            }
            
        }
        else
        {
            return;
        }
    }
}
