using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//列舉
//列舉為實質型別，宣告一組具名常數
public enum Season
{
    Spring, Summer, Fall, Winter
}

public enum ItemPotion
{
    RedHerb, BlueHerb, Others
}

public class Practice05 : MonoBehaviour
{
    public int A = 1, B = 1,C=1;
    public GameObject Wall;
    public int[] scores = { 10, 60, 55, 33, 1, 75, 98, 22, 24, 32 };

    public ItemPotion prop = ItemPotion.RedHerb;

    void Start()
    {
        if( A== 5)
        {
            Debug.Log("執行判斷式...");
            A++;
            Debug.Log("A為："+A);
        }

        //遞迴陳述式
        //while迴圈，先判斷是否符合迴圈的判斷式，符合條件再執行內部陳述式
        while ( B<5 )
        {
            Debug.Log("執行while迴圈...");
            B++;
            Debug.Log("B為：" + B);
        }

        //do迴圈，先執行內部陳述式一次，再根據判斷式決定是否繼續執行
        do
        {
            Debug.Log("執行do迴圈...");
            C++;
            Debug.Log("C為：" + C);
        } while (C<5);

        //for迴圈，由初始值、條件、迭代器組成條件
        for (int D = 0; D < 5; D++)
        {
            Debug.Log("執行do迴圈...");
            Debug.Log("D為：" + D);
        }

        //巢狀迴圈
        for (int i = 0; i < 3; i++)
        {
            //實例化物件
            //類似new但會顯示於場景上
            //Instantiate(Wall);

            //多載 (物件，座標，角度)
            //Quaternion 四元(x,y,z,w)
            //Quaternion.identity 零角度

            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Instantiate(Wall, new Vector3(i, j, k), Quaternion.identity);
                }
            }
        }

        //練習 印出九九乘法表
        for (int i = 1; i <=9; i++)
        {
            for (int j = 1; j <=9; j++)
            {
                Debug.Log( "<color=blue>" + i + "</color> × <color=red>" + j + "</color> = <color=#008000>" + i*j + "</color>");
            }
        }

        //for搭配陣列使用
        for (int i = 0; i < scores.Length; i++)
        {
            Debug.Log("for迴圈輸出分數："+scores[i]);
        }

        //foreach
        foreach (int score in scores)
        {
            Debug.Log("foreach迴圈輸出分數：" + score);
        }


        //跳躍陳述式

        //goto 中斷目前所在的迴圈陳述式，並跳到指定標記處繼續執行
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5) goto Talk;

            Debug.Log("<color=blue><b> goto數字" + i + "</b></color>");
        }
        Talk:
            Debug.Log("<color=red>我在標記內</color>");
            Debug.Log("<color=red>YO~</color>");


        //break 中斷目前所在的迴圈陳述式，並結束該迴圈
        for (int i = 1; i <=10; i++)
        {
            if (i == 5) break;

            Debug.Log("<color=blue><b> break數字" + i +"</b></color>");
        }
        Debug.Log("<color=red>88行for迴圈陳述式下方敘述</color>");

        //continue 中斷目前所在的迴圈陳述式，但該迴圈繼續執行
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5) continue;

            Debug.Log("<color=blue><b> continue數字" + i + "</b></color>");
        }
        Debug.Log("<color=red>98行for迴圈陳述式下方敘述</color>");

    }

    // Update is called once per frame
    void Update()
    {
        switch (prop)
        {
            case ItemPotion.RedHerb:
                Debug.Log("回復HP <color=#008000><b>HP +10</b></color>");
                break;
            case ItemPotion.BlueHerb:
                Debug.Log("回復HP <color=#0000FF><b>MP +10</b></color>");
                break;
            default:
                Debug.Log("<color=#FF0000>這不是一個正常的道具</color>");
                break;
        }
    }
}
