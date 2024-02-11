using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PlayerHand : SlotContainer
{
    [SerializeField] Transform hand;
    [SerializeField] DrawCard drawCard;
    [SerializeField] PlayerDeck playerDeck;
    [SerializeField] DrawToHand drawToHand;
    

    void Start()
    {
        ContainerSizeLimit = 5;
        container = new List<Card>();
        RandomizeContainer();
    }

    void Update()
    {
        UpdateContainerSize();
    }


    public override void RandomizeContainer()
    {
        for(int i = 0; i < ContainerSizeLimit; i++)
        {
            StartDrawProcess();
        }
    }

    private void StartDrawProcess()
    {
        if(CurrentContainerSize < ContainerSizeLimit)
        {
            Card randomCard = drawCard.DrawOneRandomCard(playerDeck.Container);
            {
                if(randomCard != null)
                {
                    GameObject newCardObject = drawToHand.VisualInstantiateInHand();

                    CardInstance cardInstance = newCardObject.GetComponent<CardInstance>();
                    cardInstance.card = randomCard;

                    container.Add(randomCard);
                }
                else
            {
                Debug.LogWarning("Unable to get a random card from the database.");
            }
            }
        }
    }
}
