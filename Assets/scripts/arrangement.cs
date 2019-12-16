using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrangement : MonoBehaviour
{
    public static int[,] arr1 = new int[20, 20];
    public static bool finishArrang;
    public GameObject screen1, screen2;

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

        //goArrangement7();

        //fillCage();

        //for(int i = 0; i < 20; i++)
        //{
        //    for(int j=0; j<20; j++)
        //    {
        //        
        //    }
        //}
    }

    private void swapScreen()
    {
        screen1.SetActive(false);
        screen2.SetActive(true);
    }

    public void goArrangement1()
    {
        //строка х столбец

        for (int i = 0; i <= 3; i++)
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


        finishArrang = true;
    }

    public void goArrangement3()
    {
        for (int i = 0; i <= 5; i++)
        {
            arr1[0, i] = -1; //1 
        }

        for (int i = 7; i <= 11; i++)
        {
            arr1[0, i] = -1; //2 
        }

        for (int i = 13; i <= 17; i++)
        {
            arr1[0, i] = -1; //3 
        }

        for (int i = 1; i <= 3; i++)
        {
            arr1[2, i] = -1; //4 
        }

        for (int i = 5; i <= 7; i++)
        {
            arr1[2, i] = -1; //5 
        }

        for (int i = 9; i <= 12; i++)
        {
            arr1[2, i] = -1; //6 
        }

        for (int i = 14; i <= 17; i++)
        {
            arr1[2, i] = -1; //7 
        }

        for (int i = 0; i <= 1; i++)
        {
            arr1[4, i] = -1; //8 
        }

        for (int i = 3; i <= 5; i++)
        {
            arr1[4, i] = -1; //9 
        }

        for (int i = 7; i <= 9; i++)
        {
            arr1[4, i] = -1; //10 
        }

        for (int i = 11; i <= 13; i++)
        {
            arr1[4, i] = -1; //11 
        }

        for (int i = 15; i <= 17; i++)
        {
            arr1[4, i] = -1; //12 
        }

        for (int i = 1; i <= 2; i++)
        {
            arr1[6, i] = -1; //13 
        }

        for (int i = 4; i <= 5; i++)
        {
            arr1[6, i] = -1; //14 
        }

        for (int i = 7; i <= 8; i++)
        {
            arr1[6, i] = -1; //15 
        }

        for (int i = 10; i <= 11; i++)
        {
            arr1[6, i] = -1; //16 
        }

        for (int i = 13; i <= 14; i++)
        {
            arr1[6, i] = -1; //17 
        }

        for (int i = 16; i <= 17; i++)
        {
            arr1[6, i] = -1; //18 
        }

        for (int i = 0; i <= 3; i++)
        {
            arr1[i, 19] = -1; //19 
        }

        for (int i = 5; i <= 6; i++)
        {
            arr1[i, 19] = -1; //20
        }

        for (int i = 8; i <= 9; i++)
        {
            arr1[i, 19] = -1; //21
        }

        arr1[8, 1] = -1;
        arr1[8, 3] = -1;
        arr1[8, 5] = -1;
        arr1[8, 7] = -1;
        arr1[8, 9] = -1;
        arr1[8, 11] = -1;
        arr1[8, 13] = -1;
        arr1[8, 15] = -1;
        arr1[8, 17] = -1;

        arr1[10, 0] = -1;

        arr1[19, 0] = -1;

        arr1[19, 19] = -1;

        finishArrang = true;
    }
    public void goArrangement4()
    {
        for (int i = 10; i <= 11; i++)
        {
            arr1[0, i] = -1; //1
        }

        for (int i = 13; i <= 14; i++)
        {
            arr1[0, i] = -1; //2
        }

        for (int i = 16; i <= 19; i++)
        {
            arr1[0, i] = -1; //3
        }

        for (int i = 2; i <= 6; i++)
        {
            arr1[i, 19] = -1; //4
        }

        for (int i = 8; i <= 12; i++)
        {
            arr1[i, 19] = -1; //5
        }

        for (int i = 14; i <= 19; i++)
        {
            arr1[i, 19] = -1; //6
        }

        for (int i = 2; i <= 5; i++)
        {
            arr1[i, 17] = -1; //7
        }

        for (int i = 7; i <= 10; i++)
        {
            arr1[i, 17] = -1; //8
        }

        for (int i = 12; i <= 14; i++)
        {
            arr1[i, 17] = -1; //9
        }

        for (int i = 16; i <= 18; i++)
        {
            arr1[i, 17] = -1; //10
        }

        for (int i = 2; i <= 4; i++)
        {
            arr1[i, 15] = -1; //11
        }

        for (int i = 6; i <= 8; i++)
        {
            arr1[i, 15] = -1; //12
        }

        for (int i = 10; i <= 12; i++)
        {
            arr1[i, 15] = -1; //13
        }

        for (int i = 14; i <= 16; i++)
        {
            arr1[i, 15] = -1; //14
        }

        for (int i = 18; i <= 19; i++)
        {
            arr1[i, 15] = -1; //15
        }

        for (int i = 2; i <= 3; i++)
        {
            arr1[i, 13] = -1; //16
        }

        for (int i = 5; i <= 6; i++)
        {
            arr1[i, 13] = -1; //17
        }

        for (int i = 8; i <= 9; i++)
        {
            arr1[i, 13] = -1; //18
        }

        for (int i = 11; i <= 12; i++)
        {
            arr1[i, 13] = -1; //19
        }

        for (int i = 14; i <= 15; i++)
        {
            arr1[i, 13] = -1; //20
        }

        for (int i = 17; i <= 18; i++)
        {
            arr1[i, 13] = -1; //21
        }

        arr1[2, 11] = -1;
        arr1[4, 11] = -1;
        arr1[6, 11] = -1;
        arr1[8, 11] = -1;
        arr1[10, 11] = -1;
        arr1[12, 11] = -1;
        arr1[14, 11] = -1;
        arr1[16, 11] = -1;
        arr1[18, 11] = -1;

        arr1[0, 0] = -1;

        arr1[19, 0] = -1;

        arr1[19, 5] = -1;

        finishArrang = true;
    }

    public void goArrangement5()
    {
        for (int i = 10; i <= 11; i++)
        {
            arr1[i, 0] = -1; //1
        }

        for (int i = 13; i <= 14; i++)
        {
            arr1[i, 0] = -1; //2
        }

        for (int i = 16; i <= 19; i++)
        {
            arr1[i, 0] = -1; //3
        }

        for (int i = 2; i <= 3; i++)
        {
            arr1[13, i] = -1; //4
        }

        for (int i = 5; i <= 6; i++)
        {
            arr1[13, i] = -1; //5
        }

        for (int i = 8; i <= 9; i++)
        {
            arr1[13, i] = -1; //6
        }

        for (int i = 11; i <= 12; i++)
        {
            arr1[13, i] = -1; //7
        }

        for (int i = 14; i <= 15; i++)
        {
            arr1[13, i] = -1; //8
        }

        for (int i = 17; i <= 18; i++)
        {
            arr1[13, i] = -1; //9
        }

        for (int i = 2; i <= 4; i++)
        {
            arr1[15, i] = -1; //10
        }

        for (int i = 6; i <= 8; i++)
        {
            arr1[15, i] = -1; //11
        }

        for (int i = 10; i <= 12; i++)
        {
            arr1[15, i] = -1; //12
        }

        for (int i = 14; i <= 16; i++)
        {
            arr1[15, i] = -1; //13
        }

        for (int i = 18; i <= 19; i++)
        {
            arr1[15, i] = -1; //14
        }

        for (int i = 2; i <= 5; i++)
        {
            arr1[17, i] = -1; //15
        }

        for (int i = 7; i <= 10; i++)
        {
            arr1[17, i] = -1; //16
        }

        for (int i = 12; i <= 14; i++)
        {
            arr1[17, i] = -1; //17
        }

        for (int i = 16; i <= 18; i++)
        {
            arr1[17, i] = -1; //18
        }

        for (int i = 2; i <= 6; i++)
        {
            arr1[19, i] = -1; //19
        }

        for (int i = 8; i <= 12; i++)
        {
            arr1[19, i] = -1; //20
        }

        for (int i = 14; i <= 19; i++)
        {
            arr1[19, i] = -1; //21
        }

        arr1[0, 0] = -1;
        arr1[0, 2] = -1;
        arr1[0, 4] = -1;
        arr1[0, 6] = -1;
        arr1[0, 8] = -1;
        arr1[0, 10] = -1;
        arr1[0, 12] = -1;
        arr1[0, 14] = -1;
        arr1[0, 16] = -1;
        arr1[0, 18] = -1;

        arr1[11, 2] = -1;

        arr1[6, 9] = -1;

        finishArrang = true;
    }

    public void goArrangement6()
    {
        for (int i = 0; i <= 3; i++)
        {
            arr1[i, 0] = -1; //1
        }

        for (int i = 5; i <= 6; i++)
        {
            arr1[i, 0] = -1; //2
        }

        for (int i = 8; i <= 9; i++)
        {
            arr1[i, 0] = -1; //3
        }

        for (int i = 11; i <= 12; i++)
        {
            arr1[i, 0] = -1; //4
        }

        for (int i = 14; i <= 15; i++)
        {
            arr1[i, 0] = -1; //5
        }

        for (int i = 17; i <= 18; i++)
        {
            arr1[i, 0] = -1; //6
        }

        for (int i = 2; i <= 6; i++)
        {
            arr1[0, i] = -1; //7
        }

        for (int i = 8; i <= 12; i++)
        {
            arr1[0, i] = -1; //8
        }

        for (int i = 14; i <= 19; i++)
        {
            arr1[0, i] = -1; //9
        }

        for (int i = 2; i <= 5; i++)
        {
            arr1[2, i] = -1; //10
        }

        for (int i = 7; i <= 10; i++)
        {
            arr1[2, i] = -1; //11
        }

        for (int i = 12; i <= 14; i++)
        {
            arr1[2, i] = -1; //12
        }

        for (int i = 16; i <= 18; i++)
        {
            arr1[2, i] = -1; //13
        }

        for (int i = 2; i <= 4; i++)
        {
            arr1[4, i] = -1; //14
        }

        for (int i = 6; i <= 8; i++)
        {
            arr1[4, i] = -1; //15
        }

        for (int i = 10; i <= 12; i++)
        {
            arr1[4, i] = -1; //16
        }

        for (int i = 14; i <= 16; i++)
        {
            arr1[4, i] = -1; //17
        }

        for (int i = 18; i <= 19; i++)
        {
            arr1[4, i] = -1; //18
        }

        for (int i = 6; i <= 7; i++)
        {
            arr1[i, 19] = -1; //19
        }

        for (int i = 9; i <= 10; i++)
        {
            arr1[i, 19] = -1; //20
        }

        for (int i = 12; i <= 13; i++)
        {
            arr1[i, 19] = -1; //21
        }

        arr1[15, 19] = -1;
        arr1[17, 19] = -1;
        arr1[19, 19] = -1;
        arr1[19, 3] = -1;
        arr1[19, 5] = -1;
        arr1[19, 7] = -1;
        arr1[19, 9] = -1;
        arr1[19, 11] = -1;
        arr1[19, 13] = -1;
        arr1[19, 15] = -1;
        arr1[19, 17] = -1;

        arr1[6, 17] = -1;


        finishArrang = true;
    }

    public void goArrangement7()
    {
        for (int i = 0; i <= 2; i++)
        {
            arr1[i, 0] = -1; //1
        }

        for (int i = 4; i <= 6; i++)
        {
            arr1[i, 0] = -1; //2
        }

        for (int i = 8; i <= 10; i++)
        {
            arr1[i, 0] = -1; //3
        }

        for (int i = 12; i <= 14; i++)
        {
            arr1[i, 0] = -1; //4
        }

        for (int i = 16; i <= 17; i++)
        {
            arr1[i, 0] = -1; //5
        }

        for (int i = 2; i <= 4; i++)
        {
            arr1[0, i] = -1; //6
        }

        for (int i = 6; i <= 9; i++)
        {
            arr1[0, i] = -1; //7
        }

        for (int i = 11; i <= 14; i++)
        {
            arr1[0, i] = -1; //8
        }

        for (int i = 16; i <= 19; i++)
        {
            arr1[0, i] = -1; //9
        }

        for (int i = 0; i <= 2; i++)
        {
            arr1[19, i] = -1; //10
        }

        for (int i = 4; i <= 5; i++)
        {
            arr1[19, i] = -1; //11
        }

        for (int i = 7; i <= 8; i++)
        {
            arr1[19, i] = -1; //12
        }

        for (int i = 10; i <= 11; i++)
        {
            arr1[19, i] = -1; //13
        }

        for (int i = 13; i <= 14; i++)
        {
            arr1[19, i] = -1; //14
        }

        for (int i = 16; i <= 17; i++)
        {
            arr1[19, i] = -1; //15
        }

        for (int i = 10; i <= 11; i++)
        {
            arr1[i, 17] = -1; //16
        }

        for (int i = 13; i <= 14; i++)
        {
            arr1[i, 17] = -1; //17
        }

        for (int i = 16; i <= 17; i++)
        {
            arr1[i, 17] = -1; //18
        }

        for (int i = 2; i <= 6; i++)
        {
            arr1[i, 19] = -1; //19
        }

        for (int i = 8; i <= 12; i++)
        {
            arr1[i, 19] = -1; //20
        }

        for (int i = 14; i <= 19; i++)
        {
            arr1[i, 19] = -1; //21
        }

        arr1[2, 4] = -1;
        arr1[2, 2] = -1;

        arr1[4, 2] = -1;
        arr1[6, 2] = -1;

        arr1[2, 13] = -1;
        arr1[2, 15] = -1;
        arr1[2, 17] = -1;

        arr1[4, 17] = -1;
        arr1[6, 17] = -1;
        arr1[8, 17] = -1;

        arr1[17, 4] = -1;
        arr1[16, 9] = -1;

        finishArrang = true;
    }

    public void goArrangement8()
    {
        for (int i = 0; i <= 2; i++)
        {
            arr1[0, i] = -1; //1
        }

        for (int i = 4; i <= 6; i++)
        {
            arr1[0, i] = -1; //2
        }

        for (int i = 8; i <= 10; i++)
        {
            arr1[0, i] = -1; //3
        }

        for (int i = 12; i <= 14; i++)
        {
            arr1[0, i] = -1; //4
        }

        for (int i = 16; i <= 17; i++)
        {
            arr1[0, i] = -1; //5
        }

        for (int i = 2; i <= 4; i++)
        {
            arr1[i, 0] = -1; //6
        }

        for (int i = 6; i <= 9; i++)
        {
            arr1[i, 0] = -1; //7
        }

        for (int i = 11; i <= 14; i++)
        {
            arr1[i, 0] = -1; //8
        }

        for (int i = 16; i <= 19; i++)
        {
            arr1[i, 0] = -1; //9
        }

        for (int i = 0; i <= 2; i++)
        {
            arr1[i, 19] = -1; //10
        }

        for (int i = 4; i <= 5; i++)
        {
            arr1[i, 19] = -1; //11
        }

        for (int i = 7; i <= 8; i++)
        {
            arr1[i, 19] = -1; //12
        }

        for (int i = 10; i <= 11; i++)
        {
            arr1[i, 19] = -1; //13
        }

        for (int i = 13; i <= 14; i++)
        {
            arr1[i, 19] = -1; //14
        }

        for (int i = 16; i <= 17; i++)
        {
            arr1[i, 19] = -1; //15
        }

        for (int i = 2; i <= 6; i++)
        {
            arr1[19, i] = -1; //16
        }

        for (int i = 8; i <= 12; i++)
        {
            arr1[19, i] = -1; //17
        }

        for (int i = 14; i <= 19; i++)
        {
            arr1[19, i] = -1; //18
        }

        for (int i = 10; i <= 11; i++)
        {
            arr1[17, i] = -1; //19
        }

        for (int i = 13; i <= 14; i++)
        {
            arr1[17, i] = -1; //20
        }

        for (int i = 16; i <= 17; i++)
        {
            arr1[17, i] = -1; //21
        }


        arr1[6, 11] = -1;

        arr1[13, 6] = -1;

        arr1[15, 17] = -1;

        arr1[7, 2] = -1;
        arr1[9, 2] = -1;
        arr1[11, 2] = -1;
        arr1[13, 2] = -1;
        arr1[15, 2] = -1;
        arr1[17, 2] = -1;

        arr1[17, 4] = -1;
        arr1[17, 6] = -1;
        arr1[17, 8] = -1;
        finishArrang = true;
    }

    public void goArrangement9()
    {
        for (int i = 0; i <= 3; i++)
        {
            arr1[0, i] = -1; //1
        }

        for (int i = 5; i <= 8; i++)
        {
            arr1[0, i] = -1; //2
        }

        for (int i = 10; i <= 12; i++)
        {
            arr1[0, i] = -1; //3
        }

        for (int i = 14; i <= 16; i++)
        {
            arr1[0, i] = -1; //4
        }

        for (int i = 18; i <= 19; i++)
        {
            arr1[0, i] = -1; //5
        }

        for (int i = 0; i <= 5; i++)
        {
            arr1[19, i] = -1; //6
        }

        for (int i = 7; i <= 8; i++)
        {
            arr1[19, i] = -1; //7
        }

        for (int i = 10; i <= 11; i++)
        {
            arr1[19, i] = -1; //8
        }

        for (int i = 13; i <= 14; i++)
        {
            arr1[19, i] = -1; //9
        }

        for (int i = 16; i <= 17; i++)
        {
            arr1[19, i] = -1; //10
        }

        for (int i = 2; i <= 4; i++)
        {
            arr1[i, 19] = -1; //11
        }

        for (int i = 6; i <= 8; i++)
        {
            arr1[i, 19] = -1; //12
        }

        for (int i = 10; i <= 12; i++)
        {
            arr1[i, 19] = -1; //13
        }

        for (int i = 14; i <= 16; i++)
        {
            arr1[i, 19] = -1; //14
        }

        for (int i = 18; i <= 19; i++)
        {
            arr1[i, 19] = -1; //15
        }

        for (int i = 2; i <= 5; i++)
        {
            arr1[i, 0] = -1; //16
        }

        for (int i = 7; i <= 11; i++)
        {
            arr1[i, 0] = -1; //17
        }

        for (int i = 13; i <= 17; i++)
        {
            arr1[i, 0] = -1; //18
        }

        for (int i = 10; i <= 11; i++)
        {
            arr1[i, 2] = -1; //19
        }

        for (int i = 13; i <= 14; i++)
        {
            arr1[i, 2] = -1; //20
        }

        for (int i = 16; i <= 17; i++)
        {
            arr1[i, 2] = -1; //21
        }


        arr1[17, 17] = -1;

        arr1[4, 2] = -1;
        arr1[6, 2] = -1;
        arr1[8, 2] = -1;

        arr1[2, 2] = -1;
        arr1[2, 4] = -1;
        arr1[2, 6] = -1;
        arr1[2, 8] = -1;
        arr1[2, 10] = -1;
        arr1[2, 12] = -1;
        arr1[2, 14] = -1;
        arr1[2, 16] = -1;

        finishArrang = true;
    }

    public void goArrangement10()
    {
        for (int i = 2; i <= 3; i++)
        {
            arr1[0, i] = -1; //1
        }

        for (int i = 5; i <= 6; i++)
        {
            arr1[0, i] = -1; //2
        }

        for (int i = 8; i <= 9; i++)
        {
            arr1[0, i] = -1; //3
        }

        for (int i = 11; i <= 12; i++)
        {
            arr1[0, i] = -1; //4
        }

        for (int i = 14; i <= 19; i++)
        {
            arr1[0, i] = -1; //5
        }

        for (int i = 2; i <= 6; i++)
        {
            arr1[i, 19] = -1; //6
        }

        for (int i = 8; i <= 12; i++)
        {
            arr1[i, 19] = -1; //7
        }

        for (int i = 14; i <= 17; i++)
        {
            arr1[i, 19] = -1; //8
        }

        for (int i = 0; i <= 2; i++)
        {
            arr1[19, i] = -1; //9
        }

        for (int i = 4; i <= 5; i++)
        {
            arr1[19, i] = -1; //10
        }

        for (int i = 7; i <= 9; i++)
        {
            arr1[19, i] = -1; //11
        }

        for (int i = 11; i <= 14; i++)
        {
            arr1[19, i] = -1; //12
        }

        for (int i = 16; i <= 19; i++)
        {
            arr1[19, i] = -1; //13
        }

        for (int i = 0; i <= 1; i++)
        {
            arr1[i, 0] = -1; //14
        }

        for (int i = 3; i <= 5; i++)
        {
            arr1[i, 0] = -1; //15
        }

        for (int i = 7; i <= 9; i++)
        {
            arr1[i, 0] = -1; //16
        }

        for (int i = 11; i <= 13; i++)
        {
            arr1[i, 0] = -1; //17
        }

        for (int i = 15; i <= 17; i++)
        {
            arr1[i, 0] = -1; //18
        }

        for (int i = 2; i <= 3; i++)
        {
            arr1[i, 17] = -1; //19
        }

        for (int i = 5; i <= 6; i++)
        {
            arr1[i, 17] = -1; //20
        }

        for (int i = 8; i <= 9; i++)
        {
            arr1[i, 17] = -1; //21
        }

        arr1[11, 17] = -1;
        arr1[13, 17] = -1;
        arr1[15, 17] = -1;
        arr1[17, 17] = -1;

        arr1[3, 2] = -1;
        arr1[5, 2] = -1;
        arr1[7, 2] = -1;
        arr1[9, 2] = -1;
        arr1[11, 2] = -1;
        arr1[13, 2] = -1;
        arr1[15, 2] = -1;
        arr1[17, 2] = -1;






        finishArrang = true;
    }

    public void goArrangement11() // find 6 
    {
        int k = 6;
        int m = 6;
        for (int i = 0; i < 20; i++)
        {
            k = m;
            for (int j = 0; j < 20; j++)
            {

                if (k == 6)
                {
                    arr1[i, j] = -1;
                    k = 0;
                }
                k += 1;
            }
            m -= 1;
            if (m == 0)
            {
                m = 6;
            }
        }
        finishArrang = true;
    }

    public void goArrangement12() // find 5
    {
        int k = 5;
        int m = 5;
        for (int i = 0; i < 20; i++)
        {
            k = m;
            for (int j = 0; j < 20; j++)
            {

                if (k == 5)
                {
                    arr1[i, j] = -1;
                    k = 0;
                }
                k += 1;
            }
            m -= 1;
            if (m == 0)
            {
                m = 5;
            }
        }
        finishArrang = true;
    }

    public void goArrangement13() // find 4
    {
        int k = 4;
        int m = 4;
        for (int i = 0; i < 20; i++)
        {
            k = m;
            for (int j = 0; j < 20; j++)
            {

                if (k == 4)
                {
                    arr1[i, j] = -1;
                    k = 0;
                }
                k += 1;
            }
            m -= 1;
            if (m == 0)
            {
                m = 4;
            }
        }
        finishArrang = true;
    }

    public void goArrangement14() // find 3
    {
        int k = 3;
        int m = 3;
        for (int i = 0; i < 20; i++)
        {
            k = m;
            for (int j = 0; j < 20; j++)
            {

                if (k == 3)
                {
                    arr1[i, j] = -1;
                    k = 0;
                }
                k += 1;
            }
            m -= 1;
            if (m == 0)
            {
                m = 3;
            }
        }
        finishArrang = true;
    }

    public void goArrangement15() // find 2
    {
        int k = 2;
        int m = 2;
        for (int i = 0; i < 20; i++)
        {
            k = m;
            for (int j = 0; j < 20; j++)
            {

                if (k == 2)
                {
                    arr1[i, j] = -1;
                    k = 0;
                }
                k += 1;
            }
            m -= 1;
            if (m == 0)
            {
                m = 2;
            }
        }
        finishArrang = true;
    }
    


    public void btn1()
    {
        goArrangement1();
        swapScreen();
    }

    public void btn2()
    {
        goArrangement2();
        swapScreen();
    }

    public void btn3()
    {
        goArrangement3();
        swapScreen();
    }

    public void btn4()
    {
        goArrangement4();
        swapScreen();
    }

    public void btn5()
    {
        goArrangement5();
        swapScreen();
    }

    public void btn6()
    {
        goArrangement6();
        swapScreen();
    }

    public void btn7()
    {
        goArrangement7();
        swapScreen();
    }

    public void btn8()
    {
        goArrangement8();
        swapScreen();
    }

    public void btn9()
    {
        goArrangement9();
        swapScreen();
    }

    public void btn10()
    {
        goArrangement10();
        swapScreen();
    }
}