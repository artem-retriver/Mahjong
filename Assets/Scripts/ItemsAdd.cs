using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemsAdd : MonoBehaviour
{
    private GameManager _gameManager;
    public bool isOn;
    public bool isSelected;

    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if(isOn == true)
        {
            var r = GetComponent<SpriteRenderer>();
            r.color = new Color(255, 255, 255);
        }
    }

    public virtual void OnMouseDown()
    {
        if (_gameManager._items.Count < 7 && isOn == true)
        {
            isSelected = true;

            _gameManager.AddItem(this);

            for (int i = 0; i < _gameManager._items.Count; i++)
            {
                _gameManager._items[i].transform.position = _gameManager._vector2s[i];
            }
        }
    }

    public void InvisibleOff()
    {
        gameObject.SetActive(false);
    }
}