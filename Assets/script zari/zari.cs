using UnityEngine;

public class zari : MonoBehaviour
{

    [SerializeField] private int sides = 20;

    [SerializeField] private Color GoldNumber;
    [SerializeField] private Color highNumber;
    [SerializeField] private Color midhNumber;
    [SerializeField] private Color lowhNumber;

    MeshRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        int result = Random.Range(1, sides + 1);
        Debug.Log("zari roll: " + result);
    }

}
