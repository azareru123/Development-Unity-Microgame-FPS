using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    public DoSlowMotion doSLowMotion;

       // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
            SlowMo();
        
    }

    void SlowMo(){
        doSLowMotion.DoSlowmotion();
    }
}
