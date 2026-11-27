using UnityEngine;
using System.Collections;
public class Dice3 : MonoBehaviour
{
    [SerializedField] int side = 20;

    [SerializeField] int sides = 20;
    [SerializeField] float rollTime = 1.5f;
    [SerializeField] float changeColorEvery = 0.08f;

    [SerializeField] private Color GoldNumber;
    [SerializeField] private Color highNumber;
    [SerializeField] private Color midNumber;
    [SerializeField] private Color lowNumber;

    MeshRenderer _renderer;

    private bool isRolling = false;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isRolling)
            {
                StartCoroutine(RollDice());
            }
        }
    }

    private IEnumerator RollDice()
    {
        isRolling = true;
        float elapsedTime = 0f;

        while (elapsedTime < rollTime)
        {
            _renderer.material.color = Random.ColorHSV(0, 1f, 0.8f, 1f, 08f, 1f); // change random color
            yield return new WaitForSeconds(changeColorEvery); // wait time
            elapsedTime = elapsedTime + changeColorEvery;
        }
        int result = Random.Range(1, sides + 1);
        Debug.Log(result);

        if (result <= 5) _renderer.material.color = lowNumber;

        else if (result <= 10) _renderer.material.color = midNumber;

        else if (result < 20) _renderer.material.color = highNumber;

        else _renderer.material.color = GoldNumber;

        isRolling = false;
    }
}

