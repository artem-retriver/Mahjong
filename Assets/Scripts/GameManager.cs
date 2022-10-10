using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour
{
    /*[Header("Game Object Cheese:")]
    [SerializeField] public CheeseOn _cheeseON;
    [SerializeField] public CheeseOn _cheeseON1;
    [SerializeField] public CheeseOn _cheeseON2;
    [SerializeField] public CheeseOn _cheeseOFF;
    [SerializeField] public CheeseOn _cheeseOFF1;
    [SerializeField] public CheeseOn _cheeseOFF2;

    [Header("Game Object Bread:")]
    [SerializeField] public BreadON _breadON;
    [SerializeField] public BreadON _breadON1;
    [SerializeField] public BreadON _breadOFF;

    [Header("Game Object Beer:")]
    [SerializeField] public BeerON _beerON;
    [SerializeField] public BeerON _beerOFF;
    [SerializeField] public BeerON _beerOFF1;

    [Header("Game Object Meat:")]
    [SerializeField] public MeatON _meatON;
    [SerializeField] public MeatON _meatON1;
    [SerializeField] public MeatON _meatOFF;*/

    public Vector2 pos1 = new Vector2(-2.74f, -2.63f);
    public Vector2 pos2 = new Vector2(-1.81f, -2.63f);
    public Vector2 pos3 = new Vector2(-0.87f, -2.63f);
    public Vector2 pos4 = new Vector2(0.03000003f, -2.63f);
    public Vector2 pos5 = new Vector2(0.9400001f, -2.63f);
    public Vector2 pos6 = new Vector2(1.85f, -2.63f);
    public Vector2 pos7 = new Vector2(2.75f, -2.63f);

    public int cheese = 0;
    public int cheeseoff = 0;
    public int bread = 0;
    public int beer = 0;
    public int meat = 0;
    public List<GameObject> _items = new List<GameObject>(7);
    public List<GameObject> _items1 = new List<GameObject>(15);
    //CheeseOn cheeseOn;
    //List<int> _items;

    private void Start()
    {
        //_items.Clear();

        //Instantiate(gameObject);

        //for (int i = 0; i < _items1.Count; i++)
        //{
        //    Instantiate(_items1[i]);
        //}
        
        
        /*Instantiate(_cheeseON);
        _cheeseON.transform.position = new Vector2(0.05999756f, 3.97998f);
        Instantiate(_cheeseON1);
        _cheeseON1.transform.position = new Vector2(-0.44f, -0.42f);
        Instantiate(_cheeseON2);
        _cheeseON2.transform.position = new Vector2(-0.9099731f, 1.78f);
        Instantiate(_cheeseOFF);
        _cheeseOFF.transform.position = new Vector2(0.16f, 2.71f);
        Instantiate(_cheeseOFF1);
        _cheeseOFF1.transform.position = new Vector2(-0.44f, 0.46f);
        Instantiate(_cheeseOFF2);
        _cheeseOFF2.transform.position = new Vector2(-0.9099731f, 2.680002f);
        Instantiate(_breadON);
        _breadON.transform.position = new Vector2(0.16f, 1.78f);
        Instantiate(_breadON1);
        _breadON1.transform.position = new Vector2(1.62f, -0.42f);
        Instantiate(_breadOFF);
        _breadOFF.transform.position = new Vector2(-1.5f, 0.46f);
        Instantiate(_beerON);
        _beerON.transform.position = new Vector2(0.55f, -0.42f);
        Instantiate(_beerOFF);
        _beerOFF.transform.position = new Vector2(1.259f, 2.69f);
        Instantiate(_beerOFF1);
        _beerOFF1.transform.position = new Vector2(1.69f, 0.46f);
        Instantiate(_meatON);
        _meatON.transform.position = new Vector2(1.252f, 1.78f);
        Instantiate(_meatON1);
        _meatON1.transform.position = new Vector2(-1.5f, -0.42f);
        Instantiate(_meatOFF);
        _meatOFF.transform.position = new Vector2(0.55f, 0.46f);

        //DestroyImmediate(_cheeseON1, true);*/
    }

    private void Update()
    {
        if(_items.Count == 7)
        {
            Debug.Log("�� ���������");
            GameOver();
        }

        /*if (cheeseoff == 3)
        {
            cheeseoff = 0;
            _items.RemoveAll(x => x.GetComponent<CheeseOFF>());

            var array = _items.OfType<CheeseOn>().Where(x => x.isOn && x.isSelected).ToArray(); 
            
            if(array.Length >= 3)
            {
                foreach (var x in array)
                {
                    x.InvisibleOff();
                }
            }
            
            gameObject.GetComponent<CheeseOn>().InvisibleOff();
        }

        if (cheese == 3)
        {
            cheese = 0;
            _items.RemoveAll(x => x.GetComponent<CheeseOn>());

            _cheeseON.InvisibleOff();
            _cheeseON1.InvisibleOff();
            _cheeseON2.InvisibleOff();
        }

        if (beer == 3)
        {
            beer = 0;
            _items.RemoveAll(x => x.GetComponent<BeerON>());

            _beerON.InvisibleOff();
            _beerOFF.InvisibleOff();
            _beerOFF1.InvisibleOff();
        }

        if (bread == 3)
        {
            bread = 0;
            _items.RemoveAll(x => x.GetComponent<BreadON>());
            
            _breadON.InvisibleOff();
            _breadOFF.InvisibleOff();
            _breadON1.InvisibleOff();
        }

        if (meat == 3)
        {
            meat = 0;
            _items.RemoveAll(x => x.GetComponent<MeatON>());
            
            _meatON.InvisibleOff();
            _meatON1.InvisibleOff();
            _meatOFF.InvisibleOff();
        }*/
    }

    public void AddCheese(GameObject gameObject)
    {
        _items1.Remove(gameObject);
        _items.Add(gameObject);

        var array = _items.OfType<ItemsAdd>().Where(x => x.isOn == true && x.isSelected == true).ToArray();
        //var array = _items.FindAll(x => x.GetComponent<ItemsAdd>());
        var ar = _items.OfType<ItemsAdd>().ToArray();
        //Debug.Log(array.Count);

        Debug.Log(ar.Length);
        Debug.Log(array.Length);

        /*if (array.Count >= 3)
        {
            foreach (var x in array)
            {
                _items.Remove(x);
                x.GetComponent<ItemsAdd>().InvisibleOff();
            }
        }*/

        if (array.Length >= 3)
        {
            foreach (var x in array)
            {
                x.InvisibleOff();
            }
        }
    }

    public void AddBread(GameObject gameObject)
    {
        _items1.Remove(gameObject);
        _items.Add(gameObject);

        /*var array = _items.OfType<BreadON>().Where(x => x.isOn && x.isSelected).ToArray();

        if (array.Length >= 3)
        {
            foreach (var x in array)
            {
                x.InvisibleOff();
            }
        }*/
    }

    public void GameOver()
    {
       
    }
}
