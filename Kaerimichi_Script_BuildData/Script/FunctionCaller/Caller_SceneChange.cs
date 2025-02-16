using Cysharp.Threading.Tasks;
using UnityEngine;

public class Caller_SceneChange : MonoBehaviour
{
    [SerializeField] private SceneChanger.Scenes goalScene;

/***************************************************************************
外部呼出し専用関数
***************************************************************************/

    public void Call_sceneChange()
    {
        UniTask.Void(async () =>
        {
            Fader.instance.FadeOut();
            await UniTask.Delay((int)(Fader.instance.GetDuration_fadeOut() * 1000));
            SceneChanger.SceneLoad(goalScene);
        });
    }
}