using UnityEngine;

public class BotSpawner : MonoBehaviour
{
    public static BotSpawner Instance;
    public GameObject botPrefab;
    public Transform player;
    public float minSpawnDistanceMultiplier = 1f; 
    public float maxSpawnDistanceMultiplier = 1.5f; 
    public float spawnAreaWidth = 3f;
    public float spawnYPosition = -1.64f;

    private float nextSpawnX;
    private float screenWidth;
    private Camera mainCamera;
    private bool spawnPositionReached = false;

    void Start()
    {
        mainCamera = Camera.main;
        screenWidth = CalculateScreenWidth();
        CalculateNextSpawnPosition();
    }

    void Update()
    {
        screenWidth = CalculateScreenWidth();

        
        if (!spawnPositionReached && player.position.x >= nextSpawnX)
        {
            spawnPositionReached = true;
            SpawnNewBot();
        }

        if (spawnPositionReached)
        {
            CalculateNextSpawnPosition();
            spawnPositionReached = false;
        }
    }

    float CalculateScreenWidth()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
            if (mainCamera == null) return 10f; 
        }

        
        float screenHeight = 2f * mainCamera.orthographicSize;
        return screenHeight * mainCamera.aspect;
    }

    void CalculateNextSpawnPosition()
    {
        float randomMultiplier = Random.Range(minSpawnDistanceMultiplier, maxSpawnDistanceMultiplier);
        float spawnDistance = randomMultiplier * screenWidth;
        nextSpawnX = player.position.x + spawnDistance;
        Debug.Log($"Neue Spawn-Position berechnet: {nextSpawnX}");
    }

    public void SpawnNewBot()
    {
        
        float randomX = nextSpawnX + Random.Range(-spawnAreaWidth / 2f, spawnAreaWidth / 2f);
        Vector3 spawnPos = new Vector3(randomX, spawnYPosition, 0);

        var gameObject = Instantiate(botPrefab, spawnPos, Quaternion.identity);
        gameObject.SetActive(true);
        Debug.Log("Neuer Bot gespawnt");
    }

    void OnDrawGizmosSelected()
    {
        if (player != null && mainCamera != null)
        {
            
            Gizmos.color = Color.green;
            Gizmos.DrawLine(
                new Vector3(nextSpawnX, player.position.y - 3, 0),
                new Vector3(nextSpawnX, player.position.y + 3, 0)
            );

           
            Gizmos.color = new Color(1, 0, 0, 0.3f);
            Gizmos.DrawCube(
                new Vector3(nextSpawnX, player.position.y, 0),
                new Vector3(spawnAreaWidth, 1, 1)
            );

            
            Gizmos.color = Color.blue;
            Gizmos.DrawWireCube(
                new Vector3(player.position.x + screenWidth / 2, player.position.y, 0),
                new Vector3(screenWidth, 2, 0)
            );
        }
    }
}