using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class SelectPathTarget : MonoBehaviour
{
    public EnemyRobot enemyRobot;
    [SerializeField] Player2D player2D;

    private void OnMouseDown()
    {
        if(player2D.chosenPath == null || !player2D.chosenPaths.Contains(this.gameObject))
        {   
            player2D.chosenPath = this.gameObject;
        }
    }
}

