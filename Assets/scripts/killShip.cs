using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killShip : MonoBehaviour
{
     
    // Start is called before the first frame update
    void Start()
    {
        // for example: enemyPlane.enemyArr[1, 1] = 1;

    }

    public void pisatZdesDima()
    {
        //обводит корабли вокруг ячейки застрелленым индексом
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (enemyPlane.enemyArr[i, j] == 1)
                {
                    if (i + 1 <= 19 && enemyPlane.enemyArr[i + 1, j] != 1) //1
                    {
                        enemyPlane.enemyArr[i + 1, j] = 0;
                    }

                    if (i + 1 <= 19 && j + 1 <= 19 && enemyPlane.enemyArr[i + 1, j + 1] != 1) //2
                    {
                        enemyPlane.enemyArr[i + 1, j + 1] = 0;
                    }

                    if (j + 1 <= 19 && enemyPlane.enemyArr[i, j + 1] != 1) //3
                    {
                        enemyPlane.enemyArr[i, j + 1] = 0;
                    }

                    if (j + 1 <= 19 && i - 1 >= 0 && enemyPlane.enemyArr[i - 1, j + 1] != 1) //4
                    {
                        enemyPlane.enemyArr[i - 1, j + 1] = 0;
                    }

                    if (i - 1 >= 0 && enemyPlane.enemyArr[i - 1, j] != 1) //5
                    {
                        enemyPlane.enemyArr[i - 1, j] = 0;
                    }

                    if (j - 1 >= 0 && i - 1 >= 0 && enemyPlane.enemyArr[i - 1, j - 1] != 1) //6
                    {
                        enemyPlane.enemyArr[i - 1, j - 1] = 0;
                    }

                    if (j - 1 >= 0 && enemyPlane.enemyArr[i, j - 1] != 1) //7
                    {
                        enemyPlane.enemyArr[i, j - 1] = 0;
                    }

                    if (j - 1 >= 0 && i + 1 <= 19 && enemyPlane.enemyArr[i + 1, j - 1] != 1) //8
                    {
                        enemyPlane.enemyArr[i + 1, j - 1] = 0;
                    }

                }
            }
        }

        enemyPlane.fillEnemyShip();
    }
}
