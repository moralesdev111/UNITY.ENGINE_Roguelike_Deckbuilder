using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HighlightCardIfPlayable : MonoBehaviour
{
    [SerializeField] Material material;
    [SerializeField] Image image;

    void Update()
    {
        ChangeColorBasedOnAvailableEnergy();
    }

    private void ChangeColorBasedOnAvailableEnergy()
    {
        image.color = GameManager.Instance.player.currentEnergy >= this.GetComponent<CardInstance>().card.energyCost ? material.color = material.color : Color.white;
    }
}
