# 学生LT in 品川用のプロジェクト
XamarinとWPFのプロジェクトを実際に比較したソースコードを書きました。
プログラムは以下の構成で配置されています

 - TestApp/WPF/TestApp.WPFにWPFのみで書いたMVVMプログラム
 - TestApp/Xamarin/TestAppにXamarin.Formsで書いたMVVMプログラム
 - TestApp/Shared/SharedLibraryにModelとViewModel

WPFとXamarin.FormsプロジェクトのMainPage.xamlを試しに比較すれば、コードが非常に似ていることがわかると思います。

また、SharedLibraryは.Net Standardプロジェクトです。
そのためModelとViewModelは同じコードを使いまわすだけでWPFとXamarin.Formsで同じ事が出来ていると確認できると思います

## 細かい話
実は今回のようにViewModelを共有することは実用ではほとんどないかもしれません。ですが、やる気次第で基本的なプロパティからCommandのバインドも可能であることも確認できると思います。

## Q & A
Q.Androidプロジェクトがビルドできない

A.プロジェクトがAnyCPUだった場合、x86に変えてみてください。それでも解決しない場合はリビルドとか、bin&objフォルダを削除してプロジェクトを開きなおしてください。それでも無理だったら...私にはわからないので検索してください

Q.XamarinではListViewのDataTemplateがなんでViewCellを使っているの？

A.詳しい理由はわかりませんが、とりあえずダイレクトにLabelを配置すると実行時にエラーを起こします。内部でViewCellへ型変換しているようです