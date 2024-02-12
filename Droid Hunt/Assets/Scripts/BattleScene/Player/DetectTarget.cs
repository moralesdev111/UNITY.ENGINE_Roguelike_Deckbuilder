using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTarget : MonoBehaviour
{
    public GameObject target = null;
    [SerializeField] Camera secondaryCamera;
    [SerializeField] PlayerAttack playerAttack;
    private RaycastHit hitInfo;
    
     private void OnEnable()
     {
        secondaryCamera =  secondaryCamera = GameObject.FindWithTag("P2Camera").GetComponent<Camera>();
     }


    public void DetectTargets()
    {
        Ray ray = secondaryCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("Target"))
                {
                    if (Input.GetMouseButton(0))
                    {
                         target = hitInfo.collider.gameObject;
                        Enemy enemy = target.GetComponent<Enemy>();
                    
                        if (enemy != null)
                        {
                            CardInstance cardInPlay = GetComponentInParent<CardInstance>();
                            if (cardInPlay != null)
                        {
                            playerAttack.HandleAttack(enemy, cardInPlay);
                        }
                        else
                    {
                        Debug.LogWarning("CardInstance component is missing.");
                    }
                }
                else
                {
                    Debug.LogWarning("Enemy component is missing.");
                }
                gameObject.SetActive(false);
            }        
          }
        }
    }
}
