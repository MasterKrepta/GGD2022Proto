using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private void Start()
    {
        MusicSwitch(0);
        MusicPlayback();
    }

    public void MusicPlayback()
    {
        AkSoundEngine.PostEvent("MusicPlayback", gameObject);
    }

    public void PickupMusic()
    {
        AkSoundEngine.PostEvent("PickupMusic", gameObject);
    }

    public void FootstepsPlayback()
    {
        AkSoundEngine.PostEvent("PlayerFootsteps", gameObject);
    }

    public void ObjectInteraction()
    {
        AkSoundEngine.PostEvent("ChestOpen", gameObject);
    }

    public void MusicSwitch(int switchNum)
    {
        if(switchNum == 0)
        {
            AkSoundEngine.SetSwitch("ostSwitchGroup", "calmMusic", gameObject);
        }
        else if(switchNum == 1)
        {
            AkSoundEngine.SetSwitch("ostSwitchGroup", "swordMusic", gameObject);
        }
        else if (switchNum == 2)
        {
            AkSoundEngine.SetSwitch("ostSwitchGroup", "enemyMusic", gameObject);
        }
        else if (switchNum == 3)
        {
            AkSoundEngine.SetSwitch("ostSwitchGroup", "bossMusic", gameObject);
        }   
    }
}
