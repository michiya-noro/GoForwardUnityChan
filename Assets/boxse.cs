
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxse : MonoBehaviour
{
   public AudioClip sound1;
   AudioSource audioSource;

   void Start()
   {
    audioSource = GetComponent<AudioSource>();
   }

    // Update is called once per frame
    void Update()
   {
      
   }
    void OnCollisionEnter2D(Collision2D collision)
        {
           if (collision.gameObject.tag == "BoxTag")
            {
            audioSource.PlayOneShot(sound1);
             }
           if (collision.gameObject.tag == "GroundTag")
            {
            audioSource.PlayOneShot(sound1);
             }
        }       
}