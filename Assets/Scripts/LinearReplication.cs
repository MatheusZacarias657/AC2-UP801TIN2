using UnityEngine;

public class AsphaltEdge : MonoBehaviour
{
    public GameObject itemPrefab; 
    public int qtdItems = 40;
    public float space = 2.015f;

    void Start()
    {
        Vector3 inicialPos = transform.position;

        for (int i = 0; i < qtdItems; i++)
        {
            Vector3 pos = inicialPos + new Vector3(i * space, 0f, 0f);
            GameObject brick = Instantiate(itemPrefab, pos, Quaternion.identity);
            brick.transform.parent = transform;
        }
    }

    void Update()
    {
        
    }
}
