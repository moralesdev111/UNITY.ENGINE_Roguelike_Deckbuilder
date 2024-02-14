using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Robot : MonoBehaviour
{
    public int maxParts;
    public int currentParts;
    public TextMeshProUGUI currentPartsDisplay;


    public abstract void UpdateRobotUI();
    public abstract void SetupStats();
}
