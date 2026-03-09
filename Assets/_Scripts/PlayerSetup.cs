using UnityEngine;
using Photon.Pun;
public class PlayerSetup : MonoBehaviourPun
{
    [SerializeField] private GameObject fpCamera;
    [SerializeField] private Movement movementScript;
    void Start()
    {
        fpCamera.SetActive(photonView.IsMine);
        movementScript.enabled = photonView.IsMine;
    }
}
