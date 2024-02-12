using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : Robot
{
    public EnemyRobot enemyRobot;
    [SerializeField] TextMeshProUGUI robotName;


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
        maxParts = enemyRobot.maxParts;
        currentParts = maxParts;
        robotName.text = enemyRobot.robotName;
    }
}
