﻿using WebApi.Models;
namespace WebApi.Services.Interfaces
{
    public interface IPaycheckRepository : IRepository<Paycheck>
    {
        Task UpdateSalary(Paycheck paycheck);
        Task<Paycheck> GetByNumber(string paycheckNumber);
    }
}