﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MyPlayerNameInput : MonoBehaviour
{

    [Header("UI")]
    [SerializeField] private TMP_InputField nameInputField = null;
    [SerializeField] private Button continueButton = null;

    public static string DisplayName { get; private set; }

    private const string PlayerPrefsNameKey = "PlayerName";



    // Start is called before the first frame update
    void Start()
    {
        SetupInputField();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetupInputField()
    {
        if(!PlayerPrefs.HasKey(PlayerPrefsNameKey)) { return; }
        string defaultName = PlayerPrefs.GetString(PlayerPrefsNameKey);
        nameInputField.text = defaultName;

        SetPlayerName(defaultName);
    }

    public void SetPlayerName(string name)
    {
        continueButton.interactable = !string.IsNullOrEmpty(name);
    }

    public void SavePlayerNane()
    {
        DisplayName = nameInputField.text;
        PlayerPrefs.SetString(PlayerPrefsNameKey, DisplayName);
    }
}
