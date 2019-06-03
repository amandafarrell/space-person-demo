using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseSound : MonoBehaviour
{
   
    public void Pause()
    {
        AudioListener.pause = true;        
    }
}
