using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubeManager : MonoBehaviour
{
    public UnityEvent EvenementContact;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        EvenementContact.Invoke();
        Debug.Log(other.name + " est entré dans " + gameObject.name);
        other.GetComponent<MeshRenderer>().enabled = false;
    }
        private void OnTriggerExit(Collider other) {
        Debug.Log(other.name + " est sorti du " + gameObject.name);
        other.GetComponent<MeshRenderer>().enabled = true;
    }
    private void OnCollisionEnter(Collision collision) {
        EvenementContact.Invoke();
        Debug.Log(collision.collider.name + " est entré en collision avec " + gameObject.name);
        var monLecteurCD = collision.collider.GetComponent<AudioSource>();
        if(!monLecteurCD)
        {
            Debug.Log("Pas de lecteur CD");
        } else{
        monLecteurCD.Play();

        }
    }
}
