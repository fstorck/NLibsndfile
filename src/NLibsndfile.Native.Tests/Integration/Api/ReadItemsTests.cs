﻿using System;
using NUnit.Framework;

namespace NLibsndfile.Native.Tests.Integration.Api
{
    [TestFixture]
    [Category("NLibsndfileApi.Native.IntegrationTests.Api")]
    public class ReadItemsTests
    {
        [Test]
        public void ReadItemsShort_ReturnsValidData()
        {
            const long Items = 50;

            var api = new LibsndfileApi();
            var info = new LibsndfileInfo();

            var open = api.Open(TestConfiguration.ValidWavFile, LibsndfileMode.Read, ref info);
            Assert.That(open != IntPtr.Zero);

            var buffer = new short[Items];
            var read = api.ReadItems(open, buffer, Items);
            Assert.That(Items == read);
            Assert.That(buffer != null);
            Assert.That(buffer.Length == Items);

            var close = api.Close(open);
            Assert.That(close == LibsndfileError.NoError);
        }

        [Test]
        public void ReadItemsInt_ReturnsValidData()
        {
            const long Items = 50;

            var api = new LibsndfileApi();
            var info = new LibsndfileInfo();

            var open = api.Open(TestConfiguration.ValidWavFile, LibsndfileMode.Read, ref info);
            Assert.That(open != IntPtr.Zero);

            var buffer = new int[Items];
            var read = api.ReadItems(open, buffer, Items);
            Assert.That(Items == read);
            Assert.That(buffer != null);
            Assert.That(buffer.Length == Items);

            var close = api.Close(open);
            Assert.That(close == LibsndfileError.NoError);
        }

        [Test]
        public void ReadItemsFloat_ReturnsValidData()
        {
            const long Items = 50;

            var api = new LibsndfileApi();
            var info = new LibsndfileInfo();

            var open = api.Open(TestConfiguration.ValidWavFile, LibsndfileMode.Read, ref info);
            Assert.That(open != IntPtr.Zero);

            var buffer = new float[Items];
            var read = api.ReadItems(open, buffer, Items);
            Assert.That(Items == read);
            Assert.That(buffer != null);
            Assert.That(buffer.Length == Items);

            var close = api.Close(open);
            Assert.That(close == LibsndfileError.NoError);
        }

        [Test]
        public void ReadItemsDouble_ReturnsValidData()
        {
            const long Items = 50;

            var api = new LibsndfileApi();
            var info = new LibsndfileInfo();

            var open = api.Open(TestConfiguration.ValidWavFile, LibsndfileMode.Read, ref info);
            Assert.That(open != IntPtr.Zero);

            var buffer = new double[Items];
            var read = api.ReadItems(open, buffer, Items);
            Assert.That(Items == read);
            Assert.That(buffer != null);
            Assert.That(buffer.Length == Items);

            var close = api.Close(open);
            Assert.That(close == LibsndfileError.NoError);
        }
    }
}