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
        
        //here we can use mutliple sets of data at once, inputs, expected outputs
        [Theory]
        [InlineData(50, 150)]
        [InlineData(100, 200)]
        [InlineData(900, 1000)]
        public void CanDepositMulti(decimal input, decimal expectedOutput)
        {
            Assert.Equal(expectedOutput , Program.Deposit(input)); 
        }

        [Fact]
        public void CanWithdraw()
        {
            //test that the output is 120 if we deposit 20
            Assert.Equal(80, Program.Withdraw(20));

        }

        //here we can use mutliple sets of data at once, inputs, expected outputs
        [Theory]
        [InlineData(50, 50)]
        [InlineData(100, 0)]
        [InlineData(99, 1)]
        public void CanWithdrawMulti(decimal input, decimal expectedOutput)
        {
            Assert.Equal(expectedOutput, Program.Withdraw(input));
        }

       
    }

}
