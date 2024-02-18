using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteOnVisited : MonoBehaviour
{
    [SerializeField] SelectPathTarget selectPathTarget;
    [SerializeField] Sprite visitedSprite;


    // Update is called once per frame
    void Update()
    {
        if(selectPathTarget.CheckIfVisited())
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = visitedSprite;
        }
    }
}
