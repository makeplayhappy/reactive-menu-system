using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

//The global Game State Manager
public class GameStateManager : MonoBehaviour{

    [SerializeField]   
    private IntEvent HealthChangedEvent;

    [SerializeField]
    private GameStateVariable GlobalGameState;

    [SerializeField]   
    private GameStateEvent GlobalGameStateChangedEvent;

    private void GameStateChange(GameState newState){
        switch(newState){
            case GameState.GamePlay:
                Debug.Log("GameStateManager GamePlay");

            break;
            case GameState.MainMenu:
                Debug.Log("GameStateManager MainMenu");


            break;

            case GameState.Shopping:
                Debug.Log("GameStateManager Shopping");
                ExShopMenu.Show();

            break;

            case GameState.PlayerDead:
                Debug.Log("GameStateManager PlayerDead");
                ExGameOverMenu.Show();

            break;

    
        }
    }

    private void PlayerHealthChanged(int health){
        Debug.Log($"GameStateManager heard player health is {health}");
        if(health <= 0){
            GlobalGameState.Value = GameState.PlayerDead;

        }
    }

    void Awake(){
        GlobalGameStateChangedEvent.Register(this.GameStateChange);
        HealthChangedEvent.Register(this.PlayerHealthChanged);
        Debug.Log("GameStateManager Awake");
        
    }

    void OnDestroy(){
        GlobalGameStateChangedEvent.Unregister(this.GameStateChange);
        HealthChangedEvent.Unregister(this.PlayerHealthChanged);
        Debug.Log("GameStateManager OnDestroy");
    }

 
}

