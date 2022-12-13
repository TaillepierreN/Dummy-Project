using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    public Rigidbody Rb;
    [SerializeField] float _force;
    [SerializeField] float _forceimpulse;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(Vector3.up * _force / 2);
        if(transform.position.y < 2)
        {
                Rb.AddForce(Vector3.up * _forceimpulse, ForceMode.Impulse);
        }


    }
    public void ForceImpulse()
    {

        Rb.AddForce(Vector3.up * _forceimpulse, ForceMode.Impulse);
    }
}
