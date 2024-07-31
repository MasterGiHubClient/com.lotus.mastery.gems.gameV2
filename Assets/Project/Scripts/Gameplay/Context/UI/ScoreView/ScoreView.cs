using TMPro;
using UnityEngine;
using Zenject;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private TextMeshProUGUI _winScore;

    [Inject] private readonly WinView _winView;
    [Inject] private readonly PlayerScore _playerScore;


    private void Awake()
    {
        _playerScore.ScoreUpdated += Handle;
        Handle(0);
    }

    private void Handle(int score)
    {
        _score.text = $"{score}";
        _winScore.text = $"Score:\n{score}";
    }

    private void OnDestroy() => _playerScore.ScoreUpdated -= Handle;
}