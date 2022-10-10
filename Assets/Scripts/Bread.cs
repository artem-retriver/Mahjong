using System;
using UnityEngine;

public class Bread : ItemsAdd
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Cheese cheese))
        {
            cheese.isOn = true;
        }

        if (collision.TryGetComponent(out Beer beer))
        {
            beer.isOn = true;
        }
    }
}
