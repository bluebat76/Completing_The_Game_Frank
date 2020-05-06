using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody TargetRB;




    void Start()
    {
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
        Destroy(gameObject);
    }
}
