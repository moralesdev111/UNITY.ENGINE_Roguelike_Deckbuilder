using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public void HandleAttack(EnemyInstance enemy, CardInstance cardInPlay)
    {
        if(cardInPlay.card.cardType == Card.CardType.attack)
        {
            enemy.currentParts -= cardInPlay.card.utilityValue;
            SceneManager.Instance.player.currentEnergy -= cardInPlay.card.energyCost;
            SceneManager.Instance.playerHand.Container.Remove(cardInPlay.card);
            Destroy(transform.parent.gameObject);
        }
        
        if (enemy.currentParts <= 0)
        {
            SceneManager.Instance.UpdateGameState(SceneManager.GameState.finishScreen);
        }
    }
}
