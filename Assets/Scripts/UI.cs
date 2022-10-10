using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [Header("UI Elements:")]
    [SerializeField] public GameObject _level1Panel;
    [SerializeField] public GameObject _level2Panel;
    [SerializeField] public GameObject _gameLosePanel;
    [SerializeField] public GameObject _gameWinPanel;
    [SerializeField] public GameObject _finallyWinPanel;
    
    private GameObject _currentPanel;
    private GameObject _currentGame;

    private void Awake()
    {
        _currentPanel = Instantiate(_level1Panel);
        _currentPanel.SetActive(true);
        _currentGame = _level1Panel;
        _gameLosePanel.SetActive(false);
        _gameWinPanel.SetActive(false);
    }

    public void WinGame()
    {
        Destroy(_currentPanel);
        _level2Panel.SetActive(false);
        _gameLosePanel.SetActive(false);
        _gameWinPanel.SetActive(true);

        if (_currentGame == _level2Panel)
        {
            _finallyWinPanel.SetActive(true);
            _currentPanel.SetActive(false);
            _gameWinPanel.SetActive(false);
        }
    }

    public void NextGame()
    {
        _currentPanel = Instantiate(_level2Panel);
        _currentPanel.SetActive(true);
        _currentGame = _level2Panel;
        _gameLosePanel.SetActive(false);
        _gameWinPanel.SetActive(false);
    }

    public void RetryGame()
    {
        _gameLosePanel.SetActive(false);
        _gameWinPanel.SetActive(false);

        if (_currentGame == _level1Panel)
        {
            Destroy(_currentPanel);
            _currentPanel = Instantiate(_level1Panel);
            _currentPanel.SetActive(true);
            _level1Panel.SetActive(false);
        }
        else if (_currentGame == _level2Panel)
        {
            Destroy(_currentPanel);
            _currentPanel = Instantiate(_level2Panel);
            _currentPanel.SetActive(true);
            _level2Panel.SetActive(false);
        }
    }

    public void LoseGame()
    {
        _currentPanel.SetActive(false);
        _level2Panel.SetActive(false);
        _gameLosePanel.SetActive(true);
        _gameWinPanel.SetActive(false);
    }
}
