using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnLogistics : MonoBehaviour
{
    public bool isPlayerTurn;
    public int playerTurn;
    public int enemyTurn;
    [SerializeField] TextMeshProUGUI turnowner;
    [SerializeField] Player player;
    [SerializeField] PlayerHand playerHand;
    

    private void Update()
    {
        turnowner.text = isPlayerTurn? "Your Turn" : "enemy turn";
    }
    public void InitialTurnSettings()
    {
        isPlayerTurn = true;
        playerTurn = 1;
        enemyTurn = 0;
    }

    public void EndYourTurn()
    {
        isPlayerTurn = false;
        enemyTurn +=1;
        GameManager.Instance.UpdateGameState(GameManager.GameState.enemyTurn);
    }

    public void EndEnemyTurn()
    {
        isPlayerTurn = true;
        playerTurn +=1;
        player.currentEnergy = player.maxEnergy;
        
        for(int i = 0; i < playerHand.ContainerSizeLimit; i++)
        {
            playerHand.StartDrawProcess();
        }
        GameManager.Instance.UpdateGameState(GameManager.GameState.playerTurn);
    }
}
