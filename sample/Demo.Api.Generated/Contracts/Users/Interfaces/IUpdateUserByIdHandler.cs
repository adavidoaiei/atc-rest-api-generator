﻿using System.CodeDom.Compiler;
using System.Threading;
using System.Threading.Tasks;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.0.181.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Generated.Contracts.Users
{
    /// <summary>
    /// Domain Interface for RequestHandler.
    /// Description: Update user by id.
    /// Operation: UpdateUserById.
    /// Area: Users.
    /// </summary>
    [GeneratedCode("ApiGenerator", "1.0.181.0")]
    public interface IUpdateUserByIdHandler
    {
        /// <summary>
        /// Execute method.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        Task<UpdateUserByIdResult> ExecuteAsync(UpdateUserByIdParameters parameters, CancellationToken cancellationToken = default);
    }
}