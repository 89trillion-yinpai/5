using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Assets.Function1._03.Scripts.Model
{
    public class Read : MonoBehaviour
    {
        //声明8个奖励按钮
        [SerializeField] protected Button receive;
        [SerializeField] protected Button receive1;
        [SerializeField] protected Button receive2;
        [SerializeField] protected Button receive3;
        [SerializeField] protected Button receive4;
        [SerializeField] protected Button receive5;
        [SerializeField] protected Button receive6;
        [SerializeField] protected Button receive7;

        //声明已领取文本
        [SerializeField] protected Text receive0;
        [SerializeField] protected Text receive11;
        [SerializeField] protected Text receive22;
        [SerializeField] protected Text receive33;
        [SerializeField] protected Text receive44;
        [SerializeField] protected Text receive55;
        [SerializeField] protected Text receive66;
        [SerializeField] protected Text receive77;

        //声明领取
        [SerializeField] protected Text receive00;
        [SerializeField] protected Text receive111;
        [SerializeField] protected Text receive222;
        [SerializeField] protected Text receive333;
        [SerializeField] protected Text receive444;
        [SerializeField] protected Text receive555;
        [SerializeField] protected Text receive666;
        [SerializeField] protected Text receive777;


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