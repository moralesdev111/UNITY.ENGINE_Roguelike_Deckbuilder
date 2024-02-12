using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    [SerializeField] DrawCard drawCard;
    public List<Card> cardDatabase = new List<Card>();
}
