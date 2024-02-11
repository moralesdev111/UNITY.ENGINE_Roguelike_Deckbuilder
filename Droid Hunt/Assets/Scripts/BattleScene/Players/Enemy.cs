using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : Robot
{
    void Start()
    {
        SetupStats();
    }

    void Update()
    {
       UpdateRobotUI();
    }

    public override void UpdateRobotUI()
    {
        currentPartsDisplay.text = "Parts: " + currentParts.ToString();
    }

    public override void SetupStats()
    {
        maxParts = 30;
        currentParts = maxParts;
    }
}
