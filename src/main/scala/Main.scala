package org.mash.app

import scala.language.implicitConversions
import org.scalacheck.Prop.forAll
import org.scalacheck.util.Pretty
import org.scalacheck.{Arbitrary, Shrink}


trait Monoid[A] {
  def union(a: A, b: A): A

  def zero: A
}

object Monoid {
  def laws[A: Arbitrary: Shrink](implicit ms: Monoid[A], p: A => Pretty) = {
    List(
      forAll { (a: A, b: A, c: A) => ms.union(ms.union(a, b), c) == ms.union(a, ms.union(b, c)) },
      forAll { (a: A) => (ms.union(a, ms.zero) == ms.union(ms.zero, a))&&(ms.union(ms.zero, a) == a) }
    )
  }

  implicit def stringMonoid = new Monoid[String] {
    override def zero: String = ""
    override def union(x: String, y: String): String = x concat y
  }
}

object Main {
  def main(args: Array[String]): Unit = {
    //Monoid.laws[String].foreach(_.check())
    val me = Monoid.stringMonoid
    forAll { (a: String, b: String, c: String) => me.union(me.union(a, b), c) == me.union(a, me.union(b, c)) }.check()
    forAll { (a: String) => (me.union(a, me.zero) == me.union(me.zero, a)) && (me.union(me.zero, a) == a) }.check()
  }
}
