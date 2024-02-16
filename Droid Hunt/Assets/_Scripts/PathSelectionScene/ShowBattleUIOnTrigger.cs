using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShowBattleUIOnTrigger : MonoBehaviour
{
    [SerializeField] Image image;

    private void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            SelectPathTarget selectPathTarget = GetComponent<SelectPathTarget>();
            if(!selectPathTarget.CheckIfVisited())
            image.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
       if(collider.CompareTag("Player") && image != null) // Check if image is not null
        {
            image.gameObject.SetActive(false);
        }
    }
}
