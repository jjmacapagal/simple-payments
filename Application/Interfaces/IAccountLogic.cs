﻿using Model;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IAccountLogic
    {
        AccountModel GetAccount(int id);

        List<AccountModel> GetUserAccounts(int userId);

        TransactionStatus Save(AccountModel model);

        void Dispose();
    }
}