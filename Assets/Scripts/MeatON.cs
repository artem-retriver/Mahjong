using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatON : MonoBehaviour
{
    [SerializeField] public GameManager gameManager;

    public void OnMouseDown()
    {
        if (gameManager._items.Count < 7)
        {
            //gameManager.col = gameManager._items.Count + 1;
            gameManager._items.Add(gameObject);

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
}
