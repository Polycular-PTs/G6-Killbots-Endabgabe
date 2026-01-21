using TMPro;
using UnityEngine;

public class PopupTextEffect : MonoBehaviour
{
    public float moveSpeed = 50f; 
    public float fadeSpeed = 1f;
    public float lifeTime = 1f;

    private TextMeshProUGUI textMeshPro;
    private RectTransform rectTransform;
    private Vector2 startPosition;
    private float startTime;

    private void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        rectTransform = GetComponent<RectTransform>();

        if (textMeshPro == null || rectTransform == null)
        {
            Debug.LogError("Benötigte Komponenten fehlen!");
            Destroy(gameObject);
            return;
        }

        startTime = Time.time;
        startPosition = rectTransform.anchoredPosition;
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        if (textMeshPro == null || rectTransform == null) return;

        float moveDistance = (Time.time - startTime) * moveSpeed;
        rectTransform.anchoredPosition = startPosition + new Vector2(0, moveDistance);

        
        float alpha = 1 - (Time.time - startTime) * fadeSpeed;
        textMeshPro.alpha = Mathf.Clamp01(alpha);

      
        transform.localScale = Vector3.one * (1 + Mathf.Sin((Time.time - startTime) * 5f) * 0.1f);
    }
}