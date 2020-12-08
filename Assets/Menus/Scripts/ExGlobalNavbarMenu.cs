using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI.Extensions;

using UnityAtoms.BaseAtoms;
public class ExGlobalNavbarMenu : SimpleMenu<ExGlobalNavbarMenu>
{
    // Start is called before the first frame update
    public RectTransform healthBar;
    private float healthMaxWidth = 250;

    [SerializeField]
    private IntConstant MaxHealth;

    [SerializeField]
    private IntEvent HealthChangedEvent;

    public Vector2 startSizeDelta; 
    

    void Start(){
        startSizeDelta = healthBar.sizeDelta;
        Debug.Log( startSizeDelta.ToString() );
        healthMaxWidth = healthBar.rect.width;
        HealthChangedEvent.Register(this.UpdateHealthBar);
    }

    void OnDestroy(){
        HealthChangedEvent.Unregister(this.UpdateHealthBar);
    }

    private void UpdateHealthBar(int healthValue){
        Debug.Log("ExGlobalNavbarMenu heard UpdateHealthBar with " + healthValue);

        Debug.Log( healthBar.sizeDelta.ToString() );

        Debug.Log( healthValue.ToString() + " / " + MaxHealth.Value.ToString() );

        float multi = (float)healthValue / (float)MaxHealth.Value;

        Debug.Log( multi.ToString() );

        multi *= startSizeDelta.x;

        Debug.Log( multi.ToString() );
        //healthMaxWidth = 
        //.rect.width

        //Rect m_rect = healthBar.rect;
        //m_rect.width = (  );
        healthBar.sizeDelta = new Vector2( multi , startSizeDelta.y );


    } 


    // Update is called once per frame
    public void OnPausePressed(){
        Debug.Log("GlobalNavbarMenu :: OnPausePressed");
        ExPauseMenu.Show();
    }


}
