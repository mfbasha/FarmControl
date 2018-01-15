/// @file FarmManagmentDBContext.cs
/// <published> N </published>
/// <privlevel> non-privilege </privlevel>
/// <privilege> none </privilege>
/// <privacy> N </privacy>
/// <product> TV </product>
/// <version> 3.*.* </version>
/// <SDK_Support> Y </SDK_Support>
/// Copyright (c) 2017 Samsung Electronics Co., Ltd All Rights Reserved
/// PROPRIETARY/CONFIDENTIAL
/// This software is the confidential and proprietary
/// information of SAMSUNG ELECTRONICS ("Confidential Information"). You shall
/// not disclose such Confidential Information and shall use it only in
/// accordance with the terms of the license agreement you entered into with
/// SAMSUNG ELECTRONICS. SAMSUNG make no representations or warranties about the
/// suitability of the software, either express or implied, including but not
/// limited to the implied warranties of merchantability, fitness for a
/// particular purpose, or non-infringement. SAMSUNG shall not be liable for any
/// damages suffered by licensee as a result of using, modifying or distributing
/// this software or its derivatives.

namespace FarmControl.DAL.DataBaseContext
{
    using FarmControl.Models.Accounting;
    using FarmControl.Models.Customers;
    using FarmControl.Models.HR;
    using FarmControl.Models.Logs;
    using FarmControl.Models.Products;
    using FarmControl.Models.Sales;
    using FarmControl.Models.Security;
    using FarmControl.Models.Shared;
    using FarmControl.Models.Work;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// hhhhhh
    /// </summary>
    /// <code>
    /// cccccc
    /// </code>
    public class FarmManagmentDBContext : IdentityDbContext<FarmControlUser, FarmControlRole, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FarmManagmentDBContext"/> class.
        /// </summary>
        /// <param name="options">The <see cref="DbContextOptions{FarmManagmentDBContext}"/></param>
        public FarmManagmentDBContext(DbContextOptions<FarmManagmentDBContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the AccountTypes
        /// </summary>
        public DbSet<AccountType> AccountTypes { get; set; }

        /// <summary>
        /// Gets or sets the Attendence
        /// </summary>
        public DbSet<Attendance> Attendence { get; set; }

        /// <summary>
        /// Gets or sets the Categories
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Gets or sets the CustomerContacts
        /// </summary>
        public DbSet<CustomerContact> CustomerContacts { get; set; }

        /// <summary>
        /// Gets or sets the Customers
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the CustomerShippingAddresses
        /// </summary>
        public DbSet<CustomerShippingAddress> CustomerShippingAddresses { get; set; }

        /// <summary>
        /// Gets or sets the Departments
        /// </summary>
        public DbSet<Department> Departments { get; set; }

        /// <summary>
        /// Gets or sets the EmployeeDepartmentHistory
        /// </summary>
        public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }

        /// <summary>
        /// Gets or sets the EmployeePayHistories
        /// </summary>
        public DbSet<EmployeePayHistory> EmployeePayHistories { get; set; }

        /// <summary>
        /// Gets or sets the EmployeePayHistory
        /// </summary>
        public DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }

        /// <summary>
        /// Gets or sets the Employees
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// Gets or sets the ErrorLogs
        /// </summary>
        public DbSet<ErrorLog> ErrorLogs { get; set; }

        /// <summary>
        /// Gets or sets the FinancialAccounts
        /// </summary>
        public DbSet<FinancialAccount> FinancialAccounts { get; set; }

        /// <summary>
        /// Gets or sets the FinancialTransactions
        /// </summary>
        public DbSet<FinancialTransaction> FinancialTransactions { get; set; }

        /// <summary>
        /// Gets or sets the JobTitles
        /// </summary>
        public DbSet<JobTitle> JobTitles { get; set; }

        /// <summary>
        /// Get or Set Product Cost History
        /// </summary>
        public DbSet<ProductCostHistory> ProductCostHistory { get; set; }

        /// <summary>
        /// Get or Set product price history for create DB
        /// </summary>
        public DbSet<ProductPriceHistory> ProductPriceHistory { get; set; }

        /// <summary>
        /// Gets or sets the Products
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Gets or sets the SalesOrders
        /// </summary>
        public DbSet<SalesOrder> SalesOrders { get; set; }

        /// <summary>
        /// Gets or sets the SalesOrderStatus
        /// </summary>
        public DbSet<SalesOrderStatus> SalesOrderStatus { get; set; }

        /// <summary>
        /// Gets or sets the SalesOrderStatusHistory
        /// </summary>
        public DbSet<SalesOrderStatusHistory> SalesOrderStatusHistory { get; set; }

        /// <summary>
        /// Gets or sets the SalesPaymentHistory
        /// </summary>
        public DbSet<SalesPaymentHistory> SalesPaymentHistory { get; set; }

        //TODO:In case the fields where not added for SalesPerson : Employee}
        //TODO:In case the fields where not added for SalesPerson : Employee}
        /// <summary>
        /// Gets or sets the SalesPerson
        /// </summary>
        public DbSet<SalesPerson> SalesPerson { get; set; }

        /// <summary>
        /// Gets or sets the SalesTaxRate
        /// </summary>
        public DbSet<SalesTaxRate> SalesTaxRate { get; set; }

        /// <summary>
        /// Gets or sets the SalesTerritories
        /// </summary>
        public DbSet<SalesTerritory> SalesTerritories { get; set; }

        /// <summary>
        /// Gets or sets the SpecialOffers
        /// </summary>
        public DbSet<SpecialOffer> SpecialOffers { get; set; }

        /// <summary>
        /// Gets or sets the TransactionServices
        /// </summary>
        public DbSet<Service> TransactionServices { get; set; }

        /// <summary>
        /// Gets or sets the FarmControlUsers
        /// </summary>
        public DbSet<FarmControlUser> FarmControlUsers { get; set; }

        /// <summary>
        /// Gets or sets the FarmControlRoles
        /// </summary>
        public DbSet<FarmControlRole> FarmControlRoles { get; set; }

        /// <summary>
        /// Gets or sets the UserAudits
        /// </summary>
        public DbSet<UserAudit> UserAudits { get; set; }

        /// <summary>
        /// Gets or sets the Documents
        /// </summary>
        public DbSet<Document> Documents { get; set; }

        /// <summary>
        /// Gets or sets the LocationFarms
        /// </summary>
        public DbSet<LocationFarm> LocationFarms { get; set; }

        /// <summary>
        /// Gets or sets the OperationCostItems
        /// </summary>
        public DbSet<OperationCostItem> OperationCostItems { get; set; }

        /// <summary>
        /// Gets or sets the ScrapReasons
        /// </summary>
        public DbSet<ScrapReason> ScrapReasons { get; set; }

        /// <summary>
        /// Gets or sets the WorkOrders
        /// </summary>
        public DbSet<WorkOrder> WorkOrders { get; set; }

        /// <summary>
        /// Gets or sets the WorkOrderOperationCostItems
        /// </summary>
        public DbSet<WorkOrderOperationCostItem> WorkOrderOperationCostItems { get; set; }
    }
}
