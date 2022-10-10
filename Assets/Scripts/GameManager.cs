using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    [Header("UI:")]
    [SerializeField] public UI _uI;

    public List<Vector2> _vector2s = new List<Vector2>(7);

    public List<ItemsAdd> _items = new List<ItemsAdd>(7);

    public List<GameObject> _items1 = new List<GameObject>(15);

    public void AddItem(ItemsAdd item)
    {
        _items1.Remove(item.gameObject);
        _items.Add(item);

        ItemsAdd[] array = null;

        if (item is Cheese)
        {
            array = _items.OfType<Cheese>().Where(x => x.isOn == true && x.isSelected == true).ToArray();
        }
        else if (item is Bread)
        {
            array = _items.OfType<Bread>().Where(x => x.isOn == true && x.isSelected == true).ToArray();
        }
        else if (item is Meat)
        {
            array = _items.OfType<Meat>().Where(x => x.isOn == true && x.isSelected == true).ToArray();
        }
        else if (item is Beer)
        {
            array = _items.OfType<Beer>().Where(x => x.isOn == true && x.isSelected == true).ToArray();
        }


        if (array?.Length >= 3)
        {
            foreach (var x in array)
            {
                x.InvisibleOff();
                _items.Remove(x);
            }
        }

        if (_items1.Count == 0)
        {
            _uI.WinGame();
        }

        if (_items.Count >= 7)
        {
            _uI.LoseGame();
        }
    }
}