﻿using System.Linq;
using Xamarin.Essentials;
using Xunit;

namespace DeviceTests
{
    public class Connectivity_Tests
    {
        [Fact]
        public void Network_Access() =>
            Assert.Equal(NetworkAccess.Internet, Connectivity.NetworkAccess);

        [Fact]
        public void Connection_Profiles() =>
            Assert.True(Connectivity.ConnectionProfiles.Count() > 0);

        [Fact]
        public void Distict_Connection_Profiles()
        {
            var profiles = Connectivity.ConnectionProfiles;
            Assert.Equal(profiles.Count(), profiles.Distinct().Count());
        }
    }
}
