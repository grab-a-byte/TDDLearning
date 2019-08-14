namespace Tests

module Tests =

    open Xunit
    open StringCalculator

    [<Fact>]
    let Add_EmptyString_ReturnsZero () =
        let stringCalculator = new StringCalculator()
        let x = stringCalculator.Add("")
        Assert.Equal(0, x)

    [<Theory>]
    [<InlineData("1", 1)>]
    [<InlineData("2", 2)>]
    let Add_SingleNumber_ReturnsSum (input, expected) =
        let stringCalculator = new StringCalculator()
        let result = stringCalculator.Add(input)
        Assert.Equal(expected, result);

    [<Theory>]
    [<InlineData("1,2", 3)>]
    [<InlineData("3,4", 7)>]
    let Add_MultipleNumbers_ReturnsSum (input, expected) =
        let stringCalculator = new StringCalculator()
        let result = stringCalculator.Add(input)
        Assert.Equal(expected, result);

    [<Theory>]
    [<InlineData("1,2,3,4,5", 15)>]
    [<InlineData("3,4,9", 16)>]
    let Add_UnknownAmountNumbers_ReturnsSum (input, expected) =
        let stringCalculator = new StringCalculator()
        let result = stringCalculator.Add(input)
        Assert.Equal(expected, result);


    [<Theory>]
    [<InlineData("1\n2", 3)>]
    [<InlineData("3\n4", 7)>]
    let Add_NewlineSeperatedNumbers_ReturnsSum (input, expected) =
        let stringCalculator = new StringCalculator()
        let result = stringCalculator.Add(input)
        Assert.Equal(expected, result);