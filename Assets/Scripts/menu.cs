using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class begin : MonoBehaviour
{
    // ���˵�����
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //��ʼ��Ϸ
    public void StartGame()
    {   //���س����±�
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //������Ϸ�������浵��ȡҳ�棩
    //��Ϸ���ã�������Ϸ���ý��棩
    //�˳���Ϸ
    public void ExitGame()
    {
        Application.Quit();
    }










}
