# ASFEnhance

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/3d174e792fd4412bb6b34a77d67e5dea)](https://www.codacy.com/gh/chr233/ASFEnhance/dashboard)
![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/chr233/ASFEnhance/autobuild.yml?logo=github)
[![License](https://img.shields.io/github/license/chr233/ASFEnhance?logo=apache)](https://github.com/chr233/ASFEnhance/blob/master/license)
![GitHub last commit](https://img.shields.io/github/last-commit/chr233/ASFEnhance?logo=github)

[![GitHub Release](https://img.shields.io/github/v/release/chr233/ASFEnhance?logo=github)](https://github.com/chr233/ASFEnhance/releases)
[![GitHub Release](https://img.shields.io/github/v/release/chr233/ASFEnhance?include_prereleases&label=pre-release&logo=github)](https://github.com/chr233/ASFEnhance/releases)
[![GitHub Download](https://img.shields.io/github/downloads/chr233/ASFEnhance/total?logo=github)](https://img.shields.io/github/v/release/chr233/ASFEnhance)

![GitHub Repo stars](https://img.shields.io/github/stars/chr233/ASFEnhance?logo=github)
[![Gitee Stars](https://gitee.com/chr_a1/ASFEnhance/badge/star.svg?theme=dark)](https://gitee.com/chr_a1/ASFEnhance/stargazers)

[![爱发电](https://img.shields.io/badge/爱发电-chr__-ea4aaa.svg?logo=github-sponsors)](https://afdian.net/@chr233)
[![Bilibili](https://img.shields.io/badge/bilibili-Chr__-00A2D8.svg?logo=bilibili)](https://space.bilibili.com/5805394)
[![Steam](https://img.shields.io/badge/steam-Chr__-1B2838.svg?logo=steam)](https://steamcommunity.com/id/Chr_)

[![Steam](https://img.shields.io/badge/steam-donate-1B2838.svg?logo=steam)](https://steamcommunity.com/tradeoffer/new/?partner=221260487&token=xgqMgL-i)

[English Version](README.en.md) | [Русская Версия](README.ru.md)

ASFEnhance 介绍 & 使用指南: [https://keylol.com/t804841-1-1](https://keylol.com/t804841-1-1)

## EULA

> 请不要使用本插件来进行不受欢迎的行为, 包括但不限于: 刷好评, 发布广告 等.
>
> 详见 [插件配置说明](#插件配置说明)

## 限时活动 EVENT

| 命令                    | 权限       | 说明                                                     |
| ----------------------- | ---------- | -------------------------------------------------------- |
| `SIM4 [Bots]`           | `Operator` | 获取 `The Sims™ 4` 贴纸                                  |
| `DL2 [Bots]`            | `Operator` | 获取 `Dying Light 2 Stay Human` 个人资料装饰品           |

## 下载链接

> 下载解压后将 "ASFEnhance.dll" 丢进 ASF 目录下的 "plugins" 文件夹即可安装

[GitHub Releases](https://github.com/chr233/ASFEnhance/releases)

## 适配说明

- 更新命令

  - `ASFEVERSION` / `AV` 检查插件更新
  - `ASFEUPDATE` / `AU` 自动更新插件到最新版本 (需要手动重启 ASF)

- .NET 版本改动说明

  > ASF 5.4.0.3 迁移到了 .NET 7.0, ASFEnhance 1.7.0.0 及以后的版本也将迁移至 .NET 7.0
  > 旧版插件可以兼容新版 ASF, 但是新版插件**不再**兼容旧版 ASF

- 版本下载

| ASFEnhance 版本                                                      | 适配 ASF 版本 | 更新说明                             |
| -------------------------------------------------------------------- | ------------- | ------------------------------------ |
| [1.7.6.0](https://github.com/chr233/ASFEnhance/releases/tag/1.7.6.0) | 5.4.0.3       | 新增 `GAMEAVATAR` `ADVNICKNAME` 命令 |
| [1.7.5.0](https://github.com/chr233/ASFEnhance/releases/tag/1.7.5.0) | 5.4.0.3       | 新增 `Steam Replay` 相关命令         |
| [1.7.4.0](https://github.com/chr233/ASFEnhance/releases/tag/1.7.4.0) | 5.4.0.3       | 新增领取冬促贴纸相关命令             |
| [1.7.3.0](https://github.com/chr233/ASFEnhance/releases/tag/1.7.3.0) | 5.4.0.3       | 新增冬促投票相关命令                 |

<details>
  <summary>历史版本</summary>

| ASFEnhance 版本                                                            | 依赖 ASF 版本 | 5.2.6.3 | 5.2.7.7 | 5.2.8.4 | 5.3.0.3 | 5.3.1.2 | 5.3.2.4 | 5.4.0.3 |
| -------------------------------------------------------------------------- | ------------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- |
| [1.7.2.1](https://github.com/chr233/ASFEnhance/releases/tag/1.7.2.1)       | 5.4.0.3       | ❌      | ❌      | ❌      | ❌      | ❌      | ❌      | ✔️      |
| [1.7.1.0](https://github.com/chr233/ASFEnhance/releases/tag/1.7.1.0)       | 5.4.0.3       | ❌      | ❌      | ❌      | ❌      | ❌      | ❌      | ✔️      |
| [1.7.0.1](https://github.com/chr233/ASFEnhance/releases/tag/1.7.0.1)       | 5.4.0.3       | ❌      | ❌      | ❌      | ❌      | ❌      | ❌      | ✔️      |
| [1.6.23.0](https://github.com/chr233/ASFEnhance/releases/tag/1.6.23.0)     | 5.3.2.4       | ❌      | ❌      | ❌      | ❌      | ❌      | ✔️      | ✔️      |
| [1.6.22.1](https://github.com/chr233/ASFEnhance/releases/tag/1.6.22.1)     | 5.3.2.4       | ❌      | ❌      | ❌      | ❌      | ❌      | ✔️      | ✔️      |
| [1.6.21.6](https://github.com/chr233/ASFEnhance/releases/tag/1.6.21.6)     | 5.3.2.4       | ❌      | ❌      | ❌      | ❌      | ❌      | ✔️      | ✔️      |
| [1.6.20.1](https://github.com/chr233/ASFEnhance/releases/tag/1.6.20.1)     | 5.3.2.4       | ❌      | ❌      | ❌      | ❌      | ❌      | ✔️      | ✔️      |
| [1.6.19.4](https://github.com/chr233/ASFEnhance/releases/tag/1.6.19.4)     | 5.3.2.4       | ❌      | ❌      | ❌      | ❌      | ❌      | ✔️      | ✔️      |
| [1.6.18.1](https://github.com/chr233/ASFEnhance/releases/tag/1.6.18.1)     | 5.3.2.4       | ❌      | ❌      | ❌      | ❌      | ❌      | ✔️      | ✔️      |
| [1.6.18.0](https://github.com/chr233/ASFEnhance/releases/tag/1.6.18.0)     | 5.3.1.2       | ❌      | ❌      | ❌      | ✔️      | ✔️      |         |         |
| [1.6.16.0](https://github.com/chr233/ASFEnhance/releases/tag/1.6.16.0)     | 5.3.1.2       | ❌      | ❌      | ❌      | ✔️      | ✔️      |         |         |
| [1.6.15.0](https://github.com/chr233/ASFEnhance/releases/tag/1.6.15.0)     | 5.3.1.2       | ❌      | ❌      | ❌      | ✔️      | ✔️      |         |         |
| [1.6.14.0](https://github.com/chr233/ASFEnhance/releases/tag/1.6.14.0)     | 5.3.1.2       | ❌      | ❌      | ❌      | ✔️      | ✔️      |         |         |
| [1.6.12.717](https://github.com/chr233/ASFEnhance/releases/tag/1.6.12.717) | 5.3.1.2       | ❌      | ❌      | ❌      | ✔️      | ✔️      |         |         |
| [1.6.11.670](https://github.com/chr233/ASFEnhance/releases/tag/1.6.11.670) | 5.3.1.2       | ❌      | ❌      | ❌      | ✔️      | ✔️      |         |         |
| [1.6.10.666](https://github.com/chr233/ASFEnhance/releases/tag/1.6.10.666) | 5.3.0.3       | ❌      | ❌      | ❌      | ✔️      | ✔️\*    |         |         |
| [1.6.9.663](https://github.com/chr233/ASFEnhance/releases/tag/1.6.9.663)   | 5.2.8.4       | ❌      | ❌      | ✔️      | ❌      |         |         |         |
| [1.6.8.661](https://github.com/chr233/ASFEnhance/releases/tag/1.6.8.661)   | 5.2.7.7       | ❌      | ✔️      |         |         |         |         |         |

</details>

## 插件配置说明

ASF.json

```json
{
  //ASF 配置
  "CurrentCulture": "...",
  "IPCPassword": "...",
  "...": "...",
  //ASFEnhance 配置
  "ASFEnhance": {
    "EULA": true,
    "Statistic": true,
    "DevFeature": false
  }
}
```

| 配置项       | 类型 | 默认值  | 说明                                                               |
| ------------ | ---- | ------- | ------------------------------------------------------------------ |
| `EULA`       | bool | `true`  | 是否同意 [EULA](#EULA)\*                                           |
| `Statistic`  | bool | `true`  | 是否允许发送统计数据, 仅用于统计插件用户数量, 不会发送任何其他信息 |
| `DevFeature` | bool | `false` | 是否启用开发者特性 (一共 3 条命令) `具有一定安全风险, 请谨慎开启`  |

> \* 同意 EULA 后, ASFEnhance 将会开放全部命令, 作为交换, ASFEnhance 会在执行 `GROUPLIST` 和 `CURATORLIST` 时自动关注作者的[鉴赏家](https://steamcommunity.com/groups/11012580/curation)和[组](https://steamcommunity.com/groups/11012580) (如果尚未关注的话)
>
> \* 禁用 EULA 后, ASFEnhance 将会限制使用 鉴赏家/群组/评测 等功能, 同时 ASFEnhance 也不会主动关注[鉴赏家](https://steamcommunity.com/groups/11012580/curation)和[组](https://steamcommunity.com/groups/11012580)

## 插件指令说明

### 插件更新

| 命令          | 缩写   | 权限            | 说明                                              |
| ------------- | ------ | --------------- | ------------------------------------------------- |
| `ASFENHANCE`  | `ASFE` | `FamilySharing` | 查看 ASFEnhance 的版本                            |
| `ASFEVERSION` | `AV`   | `Operator`      | 检查 ASFEnhance 是否为最新版本                    |
| `ASFEUPDATE`  | `AU`   | `Owner`         | 自动更新 ASFEnhance 到最新版本 (需要手动重启 ASF) |

### 账号相关

| 命令                               | 缩写  | 权限       | 说明                              |
| ---------------------------------- | ----- | ---------- | --------------------------------- |
| `PURCHASEHISTORY [Bots]`           | `PH`  | `Operator` | 读取商店消费历史记录              |
| `FREELICENSES [Bots]`              | `FL`  | `Operator` | 读取账户中的免费 Sub License 列表 |
| `FREELICENSE [Bots]`               |       |            | 同 `FREELICENSES`                 |
| `LICENSES [Bots]`                  | `L`   | `Operator` | 读取账户中的所有 License 列表     |
| `LICENSE [Bots]`                   |       |            | 同 `LICENSES`                     |
| `REMOVEDEMOS [Bots]`               | `RD`  | `Master`   | 移除账户中所有的 Demo License     |
| `REMOVEDEMO [Bots]`                |       |            | 同 `REMOVEDEMOS`                  |
| `REMOVELICENSES [Bots] <SubIDs>`   | `RL`  | `Master`   | 移除账户中指定的 Sub License      |
| `REMOVELICENSE [Bots] <SubIDs>`    |       |            | 同 `REMOVELICENSES`               |
| `EMAILIOPTIONS [Bots]`             | `EO`  | `Operator` | 读取账户中的电子邮件偏好选项      |
| `EMAILIOPTION [Bots]`              |       |            | 同 `EMAILOPTIONS`                 |
| `SETEMAILOPTIONS [Bots] <Options>` | `SEO` | `Master`   | 设置账户中的电子邮件偏好选项      |
| `SETEMAILOPTION [Bots] <Options>`  |       |            | 同 `SETEMAILOPTIONS`              |

- `SETEMAILOPTIONS` 参数说明

  `<Options>` 参数接受最多 9 个参数, 使用空格或者 `,` 分隔, 顺序参照 [此页面](https://store.steampowered.com/account/emailoptout)
  如果参数为 `on`, `yes`, `true`, `1`, `y` 则视为开启, 否则视为禁用(默认)

| 索引 | 名称                                               | 说明                     |
| ---- | -------------------------------------------------- | ------------------------ |
| 1    | 是否启用电子邮件通知                               | 禁用后其余选项均不起作用 |
| 2    | 愿望单物品打折时发送邮件通知                       |                          |
| 3    | 愿望单物品发行或脱离抢先体验时发送邮件通知         |                          |
| 4    | 关注的青睐之光物品发行或脱离抢先体验时发送邮件通知 |                          |
| 5    | 关注的发行商发行或者脱离抢险体验时发送邮件通知     |                          |
| 6    | 当季节促销开始时发送邮件通知                       |                          |
| 7    | 收到鉴赏家评测副本时发送邮件通知                   |                          |
| 8    | 收到社区奖励时发送邮件通知                         |                          |
| 9    | 收到游戏活动通知时发送邮件通知                     |                          |

### 其他功能

| 命令             | 缩写    | 权限            | 说明             |
| ---------------- | ------- | --------------- | ---------------- |
| `KEY <Text>`     | `K`     | `FamilySharing` | 从文本提取 key   |
| `ASFEHELP`       | `EHELP` | `FamilySharing` | 查看全部指令说明 |
| `HELP <Command>` | -       | `FamilySharing` | 查看指令说明     |

### 群组相关

| 命令                           | 缩写 | 权限            | 说明                 |
| ------------------------------ | ---- | --------------- | -------------------- |
| `GROUPLIST [Bots]`             | `GL` | `FamilySharing` | 查看机器人的群组列表 |
| `JOINGROUP [Bots] <GroupName>` | `JG` | `Master`        | 加入指定群组         |
| `LEAVEGROUP [Bots] <GroupID>`  | `LG` | `Master`        | 离开指定群组         |

> `GroupID`可以用命令`GROUPLIST`获取

### 个人资料相关

| 命令                                   | 缩写  | 权限            | 说明                                                                                |
| -------------------------------------- | ----- | --------------- | ----------------------------------------------------------------------------------- |
| `PROFILE [Bots]`                       | `PF`  | `FamilySharing` | 查看个人资料                                                                        |
| `PROFILELINK [Bots]`                   | `PFL` | `FamilySharing` | 查看个人资料链接                                                                    |
| `STEAMID [Bots]`                       | `SID` | `FamilySharing` | 查看 steamID                                                                        |
| `FRIENDCODE [Bots]`                    | `FC`  | `FamilySharing` | 查看好友代码                                                                        |
| `TRADELINK [Bots]`                     | `TL`  | `Operator`      | 查看交易链接                                                                        |
| `REPLAY [Bots]`                        | `RP`  | `Operator`      | 获取摘要图片链接 (可以解锁徽章)                                                     |
| `REPLAYPRIVACY [Bots] Privacy`         | `RPP` | `Operator`      | 设置年度总结可见性, `Privacy` 1=私密 2=好友可见 3=公开                              |
| `CLEARALIAS [Bots]`                    |       | `Opetator`      | 清除曾用名                                                                          |
| `GAMEAVATAR [Bots] <AppID> [AvatarID]` | `GA`  | `Opetator`      | 根据指定 `AppID` 和 `AvatarID` 设置机器人的头像, 省略 `AvatarId` 时将随机选择头像   |
| `RANDOMGAMEAVATAR [Bots]`              | `RGA` | `Opetator`      | 设置机器人的头像为随机游戏头像                                                      |
| `ADVNICKNAME [Bots] Query`             | `ANN` | `Master`        | 使用 `占位符` 设置机器人昵称, 可用占位符 `%dn%` `%ln%` `%un%` `%botn%` 不区分大小写 |

- GAMEAVATAR 使用说明

头像来自 [Game Avatars Page](https://steamcommunity.com/actions/GameAvatars/)

---

- ADVNICKNAME Query 参数说明

> 数字可以任意指定

| 占位符   | 说明                  | 示例结果                   |
| -------- | --------------------- | -------------------------- |
| `%d%`    | 随机数字              | `5`                        |
| `%dn%`   | n 位随机数字          | `%d6%` -> `114514`         |
| `%l%`    | 随机小写字母          | `x`                        |
| `%ln%`   | n 位小写字母          | `%d7%` -> `asfeadf`        |
| `%u%`    | 随机大写字母          | `C`                        |
| `%un%`   | n 位随机大写字母      | `%d8%` -> `ASXCGDFA`       |
| `%bot%`  | 机器人昵称            | `ASFE`                     |
| `%bot3%` | 机器人昵称, 重复 3 次 | `%bot3%` -> `ASFEASFEASFE` |

### 鉴赏家相关

| 命令                             | 缩写   | 权限     | 说明                   |
| -------------------------------- | ------ | -------- | ---------------------- |
| `CURATORLIST [Bots]`             | `CL`   | `Master` | 查看已关注的鉴赏家列表 |
| `FOLLOWCURATOR [Bots] <ClanIDs>` | `FCU`  | `Master` | 关注指定鉴赏家         |
| `UNFOLLOWCURATOR [Bots]`         | `UFCU` | `Master` | 取消关注指定鉴赏家     |

### 愿望单相关

| 命令                             | 缩写  | 权限     | 说明                    |
| -------------------------------- | ----- | -------- | ----------------------- |
| `ADDWISHLIST [Bots] <AppIDs>`    | `AW`  | `Master` | 添加愿望单              |
| `REMOVEWISHLIST [Bots] <AppIDs>` | `RW`  | `Master` | 移除愿望单              |
| `FOLLOWGAME [Bots] <AppIDs>`     | `FG`  | `Master` | 关注游戏                |
| `UNFOLLOWGAME [Bots] <AppIDs>`   | `UFG` | `Master` | 取消关注游戏            |
| `CHECK [Bots] <AppIDs>`          | `CK`  | `Master` | 检查游戏关注/愿望单情况 |

### 商店相关

| 命令                                       | 缩写   | 权限       | 说明                                             |
| ------------------------------------------ | ------ | ---------- | ------------------------------------------------ |
| `APPDETAIL [Bots] <AppIDs>`                | `AD`   | `Operator` | 获取 APP 信息, 无法获取锁区游戏信息, 仅支持`APP` |
| `SEARCH [Bots] Keywords`                   | `SS`   | `Operator` | 搜索商店                                         |
| `SUBS [Bots] <AppIDs\|SubIDs\|BundleIDs>`  | `S`    | `Operator` | 查询商店 SUB, 支持 `APP/SUB/BUNDLE`              |
| `PUBLISHRECOMMENT [Bots] <AppIDs> COMMENT` | `PREC` | `Master`   | 发布评测, APPID > 0 给好评, AppID < 0 给差评     |
| `DELETERECOMMENT [Bots] <AppIDs>`          | `DREC` | `Master`   | 删除评测                                         |
| `REQUESTACCESS [Bots] <AppIDs>`            | `RA`   | `Operator` | 请求游戏内测访问权限, 等效于点击 `请求访问权限`  |
| `VIEWPAGE [Bots] Url`                      | `VP`   | `Operator` | 访问指定页面                                     |

### 购物车相关

> STEAM 的购物车储存在 Cookies 里,重启 ASF 将会导致购物车清空

| 命令                                 | 缩写  | 权限       | 说明                                                                      |
| ------------------------------------ | ----- | ---------- | ------------------------------------------------------------------------- |
| `CART [Bots]`                        | `C`   | `Operator` | 查看机器人购物车                                                          |
| `ADDCART [Bots] <SubIDs\|BundleIDs>` | `AC`  | `Operator` | 添加购物车, 仅能使用`SubID`和`BundleID`                                   |
| `CARTRESET [Bots]`                   | `CR`  | `Operator` | 清空购物车                                                                |
| `CARTCOUNTRY [Bots]`                 | `CC`  | `Operator` | 获取购物车可用结算区域(跟账号钱包和当前 IP 所在地有关)                    |
| `SETCOUNTRY [Bots] <CountryCode>`    | `SC`  | `Master`   | 购物车改区,可以用`CARTCOUNTRY`命令获取当前可选的`CountryCode`(仍然有 Bug) |
| `PURCHASE [Bots]`                    | `PC`  | `Owner`    | 结算机器人的购物车, 只能为机器人自己购买 (使用 Steam 钱包余额结算)        |
| `PURCHASEGIFT [BotA] BotB`           | `PCG` | `Owner`    | 结算机器人 A 的购物车, 发送礼物给机器人 B (使用 Steam 钱包余额结算)       |

> Steam 允许重复购买,使用 `PURCHASE` 命令前请自行确认有无重复内容

### 社区相关

| 命令                           | 缩写  | 权限       | 说明                     |
| ------------------------------ | ----- | ---------- | ------------------------ |
| `CLEARNOTIFICATION [Bots]`     | `CN`  | `Operator` | 清除新物品和新留言通知   |
| `ADDBOTFRIEND [BotAs] <BotBs>` | `ABF` | `Master`   | 让`BotA`添加`BotB`为好友 |

### 探索队列

| 命令              | 缩写 | 权限     | 说明                        |
| ----------------- | ---- | -------- | --------------------------- |
| `EXPLORER [Bots]` | `EX` | `Master` | 5 秒后触发 ASF 探索队列任务 |

> 请尽量让 ASF 自己来探索队列, 本命令仅作为强制触发探索队列的一种补充方式

### ASF 命令缩写

| 命令缩写               | 等价命令                       | 说明                       |
| ---------------------- | ------------------------------ | -------------------------- |
| `AL [Bots] <Licenses>` | `ADDLICENSE [Bots] <Licenses>` | 添加免费 SUB               |
| `LA`                   | `LEVEL ASF`                    | 获取所有机器人的等级       |
| `BA`                   | `BALANCE ASF`                  | 获取所有机器人的钱包余额   |
| `PA`                   | `POINTS ASF`                   | 获取所有机器人的点数余额   |
| `P [Bots]`             | `POINTS`                       | 获取机器人的点数余额       |
| `CA`                   | `CART ASF`                     | 获取所有机器人的购物车信息 |

### 面向开发者

> 本组命令默认是禁用的.
> 需要在 `ASF.json` 中配置 `"DevFeature": true` 才能启用本组命令

| 命令                 | 权限    | 说明                      |
| -------------------- | ------- | ------------------------- |
| `COOKIES [Bots]`     | `Owner` | 查看 Steam 商店的 Cookies |
| `APIKEY [Bots]`      | `Owner` | 查看 Bot 的 APIKey        |
| `ACCESSTOKEN [Bots]` | `Owner` | 查看 Bot 的 ACCESSTOKEN   |

## IPC 接口

> 使用该功能前需要同意 EULA, 详见 [插件配置说明](#插件配置说明)

| API                                            | 方法 | 参数                                               | 说明                     |
| ---------------------------------------------- | ---- | -------------------------------------------------- | ------------------------ |
| `/Api/ASFEnhance/{botNames}/FollowCurator`     | POST | ClanIDs                                            | 关注鉴赏家               |
| `/Api/ASFEnhance/{botNames}/UnFollowCurator`   | POST | ClanIDs                                            | 取消关注鉴赏家           |
| `/Api/ASFEnhance/{botNames}/FollowingCurators` | POST | Start, Count                                       | 获取已关注的鉴赏家列表   |
| `/Api/ASFEnhance/{botNames}/GetAppDetail`      | POST | AppIDs                                             | 获取游戏详情             |
| `/Api/ASFEnhance/{botNames}/Purchase`          | POST | SubIDs, BundleIDs, SkipOwned                       | 批量购买游戏             |
| `/Api/ASFEnhance/{botNames}/PublishReview`     | POST | AppIDs, RateUp, AllowReply, ForFree,Public,Comment | 发布游戏评测             |
| `/Api/ASFEnhance/{botNames}/DeleteReview`      | POST | AppIDs                                             | 删除游戏评测             |
| `/Api/ASFEnhance/{botNames}/AddWishlist`       | POST | AppIDs                                             | 添加愿望单               |
| `/Api/ASFEnhance/{botNames}/RemoveWishlist`    | POST | AppIDs                                             | 移除愿望单               |
| `/Api/ASFEnhance/{botNames}/FollowGame`        | POST | AppIDs                                             | 关注游戏                 |
| `/Api/ASFEnhance/{botNames}/UnFollowGame`      | POST | AppIDs                                             | 取消关注游戏             |
| `/Api/ASFEnhance/{botNames}/CheckGame`         | POST | AppIDs                                             | 检查游戏关注和愿望单情况 |

---

[![Repobeats analytics image](https://repobeats.axiom.co/api/embed/df6309642cc2a447195c816473e7e54e8ae849f9.svg "Repobeats analytics image")](https://github.com/chr233/ASFEnhance/pulse)

---

[![Stargazers over time](https://starchart.cc/chr233/ASFEnhance.svg)](https://github.com/chr233/ASFEnhance/stargazers)

---
