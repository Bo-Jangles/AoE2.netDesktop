---
layout: home
# multilingual page pair id, this must pair with translations of this page. (This name must be unique)
lng_pair: id_home

# image for page specific usage
img: ":home-heading.jpg"
# publish date (used for seo)
# if not specified, site.time will be used.
#date: 2022-03-03 12:32:00 +0000

# for override items in _data/lang/[language].yml
#title: My title
#button_name: "My button"
# for override side_and_top_nav_buttons in _data/conf/main.yml
#icon: "fa fa-bath"

# seo
# if not specified, date will be used.
#meta_modify_date: 2022-03-03 12:32:00 +0000
# check the meta_common_description in _data/lang/[language].yml
#meta_description: ""

# optional
# if you enabled image_viewer_posts you don't need to enable this. This is only if image_viewer_posts = false
image_viewer_on: true
# if you enabled image_lazy_loader_posts you don't need to enable this. This is only if image_lazy_loader_posts = false
image_lazy_loader_on: true
# exclude from on site search
#on_site_search_exclude: true
# exclude from search engines
#search_engine_exclude: true
# to disable this page, simply set published: false or delete this file
# don't forget that this is root index.html. If you disable this, there will be no index.html page to open
#published: false
---

AoE2.net Desktopは Age of Empires II: Definitive Edition のプレイ履歴を表示するアプリケーションです。

# インストール

Githubのリリースページの最新バージョンをダウンロードしてください。  
<https://github.com/teshiba/AoE2.netDesktop/releases/latest/>

ソフトウェアは.Net6.0ランタイムを使用していますので、正しく動作しない場合は以下のランタイムをインストールしてください。  
<https://dotnet.microsoft.com/download/dotnet/6.0>

# 利用方法

1: アプリケーションを起動すると以下の画面になります  
2: SteamIDまたはProfileIDを登録して<span class="button"> Set ID </span>ボタンを押してください  

![InitalSetting](:InitalSetting.png "InitalSetting")

3: 正しいIDが設定されるとAoE2.net <span style="color: green">**Online**</span>と表示が変わります。

