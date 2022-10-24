using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private bool playerInfo = false;
    private int _score;
    private TextMeshProUGUI _tmp;

    // Start is called before the first frame update
    void Start()
    {
        _tmp = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _score = playerInfo ? GameManager.playerScore : GameManager.oponentScore;

        _tmp.text = _score.ToString();
    }
}