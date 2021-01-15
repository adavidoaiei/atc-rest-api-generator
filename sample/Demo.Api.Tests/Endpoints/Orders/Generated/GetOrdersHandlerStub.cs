﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Atc.Rest.Results;
using Demo.Api.Generated.Contracts;
using Demo.Api.Generated.Contracts.Orders;

//------------------------------------------------------------------------------
// This code was auto-generated by ApiGenerator 1.1.15.0.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
namespace Demo.Api.Tests.Endpoints.Orders.Generated
{
    [GeneratedCode("ApiGenerator", "1.1.15.0")]
    public class GetOrdersHandlerStub : IGetOrdersHandler
    {
        public Task<GetOrdersResult> ExecuteAsync(GetOrdersParameters parameters, CancellationToken cancellationToken = default)
        {
            var data = new List<Order>
            {
                new Order
                {
                    Id = Guid.Parse("77a33260-0001-441f-ba60-b0a833803fab"),
                    Description = "Hallo11",
                    MyTime = DateTimeOffset.Parse("2020-10-12T21:22:23"),
                    MyEmail = "john1.doe@example.com",
                    MyNullableDateTime = DateTimeOffset.Parse("2020-10-12T21:22:23"),
                    MyDateTime = DateTimeOffset.Parse("2020-10-12T21:22:23"),
                    MyNumber = 20.2,
                    MyInteger = 42,
                    MyBool = true,
                    MyUri = new Uri("http://www.dr.dk"),
                    MyByte = "Hallo110",
                    MyStringList = null,
                    MyLong = 42,
                    DeliveryAddress = new Address
                    {
                        StreetName = "Hallo1",
                        StreetNumber = "Hallo11",
                        PostalCode = "Hallo12",
                        CityName = "Hallo13",
                        MyCountry = new Country
                        {
                            Name = "Hallo11",
                            Alpha2Code = "Ha",
                            Alpha3Code = "Hal",
                        },
                    },
                },
                new Order
                {
                    Id = Guid.Parse("77a33260-0002-441f-ba60-b0a833803fab"),
                    Description = "Hallo21",
                    MyTime = DateTimeOffset.Parse("2020-10-12T21:22:23"),
                    MyEmail = "john2.doe@example.com",
                    MyNullableDateTime = DateTimeOffset.Parse("2020-10-12T21:22:23"),
                    MyDateTime = DateTimeOffset.Parse("2020-10-12T21:22:23"),
                    MyNumber = 20.2,
                    MyInteger = 42,
                    MyBool = true,
                    MyUri = new Uri("http://www.dr.dk"),
                    MyByte = "Hallo210",
                    MyStringList = null,
                    MyLong = 42,
                    DeliveryAddress = new Address
                    {
                        StreetName = "Hallo2",
                        StreetNumber = "Hallo21",
                        PostalCode = "Hallo22",
                        CityName = "Hallo23",
                        MyCountry = new Country
                        {
                            Name = "Hallo21",
                            Alpha2Code = "Ha",
                            Alpha3Code = "Hal",
                        },
                    },
                },
                new Order
                {
                    Id = Guid.Parse("77a33260-0003-441f-ba60-b0a833803fab"),
                    Description = "Hallo31",
                    MyTime = DateTimeOffset.Parse("2020-10-12T21:22:23"),
                    MyEmail = "john3.doe@example.com",
                    MyNullableDateTime = DateTimeOffset.Parse("2020-10-12T21:22:23"),
                    MyDateTime = DateTimeOffset.Parse("2020-10-12T21:22:23"),
                    MyNumber = 20.2,
                    MyInteger = 42,
                    MyBool = true,
                    MyUri = new Uri("http://www.dr.dk"),
                    MyByte = "Hallo310",
                    MyStringList = null,
                    MyLong = 42,
                    DeliveryAddress = new Address
                    {
                        StreetName = "Hallo3",
                        StreetNumber = "Hallo31",
                        PostalCode = "Hallo32",
                        CityName = "Hallo33",
                        MyCountry = new Country
                        {
                            Name = "Hallo31",
                            Alpha2Code = "Ha",
                            Alpha3Code = "Hal",
                        },
                    },
                },
            };

            var paginationData = new Pagination<Order>(data, parameters.PageSize, parameters.QueryString, parameters.ContinuationToken);
            return Task.FromResult(GetOrdersResult.Ok(paginationData));
        }
    }
}