using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using MongoDB.Bson.Serialization;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using System.Linq;
using Mongo.Core.Interfaces;

namespace UnitTests
{
    public class TripEventQueryTests
    {
        IQueryTripEvents _queryTripEvents;

        [OneTimeSetUp]
        public void Setup()
        {
            var webHost = WebHost.CreateDefaultBuilder().UseStartup<Startup>().Build();

            _queryTripEvents = webHost.Services.GetService(typeof(IQueryTripEvents)) as IQueryTripEvents;
           
        }
     }
}
