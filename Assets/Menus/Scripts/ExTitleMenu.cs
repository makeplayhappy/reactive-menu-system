using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;
using UnityAtoms.BaseAtoms;

public class ExTitleMenu : SimpleMenu<ExTitleMenu>{
    // Start is called before the first frame update
    [SerializeField]
    private BoolVariable playerCanMove;
    public void OnNewPressed(){

        Debug.Log("TitleMenu :: OnNewPressed");
        
        playerCanMove.SetValue(true);

        ExGlobalNavbarMenu.Show();

    }


    public override void OnBackPressed(){

        #if UNITY_EDITOR
        Debug.Log("Quit Scene");
        UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
        Application.OpenURL("http://makeplayhappy.com");
        #else
        Application.Quit();
        #endif
    }
}
