using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] string itemName;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Item Collected: {itemName}");
        Destroy(this.gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
