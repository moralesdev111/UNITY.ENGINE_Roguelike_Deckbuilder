using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public void HandleAttack(Enemy enemy, CardInstance cardInPlay)
    {
        if(cardInPlay.card.cardType == Card.CardType.utility)
        {
            GameManager.Instance.player.currentEnergy -= cardInPlay.card.energyCost;
            GameManager.Instance.player.currentParts += cardInPlay.card.utilityValue;
            GameManager.Instance.playerHand.Container.Remove(cardInPlay.card);
            Destroy(transform.parent.gameObject);
        }
        else
        {
            enemy.currentParts -= cardInPlay.card.utilityValue;
            GameManager.Instance.player.currentEnergy -= cardInPlay.card.energyCost;
            GameManager.Instance.playerHand.Container.Remove(cardInPlay.card);
            Destroy(transform.parent.gameObject);
        }
        
        if (enemy.currentParts <= 0)
        {
            GameManager.Instance.UpdateGameState(GameManager.GameState.finishScreen);
        }
    }
}
