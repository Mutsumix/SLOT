
# SLOT - slot machine for SMC Year-end party

2020年のシスマック忘年会で使用したスロットマシーンです

## 開発環境
Visual Studio 2019

## 使い方
リポジトリをクローンすれば、すぐに開始できます。
https://user-images.githubusercontent.com/46163569/120410855-c4d50800-c38e-11eb-88ab-3bb19f11d409.mp4

### BGM
デフォルトでは確変に突入するとバニラのBGMが流れます。  
https://user-images.githubusercontent.com/46163569/120410826-ba1a7300-c38e-11eb-82ea-0f197e1b1b58.mp4

変更したい場合は
SMC-SLOT\Resources 内に曲のファイルを追加し、さらにビルドした後  
SMC-SLOT\bin\Release\Resources 内に同じファイルを追加します。  
Main.cs の slot_Click メソッド内でファイルを直に指定しているので、そこを変更するのも忘れずに

### 景品画像
SMC-SLOT\PrizeImages が景品画像置き場で、14個まで登録できます。  
変更したい場合は、以下の形式で保存してください。  
[ XX(数字)_景品名.png ]
