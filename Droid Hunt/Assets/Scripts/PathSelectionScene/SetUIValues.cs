using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;

public class SetUIValues : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI gold;
    [SerializeField] TextMeshProUGUI parts;
    
    
    void Start()
    {
        SetPathSceneUIValues();
    }

    private void SetPathSceneUIValues()
    {
        if (GameManager.Instance == null)
        {
             gold.text = "Gold: ";
             parts.text = "Parts: 50";
        }
        else if(GameManager.Instance != null)
        {
            gold.text = "Gold: " + GameManager.Instance.player.gold.ToString();
            parts.text = "Parts: " + GameManager.Instance.player.currentParts.ToString();
        }
    }
}
