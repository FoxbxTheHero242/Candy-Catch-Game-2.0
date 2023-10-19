using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class candyfall : MonoBehaviour
{
    [SerializeField] private GameObject[] candies;
    [SerializeField] private int[] chances;
    [SerializeField] private PlayerMove _playerMove;
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;
    [SerializeField] private GameObject canvas2;
    
    private float sec;

    private float timer;

    private int candyAmmount;

    private int pick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pick = Random.Range(0, 100);
        int choice = 0;
        for (int i = 0; i < chances.Length; i++)
        {
            if (pick>chances[i])
            {
                choice = i;
            }
        }
        timer += Time.deltaTime;
        if (timer>=sec&& candyAmmount<15)
        {
            Instantiate(candies[choice],
                new Vector3(Random.Range(-7.4f,7.4f),transform.position.y,transform.position.z), transform.rotation,  transform);
            sec = Random.Range(0, 3);
            timer = 0;
            candyAmmount++;
        }

        if (candyAmmount==15&& transform.childCount==0)
        {
            
            _textMeshProUGUI.text = "your final score is: "+ _playerMove.GetScore().ToString();
            canvas2.SetActive(true);
        }
        
    }
}
