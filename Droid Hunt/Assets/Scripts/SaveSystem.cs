using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem 
{
    public float[] location;

    public SaveSystem(Player2D player2D)
    {
        location = new float[3];
        //location[0] = pathScenePlayer.currentPlayerLocation.x;
    }
}
