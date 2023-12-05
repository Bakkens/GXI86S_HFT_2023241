﻿using GXI86S_HFT_2023241.Logic;
using GXI86S_HFT_2023241.Logic.InterfaceLogic;
using GXI86S_HFT_2023241.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GXI86S_HFT_2023241.Endpoint.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NonCrud : ControllerBase
    {
        ICustomerLogic logic;
        public NonCrud(ICustomerLogic logic)
        {
            this.logic = logic;
        }

        // GET: api/<NonCrud>
        [HttpGet("{year}")]
        public IEnumerable<Customer> GetCustomersWithBirthdayInYear(int year)
        {
            return this.logic.GetCustomersWithBirthdayInYear(year);
        }
        [HttpGet]
        public IEnumerable<CustomerLogic.CustomerTransactionInfo> GetCustomerTransactionInfo()
        {
            return this.logic.GetCustomerTransactionInfo();
        }
        [HttpGet]
        public IEnumerable<CustomerLogic.CustomerAccountInfo> GetCustomersWithAccountsAndTransactions()
        {
            return this.logic.GetCustomersWithAccountsAndTransactions();
        }
        [HttpGet]
        public IEnumerable<CustomerLogic.CustomerTransactionDetails> GetCustomerTransactionDetails()
        {
            return this.logic.GetCustomerTransactionDetails();
        }
        [HttpGet]
        public IEnumerable<CustomerLogic.CustomerTotalSpending> GetTotalSpendingLast30Days()
        {
            return this.logic.GetTotalSpendingLast30Days();
        }
        [HttpGet]
        public IEnumerable<CustomerLogic.CustomerIncome> GetLastIncomePerCustomer()
        {
            return this.logic.GetLastIncomePerCustomer();
        }
    }
}
