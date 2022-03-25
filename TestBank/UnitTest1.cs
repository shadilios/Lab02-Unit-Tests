using System;
using Xunit;
using Test;


namespace TestBank
{
    public class UnitTest1
    {

        //This fact is called annotation, it's comparing single data
        [Fact]
        public void CanDeposit()
        {
            //test that the output is 120 if we deposit 20
            Assert.Equal(120, Program.Deposit(20));

        }

        [Fact]
        public void CanWithdraw()
        {
            //test that the output is 120 if we deposit 20
            Assert.Equal(80, Program.Withdraw(20));

        }

        
       
    }

}
