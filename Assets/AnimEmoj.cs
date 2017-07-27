using System.Collections;
using TMPro;
using UnityEngine;

public class AnimEmoj : MonoBehaviour
{
    private TextMeshProUGUI txt;

    void Start()
    {
        txt = this.GetComponent<TextMeshProUGUI>();
        this.StartCoroutine(IE_Anim());
    }

    private IEnumerator IE_Anim()
    {
        int[] arr = new int[] { 0, 1, 2, 3, 4 };
        int idx = 0;
        while (true)
        {
            txt.text = string.Format("hello<sprite={0}><size=200%><sprite=2></size>world", arr[idx]);
            idx = (idx + 1) % arr.Length;
            yield return new WaitForSeconds(0.5f);
        }
    }

    void Update()
    {
    }
}