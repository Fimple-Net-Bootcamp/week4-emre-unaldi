﻿
namespace VirtualPetCareWebAPI.Core.Utilities.Results.Abstracts
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
