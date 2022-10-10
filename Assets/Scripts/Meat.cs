using System;
using UnityEngine;

public class Meat : ItemsAdd
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Beer beer))
        {
            beer.isOn = true;
        }

        if (collision.TryGetComponent(out Bread bread))
        {
            bread.isOn = true;
        }
    }
}
