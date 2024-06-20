﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SiteManagementSystem.Service.SharedDTOs
{
    public struct NoContent;


    public record ResponseModelDto<T>
    {
        public T? Data { get; init; }

        [JsonIgnore] public bool IsSuccess { get; init; }

        public List<string>? FailMessages { get; init; }

        [JsonIgnore] public HttpStatusCode StatusCodes { get; set; }

        public static ResponseModelDto<T> Success(T data, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return new ResponseModelDto<T>
            {
                Data = data,
                IsSuccess = true,
                StatusCodes = statusCode
            };
        }

        public static ResponseModelDto<T> Success(HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            return new ResponseModelDto<T>
            {
                IsSuccess = true,
                StatusCodes = statusCode
            };
        }

        public static ResponseModelDto<T> Fail(List<string> messages,
            HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            return new ResponseModelDto<T>
            {
                IsSuccess = false,
                FailMessages = messages,
                StatusCodes = statusCode
            };
        }

        public static ResponseModelDto<T> Fail(string message, HttpStatusCode statusCode = HttpStatusCode.BadRequest)
        {
            return new ResponseModelDto<T>
            {
                IsSuccess = false,
                FailMessages = new List<string> { message },
                StatusCodes = statusCode
            };
        }
    }

}
