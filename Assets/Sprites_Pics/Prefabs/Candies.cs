using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candies : MonoBehaviour
{
    [SerializeField] private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag=="Player")
        {
            other.gameObject.GetComponent<PlayerMove>().score(score);
            Destroy(gameObject);
        }

        if (other.transform.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
