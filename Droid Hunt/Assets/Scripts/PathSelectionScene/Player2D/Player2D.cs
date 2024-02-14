using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Player2D : MonoBehaviour
{
    public GameObject[] chosenPaths = new GameObject[5];
    public Transform player2DLocation;
    public float movementSpeed;
    public GameObject chosenPath = null;


    private void Start()
    {
        //LoadPlayer();
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("BattleLocation"))
        {
            chosenPaths[0] = (collider.gameObject);
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