using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ButtonAudioController : MonoBehaviour
{
    public List<AudioSource> Drum = new List<AudioSource>();
    public List<AudioSource> Bass = new List<AudioSource>();
    public List<AudioSource> Keyboard = new List<AudioSource>();

    void Start()
    {

    }

    public void DrumSound()
    {
        int DNumber = Random.Range(0, 3);
        Drum[DNumber].Play();
    }

    public void BassSound()
    {
        int BNumber = Random.Range(0, 3);
        Bass[BNumber].Play();
    } 
    
    public void KeyboardSound()
    {
        int KNumber = Random.Range(0, 3);
        Keyboard[KNumber].Play();
    }
}
