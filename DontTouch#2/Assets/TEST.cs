using UnityEngine;
using UnityEngine.UI;
using YG;

public class TEST : MonoBehaviour
{
    [SerializeField] private Text _text;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _text.text = YandexGame.savesData.Count.ToString();
            YandexGame.savesData.Count++;
            YandexGame.SaveProgress();
        }
    }
}
