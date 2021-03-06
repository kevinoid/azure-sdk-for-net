﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.Search.Documents.Tests
{
    /// <summary>
    /// Gets variables created from test-resources.json.
    /// </summary>
    public class SearchTestEnvironment: TestEnvironment
    {
        /// <summary>
        /// The name of the variable for <see cref="SearchAdminKey"/>.
        /// </summary>
        public const string SearchAdminKeyVariableName = "SEARCH_ADMIN_API_KEY";

        /// <summary>
        /// The name of the variable for <see cref="SearchQueryKey"/>.
        /// </summary>
        public const string SearchQueryKeyVariableName = "SEARCH_QUERY_API_KEY";

        /// <summary>
        /// The name of the variable for <see cref="SearchStorageKey"/>.
        /// </summary>
        public const string StorageAccountKeyVariableName = "SEARCH_STORAGE_KEY";

        /// <summary>
        /// Creates a new instance of the <see cref="SearchTestEnvironment"/> class.
        /// </summary>
        public SearchTestEnvironment() : base("search")
        {
        }

        /// <summary>
        /// Gets the service name.
        /// </summary>
        public string SearchServiceName => GetRecordedVariable("SEARCH_SERVICE_NAME");

        /// <summary>
        /// Gets the admin key (read-write).
        /// </summary>
        public string SearchAdminKey => GetRecordedVariable(SearchAdminKeyVariableName);

        /// <summary>
        /// Gets the query key (read-only).
        /// </summary>
        public string SearchQueryKey => GetRecordedVariable(SearchQueryKeyVariableName);

        /// <summary>
        /// Gets the name of the storage account for external data sources.
        /// </summary>
        public string SearchStorageName => GetRecordedVariable("SEARCH_STORAGE_NAME");

        /// <summary>
        /// Gets the storage account key for external data sources.
        /// </summary>
        public string SearchStorageKey => GetRecordedVariable(StorageAccountKeyVariableName);
    }
}
