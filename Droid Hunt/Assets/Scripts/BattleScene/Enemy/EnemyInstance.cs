using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyInstance : Robot
{
    [SerializeField] TextMeshProUGUI robotName;
    [SerializeField] TextMeshProUGUI attackDamage;
    public EnemyToFace enemyToFace;


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
        maxParts = enemyToFace.enemyRobot.maxParts;
        currentParts = enemyToFace.enemyRobot.maxParts;
        robotName.text = enemyToFace.enemyRobot.robotName;
        attackDamage.text = enemyToFace.enemyRobot.attack.ToString();
    }
}
