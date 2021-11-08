using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Assets.Function1._03.Scripts.Model
{
    public class Read : MonoBehaviour
    {
        //声明8个奖励按钮
        protected Button Receive;
        protected Button Receive1;
        protected Button Receive2;
        protected Button Receive3;
        protected Button Receive4;
        protected Button Receive5;
        protected Button Receive6;
        protected Button Receive7;

        //声明已领取文本
        protected Text Receive0;
        protected Text Receive11;
        protected Text Receive22;
        protected Text Receive33;
        protected Text Receive44;
        protected Text Receive55;
        protected Text Receive66;
        protected Text Receive77;

        //声明领取
        protected Text Receive00;
        protected Text Receive111;
        protected Text Receive222;
        protected Text Receive333;
        protected Text Receive444;
        protected Text Receive555;
        protected Text Receive666;
        protected Text Receive777;


        //声明不同段位图片，"FormerlySerializedAs"用于防止变量名更改后丢失引用
        [FormerlySerializedAs("Rank")] protected Image Rank;

        [FormerlySerializedAs("primary")] protected Sprite primary;

        [FormerlySerializedAs("master")] protected Sprite master;

        [FormerlySerializedAs("King")] protected Sprite King;

        //声明分数面板
        protected Text score;
        protected Text rankScore;

        //声明赛季面板
        protected Text saiJi;
        protected int I;
        protected int J;
        protected int Z;
        protected Text Sum;
    }
}