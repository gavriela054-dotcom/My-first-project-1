using System.Collections;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

// Die change color based on result.
// Low number = red / high = green / 20 = gold

public class Zari1 : MonoBehaviour
{
    [SerializeField] private int sides = 20;

    [SerializeField] private Color GoldNumber;
    [SerializeField] private Color highNumber;
    [SerializeField] private Color midNumber;
    [SerializeField] private Color lowNumber;

    MeshRenderer _renderer;
    private readonly float waitTime;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(MyFunction());
            int result = GetRoll();
            ApplyColor(result);
        }
    }

    private int GetRoll()
    {
        int result = Random.Range(1, sides + 1);
        Debug.Log("Dice roll: " + result);
        return result;
    }

    private void ApplyColor(int result)
    {
        if (result <= 5) _renderer.material.color = lowNumber;

        else if (result <= 10) _renderer.material.color = midNumber;

        else if (result < 20) _renderer.material.color = highNumber;

        else _renderer.material.color = GoldNumber;
    }

    private IEnumerator MyFunction()
    {
        Debug.Log("First text");
        yield return new WaitForSeconds(1);
        Debug.Log("Second text");
        yield return new WaitForSeconds(3);
        Debug.Log("Third text");
    }
}