using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;



public class InteractableEventDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public AudioClip hoverEnterSound;

    public void PlayHoverEnterSound(){
        if(hoverEnterSound != null)
            AudioSource.PlayClipAtPoint(hoverEnterSound, transform.position);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
