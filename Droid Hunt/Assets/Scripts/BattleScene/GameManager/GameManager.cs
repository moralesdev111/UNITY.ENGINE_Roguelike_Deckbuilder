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
    public Enemy enemy;
    public GameState currentGameState;
    public static event Action<GameState> onGameStateChanged;
    [SerializeField] EnemyAttack aIActions;
    [SerializeField] EnemyEndsTurn enemyEndsTurn;



    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
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

            case GameState.finishScreen:
            break;


        }
    onGameStateChanged?.Invoke(newState);
    }


    public enum GameState
    {
        playerTurn,
        enemyTurn,
        finishScreen
    }
}
