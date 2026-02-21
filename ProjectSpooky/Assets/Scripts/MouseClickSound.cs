using UnityEngine;

public class MouseClickSound : MonoBehaviour
{
    public AudioClip soundfx;
    private AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
                audioSource.clip = soundfx;
                audioSource.Play();
        }
    }
}
