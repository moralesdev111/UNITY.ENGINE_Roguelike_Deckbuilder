using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PassData", menuName ="ScriptableObjects/PassData")]
public class PassSaveDataBetweenScenes : ScriptableObject
{
    public bool firstVisited = false;
    public bool secondVisited = false;
    public bool thirdVisited = false;
    public bool fourthVisited = false;
    public bool fifthVisited = false;
}
