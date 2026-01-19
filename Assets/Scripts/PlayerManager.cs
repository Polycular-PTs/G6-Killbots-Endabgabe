using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject[] playerPrefabs;
    private GameObject currentPlayer;

    void Start()
    {
        SpawnPlayer(3); 
    }

    public void SpawnPlayer(int index)
    {
        Vector3 position = currentPlayer != null ? currentPlayer.transform.position : Vector3.zero;
        Quaternion rotation = currentPlayer != null ? currentPlayer.transform.rotation : Quaternion.identity;

        if (currentPlayer != null)
            Destroy(currentPlayer);

        currentPlayer = Instantiate(playerPrefabs[index], position, rotation);
    }
}
