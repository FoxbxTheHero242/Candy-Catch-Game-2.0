using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI;
    [SerializeField] private TextMeshProUGUI _textMeshProUGUI2;

    
    private Vector2 moveDir;
    
    private int _score;
    // Start is called before the first frame update
    void Start()
    {
     InputManager.INIT(this);   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3)moveDir * speed;
        if (_score<15)
        {
            _textMeshProUGUI2.text = "Sadness";
        }

        if (_score>=15&&_score<35)
        {
            _textMeshProUGUI2.text = "Sugar rush"; 
        }
        if (_score>=35&&_score<50)
        {
            _textMeshProUGUI2.text = "Halloween"; 
        }
        if (_score>=50)
        {
            _textMeshProUGUI2.text = "Candy Craze"; 
        }
        
    }

    public void MoveMe(Vector2 dir)
    {
        moveDir = dir;
    }

    public void score(int add)
    {
        _score = _score + add;
        _textMeshProUGUI.text = "Current score: " + _score.ToString();
    }

    public int GetScore()
    {
        return _score;
    }
}
