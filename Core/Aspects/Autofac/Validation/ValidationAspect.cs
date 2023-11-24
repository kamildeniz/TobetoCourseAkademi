using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interseptors;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect:MethodInterception
    {
       private Type _validateType;

        public ValidationAspect(Type validateType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validateType))
            {
                throw new Exception("Bu bir doğrulama sınıfı değil.");
            }
            _validateType = validateType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validateType);
            var entityType = _validateType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(T => T.GetType()==entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
            base.OnBefore(invocation);
        }
    }
}
