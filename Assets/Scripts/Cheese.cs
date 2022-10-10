using System;
using UnityEngine;

public class Cheese : ItemsAdd
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Cheese cheese))
        {
            cheese.isOn = true;
        }
    }
}