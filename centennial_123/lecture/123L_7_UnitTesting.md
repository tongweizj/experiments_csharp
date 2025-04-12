
```c#
[TestMethod]

public void Test_Withdraw_WithoutException() //methods does not take any

{                                            //parameter and does not return a value

  //arrange

  double beginingBalance = 10.99;

  double withdrawAmount = 5.25;

  double expected = beginingBalance - withdrawAmount;

  Account account = new Account("Narendra", beginingBalance);

  //act

  account.Withdraw(withdrawAmount);

  //assert

  double actual = account.Balance;

  Assert.AreEqual(expected, actual, 0.0001, "Failure message");

}
```

```c#
[TestMethod]

public void Withdraw_WhenAmountIsMoreThanLimit_ShouldThrowArgumentOutOfRange()

{

  //arrange

  double beginingBalance = 500.00;

  double withdrawAmount = 300;

  Account account = new Account("Narendra", beginingBalance);

  try

  {

    //act

    account.Withdraw(withdrawAmount);

  }

  catch (ArgumentOutOfRangeException e)

  {

    //assert

    StringAssert.Contains(e.Message, Account.WithdrawAmountMoreThanLimitMessage);

  }

}
```