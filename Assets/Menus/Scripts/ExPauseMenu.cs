using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;
using UnityAtoms.BaseAtoms;
using TMPro;
public class ExPauseMenu : SimpleMenu<ExPauseMenu>{

    [SerializeField]
    private BoolVariable PlayerCanMove;
    [SerializeField]
    private IntVariable CoinsCollected;

    public TextMeshProUGUI TMPCoinCount;


    //CoinsCollected

    public override void OnBackPressed(){
        Debug.Log("PauseMenu :: OnBackPressed");
        ExGlobalNavbarMenu.Show();
        PlayerCanMove.Value = true;

    }

    public void OnEnable(){
        TMPCoinCount.text = CoinsCollected.Value.ToString();
        Debug.Log("ExPauseMenu was enabled");
        PlayerCanMove.Value = false;
    }

    

    


    
}
