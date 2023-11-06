using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{


    [SerializeField] private GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            Fire();
        }

        
    }


    private void Fire()
    {
        Vector3 pos = transform.position;

        Instantiate (bullet, pos, Quaternion.Euler(0,-90,0) );
    }


}
