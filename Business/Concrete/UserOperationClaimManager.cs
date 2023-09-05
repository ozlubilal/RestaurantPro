﻿using Business.Abstract;
using Business.Constans;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        IUserOperationClaimDal _userOperationClaimDal;
        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal)
        {
            _userOperationClaimDal = userOperationClaimDal;
        }

        public IResult Add(UserOperationClaim userOperationClaim)
        {
            
            _userOperationClaimDal.Add(userOperationClaim);
            return new SuccessResult(Messages.AddedSuccess);
        }

        public IResult Delete(UserOperationClaim userOperationClaim)
        {
         
            _userOperationClaimDal.Delete(userOperationClaim);
            return new SuccessResult(Messages.DeletedSuccess);
        }

      
        public IDataResult<List<UserOperationClaim>> GetList()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaimDal.GetList());
        }

        public IResult Update(UserOperationClaim userOperationClaim)
        {
            
            _userOperationClaimDal.Update(userOperationClaim);
            return new SuccessResult(Messages.UpdatedSuccess);
        }
    }
}
