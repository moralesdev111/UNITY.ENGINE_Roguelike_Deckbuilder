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
        gold.text = "Gold: " + GameManager.Instance.player.gold.ToString();
        parts.text = "Parts: " + GameManager.Instance.player.currentParts.ToString();
    }
}
