using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Mirror;

public class myHUD : NetworkBehaviour
{
    [SerializeField] private TextMeshProUGUI tmpro;
    [SerializeField] private List<string> clientNames;

    
    // Start is called before the first frame update
    void Start()
    {
        tmpro = gameObject.GetComponentInChildren<TextMeshProUGUI>();

        
        clientNames = new List<string>();
        tmpro.text = "Connected Clients:";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Server]
    void OnClientsUpdated(string clientname, bool connected)
    {
        clientNames.Add(clientname);
        tmpro.text = tmpro.text += " " + clientname;
    }
}
