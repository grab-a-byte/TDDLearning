import org.scalatest._

import scala.collection.mutable

class ApplicationSpec extends FlatSpec with MustMatchers {
  "A Stack" must "pop values in last-in-first-out order" in {
    val stack = new mutable.Stack[Int]
    stack.push(1)
    stack.push(2)
    stack.pop() must be(2)
    stack.pop() must be(1)
  }
}
