using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    [SerializeField] Image image;

    private void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            image.gameObject.SetActive(true);
        }
    }
}
