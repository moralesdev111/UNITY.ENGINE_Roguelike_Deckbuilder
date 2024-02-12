using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyRobot", menuName = "ScriptableObjects /EnemyRobot")]
public class EnemyRobot : ScriptableObject
{
    public string robotName;
    public int attack;
    public int maxParts;
    public GameObject robotModel;
}
