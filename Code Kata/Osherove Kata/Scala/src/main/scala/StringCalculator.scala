class StringCalculator {
  def Add(input : String): Int = {

    val replacedInput = input.replace("\n", ",")

    replacedInput match {
      case "" => 0
      case _ => replacedInput.split(',').map(x => x.toInt).sum
    }
  }
}
