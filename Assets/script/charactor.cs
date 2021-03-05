using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private string name;
    private int level = 1;

    public Player(string name)
    {
        this.name = name;
    }

    public void GetInfo()
    {
        Debug.Log("이름 : " + name);
        Debug.Log("레벨 : " + level);
    }

    public void LevelUp()
    {
        this.level++;
        Debug.Log("레벨 업~!");
    }

}


public class charactor : MonoBehaviour
{
    void Start()
    {
        Player myPlayer = new Player("김지웅");
        myPlayer.GetInfo();
        myPlayer.LevelUp();
        myPlayer.GetInfo();
    }

}
