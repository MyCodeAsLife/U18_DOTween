using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void Start()
    {
        const string ReplacementText = "Замена";
        const string AdditionText = " Дополнение";
        const string IteratingText = "Перебор";
        const float Duration = 3f;

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(ReplacementText, Duration));
        sequence.Append(_text.DOText(AdditionText, Duration).SetRelative());
        sequence.Append(_text.DOText(IteratingText, Duration, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Restart);
    }
}