_※[AoE2.net](https://aoe2.net/ "AoE2.net")のサーバーが稼働しているときのみ利用できます。_

![online](:online.png "online")

# メイン画面

IDが正しく設定されるとメイン画面には現在対戦中または最後の対戦の結果が表示されます。  
1対1戦とチーム戦で表示画面が異なりそれぞれ以下のように表示されます。  

設定したIDのプレイヤー名が、オレンジ色で表示されています。

## チーム戦

![Team](:TeamMatch.png "Team")

## 1対1戦

![1v1](:1v1match.png "1v1")

画面では以下の操作ができます。
記載以外のウィンドウ操作はOSの仕様に準じます。

## マウス操作

| 操作方法       | 領域                   | 操作内容                               |
| -------------- | ---------------------- | -------------------------------------- |
| 右クリック     | ウィンドウ内           | コンテキストメニューを表示             |
| ダブルクリック | プレイヤー名           | クリックしたプレイヤーの履歴画面を表示 |
| ドラッグ       | テキスト・画像表示領域 | ウィンドウ移動                         |

## キーボード操作

| 操作方法               | 操作内容                                           |
| ---------------------- | -------------------------------------------------- |
| Alt+F4                 | アプリケーションを終了                             |
| F5                     | メイン画面の対戦情報を更新                         |
| Alt+カーソルキー       | カーソル方向にウィンドウを10ピクセル単位で拡大縮小 |
| Alt+Shift+カーソルキー | カーソル方向にウィンドウを1ピクセル単位で拡大縮小  |

## コンテキストメニュー

右クリックでコンテキストメニューが表示されます。

![ContextMenu](:TeamMatch-contextMenu.png "ContextMenu")

| 項目            | 操作内容                                 |
| --------------- | ---------------------------------------- |
| Settings        | 設定画面を表示します。                   |
| Show my history | 設定したユーザーの履歴画面を表示します。 |
| Update          | 対戦情報を更新します。                   |
| Exit            | アプリケーションを終了します。           |

# 履歴画面

## Matchesタブ

 設定したIDのプレイヤーの戦歴を表示します。
リストからLeaderboeadを選択すると、左の表が選択した対戦種類の戦歴に切り替わります。

| 項目         | 内容                                                           |
| ------------ | -------------------------------------------------------------- |
| Map          | 使用されたマップ                                               |
| Rate         | 対戦時点のレートとレートの変化値                               |
| Win          | 勝敗の状態を表示します<br>勝ったゲームに "〇" が付与されます。 |
| Civilization | 使用した文明                                                   |
| Color        | プレイヤー色に対応する番号                                     |
| Date         | 対戦した日時                                                   |
| Version      | AoE2DEのソフトウェアバージョン                                 |

右のグラフは勝敗を表示します。
Data sourceを選択すると、グラフを文明毎の勝敗とマップ毎の勝敗に切り替えます。

- 使用文明数

![MatchesTab-CivsData](:MatchesTab-CivsData.png "MatchesTab-CivsData")

- マップ数

![MatchesTab-MapData](:MatchesTab-MapData.png "MatchesTab-MapData")

## Playersタブ

過去の敵および味方チームのプレイヤーの情報を表示します。
左の表はプレイヤーの一覧を表示し、プレイヤーの情報を表示します。

| 項目       | 内容                                                                               |
| ---------- | ---------------------------------------------------------------------------------- |
| Name       | プレイヤー名                                                                       |
| Country    | 国名                                                                               |
| 1v1 Rate   | 1対1で対戦した時のレート<br>1対1戦を行っていない場合は表示されません。             |
| Team Rate  | チーム戦で対戦した時のチームレート<br>チーム戦を行っていない場合は表示されません。 |
| Team Games | プレイヤーとゲームをした数                                                         |
| Ally       | 味方プレイヤーとして参加したゲーム数                                               |
| Enemy      | 敵プレイヤーとして参加したゲーム数                                                 |
| 1v1        | 1対1で対戦したゲーム数                                                             |
| Last Date  | プレイヤーと最後に対戦した日付                                                     |

![PlayerTab](:PlayerTab.png "PlayerTab")

Findテキストボックスに文字を入力すると、プレイヤー名をインクリメンタルサーチで検索ができます。  
大文字と小文字を無視する場合は、Ignore caseにチェックを入れてください。  

![PlayerTabFilter](:PlayerTabFilter.png "PlayerTabFilter")

右のグラフは過去に対戦相手およびチームになったプレイヤーを国毎に集計した人数を示します。  
リストの列見出しを右クリックすると国の一覧のリストが表示され、チェックした国のプレイヤーのみが表示されます。

![CountryFilter](:CountryFilter.png "CountryFilter")

## Statisticsタブ

対戦形式ごとに統計とレート履歴のグラフを表示します。

| 項目           | 内容                                                             |
| -------------- | ---------------------------------------------------------------- |
| Leaderboard    | チェックボックスにチェックがある対戦形式がグラフに表示されます。 |
| Rank           | 順位                                                             |
| Rate           | レート                                                           |
| Highest Rating | 今までの最高レート                                               |
| Game           | ゲーム数                                                         |
| Win%           | 勝率                                                             |
| Wins           | 勝ち数                                                           |
| Losses         | 負け数                                                           |
| Drop           | 放棄した試合数                                                   |
| Streak         | 連勝数                                                           |
| HighestStreak  | 今までの最高連勝数                                               |
| LowestStreak   | 最高連敗数                                                       |

![History](:History.png "History")

# 設定画面

ウィンドウとユーザーの設定を行います。

![Settings](:settings.png "Settings")

## 表示設定

| 項目                   | 内容                                       |
| ---------------------- | ------------------------------------------ |
| Always on top          | メイン画面を常に手前に表示します。         |
| Hide title             | メイン画面のタイトルバーを非表示にします。 |
| Transparency window    | メイン画面の背景を透過します。             |
| Opacity                | メイン画面の表示内容の透明度を設定します。 |
| Chroma key             | メイン画面の背景色を設定します。           |
| Draw high quality      | テキスト描画品質を設定します。             |
| Auto reload last match | 現在の対戦情報を定期的に更新します。       |

## プレイヤー設定

| 項目       | 内容                                                            |
| ---------- | --------------------------------------------------------------- |
| Steam-ID   | SteamアカウントのIDを利用してユーザー設定する場合選択します。   |
| profile-ID | AoE2netアカウントのIDを利用してユーザー設定する場合選択します。 |
| Name       | 設定したIDのプレイヤー名を表示します。                          |
| Country    | 設定したIDの国名を表示します。                                  |
