using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Player2D : MonoBehaviour
{
    public List<GameObject> chosenPaths = new List<GameObject>();
    public Transform player2DLocation;
    public float movementSpeed;
    public GameObject chosenPath = null;
    public bool firstVisited = false;
    public bool secondVisited = false;
    public bool thirdVisited = false;
    public bool fourthVisited = false;
    public bool fifthVisited = false;
    [SerializeField] PassSaveDataBetweenScenes passSaveDataBetweenScenes;

    private void Start()
    {
        LoadPlayer();
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("BattleLocation"))
        {
            if(!chosenPaths.Contains(collider.gameObject))
            {
                chosenPaths.Add(collider.gameObject);
                firstVisited = passSaveDataBetweenScenes.firstVisited;
                
                SavePlayer();
            }
            
        }
        else if(collider.CompareTag("BattleLocation2"))
        {
            if(!chosenPaths.Contains(collider.gameObject))
            {
                chosenPaths.Add(collider.gameObject);
                secondVisited = passSaveDataBetweenScenes.secondVisited;
                
                SavePlayer();
            }
        }
         else if(collider.CompareTag("BattleLocation3"))
        {
            if(!chosenPaths.Contains(collider.gameObject))
            {
                chosenPaths.Add(collider.gameObject);
                thirdVisited = passSaveDataBetweenScenes.thirdVisited;
               
                SavePlayer();
            }
        }
         else if(collider.CompareTag("BattleLocation4"))
        {
            if(!chosenPaths.Contains(collider.gameObject))
            {
                chosenPaths.Add(collider.gameObject);
                fourthVisited = passSaveDataBetweenScenes.fourthVisited;
               
                SavePlayer();
            }
        }
         else if(collider.CompareTag("BattleLocation5"))
        {
            if(!chosenPaths.Contains(collider.gameObject))
            {
                chosenPaths.Add(collider.gameObject);
                fifthVisited = passSaveDataBetweenScenes.fifthVisited;
                
                SavePlayer();
            }
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
        firstVisited = pathSceneSaveData.firstVisited;
        secondVisited = pathSceneSaveData.secondVisited;
        thirdVisited = pathSceneSaveData.thirdVisited;
        fourthVisited = pathSceneSaveData.fourthVisited;
        fifthVisited = pathSceneSaveData.fifthVisited;

       transform.position = position;
    }
}
