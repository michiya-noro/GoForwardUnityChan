using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubese : MonoBehaviour
{
// Use this for initialization
void Start()
{

    }

    // Update is called once per frame
void Update()
{
      
}
 void OnCollisionEnter(Collision other)
        {
           if (other.gameObject.tag == "BoxTag")
            {
            GetComponent<AudioSource>().Play();
             }
           if (other.gameObject.tag == "GroundTag")
            {
            GetComponent<AudioSource>().Play();
             }
        }       
}