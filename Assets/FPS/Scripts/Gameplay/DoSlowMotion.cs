using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoSlowMotion : MonoBehaviour
{
   public float slowDownFactor = 0.25f;
    public float cooldown = 10;
    public float range = 2;
    public float now;
    public bool isSlowMotion = false;

    // Update is called once per frame
    public void Update()
    {
        now += Time.deltaTime;

        if(now >= 1){
            if(cooldown > 0){
                cooldown--;
                now = 0;  
            }

            if(cooldown == 0 && isSlowMotion){
                range--;
                if(range == 0){
                    isSlowMotion = false;
                    range = 2;
                    cooldown = 10;
                    Time.timeScale = 1f;
                }
                now = 0;
            }
        }
    }

    public void DoSlowmotion(){
        
        if(cooldown == 0){
            isSlowMotion = true;
            Time.timeScale = slowDownFactor;
            Time.fixedDeltaTime = Time.timeScale * .02f;
        }
        
    }
}
