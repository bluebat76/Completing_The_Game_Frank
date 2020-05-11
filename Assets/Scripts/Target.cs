using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody TargetRB;
    private EventManager EventManager;
    [SerializeField] private ParticleSystem Exploticle;



    void Start()
    {

        EventManager = GameObject.Find("Event Manager").GetComponent<EventManager>();
        TargetRB = GetComponent<Rigidbody>();
        
        //Randomly selected launch location
        transform.position = new Vector3(Random.Range(-5, 5), -5);

        //Randomly selected launch force
        TargetRB.AddForce(Vector3.up * Random.Range(14, 19), ForceMode.Impulse);

        //Randomly selected spin force
        TargetRB.AddTorque(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5), ForceMode.Impulse);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Instantiate(Exploticle, transform.position, Exploticle.transform.rotation);
        Destroy(gameObject);
        
        if (CompareTag("Bad"))
        {

            EventManager.targetDestroyed?.Invoke(-30);
                 
        }
        else if (CompareTag("Good"))
        {
            EventManager.targetDestroyed?.Invoke(10);
        }
      
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
