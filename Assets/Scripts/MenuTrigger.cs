using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;

public class MenuTrigger : MonoBehaviour{

 
    void OnTriggerEnter(Collider other)
    {
        #if UNITY_EDITOR
        Debug.Log("Entered MenuTrigger " + other.gameObject.name );
        #endif
        //trigger menu  
        ExShopMenu.Show();
    }
}
