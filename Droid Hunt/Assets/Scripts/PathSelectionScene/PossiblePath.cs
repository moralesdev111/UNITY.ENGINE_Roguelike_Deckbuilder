using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PossiblePath : MonoBehaviour
{
    public EnemyRobot enemyRobot;
    [SerializeField] SetRobotEnemyData loadBattleOnClick;

    private void OnMouseDown()
    {
        if(loadBattleOnClick.chosenPath == null)
        {   
            loadBattleOnClick.chosenPath = this.gameObject;
        }
    }
}

