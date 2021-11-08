using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Assets.Function1._03.Scripts.Model
{
    public class Read : MonoBehaviour
    {
        //声明8个奖励按钮
        [SerializeField] protected Button Receive;
        [SerializeField] protected Button Receive1;
        [SerializeField] protected Button Receive2;
        [SerializeField] protected Button Receive3;
        [SerializeField] protected Button Receive4;
        [SerializeField] protected Button Receive5;
        [SerializeField] protected Button Receive6;
        [SerializeField] protected Button Receive7;

        //声明已领取文本
        [SerializeField] protected Text Receive0;
        [SerializeField] protected Text Receive11;
        [SerializeField] protected Text Receive22;
        [SerializeField] protected Text Receive33;
        [SerializeField] protected Text Receive44;
        [SerializeField] protected Text Receive55;
        [SerializeField] protected Text Receive66;
        [SerializeField] protected Text Receive77;

        //声明领取
        [SerializeField] protected Text Receive00;
        [SerializeField] protected Text Receive111;
        [SerializeField] protected Text Receive222;
        [SerializeField] protected Text Receive333;
        [SerializeField] protected Text Receive444;
        [SerializeField] protected Text Receive555;
        [SerializeField] protected Text Receive666;
        [SerializeField] protected Text Receive777;


        //声明不同段位图片
        [FormerlySerializedAs("Rank")] [SerializeField]
        protected Image Rank;

        [FormerlySerializedAs("primary")] [SerializeField]
        protected Sprite primary;

        [FormerlySerializedAs("master")] [SerializeField]
        protected Sprite master;

        [FormerlySerializedAs("King")] [SerializeField]
        protected Sprite King;

        //声明分数面板
        [SerializeField] protected Text score;
        [SerializeField] protected Text rankScore;

        //声明赛季面板
        [SerializeField] protected Text saiJi;
        protected int I;
        protected int J;
        protected int Z;
        [SerializeField] protected Text Sum;
    }
}