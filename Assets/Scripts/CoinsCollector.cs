using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCollector : MonoBehaviour
{
    public static int Coin = 0;

    public Text amountThis;

    // Start is called before the first frame update
    private void Awake()
    {

    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        amountThis.text = Coin.ToString();
    }
}
