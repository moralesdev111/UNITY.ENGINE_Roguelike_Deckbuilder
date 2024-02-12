using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRobotEnemyData : MonoBehaviour
{
    [SerializeField] List<GameObject> pathChoices = new List<GameObject>();
    public GameObject chosenPath = null;
    [SerializeField] Transform player;
    [SerializeField] float movementSpeed;
    [SerializeField] EnemyToFace enemyToFace;
    public EnemyRobot enemyRobot;


    void Update()
    {
        SetRobotEnemyDependingOnPath();
    }

    private void SetRobotEnemyDependingOnPath()
    {
        if (chosenPath != null)
        {
            player.position = Vector3.MoveTowards(player.position, chosenPath.transform.position, movementSpeed * Time.deltaTime);
            enemyRobot = chosenPath.GetComponent<PossiblePath>().enemyRobot;
            Debug.Log("player will face" + enemyRobot);
            enemyToFace.enemyRobot = enemyRobot;
        }
    }
}
