using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class BattleManager : MonoBehaviour
{
    [SerializeField] GameObject loseFinishScreenCanvas;
    [SerializeField] GameObject winFinishScreenCanvas;
    [SerializeField] GameObject blurPanel;
    [SerializeField] TextMeshProUGUI reward;
    [SerializeField] Player player;
    [SerializeField] EnemyInstance enemyInstance;
    [SerializeField] PlayerProgression playerProgression;


    private void Start()
    {
      reward.text = enemyInstance.enemyToFace.enemyRobot.reward.ToString();
    }

   public void Defeat()
   {
    blurPanel.SetActive(true);
    loseFinishScreenCanvas.SetActive(true);
   }

   public void Victory()
   {
    blurPanel.SetActive(true);
    winFinishScreenCanvas.SetActive(true);
    playerProgression.gold += enemyInstance.enemyToFace.enemyRobot.reward;
    playerProgression.currentParts = player.currentParts;
   }
}
