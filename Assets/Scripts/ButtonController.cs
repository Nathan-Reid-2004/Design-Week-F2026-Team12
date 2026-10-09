using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private string TempScene = "TempScene";
    public void InventoryButton()
    {
        SceneManager.LoadScene(TempScene);
    }
}
