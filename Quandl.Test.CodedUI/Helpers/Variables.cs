﻿using Quandl.Shared.Models;
using System.Collections.Generic;

namespace Quandl.Test.CodedUI.Helpers
{
    public partial class CodedUITestHelpers
    {
        public static UIMap UIMap => _map ?? (_map = new UIMap());
        private static UIMap _map;
        private static Dataset _dataset;
        private static Datatable _datatable;
        private static List<DataColumn> _datasetColumns;
        private static List<DataColumn> _datatableColumns;
        private Dictionary<string, string> _filterOptions;

        public static Dataset SampleDataset()
        {
            if (_dataset == null)
            {
                _dataset = new Dataset
                {
                    DatabaseCode = "EOD",
                    DatasetCode = "AAPL",
                    Name = "Apple Inc. (AAPL) Stock Prices, Dividends and Splits"
                };
            }

            return _dataset;
        }

        public static Dataset FreeDataset()
        {
            if (_dataset == null)
            {
                _dataset = new Dataset
                {
                    DatabaseCode = "WIKI",
                    DatasetCode = "FMC",
                    Name = "FMC Corp. (FMC) Prices, Dividends, Splits and Trading Volume"
                };
            }

            return _dataset;
        }

        public static Datatable SampleDatatable()
        {
            if (_datatable == null)
            {
                _datatable = new Datatable
                {
                    VendorCode = "ZACKS",
                    DatatableCode = "CP",
                    Name = "Zacks Company Profiles"
                };
            }

            return _datatable;
        }

        public static List<DataColumn> SampleDatasetColumns()
        {
            if (_datasetColumns == null)
            {
                _datasetColumns = new List<DataColumn>
                {
                    new DataColumn() { Name = "Volume", Parent = _dataset },
                    new DataColumn() { Name = "Open",   Parent = _dataset },
                    new DataColumn() { Name = "Close",  Parent = _dataset }
                };
            }

            return _datasetColumns;
        }

        public static List<DataColumn> SampleDatatableColumns()
        {
            if (_datasetColumns == null)
            {
                _datasetColumns = new List<DataColumn>
                {
                    new DataColumn() { Name = "ticker",         Parent = _datatable },
                    new DataColumn() { Name = "exchange",       Parent = _datatable },
                    new DataColumn() { Name = "address_line_1", Parent = _datatable },
                    new DataColumn() { Name = "city",           Parent = _datatable }
                };
            }

            return _datasetColumns;
        }
        public static Dictionary<string, string> filtersAllHistRdiff()
        {
            var filterOptions = new Dictionary<string, string>();
            filterOptions.Add("date_range", null);
            filterOptions.Add("transformation", "Row-on-row % change (rdiff)");
            filterOptions.Add("transformation code", "RDiff");
            filterOptions.Add("frequency", null);
            filterOptions.Add("sort", null);
            filterOptions.Add("limit", null);
            return filterOptions;
        }
    }
}
