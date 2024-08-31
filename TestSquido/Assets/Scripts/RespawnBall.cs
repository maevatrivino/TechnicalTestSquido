using UnityEngine;
using Object = UnityEngine.Object;

public class RespawnBall : MonoBehaviour
{
    [SerializeField] 
    private GameObject ballPrefab;
    [SerializeField] 
    private Transform respawnPoint;

    private GameObject _instantiatedBall;

    private void Start()
    {
        InstantiateBall();
    }

    private void OnTriggerEnter(Collider other)
    {
        Object.Destroy(_instantiatedBall);
        InstantiateBall();
    }

    private void InstantiateBall()
    {
        this._instantiatedBall = Object.Instantiate(ballPrefab, respawnPoint);
    }
}
