using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class RoomManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private string roomCode = "Map1";
    [SerializeField] private GameObject player;
    [SerializeField] private Transform spawnPoint;

    [Space]
    [SerializeField] private GameObject roomCamera;
    void Start()
    {
        Debug.Log("Connecting...");
        PhotonNetwork.ConnectUsingSettings();
    }

    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Joining lobby...");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joining or creating room");
        PhotonNetwork.JoinOrCreateRoom(roomCode, roomOptions:null, typedLobby:null);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined room. Spawning Player");

        PhotonNetwork.Instantiate(player.name, spawnPoint.position, spawnPoint.rotation);
        roomCamera.SetActive(false);
    }
}
