# CapacityLimitedList
C#用のサイズ制限されたスタック上のリスト

1. 動的なヒープ確保の回避
2. スレッドセーフかつlockなし（1.の実現をするためにstaticフィールドを使うと達成が難しくなる）
3. Spanもstackallocもunsafeも使えない
4. インデックスアクセスしたい

これら全てを満たしたい場合に役に立つ場合があります。
手で書くと面倒なので自動生成してひとまとめにしてみました。

リストのサイズは1,2,4,8,16,32,64,128,256の9種類です。多すぎず適切なサイズを使いましょう

使う際には、
```C#
void UseOptimizedList<T, E>(ref T list)
  where T : IList<E>
{
  ...
}
```
などと、きちんとbox化しないこと(引数の型を`IList<E>`とした場合box化されます)と、きちんと参照を渡すことに注意しなければなりません。

box化するくらいなら普通のListを使った方がよく、参照を渡さない場合はコピーコストが増えたりAdd等の操作がコピー元に反映されなくなりますので注意してください。
