using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game_Behaviour : MonoBehaviour
{

    private int itemsCollected = 0;
    private int playerHP = 10;

    public int max_Items = 8;
    public TMP_Text health_Text;
    public TMP_Text item_Text;
    public TMP_Text progress_Text;

    public int Items
    {
        get { return itemsCollected; }
        set
        {
            itemsCollected = value;

            item_Text.text = "ITEMS COLLECTED: " + Items;
            if (itemsCollected >= max_Items)
            {
                progress_Text.text = "YOU'VE FOUND ALL THE ITEMS!";
            }
            else
            {
                progress_Text.text = "ITEM FOUND, ONLY " + (max_Items - itemsCollected) + " MORE!";
            }

            Debug.LogFormat("ITEMS: {0}", itemsCollected);
        }
    }
    public int HP
    {
        get { return playerHP; }
        set
        {
            playerHP = value;

            health_Text.text = "Player Health: " + HP;
            Debug.LogFormat("Lives: {0}", playerHP);

            Debug.LogFormat("LIVES: {0}", playerHP);
        }
    }


    void Start()
    {
        item_Text.text += itemsCollected;
        health_Text.text += playerHP;
    }

    void Update()
    {
        
    }
}
