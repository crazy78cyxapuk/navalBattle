using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPlane : MonoBehaviour
{
    public GameObject enemyCage;
    public static GameObject[,] plane = new GameObject[20, 20];
    public static int[,] enemyArr = new int[20, 20];
    private float posX, posY;
    private float startPosX = 2;
    private float startPosY = 4;

    private void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                enemyArr[i, j] = -1;
            }
        }

        for (int i=0; i<=5; i++)
        {
            enemyArr[i, 4] = 1;
        }

        posX = .3f;
        posY = .3f;

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                
                plane[i, j] = Instantiate(enemyCage, new Vector3(startPosX, startPosY, 0), Quaternion.identity); //as GameObject;
                startPosX += posX;
                plane[i, j].name = i.ToString() + " " + j.ToString() + " enemy";
                plane[i, j].transform.parent = transform;
            }
            startPosY -= posY;
            startPosX = 2;
        }

        fillEnemyShip();
    }

    private void fillEnemyShip()
    {
        for(int i = 0; i < 10; i++)
        {
            for(int j=0; j < 20; j++)
            {
                if (enemyArr[i, j] == 1)
                {
                    GameObject obj = GameObject.Find(i.ToString() + " " + j.ToString() + " enemy");
                    obj.GetComponent<Renderer>().material.color = Color.red;
                }
            }
        }
    }
}
