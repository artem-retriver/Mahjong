using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsAdd : MonoBehaviour
{
    [SerializeField] public GameManager gameManager;
    public bool isOn;
    public bool isSelected;


    public void OnMouseDown()
    {
        if (gameManager._items.Count < 7)
        {
            if(isOn == false)
            {
                isOn = true;
                var r = GetComponent<SpriteRenderer>();
                r.color = new Color(255, 255, 255);
            }


            isSelected = true;
            gameManager.AddCheese(gameObject);
            //gameManager.cheese++;
            //Destroy(gameObject);
            //gameManager._items1.Remove(gameObject);
            //Instantiate(gameManager._items[0]);


            if (gameManager._items.Count == 1)
            {
                transform.position = gameManager.pos1;
            }

            if (gameManager._items.Count == 2)
            {
                transform.position = gameManager.pos2;
            }

            if (gameManager._items.Count == 3)
            {
                transform.position = gameManager.pos3;
            }

            if (gameManager._items.Count == 4)
            {
                transform.position = gameManager.pos4;
            }

            if (gameManager._items.Count == 5)
            {
                transform.position = gameManager.pos5;
            }

            if (gameManager._items.Count == 6)
            {
                transform.position = gameManager.pos6;
            }

            if (gameManager._items.Count == 7)
            {
                transform.position = gameManager.pos7;
            }
        }
    }

    public void InvisibleOff()
    {
        gameObject.SetActive(false);
    }
}
