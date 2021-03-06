﻿using System;
using System.Threading.Tasks;
using CommandLine;
using Wabbajack.Lib.FileUploader;

namespace Wabbajack.CLI.Verbs
{
    [Verb("update-server-modlists", HelpText = "Tell the Build server to update curated modlists (Requires Author API key)")]
    public class UpdateModlists : AVerb
    {
        protected override async Task<int> Run()
        {
            Console.WriteLine($"Job ID: {await AuthorAPI.UpdateServerModLists()}");
            return 0;
        }
    }
}
