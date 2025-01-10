using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class begin : MonoBehaviour
{
    // 主菜单功能
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //开始游戏
    public void StartGame()
    {   //加载场景下标
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //继续游戏（开启存档读取页面）
    //游戏设置（开启游戏设置界面）
    //退出游戏
    public void ExitGame()
    {
        Application.Quit();
    }










}
