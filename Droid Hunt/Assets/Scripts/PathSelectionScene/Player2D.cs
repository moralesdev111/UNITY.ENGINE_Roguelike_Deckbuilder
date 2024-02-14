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

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("BattleLocation"))
        {
            visitedLocations.Add(collider.gameObject.transform.position);
        }
    }
}
