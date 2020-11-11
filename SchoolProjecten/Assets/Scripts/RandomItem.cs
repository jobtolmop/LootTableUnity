using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItem : MonoBehaviour
{
    public List<GameObject> colors;

    public int[] table =
    {
        60, //common
        25, //rare
        10, //epic
        5 //legendary
    };

    public int total;
    public int randomNumber;

    private void Start()
    {
        foreach(var item in table)
        {
            total += item;
        }

        randomNumber = Random.Range(0, total);

        for (int i = 0; i < table.Length; i++)
        {
            if (randomNumber <= table[i])
            {
                colors[i].SetActive(true);
                return;
            }
            else
            {
                randomNumber -= table[i];
            }
        }
    }



}
