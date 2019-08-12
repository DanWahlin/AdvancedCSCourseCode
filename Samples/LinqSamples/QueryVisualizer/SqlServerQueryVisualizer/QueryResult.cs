// Copyright © Microsoft Corporation.  All Rights Reserved.
// This code released under the terms of the 
// Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
//
//Copyright (C) Microsoft Corporation.  All rights reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LinqToSqlQueryVisualizer {
    public partial class QueryResult : Form {

        public QueryResult() {
            InitializeComponent();
        }

        public void SetDataSet(DataSet ds) {
            this.dataGridView1.DataSource = ds.Tables[0];
        }
    }
}