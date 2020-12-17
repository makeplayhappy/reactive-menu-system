using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;
using UnityAtoms.BaseAtoms;
using UnityEngine.SceneManagement;

public class ExGameOverMenu : SimpleMenu<ExGameOverMenu>{
    // Start is called before the first frame update
    [SerializeField]
    private BoolVariable playerCanMove;
    public void OnEnable(){
        playerCanMove.Value = false;
    }


    public override void OnBackPressed(){
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex ) ;
        
       
    }
}
