using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PathSceneSaveData 
{
    public float[] location;
    public bool firstVisited;
    public bool secondVisited;
    public bool thirdVisited;
    public bool fourthVisited;
    public bool fifthVisited;

    
    public PathSceneSaveData(Player2D player2D)
    {
        location = new float[3];
        location[0] = player2D.transform.position.x;
        location[1] = player2D.transform.position.y;
        location[2] = player2D.transform.position.z;
        firstVisited = player2D.firstVisited;
        secondVisited = player2D.secondVisited;
        thirdVisited = player2D.thirdVisited;
        fourthVisited  = player2D.fourthVisited;
        fifthVisited = player2D.fifthVisited;
    }
}
