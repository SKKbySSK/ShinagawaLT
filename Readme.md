# 学生LT in 品川用のプロジェクト
XamarinとWPFのプロジェクトを実際に比較したソースコードを書きました。
プログラムは以下の構成で配置されています

 - TestApp/WPF/TestApp.WPFにWPFのみで書いたMVVMプログラム
 - TestApp/Xamarin/TestAppにXamarin.Formsで書いたMVVMプログラム
 - TestApp/Shared/SharedLibraryにModelとViewModel

試しに見ていただければ、コードが非常に似ていることがわかると思います。

また、SharedLibraryは.Net Standardプロジェクトです。
そのためModelとViewModelは同じコードを使いまわすだけでWPFとXamarin.Formsで同じ事が出来ていると確認できると思います