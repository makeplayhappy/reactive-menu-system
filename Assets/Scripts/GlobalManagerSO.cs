using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

//this is the data that gets serialised from midi files
[CreateAssetMenu(fileName = "new GlobalManager", menuName = "ScriptableObjects/GlobalManager", order = 1)]
    //probably badly named! this is the level / scene (a single atom of progression)

public class GlobalManagerSO : ScriptableObject{

    [SerializeField]   
    private IntEvent HealthChangedEvent;

    [SerializeField]
    private GameStateVariable GlobalGameState;

    [SerializeField]   
    private GameStateEvent GlobalGameStateChangedEvent;

    private void GameStateChange(GameState newState){
        switch(newState){
            case GameState.GamePlay:
                Debug.Log("GlobalManagerSO GamePlay");

            break;
            case GameState.MainMenu:
                Debug.Log("GlobalManagerSO MainMenu");


            break;

            case GameState.Shopping:
                Debug.Log("GlobalManagerSO Shopping");
                ExShopMenu.Show();

            break;

            case GameState.PlayerDead:
                Debug.Log(">>> GlobalManagerSO PlayerDead");
                ExGameOverMenu.Show();

            break;

    
        }
    }

    private void PlayerHealthChanged(int health){
        Debug.Log($"GlobalManagerSO heard player health is {health}");
        if(health <= 0){
            GlobalGameState.Value = GameState.PlayerDead;

        }
    }

    void Awake(){
        GlobalGameStateChangedEvent.Register(this.GameStateChange);
        HealthChangedEvent.Register(this.PlayerHealthChanged);
        Debug.Log("GlobalManagerSO Awake");
        
    }

    void OnEnable(){
        GlobalGameStateChangedEvent.Register(this.GameStateChange);
        HealthChangedEvent.Register(this.PlayerHealthChanged);
        Debug.Log("GlobalManagerSO Alive");

    }

    void OnDestroy(){
        GlobalGameStateChangedEvent.Unregister(this.GameStateChange);
        HealthChangedEvent.Unregister(this.PlayerHealthChanged);
        Debug.Log("GlobalManagerSO OnDestroy");
    }
    void OnDisable(){
        GlobalGameStateChangedEvent.Unregister(this.GameStateChange);
        HealthChangedEvent.Unregister(this.PlayerHealthChanged);
        Debug.Log("GlobalManagerSO OnDisable");
    }


 
}

