using System;
using UnityEngine;

public class Beer : ItemsAdd
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Meat meat))
        {
            meat.isOn = true;
        }
    }
}
