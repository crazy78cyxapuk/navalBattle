using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrangement : MonoBehaviour
{
    public static int[,] arr1 = new int[20, 20];
    public static bool finishArrang;

    // Start is called before the first frame update
    void Start()
    {
        finishArrang = false;

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                arr1[i, j] = 0;
            }
        }

        goArrangement1();

        //fillCage();

        //for(int i = 0; i < 20; i++)
        //{
        //    for(int j=0; j<20; j++)
        //    {
        //        
        //    }
        //}
    }

    
    public void goArrangement1()
    {
        //строка х столбец

        for(int i = 0; i <= 3; i++)
        {
            arr1[0, i] = -1; //1
        }

        for (int i = 5; i <= 8; i++)
        {
            arr1[0, i] = -1; //2
        }

        for (int i = 10; i <= 13; i++)
        {
            arr1[0, i] = -1; //3
        }

        for (int i = 15; i <= 17; i++)
        {
            arr1[0, i] = -1; //4
        }

        for (int i = 2; i <= 6; i++)
        {
            arr1[i, 0] = -1; //5
        }

        for (int i = 8; i <= 12; i++)
        {
            arr1[i, 0] = -1; //6
        }

        for (int i = 14; i <= 19; i++)
        {
            arr1[i, 0] = -1; //7
        }

        for (int i = 9; i <= 10; i++)
        {
            arr1[i, 2] = -1; //8
        }

        for (int i = 12; i <= 13; i++)
        {
            arr1[i, 2] = -1; //9
        }

        for (int i = 15; i <= 16; i++)
        {
            arr1[i, 2] = -1; //10
        }

        for (int i = 18; i <= 19; i++)
        {
            arr1[i, 2] = -1; //11
        }

        for (int i = 0; i <= 2; i++)
        {
            arr1[i, 19] = -1; //12
        }

        for (int i = 4; i <= 6; i++)
        {
            arr1[i, 19] = -1; //13
        }

        for (int i = 8; i <= 10; i++)
        {
            arr1[i, 19] = -1; //14
        }

        for (int i = 12; i <= 14; i++)
        {
            arr1[i, 19] = -1; //15
        }

        for (int i = 16; i <= 18; i++)
        {
            arr1[i, 19] = -1; //16
        }

        for (int i = 4; i <= 5; i++)
        {
            arr1[19, i] = -1; //17
        }

        for (int i = 7; i <= 8; i++)
        {
            arr1[19, i] = -1; //18
        }

        for (int i = 10; i <= 11; i++)
        {
            arr1[19, i] = -1; //19
        }

        for (int i = 13; i <= 14; i++)
        {
            arr1[19, i] = -1; //20
        }

        for (int i = 16; i <= 17; i++)
        {
            arr1[19, i] = -1; //21
        }

        arr1[2, 4] = -1;
        arr1[2, 6] = -1;
        arr1[2, 8] = -1;
        arr1[2, 10] = -1;
        arr1[2, 12] = -1;
        arr1[2, 14] = -1;
        arr1[2, 16] = -1;

        arr1[4, 17] = -1;
        arr1[6, 17] = -1;
     

        arr1[3, 2] = -1;
        arr1[5, 2] = -1;
        arr1[7, 2] = -1;

        finishArrang = true;
    }

    public void goArrangement2()
    {
        for (int i = 14; i <= 19; i++)
        {
            arr1[i, 0] = -1; //1 шестипалубный корабль
        }

        for (int i = 8; i <= 12; i++)
        {
            arr1[i, 0] = -1; //2 пятипалубный корабль первый
        }

        for (int i = 2; i <= 6; i++)
        {
            arr1[i, 0] = -1; //3 пятипалубный корабль второй
        }

        for (int i = 0; i <= 3; i++)
        {
            arr1[0, i] = -1; //4 четырехпалубный корабль первый
        }

        for (int i = 5; i <= 6; i++)
        {
            arr1[0, i] = -1; //5 двупалубный корабль первый
        }

        for (int i = 8; i <= 9; i++)
        {
            arr1[0, i] = -1; //6 двупалубный корабль второй
        }

        for (int i = 2; i <= 5; i++)
        {
            arr1[i, 2] = -1; //7 четырехпалубный корабль второй
        }

        for (int i = 7; i <= 10; i++)
        {
            arr1[i, 2] = -1; //8 четырехпалубный корабль третий
        }

        for (int i = 12; i <= 14; i++)
        {
            arr1[i, 2] = -1; //9 трехпалубный корабль первый
        }

        for (int i = 16; i <= 18; i++)
        {
            arr1[i, 2] = -1; //10 трехпалубный корабль второй
        }

        for (int i = 2; i <= 4; i++)
        {
            arr1[i, 4] = -1; //11 трехпалубный корабль третий
        }

        for (int i = 6; i <= 8; i++)
        {
            arr1[i, 4] = -1; //12 трехпалубный корабль четвертый
        }

        for (int i = 10; i <= 12; i++)
        {
            arr1[i, 4] = -1; //13 трехпалубный корабль пятый
        }

        for (int i = 14; i <= 16; i++)
        {
            arr1[i, 4] = -1; //14 трехпалубный корабль шестой
        }
        finishArrang = true;

        for (int i = 18; i <= 19; i++)
        {
            arr1[i, 4] = -1; //15 двухпалубный корабль третий
        }

        for (int i = 2; i <= 3; i++)
        {
            arr1[i, 6] = -1; //16 двухпалубный корабль четвертый
        }

        for (int i = 5; i <= 6; i++)
        {
            arr1[i, 6] = -1; //17 двухпалубный корабль пятый
        }

        for (int i = 8; i <= 9; i++)
        {
            arr1[i, 6] = -1; //18 двухпалубный корабль шестой
        }

        for (int i = 11; i <= 12; i++)
        {
            arr1[i, 6] = -1; //19 двухпалубный корабль седьмой
        }

        for (int i = 14; i <= 15; i++)
        {
            arr1[i, 6] = -1; //20 двухпалубный корабль восьмой
        }

        for (int i = 17; i <= 18; i++)
        {
            arr1[i, 6] = -1; //21 двухпалубный корабль девятый
        }

        arr1[2, 8] = -1;
        arr1[4, 8] = -1;
        arr1[6, 8] = -1;
        arr1[8, 8] = -1;
        arr1[10, 8] = -1;
        arr1[12, 8] = -1;
        arr1[14, 8] = -1;
        arr1[16, 8] = -1;
        arr1[18, 8] = -1;

        arr1[2, 10] = -1;
        arr1[4, 10] = -1;
        arr1[6, 10] = -1;


        //arr1[3, 2] = -1;
        //arr1[5, 2] = -1;
        //arr1[7, 2] = -1;

        finishArrang = true;
    }
 }
