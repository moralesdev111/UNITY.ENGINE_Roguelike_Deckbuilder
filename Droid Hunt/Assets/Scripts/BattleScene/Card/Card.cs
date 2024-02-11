using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public string cardAbility;
    public Sprite artwork;
    public int energyCost;
    public int utilityValue;
    public CardType cardType;
    public enum CardType
    {
        attack,
        utility
    }
}
