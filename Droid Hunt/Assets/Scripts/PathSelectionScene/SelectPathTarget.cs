using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectPathTarger : MonoBehaviour
{
    public EnemyRobot enemyRobot;
    [SerializeField] Player2D player2D;

    private void OnMouseDown()
    {
        if(player2D.chosenPath == null)
        {   
            player2D.chosenPath = this.gameObject;
        }
    }
}

