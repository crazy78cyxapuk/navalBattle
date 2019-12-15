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
        //tyt kod pisat'
        enemyPlane.enemyArr[1, 1] = 0;
        enemyPlane tt = new enemyPlane();
        tt.fillEnemyShip();
    }
}
