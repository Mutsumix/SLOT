# SLOT - slot machine for SMC Year-end party

２０２０年のシスマック忘年会で使用したスロットマシーンです

## 開発環境
Visual Studio 2019

## 使い方
リポジトリをクローンすれば、すぐに開始できます。

### BGM
デフォルトでは確変に突入するとバニラのBGMが流れます。  
変更したい場合は
SMC-SLOT\Resources 内に曲のファイルを追加し、さらにビルドした後  
SMC-SLOT\bin\Release\Resources 内に同じファイルを追加します。  
Main.cs の slot_Click メソッド内でファイルを直で指定しているので、そこを変更するのも忘れずに

### 景品画像
SMC-SLOT\PrizeImages が景品画像置き場で、１４個まで登録できます。  
変更したい場合は、  
[ XX(数字)_商品名.png ]
形式で保存してください。