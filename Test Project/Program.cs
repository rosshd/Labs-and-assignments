using System;

interface IA {
  void do_stuff1();
}

abstract class B {
  public abstract void do_stuff2();
  public int do_stuff3() {
    return 2;
  }
}

class C : B,IA {
  public void do_stuff1() {
    int a=1;
  }
  public override void do_stuff2() {
    int b=1;
  }
}

class MainClass {
  public static void Main (string[] args) {
    C myC=new C();
    Console.WriteLine(myC.do_stuff3());
  }
}