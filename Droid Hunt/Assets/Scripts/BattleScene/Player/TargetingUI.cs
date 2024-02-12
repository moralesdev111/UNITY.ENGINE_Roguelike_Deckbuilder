using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetingUI : MonoBehaviour
{
    public GameObject arrowPrefab;
    public GameObject dotPrefab;
    public int poolSize = 50;
    private List<GameObject> dotPool = new List<GameObject>();
    private GameObject arrowInstance;
    public float spacing;
    public float arrowAngleAdjustment = 0;
    public int dotsToSkip = 1;
    private Vector3 arrowDirection;
    public GameObject target = null;
    [SerializeField] Camera secondaryCamera;
    [SerializeField] float baseScreenWidth = 1900;
    [SerializeField] float spacingScale;
    RaycastHit hitInfo;

    void OnEnable(){
        secondaryCamera =  secondaryCamera = GameObject.FindWithTag("P2Camera").GetComponent<Camera>();
        spacingScale = Screen.width / baseScreenWidth;
    }
    void Start()
    {
        arrowInstance = Instantiate(arrowPrefab,transform);
        arrowInstance.transform.localPosition = Vector3.zero;
        InitializeDotPool(poolSize);
         spacingScale = Screen.width / baseScreenWidth;
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos.z = 0;

        Vector3 startPosition = transform.position;
        Vector3 midPoint = CalculateMidPoint(startPosition, mousePos);

        UpdateArc(startPosition,midPoint,mousePos);
        PositionAndRotateArrow(mousePos);
        DetectTarget();

        if(Input.GetMouseButton(1))
        {
            gameObject.SetActive(false);
        }
    }

    void InitializeDotPool(int count)
    {
        for(int i = 0; i < count; i++)
        {
            GameObject dot = Instantiate(dotPrefab,Vector3.zero,Quaternion.identity,transform);
            dot.SetActive(false);
            dotPool.Add(dot);
        }
    }

    Vector3 CalculateMidPoint(Vector3 start, Vector3 end)
    {
        Vector3 midPoint = (start + end)/2;
        float arcHeight = Vector3.Distance(start,end) / 3f;
        midPoint.y += arcHeight;
        return midPoint;
    }

    void UpdateArc(Vector3 start, Vector3 mid, Vector3 end)
    {
        int numDots = Mathf.CeilToInt(Vector3.Distance(start,end)/ (spacing * spacingScale));

        for(int i = 0; i <numDots && i < dotPool.Count; i++)
        {
            float t = i / (float)numDots;
            t = Mathf.Clamp(t,0f,1f);

            Vector3 position = QuadraticBezierCurve(start,mid,end,t);

            if(i != numDots - dotsToSkip)
            {
                dotPool[i].transform.position = position;
                dotPool[i].SetActive(true);
            
            }
            if(i == numDots - (dotsToSkip +1 )&& i -dotsToSkip +1 >= 0)
            {
                arrowDirection = dotPool[i].transform.position;
            }
        }

        for(int i = numDots - dotsToSkip; i <dotPool.Count ; i++)
        {
            if(i > 0)
            {
                dotPool[i].SetActive(false);
            }
        }
    }

    Vector3 QuadraticBezierCurve(Vector3 start, Vector3 control, Vector3 end, float t){
        float u = 1 - t;
        float tt = t*t;
        float uu =  u * u;

        Vector3 point = uu * start;
        point+=2*u*t*control;
        point +=tt * end;
        return point;
    }

    void PositionAndRotateArrow(Vector3 position)
    {
        arrowInstance.transform.position = position;

        Vector3 direction =  arrowDirection - position;
        float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
        angle += arrowAngleAdjustment;
        arrowInstance.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void DetectTarget()
    {
        Ray ray = secondaryCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitInfo))
            {
                // Check if the hit object is your target
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
                                enemy.currentParts -= cardInPlay.card.utilityValue;
                                GameManager.Instance.player.currentEnergy -= cardInPlay.card.energyCost;
                                GameManager.Instance.playerHand.Container.Remove(cardInPlay.card);
                                Destroy(transform.parent.gameObject);
                                // You may want to add additional actions or checks here
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
        
