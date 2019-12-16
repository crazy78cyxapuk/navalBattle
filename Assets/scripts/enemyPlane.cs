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

        
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                enemyArr[i, j] = -1;
            }
        }

        //!!!!
        for (int i = 0; i <= 5; i++)//test ship 1
        {
            enemyArr[i, 4] = 1;
        }

        for (int j = 0; j <= 5; j++) //test ship 2
        {
            enemyArr[14, j] = 1;
        }

        enemyArr[19, 19] = 1; //test ship 3

        //!!!!

        fillEnemyShip();



    }

    //public void attackInShip()
    //{//атака спиралью по часовой
    //    int n = 19;
    //    int k = 0;
    //    for (int i = 0; i < 10; i++)
    //    {

    //        for (int i1 = k; i1 < n; i1++)
    //        {
    //            enemyArr[k, i1] = 1;
    //        }

    //        for (int i2 = k; i2 < n; i2++)
    //        {
    //            enemyArr[i2, n] = 1;
    //        }

    //        for (int i3 = n; i3 >= k; i3--)
    //        {
    //            enemyArr[n, i3] = 1;
    //        }

    //        for (int i4 = n; i4 >= k + 1; i4--)
    //        {
    //            enemyArr[i4, k] = 1;
    //        }

    //        n -= 1;
    //        k += 1;
    //    }
    //}

    public static void fillEnemyShip()
    {
        for(int i = 0; i < 20; i++)
        {
            for(int j=0; j < 20; j++)
            {
                if (enemyArr[i, j] == 1) //ранен\убит
                {
                    GameObject obj = GameObject.Find(i.ToString() + " " + j.ToString() + " enemy");
                    obj.GetComponent<Renderer>().material.color = Color.red;
                }
                if (enemyArr[i, j] == -1) //статус до выстрела
                {
                    GameObject obj = GameObject.Find(i.ToString() + " " + j.ToString() + " enemy");
                    obj.GetComponent<Renderer>().material.color = Color.blue;
                }
                if (enemyArr[i, j] == 0) //пусто
                {
                    GameObject obj = GameObject.Find(i.ToString() + " " + j.ToString() + " enemy");
                    obj.GetComponent<Renderer>().material.color = Color.white;
                }
            }
        }
    }
}
