using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kelessc : MonoBehaviour
{
    public bool atesedebilirmi;
    float iceriatesetmesikligi;
    public float disariatesetmesikli�i;
    public Camera Mycam;
    public float menzil;
    public AudioSource atesSesi;
    public ParticleSystem atesEfekt;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && atesedebilirmi && Time.time > iceriatesetmesikligi)
        {
            AtesEt();
            disariatesetmesikli�i = Time.time + iceriatesetmesikligi;
        }
    }
    void AtesEt()
    {
        atesSesi.Play();
        atesEfekt.Play();
        RaycastHit hit;
        if(Physics.Raycast(Mycam.transform.position,Mycam.transform.forward,out hit, menzil))
        {
            
            Debug.Log(hit.transform.name);

        }
    }
}
