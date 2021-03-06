// CodeContracts
// 
// Copyright (c) Microsoft Corporation
// 
// All rights reserved. 
// 
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Text;

namespace System.Linq.Expressions
{
  // Summary:
  //     Represents creating a new array and possibly initializing the elements of
  //     the new array.
  public sealed class NewArrayExpression : Expression
  {
    private NewArrayExpression() { }

    // Summary:
    //     Gets the bounds of the array if the value of the System.Linq.Expressions.Expression.NodeType
    //     property is System.Linq.Expressions.ExpressionType.NewArrayBounds, or the
    //     values to initialize the elements of the new array if the value of the System.Linq.Expressions.Expression.NodeType
    //     property is System.Linq.Expressions.ExpressionType.NewArrayInit.
    //
    // Returns:
    //     A System.Collections.ObjectModel.ReadOnlyCollection<T> of System.Linq.Expressions.Expression
    //     objects which represent either the bounds of the array or the initialization
    //     values.
    public ReadOnlyCollection<Expression> Expressions
    {
      get
      {
        Contract.Ensures(Contract.Result<ReadOnlyCollection<Expression>>() != null);
        Contract.Ensures(Contract.Result<ReadOnlyCollection<Expression>>().Count >= 1);
        return default(ReadOnlyCollection<Expression>);
      }
    }

#if NETFRAMEWORK_4_0 || SILVERLIGHT_4_0 || SILVERLIGHT_5_0
    //
    // Summary:
    //     Creates a new expression that is like this one, but using the supplied children.
    //     If all of the children are the same, it will return this expression.
    //
    // Parameters:
    //   expressions:
    //     The System.Linq.Expressions.NewArrayExpression.Expressions property of the result.
    //
    // Returns:
    //     This expression if no children are changed or an expression with the updated
    //     children.
    [Pure]
    public NewArrayExpression Update(IEnumerable<Expression> expressions)
    {
      Contract.Requires(expressions != null);
      Contract.Ensures(Contract.Result<NewArrayExpression>() != null);
      return default(NewArrayExpression);
    }
#endif
  }
}