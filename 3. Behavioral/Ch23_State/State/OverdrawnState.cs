﻿using System;

namespace State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Overdrawn indicates that account is overdrawn 
    /// </remarks>
    /// </summary>
    public class OverdrawnState : State
    {
        private double _serviceFee;

        // Constructor
        public OverdrawnState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
            _serviceFee = 15.00;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Withdraw(double amount)
        {
            amount = amount - _serviceFee;
            Console.WriteLine("No funds available for withdrawal!");

            // Disable withdrawn functionality
        }

        public override void PayInterest()
        {
            // No interest is paid
        }

        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new StandardState(this);
            }
        }
    }
}
