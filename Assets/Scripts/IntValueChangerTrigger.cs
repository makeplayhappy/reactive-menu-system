using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

public class IntValueChangerTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private IntVariable intVariable;

    public bool incrementor = true;
    public int amount = 1;
    public ParticleSystem fxOnEnter;
    void OnTriggerEnter(Collider other)
    {
        #if UNITY_EDITOR
        Debug.Log("Entered IntValueChangerTrigger " + other.gameObject.name );
        #endif
        int addon = (incrementor)? amount : -amount;
        
        intVariable.Value += addon;
        if( fxOnEnter != null){
            fxOnEnter.Play();
        }


    }

}
