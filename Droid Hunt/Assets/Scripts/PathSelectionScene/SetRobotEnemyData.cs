using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRobotEnemyData : MonoBehaviour
{
    [SerializeField] Player2D player2D;
    [SerializeField] EnemyToFace enemyToFace;
    public EnemyRobot enemyRobot;


    void Update()
    {
        SetRobotEnemyDependingOnPath();
    }

    private void SetRobotEnemyDependingOnPath()
    {
        if (player2D.chosenPath != null)
        {
            player2D.player2DLocation.position = Vector3.MoveTowards(player2D.player2DLocation.position, player2D.chosenPath.transform.position, player2D.movementSpeed * Time.deltaTime);
            enemyRobot = player2D.chosenPath.GetComponent<SelectPathTarger>().enemyRobot;
            Debug.Log("player will face" + enemyRobot);
            enemyToFace.enemyRobot = enemyRobot;
        }
    }
}
