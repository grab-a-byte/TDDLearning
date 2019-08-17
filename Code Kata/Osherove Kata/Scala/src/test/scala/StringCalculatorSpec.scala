import org.scalatest.{FlatSpec, MustMatchers}

class StringCalculatorSpec extends FlatSpec with MustMatchers{
  "A StringCalculator" must "Return Zero on a Empty String" in {
    val stringCalculator = new StringCalculator()
    stringCalculator.Add("") must be(0)
  }

  "A StringCalculator" must "Return 1 on a input 1" in {
    val stringCalculator = new StringCalculator()
    stringCalculator.Add("1") must be(1)
  }
  "A StringCalculator" must "Return 3 on a comma seperated input 1,32" in {
    val stringCalculator = new StringCalculator()
    stringCalculator.Add("1,2") must be(3)
  }

  "A StringCalculator" must "Return 7 on a comma seperated input 3,4" in {
    val stringCalculator = new StringCalculator()
    stringCalculator.Add("3,4") must be(7)
  }

  "A StringCalculator" must "Return 45 on a comma seperated input 1,2,3,4,5,6,7,8,9" in {
    val stringCalculator = new StringCalculator()
    stringCalculator.Add("1,2,3,4,5,6,7,8,9") must be(1+2+3+4+5+6+7+8+9)
  }

  "A StringCalculator" must "Return 45 on a newline seperated input 1\\n2\\n3\\n4\\n5\\n6\\n7\\n8\\n9" in {
    val stringCalculator = new StringCalculator()
    stringCalculator.Add("1\n2\n3\n4\n5\n6\n7\n8\n9") must be(1+2+3+4+5+6+7+8+9)
  }

}
