using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Menu,
    InGame,
    GameOver
}
public class GameManager : MonoBehaviour
{
    public GameState currentGameState = GameState.Menu;

    private static GameManager sharedInstance;


    public void Awake()
    {
        sharedInstance = this;
    }

    public static GameManager GetInstance()
    {
        return sharedInstance;
    }

    private void Start()
    {
        //StartGame();
        currentGameState = GameState.Menu;
    }

    private void Update()
    {
        if (currentGameState != GameState.InGame && Input.GetButtonDown("s"))
        {
            ChangeGameState(GameState.InGame);
            StartGame();
        }
    }
    // Start our game
    public void StartGame()
    {
        PlayerController.GetInstance().StartGame();
        ChangeGameState(GameState.InGame);
    }

    // Called when player dies
    public void GameOver()
    {
        ChangeGameState(GameState.GameOver);
    }
    //
    public void BackToMainMenu()
    {
        ChangeGameState(GameState.Menu);
    }

    void ChangeGameState(GameState newGameState)
    {
        switch (newGameState)
        {
            case GameState.Menu:
                break;
            case GameState.InGame:
                break;
            case GameState.GameOver:
                break;
            default:

                break;
        }
        currentGameState = newGameState;
    }
}
