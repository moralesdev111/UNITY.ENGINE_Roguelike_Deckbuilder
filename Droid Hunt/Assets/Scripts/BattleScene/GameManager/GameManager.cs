using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public PlayerHand playerHand;
    public Player player;
    public GameState currentGameState;
    public static event Action<GameState> onGameStateChanged;
    [SerializeField] EnemyAttack aIActions;
    [SerializeField] EnemyEndsTurn enemyEndsTurn;
    public Enemy enemy;


    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        UpdateGameState(GameState.playerTurn);
    }

    void Update()
    {
        DontDestroyOnLoad(this);
    }


    public void UpdateGameState(GameState newState)
    {
        currentGameState = newState;

        switch(newState)
        {
            case GameState.playerTurn:
            aIActions.hasAttacked = false;
            enemyEndsTurn.hasEndedTurn = false;

            
            break;
            case GameState.enemyTurn:
            break;
        }
    onGameStateChanged?.Invoke(newState);
    }


    public enum GameState
    {
        playerTurn,
        enemyTurn,
    }
}
