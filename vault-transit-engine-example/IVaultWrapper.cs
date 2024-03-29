﻿using System;
namespace vault_transit_engine_example
{
    public interface IVaultWrapper
    {
        System.Threading.Tasks.Task<string> EncryptAsync(string field, string transitKeyName, int transitKeyVersion);
        System.Threading.Tasks.Task<string> GenerateCertificate(string certName, string commonName);

    }
}
