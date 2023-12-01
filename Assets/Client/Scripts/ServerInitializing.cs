using System.Collections;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Managing;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ServerInitializing : MonoBehaviour
{
    [SerializeField] private NetworkManager _networkManager;
    void Awake()
    {
        StartServer();
    }
    
    private void StartServer()
    {
        _networkManager.ServerManager.StartConnection();
    }
    
}
