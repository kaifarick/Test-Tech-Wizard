using System.Collections;
using System.Collections.Generic;
using FishNet.Managing;
using UnityEngine;

public class ClientInitializing : MonoBehaviour
{
    [SerializeField] private NetworkManager _networkManager;
    void Awake()
    {
        StartClient();
    }
    
    private void StartClient()
    {
        _networkManager.ClientManager.StartConnection();
    }
    
}
