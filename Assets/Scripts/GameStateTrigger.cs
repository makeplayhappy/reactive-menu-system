using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;
using UnityAtoms;

public class GameStateTrigger : MonoBehaviour{

    public GameState stateToTrigger;

    [SerializeField]
    private GameStateVariable GlobalGameState;

 
    void OnTriggerEnter(Collider other)
    {
        #if UNITY_EDITOR
        Debug.Log(other.gameObject.name + " Entered GameStateTrigger " + gameObject.name );
        #endif

        GlobalGameState.Value = stateToTrigger;
        //trigger menu  
        
    }

}
