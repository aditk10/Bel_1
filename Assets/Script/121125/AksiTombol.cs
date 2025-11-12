using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AksiTombol : MonoBehaviour
{
    //Sprite adalah asset gambar yang ingin dimasukkan ke object image
    public Sprite assetGambar;
    //Image adalah component dari object image yang ada di dalam scene
    public Image image;

    public TMP_Text objectText;
    public void Aksi()
    {
        // image.sprite = assetGambar;
        // objectText.text = "Welcome to My World";
        // Debug.Log("Tombol di KLIK");

        SceneManager.LoadScene("121125-1");
    }
}
