using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;
using UnityAtoms.BaseAtoms;
using TMPro;
public class ExShopMenu : SimpleMenu<ExShopMenu>{

    [SerializeField]
    private BoolVariable PlayerCanMove;
    [SerializeField]
    private IntVariable CoinsCollected;
    [SerializeField]
    private IntVariable PlayerHealth;

    public TextMeshProUGUI TMPmessage;
    public TextMeshProUGUI TMPHealthPrice;

    public int healthCost = 5;
    public int healthReward = 10;


    //CoinsCollected

    public override void OnBackPressed(){
        Debug.Log("ExShopMenu :: OnBackPressed");
        ExGlobalNavbarMenu.Show();
        PlayerCanMove.Value = true;

    }

    public void OnEnable(){
        TMPmessage.text = "Welcome to the store";
        PlayerCanMove.Value = false;
    }

    public void buyHealth(){
        if( CoinsCollected.Value >= healthCost){
            PlayerHealth.Value += healthReward;
            CoinsCollected.Value -= healthCost;
            TMPmessage.text = "You purchased extra health";
        }else{
            TMPmessage.text = "Sorry you don't have enough coins, go and collect some more";
        }

    }

    

    


    
}
