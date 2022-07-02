using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    private float m_Speed = 5;
    public virtual float speed
    {
        get { return m_Speed; }
        set { speed = value; }
    }

    private Rigidbody animalRB;
    private float zDestroy = -6;
    public bool isDestroyed = false;
    // Start is called before the first frame update
    void Start()
    {
        animalRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Update()
    {
        animalRB.AddForce(Vector3.forward * -speed);
        Destroy();
    }

    public void Destroy()
    {
        if(transform.position.z < zDestroy)
        {
            Destroy(gameObject);
            isDestroyed = true;
        }
    }
}
