using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPlane : MonoBehaviour
{

    public GameObject myCage;
    public static GameObject[,] plane = new GameObject[20, 20];
    //private GameObject currentCage;
    //private int id;
    private float posX, posY;
    private float startPosX = -8;
    private float startPosY = 4.8f;
    public Sprite ship;

    private void Start()
    {
        posX = .3f;
        posY = .3f;

        for (int i=0; i < 20; i++)
        {
            for(int j=0; j < 20; j++)
            {
                plane[i, j] = Instantiate(myCage, new Vector3(startPosX, startPosY, 0), Quaternion.identity); //as GameObject;
                startPosX += posX;
                plane[i, j].name = i.ToString() + " " + j.ToString();
                plane[i, j].transform.parent = transform;
            }
            startPosY -= posY;
            startPosX = -8;
        }

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                //plane[i, j].GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }


    private void fillCage()
    {
        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (arrangement.arr1[i, j] == -1)
                {
                    //plane[i, j].GetComponent<Renderer>().material.color = Color.red;
                    plane[i, j].GetComponent<SpriteRenderer>().sprite = ship;
                }
            }
        }
    }

    private void Update()
    {
        if (arrangement.finishArrang)
        {
            fillCage();
        }
    }

}
