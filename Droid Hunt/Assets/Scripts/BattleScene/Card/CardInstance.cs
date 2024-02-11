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
    [SerializeField] TextMeshProUGUI utilityValue;


      void Start()
    {
        SetInstanceData();
    }

    private void SetInstanceData()
    {
        cardName.text = card.name;
        cardAbility.text = card.cardAbility;
        artwork.sprite = card.artwork;
        energyCost.text = card.energyCost.ToString();
        utilityValue.text = card.utilityValue.ToString();
    }
}
