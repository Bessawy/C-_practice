public delegate bool Mypredicate<T>(T values);
public delegate TResult Myfunct<T, TResult>(T values);
public delegate TResult Myfunct<T1, T2, TResult>(T1 val1, T2 val2);
