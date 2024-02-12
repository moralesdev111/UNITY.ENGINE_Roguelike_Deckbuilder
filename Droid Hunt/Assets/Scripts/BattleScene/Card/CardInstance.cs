using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CardInstance : MonoBehaviour
{
    public Card card;
    [Header("References")]
    [SerializeField] TextMeshProUGUI cardName;
    [SerializeField] TextMeshProUGUI cardAbility;
    [SerializeField] Image artwork;
    [SerializeField] TextMeshProUGUI energyCost;
    [SerializeField] Material attackMaterial;
     [SerializeField] Material utilityMaterial;

    void Start()
    {
        SetInstanceData();
    }

    private void SetInstanceData()
    {
        this.name = card.cardName;
        cardName.text = card.cardName;
        cardAbility.text = card.cardAbilityDescription;
        artwork.sprite = card.artwork;
        energyCost.text = card.energyCost.ToString();

        // Check card type and change text color accordingly
        if (card.cardType == Card.CardType.attack)
        {
            cardAbility.color = attackMaterial.color; // Set color to red for attack cards
        }
        else if (card.cardType == Card.CardType.utility)
        {
            cardAbility.color = utilityMaterial.color; // Set color to blue for utility cards
        }
    }
}
