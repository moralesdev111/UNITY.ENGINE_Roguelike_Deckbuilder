using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;

public class SetUIValues : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI gold;
    [SerializeField] TextMeshProUGUI parts;
    [SerializeField] PlayerProgression playerProgression;
    
    
    void Start()
    {
        SetPathSceneUIValues();
    }

    private void SetPathSceneUIValues()
    {
        gold.text = "Gold: " + playerProgression.gold;
        parts.text = "Parts: " + playerProgression.currentParts;
    }
}
