using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("Hit");
        if (other.gameObject.tag == "Player")
        {
            GameObject[] animals = GameObject.FindGameObjectsWithTag("Animal");
            foreach (GameObject a in animals)
            {
                GameObject.Destroy(a);
            }
            Destroy(gameObject);
        }
    }
}
