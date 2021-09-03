using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject LBooster;
    [SerializeField] private GameObject RBooster;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Left Booster pressed!");
            Player.transform.GetComponent<Rigidbody>().AddForceAtPosition(Vector3.forward, LBooster.transform.position);
            //LBooster.GetComponent<Rigidbody>().AddForce(Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Right Booster pressed!");
            Player.transform.GetComponent<Rigidbody>().AddForceAtPosition(Vector3.forward, RBooster.transform.position);
            //RBooster.GetComponent<Rigidbody>().AddForce(Vector3.forward);
        }
    }
}
