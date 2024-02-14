using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Player2D : MonoBehaviour
{
    public List<Vector3> visitedLocations = new List<Vector3>();
    public Transform player2DLocation;
    public float movementSpeed;
    public GameObject chosenPath = null;


    private void Start()
    {
        LoadPlayer();
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("BattleLocation"))
        {
            visitedLocations.Add(collider.gameObject.transform.position);
            SavePlayer();
        }
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
       PathSceneSaveData pathSceneSaveData = SaveSystem.LoadPlayer();

        if (pathSceneSaveData == null)
        {
            Debug.Log("No saved data found.");
            return;
        }
        
       Vector3 position;
       position.x = pathSceneSaveData.location[0];
       position.y = pathSceneSaveData.location[1];
       position.z = pathSceneSaveData.location[2];

       transform.position = position;
    }
}
