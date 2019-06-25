using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillItem : MonoBehaviour
{
    // 技能冷却时间
    public float cold_time = 2;
    // 设置按键
    public KeyCode keyCode;
    // 计时器
    private float timer = 0;
    // 获取控件的方法
    private Image filled_image;
    // 是否进入冷却时间判定
    private bool is_start_time = false;
    // Start is called before the first frame update
    void Start()
    {
        filled_image = transform.Find("FilledImg").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

        is_start_time |= Input.GetKeyDown(keyCode);

        if (is_start_time)
        {
            timer += Time.deltaTime;
            filled_image.fillAmount = (cold_time - timer) / cold_time;

            if (timer >= cold_time)
            {
                filled_image.fillAmount = 0;
                timer = 0;
                is_start_time = false;
            }
        }
    }

    public void OnClick()
    {
        is_start_time = true;
    }
}
