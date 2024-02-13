using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BattleLocationDetector : MonoBehaviour
{
    [SerializeField] Image image;

    private void OnTriggerStay2D(Collider2D collider)
    {
        image.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        image.gameObject.SetActive(false);
    }
}
