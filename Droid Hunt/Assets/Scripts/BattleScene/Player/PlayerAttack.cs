using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public void HandleAttack(Enemy enemy, CardInstance cardInPlay)
    {
        enemy.currentParts -= cardInPlay.card.utilityValue;
        GameManager.Instance.player.currentEnergy -= cardInPlay.card.energyCost;
        GameManager.Instance.playerHand.Container.Remove(cardInPlay.card);
        Destroy(transform.parent.gameObject);
    }
}
