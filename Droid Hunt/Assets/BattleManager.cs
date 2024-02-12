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
    [SerializeField] Button mainMenuButton;
    [SerializeField] Button pathSelectionSceneButton;
    [SerializeField] TextMeshProUGUI reward;


   public void Defeat()
   {
    blurPanel.SetActive(true);
    loseFinishScreenCanvas.SetActive(true);
   }


   public void Victory()
   {
    blurPanel.SetActive(true);
    winFinishScreenCanvas.SetActive(true);
   }
}