using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Kmd.Momentum.Mea.Client.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Rest;
using Serilog;

namespace Kmd.Momentum.Mea.Client.Sample
{
    public static class Program
    {
        [SuppressMessage("ReSharper", "CA1031", Justification = "We are logging the exception.")]
        public static int Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .MinimumLevel.Verbose()
                .WriteTo.Console()
                .CreateLogger();
            try
            {
                var config = new ConfigurationBuilder()
                    .AddInMemoryCollection(new[]
                    {
                        KeyValuePair.Create("<dummy>", "must exist to avoid issues"),
                    })
                    .AddCommandLine(args)
                    .Build()
                    .Get<CommandLineConfig>();

                switch (config.Action)
                {
                    case CommandLineAction.None:
                        Log.Information("You must provide arguments");
                        Log.Verbose("You must get a bearer token from the https://console.kmdlogic.io/ or using Client Credentials for your subscription.");
                        break;
                    case CommandLineAction.GetAllCaseworkers:
                        GetAllCaseworkers(config);
                        break;
                    case CommandLineAction.GetCaseworkerById:
                        GetCaseworkerById(config);
                        break;
                    case CommandLineAction.GetTasksbyCaseworker:
                        GetTasksbyCaseworker(config);
                        break;
                    case CommandLineAction.GetAllActiveCitizens:
                        GetAllActiveCitizens(config);
                        break;
                    case CommandLineAction.GetCitizenByCpr:
                        GetCitizenByCpr(config);
                        break;
                    case CommandLineAction.GetCitizenById:
                        GetCitizenById(config);
                        break;
                    case CommandLineAction.UpdateTaskStatus:
                        UpdateTaskStatus(config);
                        break;
                    case CommandLineAction.CreateJournalNote:
                        CreateJournalNote(config);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException($"Unknown action {config.Action}");
                }

                return 0;
            }
            catch (System.Exception fatalException)
            {
                Log.Fatal(fatalException, "Fatal exception");
                return 1;
            }
            finally
            {
                Log.Information("Shutting down");
                Log.CloseAndFlush();
            }
        }

        private static IInternalClient GetApi(CommandLineConfig config)
        {
            if (string.IsNullOrEmpty(config.BearerToken))
            {
                throw new System.Exception("You must specify a bearer token with `--BearerToken={YourToken}`");
            }

            var credentials = new TokenCredentials(config.BearerToken);
            var client = new InternalClient(credentials);

            if (config.MomentumApiBaseUri != null)
            {
                client.BaseUri = config.MomentumApiBaseUri;
            }

            Log.Information("Created API with Base URI {BaseUri}", client.BaseUri);
            return client;
        }

        private static void GetAllCaseworkers(CommandLineConfig config)
        {
            var client = GetApi(config);
            var response = client.GetAllCaseworkers(2);
            Log.Information("Got All Caseworkers", response);
        }

        private static void GetCaseworkerById(CommandLineConfig config)
        {
            var client = GetApi(config);
            var response = client.GetCaseworkerById(config.CaseworkerId);
            Log.Information("Got Caseworkers Details By Id", response);
        }

        private static void GetTasksbyCaseworker(CommandLineConfig config)
        {
            var client = GetApi(config);
            var response = client.GetTasksbyCaseworker(config.CaseworkerId, config.PageNo);
            Log.Information("Got All Task For The Caseworkers", response);
        }

        private static void GetCitizenByCpr(CommandLineConfig config)
        {
            var client = GetApi(config);
            var response = client.GetCitizenByCpr(config.CprNumber);
            Log.Information("Got Citizen in Momentum by CPR", response);
        }

        private static void GetAllActiveCitizens(CommandLineConfig config)
        {
            var client = GetApi(config);
            var response = client.GetAllActiveCitizens(config.PageNo);
            Log.Information("Got all active citizens", response);
        }

        private static void GetCitizenById(CommandLineConfig config)
        {
            var client = GetApi(config);
            var response = client.GetCitizenById(config.CitizenId);
            Log.Information("Got Citizen in Momentum by IDs", response);
        }

        private static void UpdateTaskStatus(CommandLineConfig config)
        {
            TaskUpdateStatus taskUpdateStatus = new TaskUpdateStatus()
            {
                TaskAction = config.TaskAction,
                TaskContext = config.TaskContext,
            };

            var client = GetApi(config);
            var response = client.UpdateTaskStatus(taskUpdateStatus, config.TaskId);
            Log.Information("Updated task status ", response);
        }

        private static void CreateJournalNote(CommandLineConfig config)
        {
            JournalNoteDocumentRequestModel journalNoteDocumentRequestModel = new JournalNoteDocumentRequestModel()
            {
                Content = config.Content,
                ContentType = config.ContentType,
                Name = config.Name,
            };

            IList<JournalNoteDocumentRequestModel> GetReadOnlyValues()
            {
                List<JournalNoteDocumentRequestModel> journalNoteDocumentRequestModelList = new List<JournalNoteDocumentRequestModel>()
                {
                    journalNoteDocumentRequestModel,
                };
                return journalNoteDocumentRequestModelList.AsReadOnly();
            }

            JournalNoteRequestModel journalNoteRequestModel = new JournalNoteRequestModel()
            {
                Body = config.Body,
                Cpr = config.Cpr,
                Documents = GetReadOnlyValues(),
                Title = config.Title,
                Type = config.Type,
            };

            var client = GetApi(config);
            var response = client.CreateJournalNote(journalNoteRequestModel, config.CitizenId);
            Log.Information("Created a Journal Note with attachment", response);
        }
    }
}
