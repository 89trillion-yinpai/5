# 奖杯之路技术文档
## 整体框架：
- 1:显示当前分数，当前赛季，当前金币
- 2:加分按钮，更新赛季按钮，查看段位和奖励的按钮
- 3:单独制作一个奖励和段位界面
- 4：脚本实现所有功能需求
## 目录结构
Assets
├─ Resourses
│    ├─ Rank   # 存放资源
├─ Resourses.meta
├─ Scenes     # 场景
│    ├─ SampleScene.unity
│    └─ SampleScene.unity.meta
├─ Scenes.meta
├─ Scripts      # 脚本  
│    ├─ Controller   # 控制层
│    │    ├─ JiaFenController.cs
│    │    └─ JiaFenController.cs.meta
│    └─ Controller.meta
├─ Script.meta
├─ award.unity
└─ award.unity.meta 

## 代码
| 需要的脚本       |     实现的功能 |
| ------ | ------                |
|  控制加分脚本| 点击加分按钮每次加100    |
|  新赛季重置脚本    |   赛季更新，可领取奖励更新，分数和段位更新 |

![奖杯之路](https://user-images.githubusercontent.com/92706401/140459901-cbcc2284-9a90-42fa-a96f-5786a72d4107.png)
