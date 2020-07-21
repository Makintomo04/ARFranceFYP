using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelAudio : MonoBehaviour
{
    public TextMeshProUGUI fact;
    public GameObject mute;
    public AudioSource audios;
    // Start is called before the first frame update
    void Start()
    {
        audios = fact.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mute.activeSelf == true)
        {
            audios.Pause();
        }
    }
}
