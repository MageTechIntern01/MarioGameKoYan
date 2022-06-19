using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    void Awake() { instance = this; }

    //Sound Effects
    public AudioClip sfx_jump, sfx_die, sfx_coin, sfx_stomp, sfx_footstep;
    
   
    //Sound Object
    public GameObject soundObject;
    
    public void PlaySFX(string sfxName)
    {
        switch(sfxName)
        {
            case "jumping":
                SoundObjectCreation(sfx_jump);
                break;
            case "dying":
                SoundObjectCreation(sfx_die);
                break;
            case "coin":
                SoundObjectCreation(sfx_coin);
                break;
            case "stomping":
                SoundObjectCreation(sfx_stomp);
                break;
            case "footstep":
                SoundObjectCreation(sfx_footstep);
                break;          
            default:
                break;
        }
    }

    void SoundObjectCreation(AudioClip clip)
    {
        //Create SoundsObject gameobject
        GameObject newObject = Instantiate(soundObject, transform);
        //Assign audioclip to its audiosource
        newObject.GetComponent<AudioSource>().clip = clip;
        //Play the audio
        newObject.GetComponent<AudioSource>().Play();
    }
}
