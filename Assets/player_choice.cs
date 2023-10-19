using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_choice : MonoBehaviour
{
    [SerializeField] private GameObject cubeBoi;
    [SerializeField] private GameObject monsterBoi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cube()
    {
        cubeBoi.SetActive(true);
        gameObject.SetActive(false);
    }
    public void mon()
    {
        monsterBoi.SetActive(true);
        gameObject.SetActive(false);
    }
}
