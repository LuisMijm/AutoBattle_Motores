using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public List<Character> survivorList_;
    public List<Character> zombieList_;

    public bool GameRunning_;

    BoardController boardControl_;

    void Start()
    {
        survivorList_ = new List<Character>();
        zombieList_ = new List<Character>();
        GameRunning_ = true;
        boardControl_.FillBoard(survivorList_, zombieList_);
    }

    void Update()
    {
        boardControl_.UpdateBoard();
    }
}
