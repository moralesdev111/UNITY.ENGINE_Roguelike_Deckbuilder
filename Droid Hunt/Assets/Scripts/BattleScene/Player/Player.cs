using UnityEngine;
using TMPro; 
public class Player : Robot
{
    public int maxEnergy;
    public int currentEnergy;
    [SerializeField] TextMeshProUGUI currentEnergyDisplay;
    [SerializeField] TextMeshProUGUI currentGoldDisplay;
    [SerializeField] PlayerProgression playerProgression;


    void Start()
    {
        SetupStats();
    }

    void Update()
    {
        UpdateRobotUI(); 
    }

    public override void UpdateRobotUI()
    {
        currentEnergyDisplay.text = "Energy: " + currentEnergy.ToString();
        currentPartsDisplay.text = "Parts: " + currentParts.ToString();
        currentGoldDisplay.text = "Gold: " + playerProgression.gold.ToString();
    }

    public override void SetupStats()
    {
        maxEnergy=5;
        maxParts = 50;
        currentEnergy = maxEnergy;
        currentParts = playerProgression.currentParts;
    }
}
