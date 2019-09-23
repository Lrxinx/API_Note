using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingControl : MonoBehaviour {

    public static LoadingControl _instance;

    public  Text numText;//展示进度的数字；
    public Image loadFilled;//改变颜色的那一个圈；   
    public GameObject loadingText;//Loading 字样的文字；
    public float loadingSpeed;//加载速度；
    public float loadingPograss;//当前的加载进度；  


    // Use this for initialization
    void Start () {
        _instance = this;
	}
	
	// Update is called once per frame
	void Update () {

        numText.text = ((int)loadingPograss).ToString() + "%";

        if (loadingPograss < 100)
        {
            loadingPograss += loadingSpeed * Time.deltaTime;//可以通过乘以 Time.deltaTime 来降低速度；
        }
        else
        {
            numText.text = "Finsh";
            loadingText.SetActive(false);
        }

       

        loadFilled.fillAmount = loadingPograss / 100; //主要就是通过 Image 的 fillAmount 的组件实现加载动画的效果；
                                                      //注意：fillAmount 的值域 0—1；
        
    }
}
