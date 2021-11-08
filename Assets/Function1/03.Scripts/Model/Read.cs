using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Assets.Function1._03.Scripts.Model
{
    public class Read : MonoBehaviour
    {
        //声明8个奖励按钮
        public Button receive;
        public Button receive1;
        public Button receive2;
        public Button receive3;
        public Button receive4;
        public Button receive5;
        public Button receive6;

        public Button receive7;

        //声明已领取文本
        public Text receive0;
        public Text receive11;
        public Text receive22;
        public Text receive33;
        public Text receive44;
        public Text receive55;
        public Text receive66;

        public Text receive77;

        //声明领取
        public Text receive00;
        public Text receive111;
        public Text receive222;
        public Text receive333;
        public Text receive444;
        public Text receive555;
        public Text receive666;
        public Text receive777;


        //声明不同段位图片
        [FormerlySerializedAs("Rank")] public Image Rank;
        [FormerlySerializedAs("primary")] public Sprite primary;
        [FormerlySerializedAs("master")] public Sprite master;
        [FormerlySerializedAs("King")] public Sprite King;

        //声明分数面板
        public Text score;

        public Text rankScore;

        //声明赛季面板
        public Text saiJi;
        protected int I;
        protected int J;
        protected int Z;
        public Text Sum;
    }
}