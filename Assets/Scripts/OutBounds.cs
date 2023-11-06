using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutBounds : MonoBehaviour
{

    [SerializeField] private float verticalBound = -5f;
    [SerializeField] private float horizontalBound = -18f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < verticalBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
            Time.timeScale = 0f;
        }
        if (transform.position.x < horizontalBound)
        {

            Destroy(gameObject);
            
        }

    }
}
