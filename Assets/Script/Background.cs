﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 更改背景的 脚本
/// </summary>
[RequireComponent(typeof(Renderer))]
public class Background : MonoBehaviour
{

    /// <summary>
    /// Renderer 对象
    /// </summary>
    Renderer rend;

    /// <summary>
    /// 初始化
    /// </summary>
    void Awake()
    {

        // 获取 Renderer 对象
        rend = GetComponent<Renderer>();

        // 加载 默认背景
        rend.material.mainTexture = Resources.Load<Texture>("Image/bg1");
    }


    /// <summary>
    /// 更改背景
    /// </summary>
    /// <param name="name">背景文件名</param>
    public void ChangeBackground(string name)
    {
        // 加载新的 背景
        rend.material.mainTexture = Resources.Load<Texture>("Image/" + name);
    }
}
